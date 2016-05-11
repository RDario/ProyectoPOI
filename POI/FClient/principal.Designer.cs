namespace FClient
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("POI", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("VJ1", 1, 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("BDM", 1, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("LMAD", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("ASO", 1, 1);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("POO", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("LCC", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Inicio", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chatInicio = new System.Windows.Forms.PictureBox();
            this.muroInicio = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.txtInicio = new System.Windows.Forms.RichTextBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.tabBdm = new System.Windows.Forms.TabPage();
            this.muroBDM = new System.Windows.Forms.Panel();
            this.btnBDM = new System.Windows.Forms.Button();
            this.txtBDM = new System.Windows.Forms.RichTextBox();
            this.cierraBDM = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabLMAD = new System.Windows.Forms.TabPage();
            this.cierraLMAD = new System.Windows.Forms.Button();
            this.tabPoi = new System.Windows.Forms.TabPage();
            this.tabVj1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lvContactos = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hechabd6 = new System.Windows.Forms.CheckBox();
            this.hechabd5 = new System.Windows.Forms.CheckBox();
            this.hechabd4 = new System.Windows.Forms.CheckBox();
            this.hechabd3 = new System.Windows.Forms.CheckBox();
            this.hechabd2 = new System.Windows.Forms.CheckBox();
            this.hechabd1 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nohechabd6 = new System.Windows.Forms.CheckBox();
            this.nohechabd5 = new System.Windows.Forms.CheckBox();
            this.nohechabd4 = new System.Windows.Forms.CheckBox();
            this.nohechabd3 = new System.Windows.Forms.CheckBox();
            this.nohechabd2 = new System.Windows.Forms.CheckBox();
            this.nohechabd1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbMedalla = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.tabBdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabLMAD.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedalla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInicio);
            this.tabControl1.Controls.Add(this.tabBdm);
            this.tabControl1.Controls.Add(this.tabLMAD);
            this.tabControl1.Controls.Add(this.tabPoi);
            this.tabControl1.Controls.Add(this.tabVj1);
            this.tabControl1.Location = new System.Drawing.Point(152, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 529);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.pictureBox1);
            this.tabInicio.Controls.Add(this.label1);
            this.tabInicio.Controls.Add(this.chatInicio);
            this.tabInicio.Controls.Add(this.muroInicio);
            this.tabInicio.Controls.Add(this.pictureBox17);
            this.tabInicio.Controls.Add(this.btnInicio);
            this.tabInicio.Controls.Add(this.txtInicio);
            this.tabInicio.Controls.Add(this.pbInicio);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(457, 503);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FClient.Properties.Resources.Inicio;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 80);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Chat grupal";
            // 
            // chatInicio
            // 
            this.chatInicio.BackgroundImage = global::FClient.Properties.Resources.personas;
            this.chatInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chatInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chatInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chatInicio.Location = new System.Drawing.Point(378, 101);
            this.chatInicio.Name = "chatInicio";
            this.chatInicio.Size = new System.Drawing.Size(72, 30);
            this.chatInicio.TabIndex = 71;
            this.chatInicio.TabStop = false;
            this.chatInicio.Click += new System.EventHandler(this.chatInicio_Click);
            // 
            // muroInicio
            // 
            this.muroInicio.AutoScroll = true;
            this.muroInicio.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            this.muroInicio.Location = new System.Drawing.Point(10, 149);
            this.muroInicio.Name = "muroInicio";
            this.muroInicio.Size = new System.Drawing.Size(456, 348);
            this.muroInicio.TabIndex = 70;
            this.muroInicio.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.muroInicio_ControlAdded);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(6, 136);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(546, 10);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 69;
            this.pictureBox17.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(311, 82);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(62, 48);
            this.btnInicio.TabIndex = 68;
            this.btnInicio.Text = "Publicar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnPOI_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInicio.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtInicio.Location = new System.Drawing.Point(62, 80);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(244, 50);
            this.txtInicio.TabIndex = 61;
            this.txtInicio.Text = "";
            // 
            // pbInicio
            // 
            this.pbInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbInicio.Location = new System.Drawing.Point(6, 80);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(50, 50);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 0;
            this.pbInicio.TabStop = false;
            // 
            // tabBdm
            // 
            this.tabBdm.Controls.Add(this.muroBDM);
            this.tabBdm.Controls.Add(this.btnBDM);
            this.tabBdm.Controls.Add(this.txtBDM);
            this.tabBdm.Controls.Add(this.cierraBDM);
            this.tabBdm.Controls.Add(this.pictureBox3);
            this.tabBdm.Controls.Add(this.pictureBox4);
            this.tabBdm.Location = new System.Drawing.Point(4, 22);
            this.tabBdm.Name = "tabBdm";
            this.tabBdm.Size = new System.Drawing.Size(457, 503);
            this.tabBdm.TabIndex = 3;
            this.tabBdm.Text = "Base de Datos Multimedia";
            this.tabBdm.UseVisualStyleBackColor = true;
            // 
            // muroBDM
            // 
            this.muroBDM.AutoScroll = true;
            this.muroBDM.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            this.muroBDM.Location = new System.Drawing.Point(8, 124);
            this.muroBDM.Name = "muroBDM";
            this.muroBDM.Size = new System.Drawing.Size(378, 273);
            this.muroBDM.TabIndex = 77;
            // 
            // btnBDM
            // 
            this.btnBDM.Location = new System.Drawing.Point(434, 71);
            this.btnBDM.Margin = new System.Windows.Forms.Padding(2);
            this.btnBDM.Name = "btnBDM";
            this.btnBDM.Size = new System.Drawing.Size(80, 24);
            this.btnBDM.TabIndex = 75;
            this.btnBDM.Text = "Publicar";
            this.btnBDM.UseVisualStyleBackColor = true;
            this.btnBDM.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBDM
            // 
            this.txtBDM.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBDM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBDM.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBDM.Location = new System.Drawing.Point(64, 16);
            this.txtBDM.Name = "txtBDM";
            this.txtBDM.Size = new System.Drawing.Size(450, 50);
            this.txtBDM.TabIndex = 74;
            this.txtBDM.Text = "";
            // 
            // cierraBDM
            // 
            this.cierraBDM.Location = new System.Drawing.Point(513, 2);
            this.cierraBDM.Margin = new System.Windows.Forms.Padding(2);
            this.cierraBDM.Name = "cierraBDM";
            this.cierraBDM.Size = new System.Drawing.Size(32, 24);
            this.cierraBDM.TabIndex = 72;
            this.cierraBDM.Text = "X";
            this.cierraBDM.UseVisualStyleBackColor = true;
            this.cierraBDM.Click += new System.EventHandler(this.cierraBDM_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 99);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(534, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(8, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            // 
            // tabLMAD
            // 
            this.tabLMAD.Controls.Add(this.cierraLMAD);
            this.tabLMAD.Location = new System.Drawing.Point(4, 22);
            this.tabLMAD.Name = "tabLMAD";
            this.tabLMAD.Size = new System.Drawing.Size(457, 503);
            this.tabLMAD.TabIndex = 4;
            this.tabLMAD.Text = "LMAD";
            this.tabLMAD.UseVisualStyleBackColor = true;
            // 
            // cierraLMAD
            // 
            this.cierraLMAD.Location = new System.Drawing.Point(380, 2);
            this.cierraLMAD.Margin = new System.Windows.Forms.Padding(2);
            this.cierraLMAD.Name = "cierraLMAD";
            this.cierraLMAD.Size = new System.Drawing.Size(32, 24);
            this.cierraLMAD.TabIndex = 69;
            this.cierraLMAD.Text = "X";
            this.cierraLMAD.UseVisualStyleBackColor = true;
            this.cierraLMAD.Click += new System.EventHandler(this.cierraLMAD_Click);
            // 
            // tabPoi
            // 
            this.tabPoi.Location = new System.Drawing.Point(4, 22);
            this.tabPoi.Name = "tabPoi";
            this.tabPoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoi.Size = new System.Drawing.Size(457, 503);
            this.tabPoi.TabIndex = 1;
            this.tabPoi.Text = "POI";
            this.tabPoi.UseVisualStyleBackColor = true;
            // 
            // tabVj1
            // 
            this.tabVj1.Location = new System.Drawing.Point(4, 22);
            this.tabVj1.Name = "tabVj1";
            this.tabVj1.Size = new System.Drawing.Size(457, 503);
            this.tabVj1.TabIndex = 2;
            this.tabVj1.Text = "Video juegos 1";
            this.tabVj1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList2;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "treePOI";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "POI";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "treeVJ1";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "VJ1";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "treeBDM";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "BDM";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "treeLMAD";
            treeNode12.Text = "LMAD";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "Nodo2";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "ASO";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "Nodo1";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "POO";
            treeNode15.ImageIndex = 0;
            treeNode15.Name = "Nodo0";
            treeNode15.SelectedImageIndex = 0;
            treeNode15.Text = "LCC";
            treeNode16.ImageKey = "folder.png";
            treeNode16.Name = "treeFCFM";
            treeNode16.Text = "Inicio";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(128, 98);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "folder.png");
            this.imageList2.Images.SetKeyName(1, "materia.png");
            this.imageList2.Images.SetKeyName(2, "personas.png");
            // 
            // lvContactos
            // 
            this.lvContactos.LargeImageList = this.imageList1;
            this.lvContactos.Location = new System.Drawing.Point(10, 116);
            this.lvContactos.MultiSelect = false;
            this.lvContactos.Name = "lvContactos";
            this.lvContactos.Scrollable = false;
            this.lvContactos.Size = new System.Drawing.Size(130, 315);
            this.lvContactos.TabIndex = 0;
            this.lvContactos.UseCompatibleStateImageBehavior = false;
            this.lvContactos.View = System.Windows.Forms.View.Tile;
            this.lvContactos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvContactos_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "medalla_1.png");
            this.imageList3.Images.SetKeyName(1, "medalla_2.png");
            this.imageList3.Images.SetKeyName(2, "medalla_3.png");
            this.imageList3.Images.SetKeyName(3, "medalla_4.png");
            this.imageList3.Images.SetKeyName(4, "medalla_5.png");
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(146, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblTitulo.TabIndex = 5;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(623, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(258, 529);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox28);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tareas BDM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(5, 25);
            this.pictureBox28.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(240, 12);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 51;
            this.pictureBox28.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hechabd6);
            this.panel3.Controls.Add(this.hechabd5);
            this.panel3.Controls.Add(this.hechabd4);
            this.panel3.Controls.Add(this.hechabd3);
            this.panel3.Controls.Add(this.hechabd2);
            this.panel3.Controls.Add(this.hechabd1);
            this.panel3.Location = new System.Drawing.Point(27, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 198);
            this.panel3.TabIndex = 46;
            // 
            // hechabd6
            // 
            this.hechabd6.AutoSize = true;
            this.hechabd6.Location = new System.Drawing.Point(22, 173);
            this.hechabd6.Name = "hechabd6";
            this.hechabd6.Size = new System.Drawing.Size(29, 17);
            this.hechabd6.TabIndex = 16;
            this.hechabd6.Text = ".";
            this.hechabd6.UseVisualStyleBackColor = true;
            this.hechabd6.Visible = false;
            // 
            // hechabd5
            // 
            this.hechabd5.AutoSize = true;
            this.hechabd5.Location = new System.Drawing.Point(22, 143);
            this.hechabd5.Name = "hechabd5";
            this.hechabd5.Size = new System.Drawing.Size(29, 17);
            this.hechabd5.TabIndex = 15;
            this.hechabd5.Text = ".";
            this.hechabd5.UseVisualStyleBackColor = true;
            this.hechabd5.Visible = false;
            // 
            // hechabd4
            // 
            this.hechabd4.AutoSize = true;
            this.hechabd4.Location = new System.Drawing.Point(22, 111);
            this.hechabd4.Name = "hechabd4";
            this.hechabd4.Size = new System.Drawing.Size(29, 17);
            this.hechabd4.TabIndex = 14;
            this.hechabd4.Text = ".";
            this.hechabd4.UseVisualStyleBackColor = true;
            this.hechabd4.Visible = false;
            // 
            // hechabd3
            // 
            this.hechabd3.AutoSize = true;
            this.hechabd3.Location = new System.Drawing.Point(22, 79);
            this.hechabd3.Name = "hechabd3";
            this.hechabd3.Size = new System.Drawing.Size(29, 17);
            this.hechabd3.TabIndex = 13;
            this.hechabd3.Text = ".";
            this.hechabd3.UseVisualStyleBackColor = true;
            this.hechabd3.Visible = false;
            // 
            // hechabd2
            // 
            this.hechabd2.AutoSize = true;
            this.hechabd2.Location = new System.Drawing.Point(22, 46);
            this.hechabd2.Name = "hechabd2";
            this.hechabd2.Size = new System.Drawing.Size(29, 17);
            this.hechabd2.TabIndex = 12;
            this.hechabd2.Text = ".";
            this.hechabd2.UseVisualStyleBackColor = true;
            this.hechabd2.Visible = false;
            // 
            // hechabd1
            // 
            this.hechabd1.AutoSize = true;
            this.hechabd1.Location = new System.Drawing.Point(22, 13);
            this.hechabd1.Name = "hechabd1";
            this.hechabd1.Size = new System.Drawing.Size(29, 17);
            this.hechabd1.TabIndex = 11;
            this.hechabd1.Text = ".";
            this.hechabd1.UseVisualStyleBackColor = true;
            this.hechabd1.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(81, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 49;
            this.label17.Text = "Terminadas";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(84, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 20);
            this.label20.TabIndex = 48;
            this.label20.Text = "Pendientes";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(27, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(195, 20);
            this.label21.TabIndex = 47;
            this.label21.Text = "Base de Datos Multimedia";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nohechabd6);
            this.panel4.Controls.Add(this.nohechabd5);
            this.panel4.Controls.Add(this.nohechabd4);
            this.panel4.Controls.Add(this.nohechabd3);
            this.panel4.Controls.Add(this.nohechabd2);
            this.panel4.Controls.Add(this.nohechabd1);
            this.panel4.Location = new System.Drawing.Point(24, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 199);
            this.panel4.TabIndex = 50;
            // 
            // nohechabd6
            // 
            this.nohechabd6.AutoSize = true;
            this.nohechabd6.Location = new System.Drawing.Point(15, 173);
            this.nohechabd6.Name = "nohechabd6";
            this.nohechabd6.Size = new System.Drawing.Size(178, 17);
            this.nohechabd6.TabIndex = 15;
            this.nohechabd6.Text = "Ejercicios de Algebra Relacional";
            this.nohechabd6.UseVisualStyleBackColor = true;
            // 
            // nohechabd5
            // 
            this.nohechabd5.AutoSize = true;
            this.nohechabd5.Location = new System.Drawing.Point(15, 143);
            this.nohechabd5.Name = "nohechabd5";
            this.nohechabd5.Size = new System.Drawing.Size(114, 17);
            this.nohechabd5.TabIndex = 14;
            this.nohechabd5.Text = "Modelo Relacional";
            this.nohechabd5.UseVisualStyleBackColor = true;
            // 
            // nohechabd4
            // 
            this.nohechabd4.AutoSize = true;
            this.nohechabd4.Location = new System.Drawing.Point(15, 111);
            this.nohechabd4.Name = "nohechabd4";
            this.nohechabd4.Size = new System.Drawing.Size(54, 17);
            this.nohechabd4.TabIndex = 13;
            this.nohechabd4.Text = "Query";
            this.nohechabd4.UseVisualStyleBackColor = true;
            // 
            // nohechabd3
            // 
            this.nohechabd3.AutoSize = true;
            this.nohechabd3.Location = new System.Drawing.Point(15, 79);
            this.nohechabd3.Name = "nohechabd3";
            this.nohechabd3.Size = new System.Drawing.Size(58, 17);
            this.nohechabd3.TabIndex = 12;
            this.nohechabd3.Text = "Tablas";
            this.nohechabd3.UseVisualStyleBackColor = true;
            this.nohechabd3.CheckedChanged += new System.EventHandler(this.nohechabd3_CheckedChanged);
            // 
            // nohechabd2
            // 
            this.nohechabd2.AutoSize = true;
            this.nohechabd2.Location = new System.Drawing.Point(16, 46);
            this.nohechabd2.Name = "nohechabd2";
            this.nohechabd2.Size = new System.Drawing.Size(103, 17);
            this.nohechabd2.TabIndex = 11;
            this.nohechabd2.Text = "Store Procedure";
            this.nohechabd2.UseVisualStyleBackColor = true;
            this.nohechabd2.CheckedChanged += new System.EventHandler(this.nohechabd2_CheckedChanged);
            // 
            // nohechabd1
            // 
            this.nohechabd1.AutoSize = true;
            this.nohechabd1.Location = new System.Drawing.Point(16, 13);
            this.nohechabd1.Name = "nohechabd1";
            this.nohechabd1.Size = new System.Drawing.Size(145, 17);
            this.nohechabd1.TabIndex = 10;
            this.nohechabd1.Text = "Modelo Entidad-Relacion";
            this.nohechabd1.UseVisualStyleBackColor = true;
            this.nohechabd1.CheckedChanged += new System.EventHandler(this.nohechabd1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbMedalla
            // 
            this.pbMedalla.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMedalla.InitialImage")));
            this.pbMedalla.Location = new System.Drawing.Point(12, 437);
            this.pbMedalla.Name = "pbMedalla";
            this.pbMedalla.Size = new System.Drawing.Size(128, 104);
            this.pbMedalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMedalla.TabIndex = 4;
            this.pbMedalla.TabStop = false;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 553);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbMedalla);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lvContactos);
            this.Name = "principal";
            this.Text = "principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.principal_FormClosing);
            this.Load += new System.EventHandler(this.principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.tabBdm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabLMAD.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.RichTextBox txtInicio;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.TabPage tabPoi;
        private System.Windows.Forms.TabPage tabVj1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pbMedalla;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.ListView lvContactos;
        private System.Windows.Forms.Panel muroInicio;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabLMAD;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button cierraLMAD;
        private System.Windows.Forms.TabPage tabBdm;
        private System.Windows.Forms.Panel muroBDM;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBDM;
        private System.Windows.Forms.RichTextBox txtBDM;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button cierraBDM;
        private System.Windows.Forms.PictureBox chatInicio;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox hechabd6;
        private System.Windows.Forms.CheckBox hechabd5;
        private System.Windows.Forms.CheckBox hechabd4;
        private System.Windows.Forms.CheckBox hechabd3;
        private System.Windows.Forms.CheckBox hechabd2;
        private System.Windows.Forms.CheckBox hechabd1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox nohechabd6;
        private System.Windows.Forms.CheckBox nohechabd5;
        private System.Windows.Forms.CheckBox nohechabd4;
        private System.Windows.Forms.CheckBox nohechabd3;
        private System.Windows.Forms.CheckBox nohechabd2;
        private System.Windows.Forms.CheckBox nohechabd1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}