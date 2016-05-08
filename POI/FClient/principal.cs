using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using POI;
using System.Security.Cryptography;
using System.IO;
using System.Collections;
using System.Net.NetworkInformation;
using System.Threading;

namespace FClient
{
    public partial class principal : Form
    {
        public Client mClient { get; set; }
        delegate void OnMessageDelegate(String msg, String para);
        delegate void OnComboDelegate(String msg);
        public static ArrayList chats = new ArrayList();
        ArrayList Contacts = new ArrayList();
        ArrayList Groups = new ArrayList();
        int cuenta = 0;
        int ytin = 10;
        int ypin = 20;
        int ytbdm = 10;
        int ypbdm = 20;
        int contador;
        PictureBox[] pbName = new PictureBox[150];
        PictureBox[] pbBorder = new PictureBox[150];
        RichTextBox[] tbName = new RichTextBox[150];

        delegate void onContactList(String msg);
        delegate void onFileDelegate(String msg);
        delegate void onConversacionDelegate(String desde, String msg);
        delegate void PegarMuroCallback(String muro, String usuario, String publicacion);
        delegate void cambiarPanel(String bol);
        private System.Windows.Forms.Timer timer1;

        public void onWebcamRequest(String msg)
        {
            if (MessageBox.Show("El usuario " + msg + " quiere comenzar una transmision webcam. ¿Aceptas?", "Webcam Request", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mClient.webCamAccept(msg, mClient.mName);

            }
        }
        public void onFileRequest(String path,String name)
        {
            if (MessageBox.Show("El usuario " + name + " quiere compartir el archivo "+path+ " contigo, ¿Aceptas?", "Transferencia de Archivo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                mClient.descargaArchivo(path);
            }
        }
        public void onWebcamEstablish(String ip,String usuario)
        {
            foreach (chat ch in chats)
            {
                if (usuario == ch.Text)
                {
                    ch.comienzaWebcam(ip);
                    break;
                }
            }
        }
        public void onConversacionCallback(String para, String msg)
        {
            foreach (chat ch in chats)
            {
                if (para == ch.Text)
                {
                    ch.onConversacionCallback(msg);
                    break;
                }
            }
        }
        public void onMessageCallback(String msg, String para)
        {
            foreach (chat ch in chats)
            {
                if (para == ch.Text)
                {
                    ch.onMessageCallback(msg);
                    break;
                }
            }
        }
        bool panelswitch = true;
        public void onWallCallback(String muro, String usuario,String publicacion)
        {
            if (InvokeRequired)
            {
                PegarMuroCallback d = new PegarMuroCallback(onWallCallback);
                this.Invoke(d, new object[] { muro, usuario, publicacion });
            }
            else
            {
                foreach (Client contact in Contacts)
                {

                    if (usuario == contact.mName)
                    {
                        tbName[cuenta] = new RichTextBox();
                        pbName[cuenta] = new PictureBox();
                        pbBorder[cuenta] = new PictureBox();

                        if (muro == "Muros/Inicio.txt")
                        {
                            tbName[cuenta].Parent = this.muroInicio;
                            pbName[cuenta].Parent = this.muroInicio;
                            tbName[cuenta].Location = new Point(70, ytin);
                            pbName[cuenta].Location = new Point(10, ypin);
                            ytin += 80;
                            ypin += 80;
                        }
                        if (muro == "Muros/BDM.txt")
                        {
                            tbName[cuenta].Parent = this.muroBDM;
                            pbName[cuenta].Parent = this.muroBDM;
                            tbName[cuenta].Location = new Point(70, ytbdm);
                            pbName[cuenta].Location = new Point(10, ypbdm);
                            ytbdm += 80;
                            ypbdm += 80;
                        }/*
                        else if (muro == "Muros/BDM.txt")
                        {
                            tbName[cuenta].Parent = this.muroBDM;
                            pbName[cuenta].Parent = this.muroBDM;
                            tbName[cuenta].Location = new Point(70, ytbbdm);
                            pbName[cuenta].Location = new Point(10, ypbbdm);
                            ytbbdm += 80;
                            ypbbdm += 80;
                        }
                        else if (muro == "Muros/PAPW.txt")
                        {
                            tbName[cuenta].Parent = this.muroPAPW;
                            pbName[cuenta].Parent = this.muroPAPW;
                            tbName[cuenta].Location = new Point(70, ytbpapw);
                            pbName[cuenta].Location = new Point(10, ypbpapw);
                            ytbpapw += 80;
                            ypbpapw += 80;
                        }
                        else if (muro == "Muros/POI.txt")
                        {
                            tbName[cuenta].Parent = this.muroPOI;
                            pbName[cuenta].Parent = this.muroPOI;
                            tbName[cuenta].Location = new Point(70, ytbpoi);
                            pbName[cuenta].Location = new Point(10, ypbpoi);
                            ytbpoi += 80;
                            ypbpoi += 80;
                        }
                        else if (muro == "Muros/CSP.txt")
                        {
                            tbName[cuenta].Parent = this.muroCSP;
                            pbName[cuenta].Parent = this.muroCSP;
                            tbName[cuenta].Location = new Point(70, ytbcsp);
                            pbName[cuenta].Location = new Point(10, ypbcsp);
                            ytbcsp += 80;
                            ypbcsp += 80;
                        }
                        else if (muro == "Muros/VJ.txt")
                        {
                            tbName[cuenta].Parent = this.muroVJ;
                            pbName[cuenta].Parent = this.muroVJ;
                            tbName[cuenta].Location = new Point(70, ytbvj);
                            pbName[cuenta].Location = new Point(10, ypbvj);
                            ytbvj += 80;
                            ypbvj += 80;
                        }*/
                        tbName[cuenta].BorderStyle = BorderStyle.None;
                        tbName[cuenta].Text = usuario + "\r\n" + publicacion + "\r\n";
                        tbName[cuenta].Size = new Size(410, 70);

                        pbName[cuenta].Size = new Size(50, 50);
                        pbName[cuenta].ImageLocation = contact.mImg;
                        pbName[cuenta].SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                }
                cuenta++;
                

            }
        }
        public static IPAddress GetIPAddress(string hostName)
        {
            Ping ping = new Ping();
            var replay = ping.Send(hostName);

            if (replay.Status == IPStatus.Success)
            {
                return replay.Address;
            }
            return null;
        }
        public principal(string name, string correo, string contrasena, string fotoperfil, CheckState state, ArrayList _lista, ArrayList _grupos)
        {
            Contacts = _lista;
            Groups = _grupos;
            mClient = new Client();
            mClient.mName = name;
            mClient.mMail = correo;
            mClient.mPassword = contrasena;
            mClient.mImg = fotoperfil;
            mClient.connect();
            //IPAddress = mClient.LocalEndPoint.Address;
            //IPAddress miIP = GetIPAddress(Dns.GetHostName());
            mClient.listening(onConversacionCallback, onMessageCallback, onWallCallback, onWebcamRequest, onWebcamEstablish, onFileRequest);

            String aux;
            aux = mClient.mName + '|' + mClient.mMail + '|' + mClient.mPassword + '|' + mClient.mImg;
            switch (state)
            {
                case CheckState.Checked:
                    mClient.encriptado = "encriptado";
                    break;
                case CheckState.Unchecked:
                    mClient.encriptado = "noencriptado";
                    break;
                default:
                    break;
            }
            mClient.sendStringMsg(aux);
            InitializeComponent();
            createChats();
            tabControl1.TabPages.Remove(tabInicio);
            tabControl1.TabPages.Remove(tabLMAD);
            tabControl1.TabPages.Remove(tabPoi);
            tabControl1.TabPages.Remove(tabVj1);
            tabControl1.TabPages.Remove(tabBdm);
            
        }
        public void cargaMuros(String elmuro)
        {
            ytbdm = 10;
            ypbdm = 20;
            ytin = 10;
            ypin = 20;
            
            foreach (Grupo g in Groups)
            {
                if (treeView1.SelectedNode.Text == g.nombre && g.nombre == elmuro)
                foreach (Client c in g.integrantes)
                {
                                           
                    if (c.mName == mClient.mName)
                    {
                        
                        mClient.cargaMuro(elmuro);
                        if (elmuro == "BDM")
                        {
                            limpiaTabs();
                            tabControl1.TabPages.Add(tabBdm);
                            muroBDM.VerticalScroll.Value = 0;
                        }
                        if (elmuro == "Inicio")
                        {
                            limpiaTabs();
                            tabControl1.TabPages.Add(tabInicio);
                            muroInicio.VerticalScroll.Value = 0;
                        }
                        
                        
                    }
                }
            }
            
        }
        public void createChats()
        {
            int n = 0;
            foreach (Client contact in Contacts)
            {

                if (contact.mName != mClient.mName)
                {
                    lvContactos.Items.Add(contact.mName, n);
                    imageList1.Images.Add(Image.FromFile(contact.mImg));

                    n++;

                    chat Chat2 = new chat(mClient, contact);
                    Chat2.Name = contact.mName;
                    Chat2.Text = contact.mName;
                    chats.Add(Chat2);
                }
            }
        }
        public void onContactListCallback(String msg)
        {
            if (lvContactos.InvokeRequired)
            {
                onContactList callback = new onContactList(onContactListCallback);
                this.Invoke(callback, new object[] { msg });
            }
            else{
                lvContactos.Items.Clear();
                string[] infoDividida = msg.Split(new String[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

            }
        }

        private void lvContactos_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Client contact in Contacts)
            {
                string nombretemp = contact.mName;
                if (lvContactos.SelectedItems[0].Text == nombretemp)
                {
                    foreach (chat ch in chats)
                    {
                        if (nombretemp == ch.Text)
                        {
                            mClient.loadChat(mClient.mName, nombretemp);
                            ch.Show();
                            break;
                        }
                    }
                    /*String usuarios = "<Chatprivado>" +
                        "<from>" +
                        mClient.mName +
                        "<from>" +
                        "<to>"+
                        nombretemp+
                        "<to>"+
                        "<Chatprivado>";
                    mClient.sendStringMsg(usuarios);*/
                    break;
                }
            }
        }

        private void btnPOI_Click(object sender, EventArgs e)
        {
            mClient.actualizaMuro("Inicio", mClient.mName, txtInicio.Text);
            txtInicio.Text = "";
        }

        private void principal_Load(object sender, EventArgs e)
        {
            
            mClient.cargaMuro("Inicio");
            tabControl1.TabPages.Add(tabInicio);
            pbInicio.ImageLocation = mClient.mImg;
            pbInicio.ImageLocation = mClient.mImg;
            pbMedalla.Image = System.Drawing.Image.FromFile("..\\..\\img\\medalla_1.png");
            
        }

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            mClient.mIsThreadRunning = false;
        }
        private void limpiaTabs()
        {
            tabControl1.TabPages.Remove(tabInicio);
            tabControl1.TabPages.Remove(tabBdm);
            tabControl1.TabPages.Remove(tabLMAD);
            tabControl1.TabPages.Remove(tabPoi);
            tabControl1.TabPages.Remove(tabVj1);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Inicio")
            {
                tabInicio.Text = "Alumnos de la Facultad de Ciencias Físico Matemáticas";
                    foreach (Grupo g in Groups)
                    {
                        if(treeView1.SelectedNode.Text == g.nombre && g.nombre=="Inicio")
                        
                        foreach (Client c in g.integrantes)
                        {
                            if (treeView1.SelectedNode != null)
                                if (c.mName == mClient.mName)
                                {
                                    cargaMuros("Inicio");
                                }
                        }
                }

            }
            else if (treeView1.SelectedNode.Text == "BDM")
            {
                tabBdm.Text = "Base de Datos Multimedia";
                    
                        foreach (Grupo g in Groups)
                        {
                            if (treeView1.SelectedNode.Text == g.nombre && g.nombre == "BDM")
                            foreach (Client c in g.integrantes)
                            {
                                if (treeView1.SelectedNode != null)
                                    if (c.mName == mClient.mName)
                                    {
                                        cargaMuros("BDM");
                                    }
                            }
                        }
                }

            else if (treeView1.SelectedNode.Text == "POI")
            {

            }
            else if (treeView1.SelectedNode.Text == "VJ1")
            {

            }
            else if (treeView1.SelectedNode.Text == "LMAD")
            {
            }
        }

        private void cierraLMAD_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabLMAD);
        }

        private void muroInicio_ControlAdded(object sender, ControlEventArgs e)
        {
            this.ScrollControlIntoView(e.Control);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cierraBDM_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabBdm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabInicio);
            tabControl1.TabPages.Remove(tabLMAD);
            tabControl1.TabPages.Remove(tabPoi);
            tabControl1.TabPages.Remove(tabVj1);
            tabControl1.TabPages.Remove(tabBdm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mClient.actualizaMuro("BDM", mClient.mName, txtBDM.Text);
            txtBDM.Text = "";
        }

        private void nohechabd1_CheckedChanged(object sender, EventArgs e)
        {
            if (nohechabd1.Checked == true)
            {
                string texto;
                texto = nohechabd1.Text;
                nohechabd1.Visible = false;
                hechabd1.Text = texto;
                hechabd1.Visible = true;
                hechabd1.Checked = true;
                contador++;
                premio();
            }
        }
        private void premio(){
            if (contador == 4)
            {
                MessageBox.Show("Has subido al nivel dos", "¡Felicidades!");
                pbMedalla.Image = System.Drawing.Image.FromFile("..\\..\\img\\medalla_2.png");
            }

            if (contador == 8)
            {
                MessageBox.Show("Has subido al nivel tres", "¡Felicidades!");
                pbMedalla.Image = System.Drawing.Image.FromFile("..\\..\\img\\medalla_3.png");
            }

            if (contador == 14)
            {
                MessageBox.Show("Has subido al nivel 4", "¡Felicidades!");
                pbMedalla.Image = System.Drawing.Image.FromFile("..\\..\\img\\medalla_4.png");
            }

            if (contador == 18)
            {
                MessageBox.Show("¡Has alcanzado el nivel maximo!", "¡Felicidades!");
                pbMedalla.Image = System.Drawing.Image.FromFile("..\\..\\img\\medalla_5.png");
            }
        }

        private void nohechabd3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nohechabd2_CheckedChanged(object sender, EventArgs e)
        {
            if (nohechabd2.Checked == true)
            {
                string texto;
                texto = nohechabd2.Text;
                nohechabd2.Visible = false;
                hechabd2.Text = texto;
                hechabd2.Visible = true;
                hechabd2.Checked = true;
                contador++;
                premio();
            }
        }

        private void pbCorreo_Click(object sender, EventArgs e)
        {

        }

        private void chatInicio_Click(object sender, EventArgs e)
        {

        }
       
    }
}
