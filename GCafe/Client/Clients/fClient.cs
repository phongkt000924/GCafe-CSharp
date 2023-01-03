using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clients
{
    public partial class fClient : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private List<Account> listAccount;

        public fClient()
        {
            InitializeComponent();
        }
        private void fClient_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            LoadDuLieuMay();
        }
        private void loadDuLieu()
        {
            if (conn == null)
            {
                try
                {
                    conn = new SqlConnection("Server = LAPTOP-N4UTGVP6\\SQLEXPRESS; uid = sa; pwd = sa2012; Database = GCafeDemo");
                    conn.Open();

                    sql = "Select * from may where trangthai = 'false'";

                    cmd = new SqlCommand(sql, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        cboMayClient.Items.Add(rdr.GetString(0));
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
            }
            cboMayClient.Text = cboMayClient.Items[0].ToString();
        }
        private void LoadDuLieuMay()
        {
            listAccount = new List<Account>();

            sql = "Select * from Account";
            try
            {
                cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Account a = new Account(rdr.GetString(0).Trim(), rdr.GetString(1).Trim(), (int)rdr.GetDecimal(2));
                    listAccount.Add(a);
                }
                rdr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnLogoutClient_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Dispose();

            }
        }

        private void btneye_MouseUp_1(object sender, MouseEventArgs e)
        {
            txtPassClient.PasswordChar = '*';
        }

        private void btneye_MouseDown_1(object sender, MouseEventArgs e)
        {
            txtPassClient.PasswordChar = '\0';
        }

        private void btnLoginClient_Click(object sender, EventArgs e)
        {
            if(txtPassClient.Text.Trim().Equals(string.Empty) || txtUserClient.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach(Account a in listAccount)
            {
                if (txtPassClient.Text.Trim() == a.getPassWord() && txtUserClient.Text.Trim() == a.getUserName())
                {
                    ChatBox cb = new ChatBox();
                    cb.SetSttMay(cboMayClient.SelectedItem.ToString());
                    cb.SetUserName(a.getUserName());
                    cb.SetTien(a.getMoney());
                    cb.setConnection(conn);
                    cb.ShowDialog();
                    this.Dispose(false);
                }
            }
        }



        private void fClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
