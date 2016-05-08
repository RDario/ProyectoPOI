namespace FClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Conexion = new System.Windows.Forms.GroupBox();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clientes = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbOnline = new System.Windows.Forms.ComboBox();
            this.estados = new System.Windows.Forms.ComboBox();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.Conexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Conexion
            // 
            this.Conexion.Controls.Add(this.nombreCliente);
            this.Conexion.Controls.Add(this.btnConectar);
            this.Conexion.Controls.Add(this.label1);
            this.Conexion.Location = new System.Drawing.Point(12, 12);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(366, 53);
            this.Conexion.TabIndex = 0;
            this.Conexion.TabStop = false;
            this.Conexion.Text = "Conexión";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(118, 20);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(100, 20);
            this.nombreCliente.TabIndex = 5;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(224, 20);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del cliente";
            // 
            // Clientes
            // 
            this.Clientes.AutoSize = true;
            this.Clientes.Location = new System.Drawing.Point(86, 103);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(44, 13);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clientes";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(228, 103);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(40, 13);
            this.estado.TabIndex = 2;
            this.estado.Text = "Estado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(283, 225);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Mandar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbOnline
            // 
            this.cbOnline.FormattingEnabled = true;
            this.cbOnline.Location = new System.Drawing.Point(89, 120);
            this.cbOnline.Name = "cbOnline";
            this.cbOnline.Size = new System.Drawing.Size(121, 21);
            this.cbOnline.TabIndex = 6;
            this.cbOnline.SelectedIndexChanged += new System.EventHandler(this.cbOnline_SelectedIndexChanged);
            // 
            // estados
            // 
            this.estados.FormattingEnabled = true;
            this.estados.Location = new System.Drawing.Point(231, 120);
            this.estados.Name = "estados";
            this.estados.Size = new System.Drawing.Size(121, 21);
            this.estados.TabIndex = 7;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(89, 147);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(263, 72);
            this.txtChat.TabIndex = 8;
            this.txtChat.Text = "";
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(89, 225);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(188, 20);
            this.txtMensaje.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 289);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.estados);
            this.Controls.Add(this.cbOnline);
            this.Controls.Add(this.Conexion);
            this.Controls.Add(this.Clientes);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.estado);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Conexion.ResumeLayout(false);
            this.Conexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Conexion;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Clientes;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbOnline;
        private System.Windows.Forms.ComboBox estados;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.TextBox txtMensaje;


    }
}

