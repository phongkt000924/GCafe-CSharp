using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace GCafe
{
    public partial class fComputer : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private List<May> mays;

        private fManager manager;
        
        public fComputer()
        {
            InitializeComponent();
        }

        private void btnThoatMay_Click(object sender, EventArgs e)
        {
            manager.loadDuLieuMay();
            manager.HienThiViTriMay();
            this.Dispose();
        }

        private void loadDulieu()
        {
            dtgvMay.Rows.Clear();

            mays = new List<May>();

            sql = "select * from May";
            try
            {
                cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    May a = new May(rdr.GetString(0).Trim(), rdr.GetString(1).Trim(), rdr.GetBoolean(2), (int)rdr.GetDecimal(3), rdr.GetString(4), rdr.GetDateTime(5).ToString(), rdr.GetDateTime(6).ToString());
                    mays.Add(a);
                }
                rdr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            foreach (May a in mays)
            {
                dtgvMay.Rows.Add(a.getIdmay(), a.getLoaimay(), a.getTrangthai(), a.getGia());
            }
        }


        private void fComputer_Load(object sender, EventArgs e)
        {
            loadDulieu();
        }

        private void dtgvMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMay.Text = dtgvMay.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            cboLoaiMay.Text = dtgvMay.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            txtGia.Text = dtgvMay.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
        }

        private void btnThemMay_Click(object sender, EventArgs e)
        {
            bool isDuplicate = false;
            foreach(May a in mays)
            {
                if (txtIdMay.Text.Trim().Equals(a.getIdmay(), StringComparison.OrdinalIgnoreCase))
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
            {
                MessageBox.Show("ID máy bị trùng");
            }
            else
            {
                sql = "Insert into May values ('" + txtIdMay.Text + "', '" + cboLoaiMay.Text.Trim() + "', '0', '" + txtGia.Text + "', '" + "Khong', '" + DateTime.Now +"', '2021-06-01 21:44:15')";
                try
                {
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    dtgvMay.Rows.Clear();

                    loadDulieu();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                
            }

        }

        private void cboLoaiMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaiMay.SelectedIndex == 0)
            {
                txtGia.Text = 8000.ToString();
            }
            else if(cboLoaiMay.SelectedIndex == 1)
            {
                txtGia.Text = 10000.ToString();
            }
            else
            {
                txtGia.Text = 12000.ToString();
            }
                

        }

        private void btnSuaMay_Click(object sender, EventArgs e)
        {
            bool isDuplicate = false;
            
            foreach(May may in mays)
            {
                if(txtIdMay.Text.Trim().Equals(may.getIdmay(), StringComparison.OrdinalIgnoreCase))
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                MessageBox.Show("ID máy bị trùng");
            }
            else
            {
                sql = "Update May set loaimay = '" + cboLoaiMay.Text.Trim() + "', gia = '" + Convert.ToInt32(txtGia.Text) + "' where idmay = '" + txtIdMay.Text + "'";

                try
                {
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadDulieu();
                    MessageBox.Show("Update thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnXoaMay_Click(object sender, EventArgs e)
        {
            sql = "Delete from May where idmay = '" + txtIdMay.Text + "'";
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                loadDulieu();
                MessageBox.Show("Xóa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void setConnection(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void setManager(fManager manager)
        {
            this.manager = manager;
        }
    }
}