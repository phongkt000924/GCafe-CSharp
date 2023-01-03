using System;
using System.Collections.Generic;
using System.Text;

namespace GCafe
{
    class Account
    {
        private string username;
        private string password;
        private int tien;

        public Account()
        {

        }

        public Account(string username, string password, int tien)
        {
            this.username = username;
            this.password = password;
            this.tien = tien;
        }

        public string getUserName() { return this.username; }
        public string getPassWord() { return this.password; }
        public int getTien() { return this.tien; }

        public void setUserName(string username) { this.username = username; }
        public void setPassWord(string password) { this.password = password; }
        public void setTien(int tien) { this.tien = tien; }
    }
}
