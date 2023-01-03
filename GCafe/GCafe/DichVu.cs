using System;
using System.Collections.Generic;
using System.Text;

namespace GCafe
{
    class DichVu
    {
        private string iddichvu;
        private string tendichvu;
        private string loaidichvu;
        private int gia;

        public DichVu()
        {

        }

        public DichVu(string iddichvu, string tendichvu, string loaidichvu, int gia)
        {
            this.iddichvu = iddichvu;
            this.tendichvu = tendichvu;
            this.loaidichvu = loaidichvu;
            this.gia = gia;
        }

        //get
        public string getIdDichVu() { return this.iddichvu; }
        public string getTenDichVu() { return this.tendichvu; }
        public string getLoaiDichVu() { return this.loaidichvu; }
        public int getGia() { return this.gia; }

        //set
        public void setIdDichVu(string iddichvu) { this.iddichvu = iddichvu; }
        public void setTenDichVu(string tendichvu) { this.tendichvu = tendichvu; }
        public void setLoaiDichVu(string loaidichvu) { this.loaidichvu = loaidichvu; }
        public void setGia(int gia) { this.gia = gia; }
    }
}
