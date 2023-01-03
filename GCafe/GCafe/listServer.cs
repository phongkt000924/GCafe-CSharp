using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace GCafe
{
    class listServer
    {
        private Socket client;
        private int ID;
        public listServer()
        {

        }
        public listServer(Socket client, int ID)
        {
            this.client = client;
            this.ID = ID;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return this.ID;
        }
        public Socket getClient()
        {
            return this.client;
        }
    }
}
