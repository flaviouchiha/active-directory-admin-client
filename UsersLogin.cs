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
    public partial class FrmUsersLogin : Form
    {
        public FrmUsersLogin() {
            InitializeComponent();
        }

        ADUserImplement ADUser = new ADUserImplement();
        RelatorioAD Relatorio = new RelatorioAD();
        int n;

        private void btnUsuariosLogin_Click(object sender, EventArgs e) {
            n = 0;
            String[] Usuarios = lstUsuarios.Text.Split('\n');

            if (radNome.Checked) {
                n = 1;
            }
            else if (radLogin.Checked) {
                n = 2;
            }

            if (ValidaLista()) {
                Relatorio.GetUsersByLoginNome(Usuarios, n);
            }
        
        }

        private Boolean ValidaLista() {
            if (lstUsuarios.TextLength <= 0) {
                MessageBox.Show("A lista de usuários não pode estar vazia", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else {
                return true;
            }
        }

    }

}
