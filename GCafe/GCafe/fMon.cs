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
    public partial class fMon : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private List<DichVu> dichvu;

        private fManager manager;
        private DichVu dv;

        private string idDV;
        private string tenDV;
        private string loaiDV;
        private int giaDV;

        private string username;

        public fMon()
        {
            InitializeComponent();
        }

        private void loadDuLieu()
        {
            dtgvDichVu.Rows.Clear();

            dichvu = new List<DichVu>();

            sql = "select * from dichvu";

            try
            {
                cmd = new SqlCommand(sql, conn);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DichVu dv = new DichVu(rdr.GetString(0).Trim(), rdr.GetString(1).Trim(), rdr.GetString(2).Trim(), (int)rdr.GetDecimal(3));
                    dichvu.Add(dv);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            int i = 0;
            foreach (DichVu dv in dichvu)
            {
                i++;
                dtgvDichVu.Rows.Add(i, dv.getIdDichVu(), dv.getTenDichVu(), dv.getLoaiDichVu(), dv.getGia());
            }

        }

        private void fMon_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        public void setConnection(SqlConnection conn)
        {
            this.conn = conn;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dv = new DichVu(idDV, tenDV, loaiDV, giaDV);

            if (dv == null)
                MessageBox.Show("Chưa nhập dịch vụ !!");
            else
                manager.AddMon(dv);           
        }
        public void setManager(fManager manager)
        {
            this.manager = manager;
        }

        private void dtgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDV = dtgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            tenDV = dtgvDichVu.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            loaiDV = dtgvDichVu.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            giaDV = (int)dtgvDichVu.Rows[e.RowIndex].Cells[4].Value;
        }
        public void setUserName(string username)
        {
            this.username = username;
        }
    }
}
