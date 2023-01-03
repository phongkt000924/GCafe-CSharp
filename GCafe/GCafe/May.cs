using System;
using System.Collections.Generic;
using System.Text;

namespace GCafe
{
    class May
    {
        private string idmay;
        private string loaimay;
        private bool trangthai;
        private int gia;
        private string username;
        private string ckin;
        private string cout;

        public May()
        {

        }
        public May(string idmay, string loaimay, bool trangthai, int gia, string username, string ckin, string cout)
        {
            this.idmay = idmay;
            this.loaimay = loaimay;
            this.trangthai = trangthai;
            this.gia = gia;
            this.username = username;
            this.ckin = ckin;
            this.cout = cout;
        }
        
        public void setIdmay(string idmay)
        {
            this.idmay = idmay;
        }

        public void setLoaimay(string loaimay)
        {
            this.loaimay = loaimay;
        }

        public void setTrangthai(bool trangthai)
        {
            this.trangthai = trangthai;
        }

        public void setGia(int gia)
        {
            this.gia = gia;
        }

        public string getIdmay()
        {
            return this.idmay;
        }

        public string getLoaimay()
        {
            return this.loaimay;
        }
        public bool getTrangthai()
        {
            return this.trangthai;
        }

        public int getGia()
        {
            return this.gia;
        }
        public string getUserName()
        {
            return this.username;
        }
        public void setUserName(string username)
        {
            this.username = username;
        }
        public string getCkin()
        {
            return this.ckin;
        }
        public void setCkin(string ckin)
        {
            this.ckin = ckin;
        }
        public string getCout()
        {
            return this.cout;
        }
        public void setCout(string cout)
        {
            this.cout = cout;
        }
    }
}
