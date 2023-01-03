using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class Account
    {
        private string username;
        private string password;
        private int money;

        public Account()
        {

        }
        public Account(string username, string password, int money)
        {
            this.username = username;
            this.password = password;
            this.money = money;
        }
        public string getUserName()
        {
            return this.username;
        }
        public string getPassWord()
        {
            return this.password;
        }
        public int getMoney()
        {
            return this.money;
        }
        public void setUserName(string username)
        {
            this.username = username;
        }
        public void setPassWord(string password)
        {
            this.password = password;
        }
        public void setMoney(int money)
        {
            this.money = money;
        }
    }
}
