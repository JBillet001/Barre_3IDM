namespace _3IDM_Toolbar
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
            if (disposing&&(components!=null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer_CheckInternet = new System.Windows.Forms.Timer(this.components);
            this.BT_Serveur3IDM = new System.Windows.Forms.Button();
            this.RB_ServLocal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_ServDistant = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_Version = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_IP = new System.Windows.Forms.Label();
            this.GPB_Infos = new System.Windows.Forms.GroupBox();
            this.PB_InternetCheck = new System.Windows.Forms.PictureBox();
            this.GPB_SMCAM = new System.Windows.Forms.GroupBox();
            this.BT_MMCAM_2023 = new System.Windows.Forms.Button();
            this.BT_MMCAM_2022 = new System.Windows.Forms.Button();
            this.BT_MMCAM_2021 = new System.Windows.Forms.Button();
            this.BT_Hide = new System.Windows.Forms.Button();
            this.BT_Teamviewer = new System.Windows.Forms.Button();
            this.BT_CodeExpert = new System.Windows.Forms.Button();
            this.BT_CimcoEdit = new System.Windows.Forms.Button();
            this.GPB_Utilitaire = new System.Windows.Forms.GroupBox();
            this.GPB_MMCAM2 = new System.Windows.Forms.GroupBox();
            this.BT_SMCAM_2023 = new System.Windows.Forms.Button();
            this.BT_SMCAM_2022 = new System.Windows.Forms.Button();
            this.BT_SMCAM_2021 = new System.Windows.Forms.Button();
            this.TT_01 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_Show = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GPB_Infos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_InternetCheck)).BeginInit();
            this.GPB_SMCAM.SuspendLayout();
            this.GPB_Utilitaire.SuspendLayout();
            this.GPB_MMCAM2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_CheckInternet
            // 
            this.Timer_CheckInternet.Enabled = true;
            this.Timer_CheckInternet.Interval = 1000;
            // 
            // BT_Serveur3IDM
            // 
            this.BT_Serveur3IDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Serveur3IDM.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_Serveur3IDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Serveur3IDM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Serveur3IDM.Location = new System.Drawing.Point(11, 53);
            this.BT_Serveur3IDM.Name = "BT_Serveur3IDM";
            this.BT_Serveur3IDM.Size = new System.Drawing.Size(105, 26);
            this.BT_Serveur3IDM.TabIndex = 15;
            this.BT_Serveur3IDM.Text = "Connexion";
            this.BT_Serveur3IDM.UseVisualStyleBackColor = true;
            this.BT_Serveur3IDM.Click += new System.EventHandler(this.BT_Serveur3IDM_Click);
            // 
            // RB_ServLocal
            // 
            this.RB_ServLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ServLocal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RB_ServLocal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ServLocal.Location = new System.Drawing.Point(11, 23);
            this.RB_ServLocal.Name = "RB_ServLocal";
            this.RB_ServLocal.Size = new System.Drawing.Size(57, 24);
            this.RB_ServLocal.TabIndex = 13;
            this.RB_ServLocal.Text = "Local";
            this.RB_ServLocal.UseVisualStyleBackColor = true;
            this.RB_ServLocal.CheckedChanged += new System.EventHandler(this.RB_ServLocal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Serveur3IDM);
            this.groupBox1.Controls.Add(this.RB_ServDistant);
            this.groupBox1.Controls.Add(this.RB_ServLocal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 102);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serveur 3IDM";
            // 
            // RB_ServDistant
            // 
            this.RB_ServDistant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ServDistant.Checked = true;
            this.RB_ServDistant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RB_ServDistant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ServDistant.Location = new System.Drawing.Point(59, 26);
            this.RB_ServDistant.Name = "RB_ServDistant";
            this.RB_ServDistant.Size = new System.Drawing.Size(57, 18);
            this.RB_ServDistant.TabIndex = 14;
            this.RB_ServDistant.TabStop = true;
            this.RB_ServDistant.Text = "Distant";
            this.RB_ServDistant.UseVisualStyleBackColor = true;
            this.RB_ServDistant.CheckedChanged += new System.EventHandler(this.RB_ServDistant_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // LBL_Version
            // 
            this.LBL_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Version.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Version.Location = new System.Drawing.Point(0, 684);
            this.LBL_Version.Name = "LBL_Version";
            this.LBL_Version.Size = new System.Drawing.Size(151, 13);
            this.LBL_Version.TabIndex = 21;
            this.LBL_Version.Text = "label1";
            this.LBL_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(37, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "SSID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Internet :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_IP
            // 
            this.LBL_IP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_IP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IP.Location = new System.Drawing.Point(10, 16);
            this.LBL_IP.Name = "LBL_IP";
            this.LBL_IP.Size = new System.Drawing.Size(105, 14);
            this.LBL_IP.TabIndex = 0;
            this.LBL_IP.Text = "192.72.31.2";
            this.LBL_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPB_Infos
            // 
            this.GPB_Infos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPB_Infos.Controls.Add(this.label3);
            this.GPB_Infos.Controls.Add(this.PB_InternetCheck);
            this.GPB_Infos.Controls.Add(this.label2);
            this.GPB_Infos.Controls.Add(this.LBL_IP);
            this.GPB_Infos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPB_Infos.Location = new System.Drawing.Point(12, 28);
            this.GPB_Infos.Name = "GPB_Infos";
            this.GPB_Infos.Size = new System.Drawing.Size(126, 110);
            this.GPB_Infos.TabIndex = 19;
            this.GPB_Infos.TabStop = false;
            this.GPB_Infos.Text = "Infos connexions";
            // 
            // PB_InternetCheck
            // 
            this.PB_InternetCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_InternetCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_InternetCheck.BackgroundImage")));
            this.PB_InternetCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_InternetCheck.Location = new System.Drawing.Point(80, 33);
            this.PB_InternetCheck.Name = "PB_InternetCheck";
            this.PB_InternetCheck.Size = new System.Drawing.Size(25, 25);
            this.PB_InternetCheck.TabIndex = 3;
            this.PB_InternetCheck.TabStop = false;
            // 
            // GPB_SMCAM
            // 
            this.GPB_SMCAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GPB_SMCAM.AutoSize = true;
            this.GPB_SMCAM.BackColor = System.Drawing.Color.Transparent;
            this.GPB_SMCAM.Controls.Add(this.BT_MMCAM_2023);
            this.GPB_SMCAM.Controls.Add(this.BT_MMCAM_2022);
            this.GPB_SMCAM.Controls.Add(this.BT_MMCAM_2021);
            this.GPB_SMCAM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPB_SMCAM.Location = new System.Drawing.Point(12, 405);
            this.GPB_SMCAM.Name = "GPB_SMCAM";
            this.GPB_SMCAM.Size = new System.Drawing.Size(126, 125);
            this.GPB_SMCAM.TabIndex = 16;
            this.GPB_SMCAM.TabStop = false;
            this.GPB_SMCAM.Text = "Shared MasterCAM";
            // 
            // BT_MMCAM_2023
            // 
            this.BT_MMCAM_2023.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MMCAM_2023.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_MMCAM_2023.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MMCAM_2023.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MMCAM_2023.Image = ((System.Drawing.Image)(resources.GetObject("BT_MMCAM_2023.Image")));
            this.BT_MMCAM_2023.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_MMCAM_2023.Location = new System.Drawing.Point(11, 82);
            this.BT_MMCAM_2023.Name = "BT_MMCAM_2023";
            this.BT_MMCAM_2023.Size = new System.Drawing.Size(105, 23);
            this.BT_MMCAM_2023.TabIndex = 6;
            this.BT_MMCAM_2023.Text = "2023";
            this.BT_MMCAM_2023.UseVisualStyleBackColor = true;
            this.BT_MMCAM_2023.Click += new System.EventHandler(this.BT_MMCAM_2023_Click);
            // 
            // BT_MMCAM_2022
            // 
            this.BT_MMCAM_2022.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MMCAM_2022.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_MMCAM_2022.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MMCAM_2022.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MMCAM_2022.Image = ((System.Drawing.Image)(resources.GetObject("BT_MMCAM_2022.Image")));
            this.BT_MMCAM_2022.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_MMCAM_2022.Location = new System.Drawing.Point(11, 53);
            this.BT_MMCAM_2022.Name = "BT_MMCAM_2022";
            this.BT_MMCAM_2022.Size = new System.Drawing.Size(105, 23);
            this.BT_MMCAM_2022.TabIndex = 5;
            this.BT_MMCAM_2022.Text = "2022";
            this.BT_MMCAM_2022.UseVisualStyleBackColor = true;
            this.BT_MMCAM_2022.Click += new System.EventHandler(this.BT_MMCAM_2022_Click);
            // 
            // BT_MMCAM_2021
            // 
            this.BT_MMCAM_2021.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MMCAM_2021.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_MMCAM_2021.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MMCAM_2021.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_MMCAM_2021.Image = ((System.Drawing.Image)(resources.GetObject("BT_MMCAM_2021.Image")));
            this.BT_MMCAM_2021.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_MMCAM_2021.Location = new System.Drawing.Point(11, 24);
            this.BT_MMCAM_2021.Name = "BT_MMCAM_2021";
            this.BT_MMCAM_2021.Size = new System.Drawing.Size(105, 23);
            this.BT_MMCAM_2021.TabIndex = 4;
            this.BT_MMCAM_2021.Text = "2021";
            this.BT_MMCAM_2021.UseVisualStyleBackColor = true;
            this.BT_MMCAM_2021.Click += new System.EventHandler(this.BT_MMCAM_2021_Click);
            // 
            // BT_Hide
            // 
            this.BT_Hide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BT_Hide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_Hide.Location = new System.Drawing.Point(0, 0);
            this.BT_Hide.Name = "BT_Hide";
            this.BT_Hide.Size = new System.Drawing.Size(120, 22);
            this.BT_Hide.TabIndex = 14;
            this.BT_Hide.Text = "==>";
            this.BT_Hide.UseVisualStyleBackColor = false;
            this.BT_Hide.Click += new System.EventHandler(this.BT_Hide_Click);
            // 
            // BT_Teamviewer
            // 
            this.BT_Teamviewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Teamviewer.AutoSize = true;
            this.BT_Teamviewer.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_Teamviewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Teamviewer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Teamviewer.Location = new System.Drawing.Point(10, 81);
            this.BT_Teamviewer.Name = "BT_Teamviewer";
            this.BT_Teamviewer.Size = new System.Drawing.Size(105, 27);
            this.BT_Teamviewer.TabIndex = 7;
            this.BT_Teamviewer.Text = "TeamViewer";
            this.BT_Teamviewer.UseVisualStyleBackColor = true;
            this.BT_Teamviewer.Click += new System.EventHandler(this.BT_Teamviewer_Click);
            // 
            // BT_CodeExpert
            // 
            this.BT_CodeExpert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CodeExpert.AutoSize = true;
            this.BT_CodeExpert.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_CodeExpert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CodeExpert.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CodeExpert.Location = new System.Drawing.Point(10, 50);
            this.BT_CodeExpert.Name = "BT_CodeExpert";
            this.BT_CodeExpert.Size = new System.Drawing.Size(105, 27);
            this.BT_CodeExpert.TabIndex = 6;
            this.BT_CodeExpert.Text = "Code Expert";
            this.BT_CodeExpert.UseVisualStyleBackColor = true;
            this.BT_CodeExpert.Click += new System.EventHandler(this.BT_CodeExpert_Click);
            // 
            // BT_CimcoEdit
            // 
            this.BT_CimcoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CimcoEdit.AutoSize = true;
            this.BT_CimcoEdit.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_CimcoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CimcoEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CimcoEdit.Location = new System.Drawing.Point(10, 19);
            this.BT_CimcoEdit.Name = "BT_CimcoEdit";
            this.BT_CimcoEdit.Size = new System.Drawing.Size(105, 27);
            this.BT_CimcoEdit.TabIndex = 5;
            this.BT_CimcoEdit.Text = "Cimco Edit";
            this.BT_CimcoEdit.UseVisualStyleBackColor = true;
            this.BT_CimcoEdit.Click += new System.EventHandler(this.BT_CimcoEdit_Click);
            // 
            // GPB_Utilitaire
            // 
            this.GPB_Utilitaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPB_Utilitaire.AutoSize = true;
            this.GPB_Utilitaire.BackColor = System.Drawing.Color.Transparent;
            this.GPB_Utilitaire.Controls.Add(this.BT_Teamviewer);
            this.GPB_Utilitaire.Controls.Add(this.BT_CodeExpert);
            this.GPB_Utilitaire.Controls.Add(this.BT_CimcoEdit);
            this.GPB_Utilitaire.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPB_Utilitaire.Location = new System.Drawing.Point(12, 144);
            this.GPB_Utilitaire.Name = "GPB_Utilitaire";
            this.GPB_Utilitaire.Size = new System.Drawing.Size(126, 132);
            this.GPB_Utilitaire.TabIndex = 18;
            this.GPB_Utilitaire.TabStop = false;
            this.GPB_Utilitaire.Text = "Utilitaires";
            // 
            // GPB_MMCAM2
            // 
            this.GPB_MMCAM2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GPB_MMCAM2.AutoSize = true;
            this.GPB_MMCAM2.Controls.Add(this.BT_SMCAM_2023);
            this.GPB_MMCAM2.Controls.Add(this.BT_SMCAM_2022);
            this.GPB_MMCAM2.Controls.Add(this.BT_SMCAM_2021);
            this.GPB_MMCAM2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPB_MMCAM2.Location = new System.Drawing.Point(12, 280);
            this.GPB_MMCAM2.Name = "GPB_MMCAM2";
            this.GPB_MMCAM2.Size = new System.Drawing.Size(126, 120);
            this.GPB_MMCAM2.TabIndex = 17;
            this.GPB_MMCAM2.TabStop = false;
            this.GPB_MMCAM2.Text = "My MasterCAM";
            // 
            // BT_SMCAM_2023
            // 
            this.BT_SMCAM_2023.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_SMCAM_2023.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_SMCAM_2023.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SMCAM_2023.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SMCAM_2023.Image = ((System.Drawing.Image)(resources.GetObject("BT_SMCAM_2023.Image")));
            this.BT_SMCAM_2023.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_SMCAM_2023.Location = new System.Drawing.Point(10, 77);
            this.BT_SMCAM_2023.Name = "BT_SMCAM_2023";
            this.BT_SMCAM_2023.Size = new System.Drawing.Size(105, 23);
            this.BT_SMCAM_2023.TabIndex = 6;
            this.BT_SMCAM_2023.Text = "2023";
            this.BT_SMCAM_2023.UseVisualStyleBackColor = true;
            this.BT_SMCAM_2023.Click += new System.EventHandler(this.BT_SMCAM_2023_Click);
            // 
            // BT_SMCAM_2022
            // 
            this.BT_SMCAM_2022.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_SMCAM_2022.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_SMCAM_2022.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SMCAM_2022.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SMCAM_2022.Image = ((System.Drawing.Image)(resources.GetObject("BT_SMCAM_2022.Image")));
            this.BT_SMCAM_2022.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_SMCAM_2022.Location = new System.Drawing.Point(10, 48);
            this.BT_SMCAM_2022.Name = "BT_SMCAM_2022";
            this.BT_SMCAM_2022.Size = new System.Drawing.Size(105, 23);
            this.BT_SMCAM_2022.TabIndex = 5;
            this.BT_SMCAM_2022.Text = "2022";
            this.BT_SMCAM_2022.UseVisualStyleBackColor = true;
            this.BT_SMCAM_2022.Click += new System.EventHandler(this.BT_SMCAM_2022_Click);
            // 
            // BT_SMCAM_2021
            // 
            this.BT_SMCAM_2021.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_SMCAM_2021.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BT_SMCAM_2021.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SMCAM_2021.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SMCAM_2021.Image = ((System.Drawing.Image)(resources.GetObject("BT_SMCAM_2021.Image")));
            this.BT_SMCAM_2021.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_SMCAM_2021.Location = new System.Drawing.Point(10, 19);
            this.BT_SMCAM_2021.Name = "BT_SMCAM_2021";
            this.BT_SMCAM_2021.Size = new System.Drawing.Size(105, 23);
            this.BT_SMCAM_2021.TabIndex = 4;
            this.BT_SMCAM_2021.Text = "2021";
            this.BT_SMCAM_2021.UseVisualStyleBackColor = true;
            this.BT_SMCAM_2021.Click += new System.EventHandler(this.BT_SMCAM_2021_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(33, 648);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 33);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // BT_Show
            // 
            this.BT_Show.BackColor = System.Drawing.Color.Transparent;
            this.BT_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Show.FlatAppearance.BorderSize = 0;
            this.BT_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Show.Image = global::Barre_3IDM.Properties.Resources.Mcam_Black;
            this.BT_Show.Location = new System.Drawing.Point(0, 0);
            this.BT_Show.Margin = new System.Windows.Forms.Padding(0);
            this.BT_Show.Name = "BT_Show";
            this.BT_Show.Padding = new System.Windows.Forms.Padding(2);
            this.BT_Show.Size = new System.Drawing.Size(20, 115);
            this.BT_Show.TabIndex = 13;
            this.BT_Show.TabStop = false;
            this.BT_Show.UseVisualStyleBackColor = false;
            this.BT_Show.Visible = false;
            this.BT_Show.Click += new System.EventHandler(this.BT_Show_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(126, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(150, 700);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Version);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GPB_Infos);
            this.Controls.Add(this.GPB_SMCAM);
            this.Controls.Add(this.BT_Hide);
            this.Controls.Add(this.GPB_Utilitaire);
            this.Controls.Add(this.GPB_MMCAM2);
            this.Controls.Add(this.BT_Show);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.GPB_Infos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_InternetCheck)).EndInit();
            this.GPB_SMCAM.ResumeLayout(false);
            this.GPB_Utilitaire.ResumeLayout(false);
            this.GPB_Utilitaire.PerformLayout();
            this.GPB_MMCAM2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer_CheckInternet;
        private System.Windows.Forms.Button BT_Serveur3IDM;
        private System.Windows.Forms.RadioButton RB_ServLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_ServDistant;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_Version;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PB_InternetCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_IP;
        private System.Windows.Forms.GroupBox GPB_Infos;
        private System.Windows.Forms.Button BT_SMCAM_2023;
        private System.Windows.Forms.Button BT_SMCAM_2022;
        private System.Windows.Forms.Button BT_SMCAM_2021;
        private System.Windows.Forms.Button BT_MMCAM_2023;
        private System.Windows.Forms.Button BT_MMCAM_2022;
        private System.Windows.Forms.Button BT_MMCAM_2021;
        private System.Windows.Forms.GroupBox GPB_SMCAM;
        private System.Windows.Forms.Button BT_Hide;
        private System.Windows.Forms.Button BT_Teamviewer;
        private System.Windows.Forms.Button BT_CodeExpert;
        private System.Windows.Forms.Button BT_CimcoEdit;
        private System.Windows.Forms.GroupBox GPB_Utilitaire;
        private System.Windows.Forms.GroupBox GPB_MMCAM2;
        public System.Windows.Forms.Button BT_Show;
        private System.Windows.Forms.ToolTip TT_01;
        private System.Windows.Forms.Button button1;
    }
}