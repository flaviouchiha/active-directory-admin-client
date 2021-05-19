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
    public partial class FrmSenha : Form
    {
        public FrmSenha() {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Senha_Load(object sender, EventArgs e) {
            btnSair.Focus();
            btnSair.Select();            
        }
    }
}
