using System;
using System.Collections.Generic;
using System.Text;

namespace GCafe
{
    class cAdminAccount
    {
        private string user;
        private string pass;
        private string name;

        public cAdminAccount(string user, string pass, string name)
        {
            this.user = user;
            this.pass = pass;
            this.name = name;
        }

        public cAdminAccount()
        {

        }

        public string getUser()
        {
            return this.user;
        }

        public string getPass()
        {
            return this.pass;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
