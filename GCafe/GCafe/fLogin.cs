using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace GCafe
{
    public partial class fLogin : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private string user;
        private string name;
        private string pass;
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(conn == null)
            {
                try
                {
                    conn = new SqlConnection("Server = LAPTOP-N4UTGVP6\\SQLEXPRESS; uid = sa; pwd = sa2012; Database = GCafeDemo");
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql = "Select * from adminaccount where usernamead = '" + txtUsername.Text + "' and passad = '" + txtPassword.Text + "'";
            int temp = 0;
            try
            {
                cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    user = rdr.GetString(0);
                    pass = rdr.GetString(1);
                    name = rdr.GetString(2);
                    temp++;
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            if (temp == 0)
            {
                MessageBox.Show("Tên đăng nhập or mật khẩu không chính xác !!");
            }
            else
            {
                fManager manager = new fManager();
                manager.setName(name);
                manager.setConnection(conn);
                manager.Show();
                this.Dispose(false);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
                conn.Close();
            }
        }
        public string getName()
        {
            return this.name;
        }
        private void btnEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }
        private void btnEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}

