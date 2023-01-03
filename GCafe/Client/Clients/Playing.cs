using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clients
{
    public partial class ChatBox : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd;
        private string sql;

        private IPEndPoint IP;
        private Socket client;

        private string sttMay;
        private string username;
        private int tien;
        private string ckin;
        private string cout;

        public ChatBox()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //Connect();
        }
        private void ChatBox_Load(object sender, EventArgs e)
        {
            Connect();
            setTrangThai("true");
            SetUser(username);
            SetCkin();
        }

        private void Connect()
        {

            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1997);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            FirstSend(sttMay.Trim() + ".....");
        }

        private new void Close()
        {
            client.Close();
        }
        //private void Send(String text)
        //{
        //    if (text != string.Empty)
        //    {
        //        client.Send(Serialize("Máy" + sttMay.Trim() + ": " +text));
        //    }
        //}
        private void FirstSend(string text)
        {
            client.Send(Serialize(text));
        }
        void Receive()
        {
            try
            {
                while (true)
                {

                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    
                    string message = (string)Deseriliaze(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }
        private void AddMessage(string s)
        {
            s = "Admin: " + s;
            lstView.Items.Add(new ListViewItem() { Text = s });
        }
        private byte[] Serialize(object obj)
        {

            MemoryStream stream = new MemoryStream();

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        private object Deseriliaze(byte[] data)
        {

            MemoryStream stream = new MemoryStream(data);

            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void setTrangThai(string trangthai)
        {
            sql = "update May set trangthai = '" + trangthai + "' where idmay = '" + sttMay + "'";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void SetUser(string username)
        {
            sql = "update may set username = '" + username + "' where idmay = '"+ sttMay +"'";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void SetCkin()
        {
            ckin = DateTime.Now.ToString();
            sql = "update may set checkin = '" + DateTime.Now + "' where idmay = '" + sttMay + "'";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void SetCout()
        {
            cout = DateTime.Now.ToString();
            sql = "update may set checkout = '" + DateTime.Now + "' where idmay = '" + sttMay + "'";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void SetHD()
        {
            sql = "select max(idhoadon) from hoadon";
            int idhd = 1;
            try
            {
                cmd = new SqlCommand(sql, conn);
                if(cmd.ExecuteScalar() == null)
                {
                    idhd = 1;
                }
                else
                {
                    idhd = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            sql = "insert into hoadon values ('" + idhd + "', '" + sttMay + "', '" + username + "', '" + ckin + "', '" + cout + "')";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ChatBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetCout();
            SetHD();
            fClient clientt = new fClient();
            clientt.Show();
            this.Dispose();
        }

        private void ChatBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
        public void SetUserName(string username)
        {
            this.username = username;
        }
        public void setConnection(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void SetSttMay(string sttMay)
        {
            this.sttMay = sttMay;
        }
        public void SetTien(int tien)
        {
            this.tien = tien;
        }
    }
}
