using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace PShell
{
    class AdUser {
        public String User { get; set; }
        public String Nome { get; set; }
        public String Login { get; set; }
        public String Cpf { get; set; }
        public String Mail { get; set; }
        public String Criado { get; set; }
        public String Modificado { get; set; }
        public String SenhaExp { get; set; }
        public String UltTrcSenha { get; set; }
        public String Ativo { get; set; }
        public String Bloqueado { get; set; }
        public PowerShell ps = PowerShell.Create();

        public void GetAdUser(String user, int n) {
            if (n == 0) {
                ps.AddCommand("Get-ADUser");
                ps.AddParameter("Filter", "Name -like '" + user + "*'");
                ps.AddParameter("Properties", "*");
            }
            else if (n == 1) {
                ps.AddCommand("Get-ADUser");
                ps.AddParameter("Filter", "SamAccountName -eq '" + user + "'");
                ps.AddParameter("Properties", "*");
            }
            else if (n == 2) {
                ps.AddCommand("Get-ADUser");
                ps.AddParameter("Filter", "EmployeeNumber -eq '" + user + "'");
                ps.AddParameter("Properties", "*");
            }

            foreach (PSObject result in ps.Invoke()) {
                Nome = result.Members["Name"].Value.ToString();
                Login = result.Members["SamAccountName"].Value.ToString();
                Cpf = result.Members["EmployeeNumber"].Value.ToString();
                Mail = result.Members["mail"].Value.ToString();
                Criado = result.Members["WhenCreated"].Value.ToString();
                Modificado = result.Members["WhenChanged"].Value.ToString();
                SenhaExp = result.Members["PasswordExpired"].Value.ToString();
                Ativo = result.Members["Enabled"].Value.ToString();
                Bloqueado = result.Members["LockedOut"].Value.ToString();

                try {
                    UltTrcSenha = result.Members["PasswordLastSet"].Value.ToString();
                }
                catch (Exception e) {
                    e.Message.ToString();
                    UltTrcSenha = "Null";
                }
               
            }

        }

        public void DisableAdUser(String user) {
            ps.AddCommand("Set-ADUser");
            ps.AddParameter("Identity", user);
            //Hashtable nDisplayName = new Hashtable { {"DisplayName", "Teste" } };
            ps.AddCommand("Replace").AddParameter("DisplayName", "Teste");
            
            //ps.AddCommand("Set-ADUser");
            //ps.AddParameter("Identity", user);
            //ps.AddParameter("replace", "@{DisplayName='Teste'}");
            
        }


    }
}
