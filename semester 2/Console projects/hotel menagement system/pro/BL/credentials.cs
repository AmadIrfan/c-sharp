using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BL
{
    class credentials
    {
        public string username;
        public string password;
        public string role;
        public credentials(string username, string password, string role)
        {

            this.username = username;
            this.password = password;
            this.role = role;
        }
        public credentials(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.role = "n/a";
        }
        public credentials()
        {

        }
    }
}
