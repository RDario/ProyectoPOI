using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Nuestra libreria dll
using POI;

namespace FServer
{
    public partial class Form1 : Form
    {

        public Server mServer { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        delegate void OnClientConnectedDelegate(Client client);

        public void onClientConnected(Client client)
        {
            if (lvClients.InvokeRequired)
            {
                OnClientConnectedDelegate callback = new OnClientConnectedDelegate(onClientConnected);
                this.Invoke(callback, new object[] { client });
            }
            else
            {
                ListViewItem item = new ListViewItem(client.mName);
                lvClients.Items.Add(item);
            }
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            mServer = new Server(onClientConnected);//agregado en la clase de hilos

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mServer != null)
            {
               mServer.mIsThreadRunning = false;
               mServer.stopSocket();
            }
        }

        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
