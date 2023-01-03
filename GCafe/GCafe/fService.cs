using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GCafe
{
    public partial class fService : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private ArrayList dichvu;
        public fService()
        {
            InitializeComponent();
        }

        private void loadDuLieu()
        {
            dtgvDichVu.Rows.Clear();

            dichvu = new ArrayList();
            
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

        private void btnThoatMay_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setConnection(SqlConnection conn)
        {
            this.conn = conn;
        }

        private void fService_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void dtgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDV.Text = dtgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTenDV.Text = dtgvDichVu.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboLoaiDV.Text = dtgvDichVu.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGiaDV.Text = dtgvDichVu.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            bool isDulicate = false;

            foreach(DichVu dv in dichvu)
            {
                if (txtIdDV.Text.Trim().Equals(dv.getIdDichVu()))
                {
                    isDulicate = true;
                    break;
                }
            }

            if (isDulicate)
            {
                MessageBox.Show("ID dịch vụ bị trùng !!");
            }
            else
            {
                sql = "Insert into dichvu values ('" + txtIdDV.Text + "', '" + txtTenDV.Text + "', '" + cboLoaiDV.Text.Trim() + "', '" + txtGiaDV.Text + "')";

                try
                {
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace + ex.Message);
                }
            }
        }

        private void SuaDV_Click(object sender, EventArgs e)
        {
            bool isDuplicate = false;

            foreach(DichVu dv in dichvu)
            {
                if (txtIdDV.Text.Trim().Equals(dv.getIdDichVu()))
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                MessageBox.Show("ID dịch vụ bị trùng !!");
            }
            else
            {
                sql = "update dichvu set tendichvu = '" + txtTenDV.Text + "', loaidichvu = '" + cboLoaiDV.Text + "', gia = '" + txtGiaDV.Text + "' where iddichvu = '" + txtIdDV.Text + "'";
                try
                {
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadDuLieu();
                    MessageBox.Show("Update thành công !!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void XoaDV_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn thật sự muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(traloi == DialogResult.Yes)
            {
                sql = "Delete from dichvu where iddichvu = '" + txtIdDV.Text + "'";

                try
                {
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadDuLieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace + ex.Message);
                }
            }
            else
            {

            }
        }
    }
}
