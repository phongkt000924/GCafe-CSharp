using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GCafe
{
    public partial class fBill : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private List<bill> bills = new List<bill>();
        public fBill()
        {
            InitializeComponent();
        }
        private void LoadDuLieu()
        {
            sql = "Select * from hoadon";
            bills = new List<bill>();

            try
            {
                cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    bill b = new bill(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetDateTime(3).ToString(), rdr.GetDateTime(4).ToString());
                    bills.Add(b);
                }
                rdr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
            int i = 1;
            foreach(bill b in bills)
            {
                dtgvBill.Rows.Add(i, b.getIDhd(), b.getIDMay(), b.getUsername(), b.getCkin(), b.getCout());
            }
        }
        private void btnThoatBill_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }
        public void SetConnection(SqlConnection conn)
        {
            this.conn = conn;
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
    }
}
