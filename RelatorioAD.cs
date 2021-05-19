using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;
using System.IO;

namespace PShell
{
    class RelatorioAD {
        private static DirectorySearcher ds = new DirectorySearcher();
        private static PrincipalContext context = new PrincipalContext(ContextType.Domain);
        public User User = new User();

        private void LimparAtributos() {
            User.Nome = null;
            User.Login = null;
            User.Cpf = null;
            User.Mail = null;
            User.Ativo = null;
            User.Bloqueado = null;
            User.SenhaExp = null;
            User.Local = null;
            User.DataNasc = null;
            User.Cargo = null;
        }

        public void GetUsersByLoginNome(String[] users, int n) {
            SearchResult AdUserEnabled;
            SearchResult AdUserDisabled;

            String Arq = "Usuarios_" + DateTime.Now.ToString("dd.MM.yyyy") + ".csv";
            StreamWriter writer = new StreamWriter(@Arq, true);
            writer.WriteLine("Nome" + ";" + "Login" + ";" + "CPF" + ";" + "Email" + ";" + "Status");

            FrmProgressBar FrmProgressBar = new FrmProgressBar();
            FrmProgressBar.Show();

            int i = 0;
            int progress;
            int total = users.Length;

            try {
                foreach (String user in users) {
                    LimparAtributos();
                    ds.SearchScope = SearchScope.Subtree;

                    switch (n) {
                        case 1:
                            ds.Filter = "(&(objectCategory=person)(objectClass=user)(Name=" + user + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";
                            break;
                        case 2:
                            ds.Filter = "(&(objectCategory=person)(objectClass=user)(SamAccountName=" + user + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";
                            break;
                        default:
                            ds.Filter = null;
                            break;
                    }

                    //if (n == 2) {
                    //    ds.Filter = "(&(objectCategory=person)(objectClass=user)(SamAccountName=" + user + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";
                    //}
                    //ds.Filter = "(&(objectCategory=person)(objectClass=user)(SamAccountName=" + user + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";

                    AdUserEnabled = null;
                    AdUserEnabled = ds.FindOne();

                    if (AdUserEnabled != null) {
                        if (AdUserEnabled.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                            User.Nome = AdUserEnabled.GetDirectoryEntry().Properties["Name"].Value.ToString();

                        if (AdUserEnabled.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                            User.Login = AdUserEnabled.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                        if (AdUserEnabled.GetDirectoryEntry().Properties["mail"].Value != null)
                            User.Mail = AdUserEnabled.GetDirectoryEntry().Properties["mail"].Value.ToString();

                        if (AdUserEnabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                            User.Cpf = AdUserEnabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                        writer.WriteLine(User.Nome + ";" + User.Login + ";" + User.Cpf + ";" + User.Mail + ";" + "Ativo");
                    }

                    LimparAtributos();

                    switch (n) {
                        case 1:
                            ds.Filter = "(&(objectCategory=person)(objectClass=user)(Name=" + user + ")(userAccountControl:1.2.840.113556.1.4.803:=2))";
                            break;
                        case 2:
                            ds.Filter = "(&(objectCategory=person)(objectClass=user)(SamAccountName=" + user + ")(userAccountControl:1.2.840.113556.1.4.803:=2))";
                            break;
                        default:
                            ds.Filter = null;
                            break;
                    }

                    AdUserDisabled = null;
                    AdUserDisabled = ds.FindOne();

                    if (AdUserDisabled != null) {
                        if (AdUserDisabled.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                            User.Nome = AdUserDisabled.GetDirectoryEntry().Properties["Name"].Value.ToString();

                        if (AdUserDisabled.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                            User.Login = AdUserDisabled.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                        if (AdUserDisabled.GetDirectoryEntry().Properties["mail"].Value != null)
                            User.Mail = AdUserDisabled.GetDirectoryEntry().Properties["mail"].Value.ToString();

                        if (AdUserDisabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                            User.Cpf = AdUserDisabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                        writer.WriteLine(User.Nome + ";" + User.Login + ";" + User.Cpf + ";" + User.Mail + ";" + "Inativo");
                    }

                    if (AdUserEnabled == null && AdUserDisabled == null) {
                        writer.WriteLine("Nao localizado" + ";" + user);
                    }

                    i++;
                    progress = (i / total * 100);
                    FrmProgressBar.progressBar1.Value = progress;
                    
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally {
                writer.Close();
            }            

        }

        public void GetEnabledUsers() {
            String Arq = "Ativos_" + DateTime.Now.ToString("dd.MM.yyyy") + ".csv";
            StreamWriter writer = new StreamWriter(@Arq, true);
            writer.WriteLine("Nome" + ";" + "Login" + ";" + "CPF");

            ds.Filter = "(&(objectCategory=person)(objectClass=user)(!userAccountControl:1.2.840.113556.1.4.803:=2))";
            ds.SearchScope = SearchScope.Subtree;
            SearchResultCollection EnabledUsers = ds.FindAll();

            FrmProgressBar FrmProgressBar = new FrmProgressBar();
            FrmProgressBar.Show();

            int i = 1;
            int progress;
            int total = EnabledUsers.Count;

            try {
                foreach (SearchResult Enabled in EnabledUsers) {
                    LimparAtributos();

                    if (Enabled.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                        User.Nome = Enabled.GetDirectoryEntry().Properties["Name"].Value.ToString();

                    if (Enabled.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                        User.Login = Enabled.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                    if (Enabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                        User.Cpf = Enabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                    writer.WriteLine(User.Nome + ";" + User.Login + ";" + User.Cpf);

                    i++;
                    progress = (i / total * 100);
                    FrmProgressBar.progressBar1.Value = progress;

                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally {
                writer.Close();
            } 

        }

        public void GetDisabledUsers() {
            String Arq = "Inativos_" + DateTime.Now.ToString("dd.MM.yyyy") + ".csv";
            StreamWriter writer = new StreamWriter(@Arq, true);
            writer.WriteLine("Nome" + ";" + "Login" + ";" + "CPF");

            ds.Filter = "(&(objectCategory=person)(objectClass=user)(userAccountControl:1.2.840.113556.1.4.803:=2))";
            ds.SearchScope = SearchScope.Subtree;
            SearchResultCollection DisabledUsers = ds.FindAll();

            FrmProgressBar FrmProgressBar = new FrmProgressBar();
            FrmProgressBar.Show();

            int i = 0;
            int progress;
            int total = DisabledUsers.Count;

            try {
                foreach (SearchResult DisabledUser in DisabledUsers) {
                    LimparAtributos();

                    if (DisabledUser.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                        User.Nome = DisabledUser.GetDirectoryEntry().Properties["Name"].Value.ToString();

                    if (DisabledUser.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                        User.Login = DisabledUser.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                    if (DisabledUser.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                        User.Cpf = DisabledUser.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                    writer.WriteLine(User.Nome + ";" + User.Login + ";" + User.Cpf);

                    i++;
                    progress = (i / total * 100);
                    FrmProgressBar.progressBar1.Value = progress;

                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally {
                writer.Close();
            }

        }

        public void PassNeverExpires() {
            String Arq = "PasswordNeverExpires_" + DateTime.Now.ToString("dd.MM.yyyy") + ".csv";
            StreamWriter writer = new StreamWriter(@Arq, true);
            writer.WriteLine("Nome" + ";" + "Login" + ";" + "CPF");

            ds.Filter = "(&(objectCategory=person)(objectClass=user)(userAccountControl:1.2.840.113556.1.4.803:=65536))";
            ds.SearchScope = SearchScope.Subtree;
            SearchResultCollection EnabledUsers = ds.FindAll();

            FrmProgressBar FrmProgressBar = new FrmProgressBar();
            FrmProgressBar.Show();

            int i = 0;
            int progress;
            int total = EnabledUsers.Count;

            try {
                foreach (SearchResult Enabled in EnabledUsers) {
                    LimparAtributos();

                    if (Enabled.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                        User.Nome = Enabled.GetDirectoryEntry().Properties["Name"].Value.ToString();

                    if (Enabled.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                        User.Login = Enabled.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                    if (Enabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                        User.Cpf = Enabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                    writer.WriteLine(User.Nome + ";" + User.Login + ";" + User.Cpf);

                    i++;
                    progress = (i / total * 100);
                    FrmProgressBar.progressBar1.Value = progress;
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally {
                writer.Close();
            }

        }

        public void GetUsersByGroup(String[] grupos) {
            foreach (string grupo in grupos) {
                String Arq = grupo + "_" + DateTime.Now.ToString("dd.MM.yyyy") + ".csv";
                StreamWriter writer = new StreamWriter(@Arq, true);
                writer.WriteLine("Nome" + ";" + "Login" + ";" + "CPF" + ";" + "Status");

                ds.Filter = "(&(objectCategory=group)(cn=" + grupo + "))";
                ds.SearchScope = SearchScope.Subtree;
                SearchResult grp = ds.FindOne();
                string dnGrupo = grp.GetDirectoryEntry().Properties["distinguishedname"].Value.ToString();

                try {
                    ds.Filter = "(&(memberOf=" + dnGrupo + ")(!userAccountControl:1.2.840.113556.1.4.803:=2))";
                    SearchResultCollection EnabledUsers = ds.FindAll();

                    foreach (SearchResult Enabled in EnabledUsers) {
                        LimparAtributos();

                        if (Enabled.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                            User.Nome = Enabled.GetDirectoryEntry().Properties["Name"].Value.ToString();

                        if (Enabled.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                            User.Login = Enabled.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                        if (Enabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                            User.Cpf = Enabled.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                        writer.WriteLine(User.Nome + ";" + User.Login + ";" + User.Cpf + ";" + "Ativo");

                    }
                

                    ds.Filter = "(&(memberOf=" + dnGrupo + ")(userAccountControl:1.2.840.113556.1.4.803:=2))";
                    SearchResultCollection DisabledUsers = ds.FindAll();

                    foreach (SearchResult DisabledUser in DisabledUsers) {
                        LimparAtributos();

                        if (DisabledUser.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                            User.Nome = DisabledUser.GetDirectoryEntry().Properties["Name"].Value.ToString();

                        if (DisabledUser.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                            User.Login = DisabledUser.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                        if (DisabledUser.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                            User.Cpf = DisabledUser.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                        writer.WriteLine(User.Nome + ";" + User.Login + ";" + User.Cpf + ";" + "Inativo");

                    }

                }
                catch (Exception e) {
                    MessageBox.Show(e.Message.ToString(), "Erro Grupos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                finally {
                    writer.Close();
                }

            }

        }

    }

}
