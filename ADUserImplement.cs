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
    class ADUserImplement {
        //private static DirectoryEntry de = new DirectoryEntry("LDAP://livehost-dom.local");
        private static DirectorySearcher ds = new DirectorySearcher();
        private static PrincipalContext context = new PrincipalContext(ContextType.Domain);
        public User User = new User();

        public String GetDomain() {
            Domain domain = Domain.GetComputerDomain();
            return domain.Name.ToString();
        }

        public void NewADUser(User user, string senha) {
            try {
                DirectoryEntry NewUser;
                DirectoryEntry UserDirectory;

                String strPath = "LDAP://OU=INTRANET,DC=livehost-dom,DC=local";
                UserDirectory = new DirectoryEntry(strPath);
                UserDirectory.RefreshCache();

                NewUser = UserDirectory.Children.Add("CN=" + user.Nome, "user");
                NewUser.Properties["Name"].Add(user.Nome);
                NewUser.Properties["DisplayName"].Add(user.Nome);
                NewUser.Properties["SamAccountName"].Add(user.Login);
                NewUser.Properties["mail"].Add(user.Mail);
                NewUser.Properties["EmployeeNumber"].Add(user.Cpf);
                NewUser.Properties["EmployeeID"].Add(user.DataNasc);
                NewUser.Properties["Title"].Add(user.Cargo);
                NewUser.Properties["UserPrincipalName"].Add(user.Login + "@livehost-dom.local");
                NewUser.CommitChanges();

                UserPrincipal ADUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user.Login);
                ADUser.SetPassword(senha);
                ADUser.Enabled = true;
                ADUser.ExpirePasswordNow();
                ADUser.Save();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public SearchResult GetUserLogin(String user, int n) {
            if (n == 0) {
                ds.Filter = "(&(objectCategory=Person)(objectClass=User)(Name=" + user + "*))";
            }
            else if (n == 1) {
                ds.Filter = "(&(objectCategory=Person)(objectClass=User)(SamAccountName=" + user + "))";
            }
            else if (n == 2) {
                user = user.Replace(".","");
                user = user.Replace("-","");
                ds.Filter = "(&(objectCategory=Person)(objectClass=User)(EmployeeNumber=" + user + "))";
            }

            ds.SearchScope = SearchScope.Subtree;
            SearchResult AdUser = ds.FindOne();
            return AdUser;
        }

        public SearchResultCollection GetUsers(String user, int n) {
            if (n == 0) {
                ds.Filter = "(&(objectCategory=Person)(objectClass=User)(Name=" + user + "))";
            }
            else if (n == 1) {
                ds.Filter = "(&(objectCategory=Person)(objectClass=User)(SamAccountName=" + user + "))";
            }
            else if (n == 2) {
                user = user.Replace(".","");
                user = user.Replace("-","");
                ds.Filter = "(&(objectCategory=Person)(objectClass=User)(EmployeeNumber=" + user + "))";
            }

            ds.SearchScope = SearchScope.Subtree;            
            SearchResultCollection AdUsers = ds.FindAll();
            return AdUsers;
        }

        /*
        public void ResetPassword(String user, int n, String senha) {
            SearchResult rs = null;
            rs = GetUserLogin(ds, user, n);

            DirectoryEntry entryUpdate = rs.GetDirectoryEntry();
            entryUpdate.Invoke("SetPassword", new object[] { senha });
            entryUpdate.CommitChanges();
        }
        */

        public User GetUserInfo(String user, int n) {
            LimparAtributos();
            SearchResult rs = null;

            try {
                rs = GetUserLogin(user, n);

                if (rs.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                    User.Nome = rs.GetDirectoryEntry().Properties["DisplayName"].Value.ToString();

                if (rs.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                    User.Login = rs.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                if (rs.GetDirectoryEntry().Properties["EmployeeNumber"].Value != null)
                    User.Cpf = rs.GetDirectoryEntry().Properties["EmployeeNumber"].Value.ToString();

                if (rs.GetDirectoryEntry().Properties["EmployeeId"].Value != null)
                    User.DataNasc = rs.GetDirectoryEntry().Properties["EmployeeId"].Value.ToString();

                if (rs.GetDirectoryEntry().Properties["mail"].Value != null)
                    User.Mail = rs.GetDirectoryEntry().Properties["mail"].Value.ToString();

                if (rs.GetDirectoryEntry().Properties["Title"].Value != null)
                    User.Cargo = rs.GetDirectoryEntry().Properties["Title"].Value.ToString();

                if (rs.GetDirectoryEntry().Properties["whenCreated"].Value != null)
                    User.Criado = (DateTime)rs.Properties["whenCreated"][0];

                if (rs.GetDirectoryEntry().Properties["whenChanged"].Value != null)
                    User.Modificado = (DateTime)rs.Properties["whenChanged"][0];

                var pwdLastSet = (long)rs.Properties["pwdLastSet"][0];
                User.UltTrcSenha = DateTime.FromFileTime(pwdLastSet);

                String path = rs.GetDirectoryEntry().Properties["DistinguishedName"].Value.ToString();
                String[] sPath = path.Split(',');

                User.Local = sPath[3].Replace("OU=","") + " " + sPath[1].Replace("OU=","");

                return User;
            }
            catch (Exception e) {
                LimparAtributos();
                MessageBox.Show(e.Message.ToString(), "Erro GetUserInfo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return User;
            }

        }

        public List<User> GetUsersInfoGrid(String user, int n) {
            List<User> ListUsers = new List<User>();
            SearchResultCollection rsc = null;
            
            try {
                rsc = GetUsers(user, n);

                foreach (SearchResult rs in rsc) {
                    User UserGrid = new User();
                    if (rs.GetDirectoryEntry().Properties["DisplayName"].Value != null)
                        UserGrid.Nome = rs.GetDirectoryEntry().Properties["DisplayName"].Value.ToString();

                    if (rs.GetDirectoryEntry().Properties["SamAccountName"].Value != null)
                        UserGrid.Login = rs.GetDirectoryEntry().Properties["SamAccountName"].Value.ToString();

                    ListUsers.Add(UserGrid);
                }

                return ListUsers;
            }
            catch (Exception e) {
                //MessageBox.Show(e.Message.ToString(), "Erro Grid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ListUsers.Clear();
                return ListUsers;
            }

        }

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

        public User GetPrincipalUserInfo(String user) {
            try {
                UserPrincipal ADUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user);
                User.Bloqueado = ADUser.IsAccountLockedOut().ToString();
                User.Ativo = ADUser.Enabled.ToString();
                return User;
            }
            catch(Exception e) {
                LimparAtributos();
                e.Message.ToString();
                return User;
            }
        }

    /*
        public void NewADUser(User user) {
            UserPrincipal ADUser = new UserPrincipal(context);
            ADUser.Name = user.Nome;
            ADUser.DisplayName = user.Nome;
            ADUser.SamAccountName = user.Login;
            ADUser.EmailAddress = user.Mail;

            ADUser.Save();

        }
    */

        public void EnableUser(String user) {
            try {
                UserPrincipal ADUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user);
                if (ADUser.Enabled == false) {
                    ADUser.Enabled = true;
                    ADUser.DisplayName = ADUser.Name;
                    ADUser.Save();
                    MessageBox.Show("Usuário Ativado", "Ativar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void DisableUser(String user) {
            try {
                UserPrincipal ADUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user);
                if (ADUser.Enabled == true) {
                    ADUser.Enabled = false;
                    ADUser.DisplayName = "DESATIVADO - " + ADUser.Name;
                    ADUser.Save();
                    MessageBox.Show("Usuário Desativado", "Desativar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public Boolean ResetPassword(String user, String senha) {
            try {
                UserPrincipal ADUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user);
                ADUser.SetPassword(senha);
                ADUser.ExpirePasswordNow();
                ADUser.Save();
                return true;
                                
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

        }

        public void UnlockUser(String user) {
            try {
                UserPrincipal ADUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user);
                if (ADUser.IsAccountLockedOut()) {
                    ADUser.UnlockAccount();
                    ADUser.Save();
                    MessageBox.Show("Usuário Desbloqueado", "Desbloquear Usuário", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void ValidateUser(String user, String senha) {
            try {
                UserPrincipal ADUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user);

                if (ADUser.Enabled == true && !ADUser.IsAccountLockedOut()) {
                    if (context.ValidateCredentials(user, senha)) {
                        MessageBox.Show("Senha Correta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else {
                        MessageBox.Show("Senha Incorreta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (ADUser.IsAccountLockedOut()) {
                        MessageBox.Show("Usuário Bloqueado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else if (ADUser.Enabled == false) {
                    MessageBox.Show("Usuário Desativado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ADUser.IsAccountLockedOut()) {
                    MessageBox.Show("Usuário Bloqueado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void ValidateUser2(String user, String senha) {
            DirectoryEntry de = new DirectoryEntry("LDAP://stefanini.dom", user, senha);
            DirectorySearcher ds = new DirectorySearcher(de);

            try {
                var result = ds.FindOne();
                MessageBox.Show("Autenticado com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}