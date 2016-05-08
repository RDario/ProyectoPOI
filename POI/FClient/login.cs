using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using POI;

namespace FClient
{
    public partial class login : Form
    {
        StreamReader readfile = new StreamReader("Usuarios.txt");
        StreamReader readfileG = new StreamReader("Grupos.txt");
        ArrayList Contacts = new ArrayList();
        ArrayList ListaGrupos = new ArrayList();
        String Contactos;
        String Grupo;
        Grupo grupo;
        public Client mClient;
        ArrayList ContactList = new ArrayList();
        ArrayList GroupList = new ArrayList();
        Client contact;
        Client groupContact;
        public login()
        {
            InitializeComponent();
        }
        int n = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            readfile.DiscardBufferedData();
            readfile.BaseStream.Seek(0, System.IO.SeekOrigin.Begin); 
            
            if (txtCorreo.Text != "" && txtContrasena.Text != "") 
            {
                while ((Contactos = readfile.ReadLine()) != null)
                {
                    n++;
                    String[] data = new String[4];
                    data = Contactos.Split('|');
                    contact = new Client(data[0], data[1], data[2], data[3],"desconectado");
                    ContactList.Add(contact);
                }
                while ((Grupo = readfileG.ReadLine()) != null)
                {
                    String[] dat = new String[2];
                    dat = Grupo.Split('|');
                    grupo = new Grupo(dat[0]);
                    grupo.integrantes = new ArrayList();
                    //======================CAMBIE ESTO============================
                    for (int i = 1; i <= dat.Length - 1; i++)
                    {
                        groupContact = new Client(dat[i]);
                        foreach (Client contact in ContactList)
                        {
                            if (contact.mMail == groupContact.mMail)
                            {
                                groupContact.mName = contact.mName;
                                groupContact.mPassword = contact.mPassword;
                                groupContact.mImg = contact.mImg;
                                break;
                            }
                        }
                        grupo.integrantes.Add(groupContact);
                        //============================================================
                    }
                    GroupList.Add(grupo);
                }
                readfile.BaseStream.Seek(0, System.IO.SeekOrigin.Begin); 
                while ((Contactos = readfile.ReadLine()) != null)
                {
                    n++;
                    String[] data = new String[4];
                    data = Contactos.Split('|');
                    if (data[1] == txtCorreo.Text && data[2] == txtContrasena.Text)
                    {
                        CheckState state = chbxEncriptar.CheckState;
                        principal form = new principal(data[0], data[1], data[2], data[3], state, ContactList,GroupList);
                        form.Name = "Principal";
                        form.Show();
                        this.Hide();
                    }


                }
            }
            else
            {
                MessageBox.Show("Correo o contraseña invalida");
            }
        }
    }
}
