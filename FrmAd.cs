using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Security;

namespace PShell
{
    public partial class FrmAd : Form
    {
        public FrmAd() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            txtUser.Focus();
            txtUser.Select();
            txtDomain.Text = ADUser.GetDomain();
            cmBox.SelectedIndex = 0;
        }

        ADUserImplement ADUser = new ADUserImplement();
        RelatorioAD Relatorio = new RelatorioAD();
        //PowerShell ps = PowerShell.Create();
        
        public void GetUser() {
            User User = ADUser.GetUserInfo(txtUser.Text.Trim(), cmBox.SelectedIndex);

            txtNome.Text = User.Nome;
            txtLogin.Text = User.Login;
            txtCpf.Text = User.Cpf;
            txtDataNasc.Text = User.DataNasc;
            txtMail.Text = User.Mail;
            txtAtivo.Text = User.Ativo;
            txtBloqueado.Text = User.Bloqueado;
            txtCriado.Text = Convert.ToString(User.Criado.ToLocalTime());
            txtModificado.Text = Convert.ToString(User.Modificado.ToLocalTime());
            txtCargo.Text = User.Cargo;
           
            if (User.Local != null && User.Local.Contains("INTRANET")) {
                txtOU.Text = "INTRANET";
            }
            else {
                txtOU.Text = User.Local;
            }

            if (Convert.ToString(User.UltTrcSenha) == "31/12/1600 22:00:00") {
                txtSenhaExp.Text = "True";
                txtTrocaSenha.Text = "Null";
            }
            else {
                txtTrocaSenha.Text = Convert.ToString(User.UltTrcSenha);
                txtSenhaExp.Text = "False";
            }

            if (DateTime.Now > User.UltTrcSenha.AddDays(45)) {
                txtSenhaExp.Text = "True";
            }

            if (Convert.ToString(User.Criado) == "01/01/0001 00:00:00" || txtLogin.Text == "") {
                LimpaCampos();
            }

        }

        private void FillGrid() {
            List<User> ListUsers = new List<User>();
            ListUsers = null;
            //ListUsers = ADUser.GetUsersInfoGrid(txtUser.Text.Trim(), cmBox.SelectedIndex);

            if (txtNome.Text.Length > 0  && cmBox.SelectedIndex == 0) {
                ListUsers = ADUser.GetUsersInfoGrid(txtUser.Text.Trim() + "*", cmBox.SelectedIndex);
            }
            else if (txtLogin.Text.Length > 0  && cmBox.SelectedIndex == 1) {
                ListUsers = ADUser.GetUsersInfoGrid(txtUser.Text.Trim() + "*", cmBox.SelectedIndex);
            }
            else if (txtCpf.Text.Length > 0  && cmBox.SelectedIndex == 2) {
                ListUsers = ADUser.GetUsersInfoGrid(txtUser.Text.Trim() + "*", cmBox.SelectedIndex);
            }

            dgvUsuarios.Rows.Clear();

            if (ListUsers != null) {
                foreach (User User in ListUsers) {
                    object[] rowUser = {
                    User.Nome,
                    User.Login
                };

                    dgvUsuarios.Rows.Add(rowUser);
                    dgvUsuarios.Columns[0].DisplayIndex = 0;
                    dgvUsuarios.Columns[1].DisplayIndex = 1;
                    rowUser = null;
                }

            }

        }

        public void GetUserPrincipal() {
            User User = ADUser.GetPrincipalUserInfo(txtLogin.Text.Trim());

            txtBloqueado.Text = User.Bloqueado;
            txtAtivo.Text = User.Ativo;
        }

        public void LimpaCampos() {
            dgvUsuarios.Rows.Clear();
            txtUser.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtLogin.Clear();
            txtMail.Clear();
            txtAtivo.Clear();
            txtCriado.Clear();
            txtModificado.Clear();
            txtSenhaExp.Clear();
            txtTrocaSenha.Clear();
            txtBloqueado.Clear();
            txtCargo.Clear();
            txtDataNasc.Clear();
            txtOU.Clear();
            txtUser.Focus();
            txtUser.Select();
        }

        private Boolean ValidaPesquisa() {
            if (txtUser.Text == "") {
                MessageBox.Show("Informe o Nome, Login ou CPF", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUser.Focus();
                txtUser.Select();
                return false;
            }
            else {
                return true;
            }               
        }

        private Boolean ValidaLogin() {
            if (txtLogin.Text == "") {
                MessageBox.Show("Login inválido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUser.Focus();
                txtUser.Select();
                return false;
            }
            else {
                return true;
            }               
        }

        private String GeraSenha() {
            var caracter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwyxz1234567890";
            var caracteres = new char[8];
            Random rnd = new Random();

            for (int i = 0; i < caracteres.Length; i++) {
                caracteres[i] = caracter[rnd.Next(caracter.Length)];
            }

            var Senha = new String(caracteres);
            return Senha + "@";
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (ValidaPesquisa()) {                
                GetUser();
                GetUserPrincipal();
                FillGrid();
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            LimpaCampos();
        }

        private void btnDesativar_Click(object sender, EventArgs e) {
            if (ValidaLogin()) {
                ADUser.DisableUser(txtLogin.Text.Trim());
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e) {
            if (ValidaLogin()) {
                ADUser.EnableUser(txtLogin.Text.Trim());
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            if (ValidaLogin()) {
                String Senha = GeraSenha();
                
                if(ADUser.ResetPassword(txtLogin.Text.Trim(), Senha)) {
                    Form frm = new FrmSenha();
                    frm.Controls["txtSenha"].Text = Senha;
                    frm.ShowDialog();
                    ADUser.UnlockUser(txtLogin.Text.Trim());
                }

            }

        }

        private void btnDesbloquear_Click(object sender, EventArgs e) {
            if (ValidaLogin()) {
                ADUser.UnlockUser(txtLogin.Text.Trim());
            }
        }

        private void txtTrocaSenha_TextChanged(object sender, EventArgs e) {

        }

        private void cmBox_SelectedIndexChanged(object sender, EventArgs e) {
            txtUser.Focus();
            txtUser.SelectAll();
        }

        private void rellatórioToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void usuáriosAtivosToolStripMenuItem_Click(object sender, EventArgs e) {
            Relatorio.GetEnabledUsers();
        }

        private void usuáriosInativosToolStripMenuItem_Click(object sender, EventArgs e) {
            Relatorio.GetDisabledUsers();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void passwordNeverExpiresToolStripMenuItem_Click(object sender, EventArgs e) {
            Relatorio.PassNeverExpires();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void usuáriosPorLoginToolStripMenuItem_Click(object sender, EventArgs e) {
            Form frm = new FrmUsersLogin();
            frm.Show();
        }

        private void validarSenhaToolStripMenuItem_Click(object sender, EventArgs e) {
            Form frm = new FrmValidarSenha();
            frm.Show();
        }

        private void usuáriosPorGrupoToolStripMenuItem_Click(object sender, EventArgs e) {
            Form frm = new FrmUsersGrupo();
            frm.Show();
        }
    }

}
