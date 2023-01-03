using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GCafe
{
    public partial class fManager : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sql;

        private string name;

        private List<May> listMay = new List<May>();
        private List<Button> listButton = new List<Button>();

        //dữ liệu đầu vào dành cho Server
        private IPEndPoint IP;
        private Socket _serverSocket;

        private List<listClient> listClients = new List<listClient>();

        public fManager()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        //load dữ liệu vào form
        public void fManager_Load(object sender, EventArgs e)
        {
            lbName.Text = name;
            loadDuLieuMay();
            HienThiViTriMay();
            Connect();
        }

        //load dữ liệu của tất cả các máy có trong CSDL
        public void loadDuLieuMay()
        {
            sql = "Select * from May";

            listMay = new List<May>();

            try
            {
                cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    May a = new May(rdr.GetString(0).Trim(), rdr.GetString(1).Trim(), rdr.GetBoolean(2), (int)rdr.GetDecimal(3), rdr.GetString(4), rdr.GetDateTime(5).ToString(), rdr.GetDateTime(6).ToString());
                    listMay.Add(a);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            dtgvManager.Rows.Clear();
            foreach (May a in listMay)
                dtgvManager.Rows.Add(a.getIdmay(), a.getLoaimay(), a.getTrangthai(), a.getUserName());
        }
        //Hiển thị vị trí của tất cả các máy vào vị trí tương ứng.
        public void HienThiViTriMay()
        {
            tpMay.Controls.Clear();
            int x = 30, y = 30;
            int w = 100, h = 100;

            int i = 1;
            foreach(May may in listMay)
            {
                Button temp = new Button();
                temp.SetBounds(x, y, w, h);
                temp.Text = may.getIdmay();

                if (may.getTrangthai() == false)
                    temp.BackColor = Color.Red;
                else
                    temp.BackColor = Color.Blue;

                tpMay.Controls.Add(temp);

                temp.Click += temp_Click;


                if (i % 5 == 0)
                {
                    x = 30;
                    y += 130;
                }
                else
                {
                    x += 130;
                }
                i++;
            }
        }
        private void temp_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            ServerChat nSer = new ServerChat();
            foreach(listClient lC in listClients)
            {
                if (lC.getID().ToString().Trim() == temp.Text)
                {
                    nSer.SetID(Int32.Parse(temp.Text.Trim()));
                    nSer.SetClient(lC.getClient());
                }
            }
            nSer.Show();
        }
        //Tạo ra Server
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Any, 1997);
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            _serverSocket.Bind(IP);

            Thread Listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        _serverSocket.Listen(100);
                        Socket client = _serverSocket.Accept();
                        listClient lC = new listClient(client, 1000);
                        listClients.Add(lC);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }

                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 1997);
                    _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        private new void Close()
        {
            _serverSocket.Close();
        }
        private void Send(Socket client, string text)
        {
            if ((client != null))
            {
                client.Send(Serialize(text));
            }
        }
        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    
                    string message = (string)Deseriliaze(data);

                    switch (message.Trim())
                    {
                        case "1.....":
                            setID(1);
                            break;
                        case "2.....":
                            setID(2);
                            break;
                        case "3.....":
                            setID(3);
                            break;
                        case "4.....":
                            setID(4);
                            break;
                        case "5.....":
                            setID(5);
                            break;
                        case "6.....":
                            setID(6);
                            break;
                        case "7.....":
                            setID(7);
                            break;
                        case "8.....":
                            setID(8);
                            break;
                        case "9.....":
                            setID(9);
                            break;
                        case "10.....":
                            setID(10);
                            break;

                            ////setForChat
                            //case "><1":
                            //    setServerID(1);
                            //    break;
                            //case "><2":
                            //    setServerID(2);
                            //    break;
                            //case "><3":
                            //    setServerID(3);
                            //    break;
                            //case "><4":
                            //    setServerID(4);
                            //    break;
                            //case "><5":
                            //    setServerID(5);
                            //    break;
                            //case "><6":
                            //    setServerID(6);
                            //    break;
                            //case "><7":
                            //    setServerID(7);
                            //    break;
                            //case "><8":
                            //    setServerID(8);
                            //    break;
                            //case "><9":
                            //    setServerID(9);
                            //    break;
                            //case "><10":
                            //    setServerID(10);
                            //    break;
                            //case "><11":
                            //    setServerID(11);
                            //    break;
                            //case "><12":
                            //    setServerID(12);
                            //    break;
                    }
                }
            }
            catch
            {
                //clientList.Remove(client);
                client.Close();
            }
        }

        private void setID(int ID)
        {
            foreach (listClient lC in listClients)
            {
                if (lC.getID() == 1000)
                {
                    lC.setID(ID);
                }
            }
            MessageBox.Show("Có kết nối mới !!");
        }
        private void setServerID(int ID)
        {
            foreach (listClient lC in listClients)
            {
                if (lC.getID() == 1000)
                {
                    lC.setID(ID + 100);
                }
            }
            MessageBox.Show("Có kết nối mới !!");
        }
        private void Sending(int i, string text)
        {
            foreach (listClient lC in listClients)
            {
                if (lC.getID() == (i + 100))
                {
                    Send(lC.getClient(), text);
                    Debug.WriteLine("Kiếm được rồi");
                }
            }
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































        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                fLogin newOne = new fLogin();
                newOne.Show();
                Close();
                this.Dispose();
            }       
        }
        private void btnKhach_Click(object sender, EventArgs e)
        {
            fGuest khach = new fGuest();
            khach.setConnection(conn);
            khach.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimer.Text=(DateTime.Now.ToString());
        }
        private void btnMay_Click(object sender, EventArgs e)
        {
            fComputer may = new fComputer();
            may.setManager(this);
            may.setConnection(conn);
            may.ShowDialog();
        }
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            fService dichvu = new fService();
            dichvu.setConnection(conn);
            dichvu.ShowDialog();
        }
        public void setConnection(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            fMon mon = new fMon();
            mon.setConnection(conn);
            mon.setUserName(txtUsername.Text.Trim());
            mon.setManager(this);
            mon.Show();
        }

        internal void AddMon(DichVu dv)
        {
            dtgvMon.Rows.Add(dtgvMon.Rows.Count + 1, dv.getTenDichVu(), dv.getGia());
            sql = "Insert into eatNdrink values ('" + txtUsername.Text.Trim() + "', '" + dv.getTenDichVu() + "', '" + dv.getGia() + "')";

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
        int tempIndex = -10;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tempIndex == -10)
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa !!");
            else
            {
                dtgvMon.Rows.RemoveAt(tempIndex);


                sql = "delete from eatNdrink where username = '" + txtUsername.Text.Trim() + "' and tenmon = '" + tenmon +"';";
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
        }
        string tenmon;
        private void dtgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tempIndex = e.RowIndex;
            tenmon = dtgvMon.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
        }
        public void setClient(Socket client, int viTri)
        {
            //clientList[viTri] = client;
        }

        private void dtgvManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMay.Text = dtgvManager.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            txtLoai.Text = dtgvManager.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            if (txtLoai.Text.Trim().Equals("NORMAL"))
                txtGia.Text = 8000.ToString();
            else if(txtLoai.Text.Trim().Equals("VIP"))
                txtGia.Text = 10000.ToString();
            else
                txtGia.Text = 12000.ToString();
            txtUsername.Text = dtgvManager.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            foreach(May may in listMay)
            {
                if(may.getIdmay() == txtMay.Text.Trim())
                {
                    txtCkin.Text = may.getCkin();
                    txtCout.Text = may.getCout();
                    
                }
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            fBill bill = new fBill();
            bill.SetConnection(conn);
            bill.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadDuLieuMay();
            HienThiViTriMay();
        }
        string ten = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime ckin = DateTime.Now;
            DateTime cout = DateTime.Now;
            int giatien = 0;

            sql = "Select * from May where idmay = '" + txtMay.Text.Trim() + "';";

            try
            {
                cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ten = rdr.GetString(4);
                    giatien = (int)rdr.GetDecimal(3);
                    ckin = rdr.GetDateTime(5);
                    cout = rdr.GetDateTime(6);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            int a = Convert.ToInt32(cout.Subtract(ckin).TotalSeconds / 3600);
            txtTienGio.Text = (a * giatien).ToString();
            int tienDV = 0;
            foreach (DataGridViewRow row in dtgvMon.Rows)
            {
                tienDV = tienDV + Convert.ToInt32(row.Cells[2].Value);
            }
            txtTienDV.Text = tienDV.ToString();

            txtTT.Text = (tienDV + a * giatien).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sql = "delete from eatNdrink where username = '" + txtUsername.Text.Trim() + "'";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            sql = "update may set trangthai = 'false', username = 'Khong' where idmay = '" + txtMay.Text.Trim() +"'";
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            loadDuLieuMay();
            dtgvMon.Rows.Clear();
            txtMay.Text = string.Empty;
            txtLoai.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtCkin.Text = string.Empty;
            txtCout.Text = string.Empty;
        }
    }
}
