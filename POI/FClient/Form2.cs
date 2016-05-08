using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Web;
using System.Net;
using System.Net.Mail;

namespace FClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*'; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sendEmail();
        }
        public void sendEmail()
        {
            String from = txtDe.Text;
            String to = txtPara.Text;
            String subject = txtPara.Text;
            String body = txtMail.Text;
            String smtpClient = txtSMTP.Text;
            if (from == "" || to == "" || subject == "" || body == "")
            {
                MessageBox.Show("Faltan Campos");
                return;
            }

            MailMessage mail = new MailMessage(from,to,subject,body);
            //ej: smtp.gmail.com Puerto: TLS 587, SSL 465
            SmtpClient client = new SmtpClient(smtpClient,587);
            client.Credentials = new NetworkCredential(txtUsername.Text,txtPassword.Text);
            client.Send(mail);
            MessageBox.Show("mensaje enviado");
        }

    }
}
