using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GCafe
{
    public partial class ServerChat : Form
    {
        private IPEndPoint IP;
        private Socket _clientSocket;

        private Socket client;
        private int id;
        public ServerChat()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void ServerChat_Load(object sender, EventArgs e)
        {
            Connect();
        }
        private void Connect()
        {

            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1997);
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                _clientSocket.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

            FirstSend();
        }

        private new void Close()
        {
            _clientSocket.Close();
        }
        private void Send(Socket client, string text)
        {
            if (text != string.Empty)
            {
                client.Send(Serialize(text));
            }
        }
        private void FirstSend()
        {
            client.Send(Serialize("><"+id));
        }
        void Receive()
        {
            try
            {
                while (true)
                {

                    byte[] data = new byte[1024 * 5000];
                    _clientSocket.Receive(data);

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
            lstView.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
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
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            Send(client, txtMessage.Text);
            AddMessage("Admin: " + txtMessage.Text);
        }
        public void SetClient(Socket client)
        {
            this.client = client;
        }
        public void SetID(int id)
        {
            this.id = id;
        }

        private void ServerChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }
    }
}
