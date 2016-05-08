namespace FClient
{
    partial class chat
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(":*", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(":D", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("<3", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(":B", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(":@", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(":P", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("(Y)", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(":\'(", 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("x.x", 8);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(":.", 9);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("...", 10);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(":|", 11);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("</3", 12);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(":(", 13);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(":)", 14);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(";)", 15);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.optionList1 = new System.Windows.Forms.ListView();
            this.Tareas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rTBChat1 = new System.Windows.Forms.RichTextBox();
            this.pbChat = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.webcam1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.webcam2 = new System.Windows.Forms.PictureBox();
            this.tim_stream = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblVacio = new System.Windows.Forms.Label();
            this.pbCorreo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // optionList1
            // 
            this.optionList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tareas});
            listViewItem1.StateImageIndex = 0;
            this.optionList1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.optionList1.LargeImageList = this.imageList1;
            this.optionList1.Location = new System.Drawing.Point(370, 26);
            this.optionList1.Margin = new System.Windows.Forms.Padding(2);
            this.optionList1.Name = "optionList1";
            this.optionList1.Size = new System.Drawing.Size(78, 252);
            this.optionList1.TabIndex = 13;
            this.optionList1.TileSize = new System.Drawing.Size(30, 30);
            this.optionList1.UseCompatibleStateImageBehavior = false;
            this.optionList1.View = System.Windows.Forms.View.Tile;
            this.optionList1.Visible = false;
            this.optionList1.SelectedIndexChanged += new System.EventHandler(this.optionList1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "besito.png");
            this.imageList1.Images.SetKeyName(1, "bigsmile.png");
            this.imageList1.Images.SetKeyName(2, "corazon.png");
            this.imageList1.Images.SetKeyName(3, "diente.png");
            this.imageList1.Images.SetKeyName(4, "enojado.png");
            this.imageList1.Images.SetKeyName(5, "lengua.png");
            this.imageList1.Images.SetKeyName(6, "like.png");
            this.imageList1.Images.SetKeyName(7, "llorando.png");
            this.imageList1.Images.SetKeyName(8, "muerto.png");
            this.imageList1.Images.SetKeyName(9, "nada.png");
            this.imageList1.Images.SetKeyName(10, "pensando.png");
            this.imageList1.Images.SetKeyName(11, "poker.png");
            this.imageList1.Images.SetKeyName(12, "roto.png");
            this.imageList1.Images.SetKeyName(13, "sad.png");
            this.imageList1.Images.SetKeyName(14, "smile2.png");
            this.imageList1.Images.SetKeyName(15, "wink.png");
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(27, 282);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(331, 61);
            this.txtMessage.TabIndex = 14;
            this.txtMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(370, 282);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 28);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Location = new System.Drawing.Point(100, 40);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Desconectado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rTBChat1
            // 
            this.rTBChat1.BackColor = System.Drawing.SystemColors.Window;
            this.rTBChat1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBChat1.Location = new System.Drawing.Point(27, 61);
            this.rTBChat1.Margin = new System.Windows.Forms.Padding(2);
            this.rTBChat1.Name = "rTBChat1";
            this.rTBChat1.Size = new System.Drawing.Size(331, 216);
            this.rTBChat1.TabIndex = 15;
            this.rTBChat1.Text = "";
            // 
            // pbChat
            // 
            this.pbChat.Location = new System.Drawing.Point(39, 11);
            this.pbChat.Margin = new System.Windows.Forms.Padding(2);
            this.pbChat.Name = "pbChat";
            this.pbChat.Size = new System.Drawing.Size(45, 42);
            this.pbChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChat.TabIndex = 18;
            this.pbChat.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(98, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(138, 25);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Desconectado";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // webcam1
            // 
            this.webcam1.Location = new System.Drawing.Point(453, 61);
            this.webcam1.Name = "webcam1";
            this.webcam1.Size = new System.Drawing.Size(186, 113);
            this.webcam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.webcam1.TabIndex = 20;
            this.webcam1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(370, 315);
            this.btnFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(78, 37);
            this.btnFile.TabIndex = 21;
            this.btnFile.Text = "Mandar Archivo";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(453, 299);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(186, 21);
            this.cbxDispositivos.TabIndex = 23;
            this.cbxDispositivos.SelectedIndexChanged += new System.EventHandler(this.cbxDispositivos_SelectedIndexChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(453, 322);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(59, 21);
            this.btnIniciar.TabIndex = 24;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(518, 326);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(35, 13);
            this.Estado.TabIndex = 25;
            this.Estado.Text = "label1";
            // 
            // webcam2
            // 
            this.webcam2.Location = new System.Drawing.Point(453, 180);
            this.webcam2.Name = "webcam2";
            this.webcam2.Size = new System.Drawing.Size(186, 113);
            this.webcam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.webcam2.TabIndex = 26;
            this.webcam2.TabStop = false;
            // 
            // tim_stream
            // 
            this.tim_stream.Interval = 1;
            this.tim_stream.Tick += new System.EventHandler(this.tim_stream_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblVacio
            // 
            this.lblVacio.AutoSize = true;
            this.lblVacio.Location = new System.Drawing.Point(521, 26);
            this.lblVacio.Name = "lblVacio";
            this.lblVacio.Size = new System.Drawing.Size(0, 13);
            this.lblVacio.TabIndex = 28;
            // 
            // pbCorreo
            // 
            this.pbCorreo.BackgroundImage = global::FClient.Properties.Resources.correo;
            this.pbCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCorreo.Location = new System.Drawing.Point(302, 6);
            this.pbCorreo.Name = "pbCorreo";
            this.pbCorreo.Size = new System.Drawing.Size(56, 47);
            this.pbCorreo.TabIndex = 29;
            this.pbCorreo.TabStop = false;
            this.pbCorreo.Click += new System.EventHandler(this.pbCorreo_Click);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 375);
            this.Controls.Add(this.pbCorreo);
            this.Controls.Add(this.lblVacio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webcam2);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cbxDispositivos);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.webcam1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbChat);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rTBChat1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.optionList1);
            this.Name = "chat";
            this.Text = "chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.chat_FormClosing);
            this.Load += new System.EventHandler(this.chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorreo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView optionList1;
        private System.Windows.Forms.ColumnHeader Tareas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RichTextBox rTBChat1;
        private System.Windows.Forms.PictureBox pbChat;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox webcam1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.PictureBox webcam2;
        private System.Windows.Forms.Timer tim_stream;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVacio;
        private System.Windows.Forms.PictureBox pbCorreo;
    }
}