using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using POI;

namespace FClient
{
    public partial class Form1 : Form
    {
        delegate void OnMessageDelegate(String msg);
        delegate void OnComboDelegate(String msg);

        public Client mClient { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        public void onMessageCalback(String msg)
        {
            if (txtChat.InvokeRequired)
            {
                OnMessageDelegate callback = new OnMessageDelegate(onMessageCalback);
                this.Invoke(callback, new object[] { msg });
            }
            else
            {
                txtChat.AppendText(msg+"\n");
            }
        }

        public void onComboCallback(String msg)
        {
            if (cbOnline.InvokeRequired)
            {
                OnComboDelegate callback = new OnComboDelegate(onComboCallback);
                this.Invoke(callback, new object[] { msg });
            }
            else
            {
                cbOnline.Items.Add(msg);
            }
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            String clientName = nombreCliente.Text;
            if (clientName == "")
            {
                MessageBox.Show("Para conectar es necesario un nombre");
                return;
            }
            mClient = new Client();
            mClient.mName = clientName;
            mClient.connect();
            //mClient.listening(onMessageCalback);

            //mClient.listening(onMessageCalback); //creo que esto lo agregué porque el profe debe haber dicho algo como "y algo asi es como se reciben mensajes usando un callback" pero creo que eso hay que hacerlo.


            //enviamos nuestro nombre de cliente al servidor
            //el nombre de usuario debe ser unico
            //aqui se manda el string, la base de datos debe subirlo a la tabla y debe tener una clave unica,
            //el nombre de usuario puede/deberia ser unico.
            mClient.sendStringMsg(clientName);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String msg = txtMensaje.Text;
            String contact = cbOnline.SelectedText;
            contact = cbOnline.SelectedItem.ToString();
            if (msg == "")
                return;
            
            mClient.sendMessageToClient(msg, contact);
        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOnline_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
    }
}
