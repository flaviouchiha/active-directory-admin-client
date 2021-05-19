using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace PShell
{
    class User {
        public String Usuario { get; set; }
        public String Nome { get; set; }
        public String Login { get; set; }
        public String Cpf { get; set; }
        public String Mail { get; set; }
        public DateTime Criado { get; set; }
        public DateTime Modificado { get; set; }
        public String SenhaExp { get; set; }
        public DateTime UltTrcSenha { get; set; }
        public String Ativo { get; set; }
        public String Bloqueado { get; set; }
        public String Cargo { get; set; }
        public String Local { get; set; }
        public String DataNasc { get; set; }

    }

}
