using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GCafe
{
    public partial class fGuest : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private ArrayList accounts;

        public fGuest()
        {
            InitializeComponent();
        }

        private void loadDuLieuGuest()
        {
            accounts = new ArrayList();
            sql = "Select * from Account";

            try
            {
                cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Account ac = new Account(rdr.GetString(0).Trim(), rdr.GetString(1).Trim(), (int)rdr.GetDecimal(2));
                    accounts.Add(ac);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            dtgvGuest.Rows.Clear();

            int i = 0;
            foreach(Account ac in accounts)
            {
                i++;
                dtgvGuest.Rows.Add(i, ac.getUserName(), ac.getPassWord(), ac.getTien());
            }
        }
        private void fGuest_Load(object sender, EventArgs e)
        {
            loadDuLieuGuest();
        }
        private void btnThoatKhach_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnThemKhach_Click(object sender, EventArgs e)
        {

            if (txtTKC.Text.Trim().Equals("") || txtPassC.Text.Trim().Equals("") || txtMoneyC.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMoneyC.Focus();
                return;
            }

            foreach(Account ac in accounts)
            {
                if (ac.getUserName().Equals(txtTKC.Text.Trim()))
                {
                    MessageBox.Show("Tài khoản bạn vừa nhập đã có sẵn !");
                    return;
                }
            }
            sql = "insert into Account values ('" + txtTKC.Text.Trim() + "', '" + txtPassC.Text.Trim() + "', '" + txtMoneyC.Text.Trim() + "')";

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            loadDuLieuGuest();
            MessageBox.Show("Thêm thành công !");
        }
        public void setConnection(SqlConnection conn)
        {
            this.conn = conn;
        }

        private void dtgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTK.Text = dtgvGuest.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMoney.Text = dtgvGuest.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void btnTimKhach_Click(object sender, EventArgs e)
        {

            foreach (Account ac in accounts)
            {
                if(string.Equals(txtSearch.Text.Trim(), ac.getUserName(), StringComparison.OrdinalIgnoreCase)){
                    dtgvGuest.Rows.Clear();
                    dtgvGuest.Rows.Add(1, ac.getUserName(), ac.getPassWord(), ac.getTien());
                }    
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            loadDuLieuGuest();
        }

        private void btnSuaMK_Click(object sender, EventArgs e)
        {
            sql = "update Account set pass = '1' where username = '" + txtTK.Text.Trim() + "'";
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                loadDuLieuGuest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            sql = "Delete from Account where username = '" + txtTK.Text.Trim() + "'";

            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn xóa !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(traloi == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loadDuLieuGuest();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace + ex.Message);
                }
            }
        }
    }
}
