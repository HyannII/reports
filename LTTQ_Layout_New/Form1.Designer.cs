using System.Drawing;

namespace LTTQ_Layout_New
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
            this.MasterPanel = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBC = new System.Windows.Forms.Panel();
            this.btnBC4 = new FontAwesome.Sharp.IconButton();
            this.btnBC3 = new FontAwesome.Sharp.IconButton();
            this.btnBC2 = new FontAwesome.Sharp.IconButton();
            this.btnBC1 = new FontAwesome.Sharp.IconButton();
            this.btnBC = new FontAwesome.Sharp.IconButton();
            this.panelQLDLK = new System.Windows.Forms.Panel();
            this.btnQLDLK3 = new FontAwesome.Sharp.IconButton();
            this.btnQLDLK2 = new FontAwesome.Sharp.IconButton();
            this.btnQLDLK1 = new FontAwesome.Sharp.IconButton();
            this.btnQLDLK = new FontAwesome.Sharp.IconButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnTKGV = new FontAwesome.Sharp.IconButton();
            this.btnTKMH = new FontAwesome.Sharp.IconButton();
            this.btnTK = new FontAwesome.Sharp.IconButton();
            this.btnQLGV = new FontAwesome.Sharp.IconButton();
            this.btnQLL = new FontAwesome.Sharp.IconButton();
            this.btnQLD = new FontAwesome.Sharp.IconButton();
            this.btnQLHV = new FontAwesome.Sharp.IconButton();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.iconVi = new FontAwesome.Sharp.IconButton();
            this.iconEng = new FontAwesome.Sharp.IconButton();
            this.iconLight = new FontAwesome.Sharp.IconButton();
            this.iconToggle = new FontAwesome.Sharp.IconButton();
            this.iconDark = new FontAwesome.Sharp.IconButton();
            this.ItemExit = new FontAwesome.Sharp.IconButton();
            this.panelMenuImg = new System.Windows.Forms.Panel();
            this.homePicture = new System.Windows.Forms.PictureBox();
            this.menuExpander = new FontAwesome.Sharp.IconButton();
            this.MasterPanel.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBC.SuspendLayout();
            this.panelQLDLK.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelMenuImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterPanel
            // 
            this.MasterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.MasterPanel.Controls.Add(this.panelDesktop);
            this.MasterPanel.Controls.Add(this.panelTitle);
            this.MasterPanel.Controls.Add(this.panelMenu);
            this.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(1784, 1039);
            this.MasterPanel.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(307, 110);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1477, 929);
            this.panelDesktop.TabIndex = 5;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(307, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1477, 110);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(1355, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1393, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 24);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnMaximize.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1431, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelTitle.Location = new System.Drawing.Point(6, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(872, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Tag = "HỆ THỐNG QUẢN LÍ THÔNG TIN TRƯỜNG HỌC";
            this.labelTitle.Text = "HỆ THỐNG QUẢN LÍ THÔNG TIN TRƯỜNG HỌC";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelBC);
            this.panelMenu.Controls.Add(this.btnBC);
            this.panelMenu.Controls.Add(this.panelQLDLK);
            this.panelMenu.Controls.Add(this.btnQLDLK);
            this.panelMenu.Controls.Add(this.panelSearch);
            this.panelMenu.Controls.Add(this.btnTK);
            this.panelMenu.Controls.Add(this.btnQLGV);
            this.panelMenu.Controls.Add(this.btnQLL);
            this.panelMenu.Controls.Add(this.btnQLD);
            this.panelMenu.Controls.Add(this.btnQLHV);
            this.panelMenu.Controls.Add(this.panelSettings);
            this.panelMenu.Controls.Add(this.ItemExit);
            this.panelMenu.Controls.Add(this.panelMenuImg);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(307, 1039);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelBC
            // 
            this.panelBC.Controls.Add(this.btnBC4);
            this.panelBC.Controls.Add(this.btnBC3);
            this.panelBC.Controls.Add(this.btnBC2);
            this.panelBC.Controls.Add(this.btnBC1);
            this.panelBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBC.Location = new System.Drawing.Point(0, 735);
            this.panelBC.Name = "panelBC";
            this.panelBC.Size = new System.Drawing.Size(305, 160);
            this.panelBC.TabIndex = 19;
            this.panelBC.Visible = false;
            // 
            // btnBC4
            // 
            this.btnBC4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBC4.FlatAppearance.BorderSize = 0;
            this.btnBC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBC4.IconColor = System.Drawing.Color.Black;
            this.btnBC4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBC4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC4.Location = new System.Drawing.Point(0, 105);
            this.btnBC4.Name = "btnBC4";
            this.btnBC4.Size = new System.Drawing.Size(305, 35);
            this.btnBC4.TabIndex = 2;
            this.btnBC4.Tag = "BÁO CÁO 4";
            this.btnBC4.Text = "BÁO CÁO 4";
            this.btnBC4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBC4.UseVisualStyleBackColor = true;
            this.btnBC4.Click += new System.EventHandler(this.btnBC4_Click);
            this.btnBC4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnBC4.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnBC3
            // 
            this.btnBC3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBC3.FlatAppearance.BorderSize = 0;
            this.btnBC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBC3.IconColor = System.Drawing.Color.Black;
            this.btnBC3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBC3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC3.Location = new System.Drawing.Point(0, 70);
            this.btnBC3.Name = "btnBC3";
            this.btnBC3.Size = new System.Drawing.Size(305, 35);
            this.btnBC3.TabIndex = 3;
            this.btnBC3.Tag = "BÁO CÁO 3";
            this.btnBC3.Text = "BÁO CÁO 3";
            this.btnBC3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBC3.UseVisualStyleBackColor = true;
            this.btnBC3.Click += new System.EventHandler(this.btnBC3_Click);
            this.btnBC3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnBC3.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnBC2
            // 
            this.btnBC2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBC2.FlatAppearance.BorderSize = 0;
            this.btnBC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBC2.IconColor = System.Drawing.Color.Black;
            this.btnBC2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBC2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC2.Location = new System.Drawing.Point(0, 35);
            this.btnBC2.Name = "btnBC2";
            this.btnBC2.Size = new System.Drawing.Size(305, 35);
            this.btnBC2.TabIndex = 1;
            this.btnBC2.Tag = "BÁO CÁO 2";
            this.btnBC2.Text = "BÁO CÁO 2";
            this.btnBC2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBC2.UseVisualStyleBackColor = true;
            this.btnBC2.Click += new System.EventHandler(this.btnBC2_Click);
            this.btnBC2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnBC2.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnBC1
            // 
            this.btnBC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBC1.FlatAppearance.BorderSize = 0;
            this.btnBC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBC1.IconColor = System.Drawing.Color.Black;
            this.btnBC1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBC1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC1.Location = new System.Drawing.Point(0, 0);
            this.btnBC1.Name = "btnBC1";
            this.btnBC1.Size = new System.Drawing.Size(305, 35);
            this.btnBC1.TabIndex = 0;
            this.btnBC1.Tag = "BÁO CÁO 1";
            this.btnBC1.Text = "BÁO CÁO 1";
            this.btnBC1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBC1.UseVisualStyleBackColor = true;
            this.btnBC1.Click += new System.EventHandler(this.btnBC1_Click);
            this.btnBC1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnBC1.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnBC
            // 
            this.btnBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBC.FlatAppearance.BorderSize = 0;
            this.btnBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBC.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnBC.IconColor = System.Drawing.Color.White;
            this.btnBC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBC.IconSize = 35;
            this.btnBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC.Location = new System.Drawing.Point(0, 680);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(305, 55);
            this.btnBC.TabIndex = 18;
            this.btnBC.Tag = "BÁO CÁO";
            this.btnBC.Text = "BÁO CÁO";
            this.btnBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            this.btnBC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnBC.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // panelQLDLK
            // 
            this.panelQLDLK.Controls.Add(this.btnQLDLK3);
            this.panelQLDLK.Controls.Add(this.btnQLDLK2);
            this.panelQLDLK.Controls.Add(this.btnQLDLK1);
            this.panelQLDLK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQLDLK.Location = new System.Drawing.Point(0, 560);
            this.panelQLDLK.Name = "panelQLDLK";
            this.panelQLDLK.Size = new System.Drawing.Size(305, 120);
            this.panelQLDLK.TabIndex = 17;
            this.panelQLDLK.Visible = false;
            // 
            // btnQLDLK3
            // 
            this.btnQLDLK3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDLK3.FlatAppearance.BorderSize = 0;
            this.btnQLDLK3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDLK3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQLDLK3.IconColor = System.Drawing.Color.Black;
            this.btnQLDLK3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDLK3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK3.Location = new System.Drawing.Point(0, 70);
            this.btnQLDLK3.Name = "btnQLDLK3";
            this.btnQLDLK3.Size = new System.Drawing.Size(305, 35);
            this.btnQLDLK3.TabIndex = 2;
            this.btnQLDLK3.Tag = "QUẢN LÍ DỮ LIỆU KHÁC 3";
            this.btnQLDLK3.Text = "QUẢN LÍ DỮ LIỆU KHÁC 3";
            this.btnQLDLK3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDLK3.UseVisualStyleBackColor = true;
            this.btnQLDLK3.Click += new System.EventHandler(this.btnQLDLK3_Click);
            this.btnQLDLK3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLDLK3.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnQLDLK2
            // 
            this.btnQLDLK2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDLK2.FlatAppearance.BorderSize = 0;
            this.btnQLDLK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDLK2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQLDLK2.IconColor = System.Drawing.Color.Black;
            this.btnQLDLK2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDLK2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK2.Location = new System.Drawing.Point(0, 35);
            this.btnQLDLK2.Name = "btnQLDLK2";
            this.btnQLDLK2.Size = new System.Drawing.Size(305, 35);
            this.btnQLDLK2.TabIndex = 1;
            this.btnQLDLK2.Tag = "QUẢN LÍ DỮ LIỆU KHÁC 2";
            this.btnQLDLK2.Text = "QUẢN LÍ DỮ LIỆU KHÁC 2";
            this.btnQLDLK2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDLK2.UseVisualStyleBackColor = true;
            this.btnQLDLK2.Click += new System.EventHandler(this.btnQLDLK2_Click);
            this.btnQLDLK2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLDLK2.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnQLDLK1
            // 
            this.btnQLDLK1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDLK1.FlatAppearance.BorderSize = 0;
            this.btnQLDLK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDLK1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQLDLK1.IconColor = System.Drawing.Color.Black;
            this.btnQLDLK1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDLK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK1.Location = new System.Drawing.Point(0, 0);
            this.btnQLDLK1.Name = "btnQLDLK1";
            this.btnQLDLK1.Size = new System.Drawing.Size(305, 35);
            this.btnQLDLK1.TabIndex = 0;
            this.btnQLDLK1.Tag = "QUẢN LÍ DỮ LIỆU KHÁC 1";
            this.btnQLDLK1.Text = "QUẢN LÍ DỮ LIỆU KHÁC 1";
            this.btnQLDLK1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDLK1.UseVisualStyleBackColor = true;
            this.btnQLDLK1.Click += new System.EventHandler(this.btnQLDLK1_Click);
            this.btnQLDLK1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLDLK1.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnQLDLK
            // 
            this.btnQLDLK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDLK.FlatAppearance.BorderSize = 0;
            this.btnQLDLK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDLK.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDLK.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.btnQLDLK.IconColor = System.Drawing.Color.White;
            this.btnQLDLK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDLK.IconSize = 35;
            this.btnQLDLK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK.Location = new System.Drawing.Point(0, 505);
            this.btnQLDLK.Name = "btnQLDLK";
            this.btnQLDLK.Size = new System.Drawing.Size(305, 55);
            this.btnQLDLK.TabIndex = 16;
            this.btnQLDLK.Tag = "QUẢN LÍ DỮ LIỆU KHÁC";
            this.btnQLDLK.Text = "QUẢN LÍ DỮ LIỆU KHÁC";
            this.btnQLDLK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDLK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDLK.UseVisualStyleBackColor = true;
            this.btnQLDLK.Click += new System.EventHandler(this.btnQLDLK_Click);
            this.btnQLDLK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLDLK.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnTKGV);
            this.panelSearch.Controls.Add(this.btnTKMH);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 425);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(305, 80);
            this.panelSearch.TabIndex = 14;
            this.panelSearch.Visible = false;
            // 
            // btnTKGV
            // 
            this.btnTKGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKGV.FlatAppearance.BorderSize = 0;
            this.btnTKGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKGV.ForeColor = System.Drawing.Color.White;
            this.btnTKGV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTKGV.IconColor = System.Drawing.Color.Black;
            this.btnTKGV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKGV.Location = new System.Drawing.Point(0, 35);
            this.btnTKGV.Name = "btnTKGV";
            this.btnTKGV.Size = new System.Drawing.Size(305, 35);
            this.btnTKGV.TabIndex = 1;
            this.btnTKGV.Tag = "TÌM KIẾM GIẢNG VIÊN";
            this.btnTKGV.Text = "TÌM KIẾM GIẢNG VIÊN";
            this.btnTKGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKGV.UseVisualStyleBackColor = true;
            this.btnTKGV.Click += new System.EventHandler(this.btnTKGV_Click);
            this.btnTKGV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnTKGV.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnTKMH
            // 
            this.btnTKMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKMH.FlatAppearance.BorderSize = 0;
            this.btnTKMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKMH.ForeColor = System.Drawing.Color.White;
            this.btnTKMH.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTKMH.IconColor = System.Drawing.Color.Black;
            this.btnTKMH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKMH.Location = new System.Drawing.Point(0, 0);
            this.btnTKMH.Name = "btnTKMH";
            this.btnTKMH.Size = new System.Drawing.Size(305, 35);
            this.btnTKMH.TabIndex = 0;
            this.btnTKMH.Tag = "TÌM KIẾM MÔN HỌC";
            this.btnTKMH.Text = "TÌM KIẾM MÔN HỌC";
            this.btnTKMH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKMH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKMH.UseVisualStyleBackColor = true;
            this.btnTKMH.Click += new System.EventHandler(this.btnTKMH_Click);
            this.btnTKMH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnTKMH.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnTK
            // 
            this.btnTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTK.FlatAppearance.BorderSize = 0;
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTK.IconColor = System.Drawing.Color.White;
            this.btnTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTK.IconSize = 35;
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTK.Location = new System.Drawing.Point(0, 370);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(305, 55);
            this.btnTK.TabIndex = 13;
            this.btnTK.Tag = "TÌM KIẾM";
            this.btnTK.Text = "TÌM KIẾM";
            this.btnTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            this.btnTK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnTK.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnQLGV
            // 
            this.btnQLGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLGV.FlatAppearance.BorderSize = 0;
            this.btnQLGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLGV.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGV.ForeColor = System.Drawing.Color.White;
            this.btnQLGV.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnQLGV.IconColor = System.Drawing.Color.White;
            this.btnQLGV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLGV.IconSize = 35;
            this.btnQLGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLGV.Location = new System.Drawing.Point(0, 315);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(305, 55);
            this.btnQLGV.TabIndex = 12;
            this.btnQLGV.Tag = "QUẢN LÍ GIẢNG VIÊN";
            this.btnQLGV.Text = "QUẢN LÍ GIẢNG VIÊN";
            this.btnQLGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLGV.UseVisualStyleBackColor = true;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            this.btnQLGV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLGV.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnQLL
            // 
            this.btnQLL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLL.FlatAppearance.BorderSize = 0;
            this.btnQLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLL.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLL.ForeColor = System.Drawing.Color.White;
            this.btnQLL.IconChar = FontAwesome.Sharp.IconChar.School;
            this.btnQLL.IconColor = System.Drawing.Color.White;
            this.btnQLL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLL.IconSize = 35;
            this.btnQLL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLL.Location = new System.Drawing.Point(0, 260);
            this.btnQLL.Name = "btnQLL";
            this.btnQLL.Size = new System.Drawing.Size(305, 55);
            this.btnQLL.TabIndex = 11;
            this.btnQLL.Tag = "QUẢN LÍ LỚP";
            this.btnQLL.Text = "QUẢN LÍ LỚP";
            this.btnQLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLL.UseVisualStyleBackColor = true;
            this.btnQLL.Click += new System.EventHandler(this.btnQLL_Click);
            this.btnQLL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLL.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnQLD
            // 
            this.btnQLD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLD.FlatAppearance.BorderSize = 0;
            this.btnQLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLD.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLD.ForeColor = System.Drawing.Color.White;
            this.btnQLD.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnQLD.IconColor = System.Drawing.Color.White;
            this.btnQLD.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQLD.IconSize = 35;
            this.btnQLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLD.Location = new System.Drawing.Point(0, 205);
            this.btnQLD.Name = "btnQLD";
            this.btnQLD.Size = new System.Drawing.Size(305, 55);
            this.btnQLD.TabIndex = 10;
            this.btnQLD.Tag = "QUẢN LÍ ĐIỂM";
            this.btnQLD.Text = "QUẢN LÍ ĐIỂM";
            this.btnQLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLD.UseVisualStyleBackColor = true;
            this.btnQLD.Click += new System.EventHandler(this.btnQLD_Click);
            this.btnQLD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLD.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnQLHV
            // 
            this.btnQLHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHV.FlatAppearance.BorderSize = 0;
            this.btnQLHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHV.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHV.ForeColor = System.Drawing.Color.White;
            this.btnQLHV.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnQLHV.IconColor = System.Drawing.Color.White;
            this.btnQLHV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLHV.IconSize = 35;
            this.btnQLHV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHV.Location = new System.Drawing.Point(0, 150);
            this.btnQLHV.Name = "btnQLHV";
            this.btnQLHV.Size = new System.Drawing.Size(305, 55);
            this.btnQLHV.TabIndex = 9;
            this.btnQLHV.Tag = "QUẢN LÍ HỌC VIÊN";
            this.btnQLHV.Text = "QUẢN LÍ HỌC VIÊN";
            this.btnQLHV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHV.UseVisualStyleBackColor = true;
            this.btnQLHV.Click += new System.EventHandler(this.btnQLHV_Click);
            this.btnQLHV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnQLHV.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.iconVi);
            this.panelSettings.Controls.Add(this.iconEng);
            this.panelSettings.Controls.Add(this.iconLight);
            this.panelSettings.Controls.Add(this.iconToggle);
            this.panelSettings.Controls.Add(this.iconDark);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSettings.Location = new System.Drawing.Point(0, 917);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(305, 40);
            this.panelSettings.TabIndex = 8;
            // 
            // iconVi
            // 
            this.iconVi.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconVi.FlatAppearance.BorderSize = 0;
            this.iconVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconVi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconVi.ForeColor = System.Drawing.Color.White;
            this.iconVi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconVi.IconColor = System.Drawing.Color.Black;
            this.iconVi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVi.Location = new System.Drawing.Point(75, 0);
            this.iconVi.Name = "iconVi";
            this.iconVi.Size = new System.Drawing.Size(45, 40);
            this.iconVi.TabIndex = 8;
            this.iconVi.Text = "VI";
            this.iconVi.UseVisualStyleBackColor = true;
            this.iconVi.Click += new System.EventHandler(this.iconVi_Click);
            this.iconVi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.iconVi.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // iconEng
            // 
            this.iconEng.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconEng.FlatAppearance.BorderSize = 0;
            this.iconEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEng.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconEng.ForeColor = System.Drawing.Color.White;
            this.iconEng.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconEng.IconColor = System.Drawing.Color.Black;
            this.iconEng.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEng.Location = new System.Drawing.Point(0, 0);
            this.iconEng.Name = "iconEng";
            this.iconEng.Size = new System.Drawing.Size(75, 40);
            this.iconEng.TabIndex = 7;
            this.iconEng.Text = "ENG";
            this.iconEng.UseVisualStyleBackColor = true;
            this.iconEng.Click += new System.EventHandler(this.iconEng_Click);
            this.iconEng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.iconEng.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // iconLight
            // 
            this.iconLight.BackColor = System.Drawing.Color.Transparent;
            this.iconLight.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconLight.Enabled = false;
            this.iconLight.FlatAppearance.BorderSize = 0;
            this.iconLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLight.ForeColor = System.Drawing.Color.Transparent;
            this.iconLight.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconLight.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.iconLight.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconLight.IconSize = 40;
            this.iconLight.Location = new System.Drawing.Point(140, 0);
            this.iconLight.Name = "iconLight";
            this.iconLight.Rotation = 23D;
            this.iconLight.Size = new System.Drawing.Size(55, 40);
            this.iconLight.TabIndex = 6;
            this.iconLight.UseVisualStyleBackColor = false;
            // 
            // iconToggle
            // 
            this.iconToggle.BackColor = System.Drawing.Color.Transparent;
            this.iconToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconToggle.FlatAppearance.BorderSize = 0;
            this.iconToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconToggle.ForeColor = System.Drawing.Color.Transparent;
            this.iconToggle.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.iconToggle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.iconToggle.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconToggle.IconSize = 50;
            this.iconToggle.Location = new System.Drawing.Point(195, 0);
            this.iconToggle.Name = "iconToggle";
            this.iconToggle.Size = new System.Drawing.Size(55, 40);
            this.iconToggle.TabIndex = 5;
            this.iconToggle.UseVisualStyleBackColor = false;
            this.iconToggle.Click += new System.EventHandler(this.iconToggle_Click);
            this.iconToggle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.iconToggle.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // iconDark
            // 
            this.iconDark.BackColor = System.Drawing.Color.Transparent;
            this.iconDark.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconDark.Enabled = false;
            this.iconDark.FlatAppearance.BorderSize = 0;
            this.iconDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDark.ForeColor = System.Drawing.Color.Transparent;
            this.iconDark.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.iconDark.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.iconDark.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconDark.IconSize = 35;
            this.iconDark.Location = new System.Drawing.Point(250, 0);
            this.iconDark.Name = "iconDark";
            this.iconDark.Size = new System.Drawing.Size(55, 40);
            this.iconDark.TabIndex = 4;
            this.iconDark.UseVisualStyleBackColor = false;
            // 
            // ItemExit
            // 
            this.ItemExit.BackColor = System.Drawing.Color.Transparent;
            this.ItemExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemExit.FlatAppearance.BorderSize = 0;
            this.ItemExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemExit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ItemExit.IconChar = FontAwesome.Sharp.IconChar.PersonThroughWindow;
            this.ItemExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.ItemExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ItemExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemExit.Location = new System.Drawing.Point(0, 957);
            this.ItemExit.Name = "ItemExit";
            this.ItemExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ItemExit.Size = new System.Drawing.Size(305, 80);
            this.ItemExit.TabIndex = 7;
            this.ItemExit.Tag = "THOÁT";
            this.ItemExit.Text = "Exit";
            this.ItemExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ItemExit.UseVisualStyleBackColor = false;
            this.ItemExit.Click += new System.EventHandler(this.ItemExit_Click_1);
            this.ItemExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.ItemExit.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // panelMenuImg
            // 
            this.panelMenuImg.BackColor = System.Drawing.Color.Transparent;
            this.panelMenuImg.Controls.Add(this.homePicture);
            this.panelMenuImg.Controls.Add(this.menuExpander);
            this.panelMenuImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuImg.Location = new System.Drawing.Point(0, 0);
            this.panelMenuImg.Name = "panelMenuImg";
            this.panelMenuImg.Size = new System.Drawing.Size(305, 150);
            this.panelMenuImg.TabIndex = 0;
            // 
            // homePicture
            // 
            this.homePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePicture.Location = new System.Drawing.Point(75, 0);
            this.homePicture.Name = "homePicture";
            this.homePicture.Size = new System.Drawing.Size(230, 150);
            this.homePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePicture.TabIndex = 2;
            this.homePicture.TabStop = false;
            this.homePicture.Click += new System.EventHandler(this.homePicture_Click);
            // 
            // menuExpander
            // 
            this.menuExpander.BackColor = System.Drawing.Color.Transparent;
            this.menuExpander.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuExpander.FlatAppearance.BorderSize = 0;
            this.menuExpander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuExpander.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExpander.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.menuExpander.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.menuExpander.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuExpander.IconSize = 75;
            this.menuExpander.Location = new System.Drawing.Point(0, 0);
            this.menuExpander.Name = "menuExpander";
            this.menuExpander.Size = new System.Drawing.Size(75, 150);
            this.menuExpander.TabIndex = 1;
            this.menuExpander.UseVisualStyleBackColor = false;
            this.menuExpander.Click += new System.EventHandler(this.menuExpander_Click);
            this.menuExpander.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.menuExpander.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1784, 1039);
            this.Controls.Add(this.MasterPanel);
            this.MinimumSize = new System.Drawing.Size(1800, 1078);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MasterPanel.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelBC.ResumeLayout(false);
            this.panelQLDLK.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelMenuImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MasterPanel;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton iconLight;
        private FontAwesome.Sharp.IconButton iconToggle;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton iconDark;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton ItemExit;
        private System.Windows.Forms.Panel panelMenuImg;
        private FontAwesome.Sharp.IconButton menuExpander;
        private System.Windows.Forms.PictureBox homePicture;
        private System.Windows.Forms.Panel panelSettings;
        private FontAwesome.Sharp.IconButton iconVi;
        private FontAwesome.Sharp.IconButton iconEng;
        private FontAwesome.Sharp.IconButton btnQLHV;
        private FontAwesome.Sharp.IconButton btnTK;
        private FontAwesome.Sharp.IconButton btnQLGV;
        private FontAwesome.Sharp.IconButton btnQLL;
        private FontAwesome.Sharp.IconButton btnQLD;
        private System.Windows.Forms.Panel panelSearch;
        private FontAwesome.Sharp.IconButton btnTKGV;
        private FontAwesome.Sharp.IconButton btnTKMH;
        private System.Windows.Forms.Panel panelQLDLK;
        private FontAwesome.Sharp.IconButton btnQLDLK1;
        private FontAwesome.Sharp.IconButton btnQLDLK;
        private FontAwesome.Sharp.IconButton btnQLDLK3;
        private FontAwesome.Sharp.IconButton btnQLDLK2;
        private System.Windows.Forms.Panel panelBC;
        private FontAwesome.Sharp.IconButton btnBC4;
        private FontAwesome.Sharp.IconButton btnBC3;
        private FontAwesome.Sharp.IconButton btnBC2;
        private FontAwesome.Sharp.IconButton btnBC1;
        private FontAwesome.Sharp.IconButton btnBC;
    }
}

