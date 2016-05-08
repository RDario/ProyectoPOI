using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POI;
using System.Net.Mail;
using System.Net.Mime;
namespace FClient
{
    public partial class Correo : Form
    {
        private MailMessage correo;
        Client otherClient = new Client();
        Client mClient = new Client();
        public Correo(Client motherclient,Client myClient)
        {
            otherClient = motherclient;
            mClient = myClient;
            InitializeComponent();
        }


        

        private void Correo_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
        try
            {
                correo = new MailMessage();
                correo.From = new MailAddress(mClient.mMail);
                correo.Subject = txtAsunto.Text;
                correo.Body = txtMensaje.Text;
                correo.IsBodyHtml = false;
                correo.To.Add(new MailAddress(this.otherClient.mMail));
                
                                
                if (mClient.mMail.Contains("@uanl.edu.mx"))
                {
                    SmtpClient cliente = new SmtpClient("smtp.office365.com", 587);
                    using (cliente)
                    {
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential(mClient.mMail, mClient.mPassword);
                        cliente.Host = "smtp.office365.com";
                        cliente.Port = 587;
                        cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                        cliente.EnableSsl = true;
                        cliente.Send(correo);
                    }
                }

                MessageBox.Show("Mensaje enviado con éxito");
                txtAsunto.Text = "";
                txtMensaje.Text = "";
                this.Close();
            }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
