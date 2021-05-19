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
    public partial class FrmUsersGrupo : Form
    {
        public FrmUsersGrupo() {
            InitializeComponent();
        }

        private void FrmUsersGrupo_Load(object sender, EventArgs e) {

        }
        RelatorioAD Relatorio = new RelatorioAD();
                
        private Boolean ValidaLista() {
            if (lstGrupos.TextLength <= 0) {
                MessageBox.Show("A lista de usuários não pode estar vazia", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else {
                return true;
            }
        }

        private void btnUsuariosGrupos_Click(object sender, EventArgs e) {
            String[] Grupos = lstGrupos.Text.Split('\n');

            if (ValidaLista()) {
                Relatorio.GetUsersByGroup(Grupos);
            }
        }

    }

}