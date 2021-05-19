using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PShell
{
    public partial class FrmValidarSenha : Form {
        public FrmValidarSenha() {
            InitializeComponent();
        }

        ADUserImplement ADUser = new ADUserImplement();

        private void button1_Click(object sender, EventArgs e) {
            if (ValidarCampos()) {
                ADUser.ValidateUser(txtUser.Text.Trim(), txtSenha.Text.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            txtUser.Clear();
            txtSenha.Clear();
            txtUser.Focus();
        }

        private Boolean ValidarCampos() {
            if (txtUser.Text == "" || txtSenha.Text == "") {
                MessageBox.Show("O usuário e a senha devem ser informados", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else {
                return true;
            }
        }
    }
}
