using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignApplication.BL
{
    internal class mUser
    {
        private string userName;
        private string password;
        private string role;

        public mUser(string userName, string password, string role)
        {
            this.UserName = userName;
            this.Password = password;
            this.Role = role;
        }
        public mUser(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
         
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
