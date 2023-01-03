using System;
using System.Collections.Generic;
using System.Text;

namespace GCafe
{
    class bill
    {
        private string idHD;
        private string idMay;
        private string username;
        private string ckin;
        private string cout;
        public bill()
        {

        }
        public bill(string idHD, string idMay, string username, string ckin, string cout)
        {
            this.idHD = idHD;
            this.idMay = idMay;
            this.username = username;
            this.ckin = ckin;
            this.cout = cout;
        }
        public string getIDhd()
        {
            return this.idHD;
        }
        public string getIDMay()
        {
            return this.idMay;
        }
        public string getUsername()
        {
            return this.username;
        }
        public string getCkin()
        {
            return this.ckin;
        }
        public string getCout()
        {
            return this.cout;
        }
    }
}
