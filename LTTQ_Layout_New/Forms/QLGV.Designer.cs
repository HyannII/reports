using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace LTTQ_Layout_New.Forms
{
    partial class QLGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MasterPanel = new System.Windows.Forms.Panel();
            this.panelBTT = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyTemp = new FontAwesome.Sharp.IconButton();
            this.btnHuyDaChonTemp = new FontAwesome.Sharp.IconButton();
            this.btnThongTinBTT = new FontAwesome.Sharp.IconButton();
            this.btnXoaBTT = new FontAwesome.Sharp.IconButton();
            this.btnT_SBTT = new FontAwesome.Sharp.IconButton();
            this.labelBTT = new System.Windows.Forms.Label();
            this.panelTTCT = new System.Windows.Forms.Panel();
            this.panel2in2 = new System.Windows.Forms.Panel();
            this.panel5in6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4in6 = new System.Windows.Forms.Panel();
            this.cbbMaCQ = new System.Windows.Forms.ComboBox();
            this.labelMaCQ = new System.Windows.Forms.Label();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.labelCM = new System.Windows.Forms.Label();
            this.panel6in6 = new System.Windows.Forms.Panel();
            this.btnLuuTTCT = new FontAwesome.Sharp.IconButton();
            this.btnSuaTTCT = new FontAwesome.Sharp.IconButton();
            this.btnXoaTTCT = new FontAwesome.Sharp.IconButton();
            this.btnThemTTCT = new FontAwesome.Sharp.IconButton();
            this.panel1in2 = new System.Windows.Forms.Panel();
            this.panel2in6 = new System.Windows.Forms.Panel();
            this.cbbGT = new System.Windows.Forms.ComboBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.labelDT = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.labelDC = new System.Windows.Forms.Label();
            this.labelGT = new System.Windows.Forms.Label();
            this.panel3in6 = new System.Windows.Forms.Panel();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.labelCD = new System.Windows.Forms.Label();
            this.txtTD = new System.Windows.Forms.TextBox();
            this.labelTD = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.labelAnh = new System.Windows.Forms.Label();
            this.panel1in6 = new System.Windows.Forms.Panel();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.labelNS = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.labelTenGV = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.labelMaGV = new System.Windows.Forms.Label();
            this.labelTTCT = new System.Windows.Forms.Label();
            this.MasterPanel.SuspendLayout();
            this.panelBTT.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTTCT.SuspendLayout();
            this.panel2in2.SuspendLayout();
            this.panel5in6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4in6.SuspendLayout();
            this.panel6in6.SuspendLayout();
            this.panel1in2.SuspendLayout();
            this.panel2in6.SuspendLayout();
            this.panel3in6.SuspendLayout();
            this.panel1in6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterPanel
            // 
            this.MasterPanel.Controls.Add(this.panelBTT);
            this.MasterPanel.Controls.Add(this.panelTTCT);
            this.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(1434, 912);
            this.MasterPanel.TabIndex = 0;
            // 
            // panelBTT
            // 
            this.panelBTT.BackColor = System.Drawing.Color.Transparent;
            this.panelBTT.Controls.Add(this.panel3);
            this.panelBTT.Controls.Add(this.panel2);
            this.panelBTT.Controls.Add(this.panel1);
            this.panelBTT.Controls.Add(this.labelBTT);
            this.panelBTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBTT.Location = new System.Drawing.Point(0, 370);
            this.panelBTT.Name = "panelBTT";
            this.panelBTT.Size = new System.Drawing.Size(1434, 542);
            this.panelBTT.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 412);
            this.panel3.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 72);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(1152, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(102, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "Demo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyTemp);
            this.panel1.Controls.Add(this.btnHuyDaChonTemp);
            this.panel1.Controls.Add(this.btnThongTinBTT);
            this.panel1.Controls.Add(this.btnXoaBTT);
            this.panel1.Controls.Add(this.btnT_SBTT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1254, 58);
            this.panel1.MaximumSize = new System.Drawing.Size(180, 484);
            this.panel1.MinimumSize = new System.Drawing.Size(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 484);
            this.panel1.TabIndex = 28;
            // 
            // btnHuyTemp
            // 
            this.btnHuyTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHuyTemp.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyTemp.FlatAppearance.BorderSize = 0;
            this.btnHuyTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTemp.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnHuyTemp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHuyTemp.IconColor = System.Drawing.Color.Black;
            this.btnHuyTemp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuyTemp.Location = new System.Drawing.Point(18, 332);
            this.btnHuyTemp.Name = "btnHuyTemp";
            this.btnHuyTemp.Size = new System.Drawing.Size(150, 50);
            this.btnHuyTemp.TabIndex = 38;
            this.btnHuyTemp.Text = "Huỷ";
            this.btnHuyTemp.UseVisualStyleBackColor = false;
            this.btnHuyTemp.Visible = false;
            this.btnHuyTemp.Click += new System.EventHandler(this.btnHuyTemp_Click);
            this.btnHuyTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnHuyTemp.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnHuyDaChonTemp
            // 
            this.btnHuyDaChonTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHuyDaChonTemp.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyDaChonTemp.FlatAppearance.BorderSize = 0;
            this.btnHuyDaChonTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDaChonTemp.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDaChonTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnHuyDaChonTemp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHuyDaChonTemp.IconColor = System.Drawing.Color.Black;
            this.btnHuyDaChonTemp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuyDaChonTemp.Location = new System.Drawing.Point(18, 184);
            this.btnHuyDaChonTemp.Name = "btnHuyDaChonTemp";
            this.btnHuyDaChonTemp.Size = new System.Drawing.Size(150, 50);
            this.btnHuyDaChonTemp.TabIndex = 37;
            this.btnHuyDaChonTemp.Text = "Huỷ đã chọn";
            this.btnHuyDaChonTemp.UseVisualStyleBackColor = false;
            this.btnHuyDaChonTemp.Visible = false;
            this.btnHuyDaChonTemp.Click += new System.EventHandler(this.btnHuyDaChonTemp_Click);
            this.btnHuyDaChonTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnHuyDaChonTemp.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnThongTinBTT
            // 
            this.btnThongTinBTT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThongTinBTT.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinBTT.FlatAppearance.BorderSize = 0;
            this.btnThongTinBTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinBTT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinBTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnThongTinBTT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThongTinBTT.IconColor = System.Drawing.Color.Black;
            this.btnThongTinBTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongTinBTT.Location = new System.Drawing.Point(18, 398);
            this.btnThongTinBTT.Name = "btnThongTinBTT";
            this.btnThongTinBTT.Size = new System.Drawing.Size(150, 50);
            this.btnThongTinBTT.TabIndex = 36;
            this.btnThongTinBTT.Text = "Thông tin";
            this.btnThongTinBTT.UseVisualStyleBackColor = false;
            this.btnThongTinBTT.Click += new System.EventHandler(this.btnThongTinBTT_Click);
            this.btnThongTinBTT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnThongTinBTT.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnXoaBTT
            // 
            this.btnXoaBTT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnXoaBTT.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaBTT.FlatAppearance.BorderSize = 0;
            this.btnXoaBTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBTT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnXoaBTT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaBTT.IconColor = System.Drawing.Color.Black;
            this.btnXoaBTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaBTT.Location = new System.Drawing.Point(18, 256);
            this.btnXoaBTT.Name = "btnXoaBTT";
            this.btnXoaBTT.Size = new System.Drawing.Size(150, 50);
            this.btnXoaBTT.TabIndex = 35;
            this.btnXoaBTT.Text = "Xoá";
            this.btnXoaBTT.UseVisualStyleBackColor = false;
            this.btnXoaBTT.Click += new System.EventHandler(this.btnXoaBTT_Click);
            this.btnXoaBTT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnXoaBTT.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnT_SBTT
            // 
            this.btnT_SBTT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnT_SBTT.BackColor = System.Drawing.Color.Transparent;
            this.btnT_SBTT.FlatAppearance.BorderSize = 0;
            this.btnT_SBTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT_SBTT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT_SBTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnT_SBTT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnT_SBTT.IconColor = System.Drawing.Color.Black;
            this.btnT_SBTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnT_SBTT.Location = new System.Drawing.Point(18, 112);
            this.btnT_SBTT.Name = "btnT_SBTT";
            this.btnT_SBTT.Size = new System.Drawing.Size(150, 50);
            this.btnT_SBTT.TabIndex = 34;
            this.btnT_SBTT.Text = "Thêm / Sửa";
            this.btnT_SBTT.UseVisualStyleBackColor = false;
            this.btnT_SBTT.Click += new System.EventHandler(this.btnT_SBTT_Click);
            this.btnT_SBTT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnT_SBTT.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // labelBTT
            // 
            this.labelBTT.AutoSize = true;
            this.labelBTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBTT.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelBTT.Location = new System.Drawing.Point(0, 0);
            this.labelBTT.Name = "labelBTT";
            this.labelBTT.Padding = new System.Windows.Forms.Padding(10, 20, 1003, 0);
            this.labelBTT.Size = new System.Drawing.Size(1296, 58);
            this.labelBTT.TabIndex = 27;
            this.labelBTT.Text = "Bảng thông tin";
            this.labelBTT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelTTCT
            // 
            this.panelTTCT.BackColor = System.Drawing.Color.Transparent;
            this.panelTTCT.Controls.Add(this.panel2in2);
            this.panelTTCT.Controls.Add(this.panel1in2);
            this.panelTTCT.Controls.Add(this.labelTTCT);
            this.panelTTCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTTCT.Location = new System.Drawing.Point(0, 0);
            this.panelTTCT.Name = "panelTTCT";
            this.panelTTCT.Size = new System.Drawing.Size(1434, 370);
            this.panelTTCT.TabIndex = 2;
            // 
            // panel2in2
            // 
            this.panel2in2.Controls.Add(this.panel5in6);
            this.panel2in2.Controls.Add(this.panel4in6);
            this.panel2in2.Controls.Add(this.panel6in6);
            this.panel2in2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2in2.Location = new System.Drawing.Point(777, 58);
            this.panel2in2.Name = "panel2in2";
            this.panel2in2.Size = new System.Drawing.Size(657, 312);
            this.panel2in2.TabIndex = 31;
            // 
            // panel5in6
            // 
            this.panel5in6.Controls.Add(this.label1);
            this.panel5in6.Controls.Add(this.pictureBox1);
            this.panel5in6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5in6.Location = new System.Drawing.Point(259, 0);
            this.panel5in6.Name = "panel5in6";
            this.panel5in6.Size = new System.Drawing.Size(398, 212);
            this.panel5in6.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ảnh đại diện";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox1.Location = new System.Drawing.Point(110, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 120);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panel4in6
            // 
            this.panel4in6.Controls.Add(this.cbbMaCQ);
            this.panel4in6.Controls.Add(this.labelMaCQ);
            this.panel4in6.Controls.Add(this.txtCM);
            this.panel4in6.Controls.Add(this.labelCM);
            this.panel4in6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4in6.Location = new System.Drawing.Point(0, 0);
            this.panel4in6.Name = "panel4in6";
            this.panel4in6.Size = new System.Drawing.Size(259, 212);
            this.panel4in6.TabIndex = 41;
            // 
            // cbbMaCQ
            // 
            this.cbbMaCQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbbMaCQ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaCQ.ForeColor = System.Drawing.Color.White;
            this.cbbMaCQ.FormattingEnabled = true;
            this.cbbMaCQ.Location = new System.Drawing.Point(21, 161);
            this.cbbMaCQ.Name = "cbbMaCQ";
            this.cbbMaCQ.Size = new System.Drawing.Size(197, 26);
            this.cbbMaCQ.TabIndex = 37;
            // 
            // labelMaCQ
            // 
            this.labelMaCQ.AutoSize = true;
            this.labelMaCQ.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaCQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelMaCQ.Location = new System.Drawing.Point(17, 128);
            this.labelMaCQ.Name = "labelMaCQ";
            this.labelMaCQ.Size = new System.Drawing.Size(133, 23);
            this.labelMaCQ.TabIndex = 36;
            this.labelMaCQ.Text = "Mã cơ quan";
            // 
            // txtCM
            // 
            this.txtCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCM.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCM.ForeColor = System.Drawing.Color.White;
            this.txtCM.Location = new System.Drawing.Point(20, 74);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(198, 24);
            this.txtCM.TabIndex = 35;
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelCM.Location = new System.Drawing.Point(17, 41);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(145, 23);
            this.labelCM.TabIndex = 34;
            this.labelCM.Text = "Chuyên môn";
            // 
            // panel6in6
            // 
            this.panel6in6.Controls.Add(this.btnLuuTTCT);
            this.panel6in6.Controls.Add(this.btnSuaTTCT);
            this.panel6in6.Controls.Add(this.btnXoaTTCT);
            this.panel6in6.Controls.Add(this.btnThemTTCT);
            this.panel6in6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6in6.Location = new System.Drawing.Point(0, 212);
            this.panel6in6.Name = "panel6in6";
            this.panel6in6.Size = new System.Drawing.Size(657, 100);
            this.panel6in6.TabIndex = 40;
            // 
            // btnLuuTTCT
            // 
            this.btnLuuTTCT.BackColor = System.Drawing.Color.Transparent;
            this.btnLuuTTCT.FlatAppearance.BorderSize = 0;
            this.btnLuuTTCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTTCT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTTCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnLuuTTCT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLuuTTCT.IconColor = System.Drawing.Color.Black;
            this.btnLuuTTCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuuTTCT.Location = new System.Drawing.Point(408, 35);
            this.btnLuuTTCT.Name = "btnLuuTTCT";
            this.btnLuuTTCT.Size = new System.Drawing.Size(100, 40);
            this.btnLuuTTCT.TabIndex = 41;
            this.btnLuuTTCT.Text = "Lưu";
            this.btnLuuTTCT.UseVisualStyleBackColor = false;
            this.btnLuuTTCT.Click += new System.EventHandler(this.btnLuuTTCT_Click);
            this.btnLuuTTCT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnLuuTTCT.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnSuaTTCT
            // 
            this.btnSuaTTCT.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaTTCT.FlatAppearance.BorderSize = 0;
            this.btnSuaTTCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTTCT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTTCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnSuaTTCT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaTTCT.IconColor = System.Drawing.Color.Black;
            this.btnSuaTTCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaTTCT.Location = new System.Drawing.Point(291, 35);
            this.btnSuaTTCT.Name = "btnSuaTTCT";
            this.btnSuaTTCT.Size = new System.Drawing.Size(100, 40);
            this.btnSuaTTCT.TabIndex = 40;
            this.btnSuaTTCT.Text = "Sửa";
            this.btnSuaTTCT.UseVisualStyleBackColor = false;
            this.btnSuaTTCT.Click += new System.EventHandler(this.btnSuaTTCT_Click);
            this.btnSuaTTCT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnSuaTTCT.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnXoaTTCT
            // 
            this.btnXoaTTCT.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaTTCT.FlatAppearance.BorderSize = 0;
            this.btnXoaTTCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTTCT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTTCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnXoaTTCT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaTTCT.IconColor = System.Drawing.Color.Black;
            this.btnXoaTTCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaTTCT.Location = new System.Drawing.Point(176, 35);
            this.btnXoaTTCT.Name = "btnXoaTTCT";
            this.btnXoaTTCT.Size = new System.Drawing.Size(100, 40);
            this.btnXoaTTCT.TabIndex = 39;
            this.btnXoaTTCT.Text = "Xoá";
            this.btnXoaTTCT.UseVisualStyleBackColor = false;
            this.btnXoaTTCT.Click += new System.EventHandler(this.btnXoaTTCT_Click);
            this.btnXoaTTCT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnXoaTTCT.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // btnThemTTCT
            // 
            this.btnThemTTCT.BackColor = System.Drawing.Color.Transparent;
            this.btnThemTTCT.FlatAppearance.BorderSize = 0;
            this.btnThemTTCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTTCT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTTCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btnThemTTCT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemTTCT.IconColor = System.Drawing.Color.Black;
            this.btnThemTTCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemTTCT.Location = new System.Drawing.Point(60, 35);
            this.btnThemTTCT.Name = "btnThemTTCT";
            this.btnThemTTCT.Size = new System.Drawing.Size(100, 40);
            this.btnThemTTCT.TabIndex = 38;
            this.btnThemTTCT.Text = "Thêm";
            this.btnThemTTCT.UseVisualStyleBackColor = false;
            this.btnThemTTCT.Click += new System.EventHandler(this.btnThemTTCT_Click);
            this.btnThemTTCT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClick);
            this.btnThemTTCT.MouseEnter += new System.EventHandler(this.btnHover);
            // 
            // panel1in2
            // 
            this.panel1in2.Controls.Add(this.panel2in6);
            this.panel1in2.Controls.Add(this.panel3in6);
            this.panel1in2.Controls.Add(this.panel1in6);
            this.panel1in2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1in2.Location = new System.Drawing.Point(0, 58);
            this.panel1in2.Name = "panel1in2";
            this.panel1in2.Size = new System.Drawing.Size(777, 312);
            this.panel1in2.TabIndex = 30;
            // 
            // panel2in6
            // 
            this.panel2in6.Controls.Add(this.cbbGT);
            this.panel2in6.Controls.Add(this.txtDT);
            this.panel2in6.Controls.Add(this.labelDT);
            this.panel2in6.Controls.Add(this.txtDC);
            this.panel2in6.Controls.Add(this.labelDC);
            this.panel2in6.Controls.Add(this.labelGT);
            this.panel2in6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2in6.Location = new System.Drawing.Point(259, 0);
            this.panel2in6.Name = "panel2in6";
            this.panel2in6.Size = new System.Drawing.Size(259, 312);
            this.panel2in6.TabIndex = 47;
            // 
            // cbbGT
            // 
            this.cbbGT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbbGT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGT.ForeColor = System.Drawing.Color.White;
            this.cbbGT.FormattingEnabled = true;
            this.cbbGT.Location = new System.Drawing.Point(33, 74);
            this.cbbGT.Name = "cbbGT";
            this.cbbGT.Size = new System.Drawing.Size(197, 26);
            this.cbbGT.TabIndex = 45;
            // 
            // txtDT
            // 
            this.txtDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.ForeColor = System.Drawing.Color.White;
            this.txtDT.Location = new System.Drawing.Point(32, 247);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(198, 24);
            this.txtDT.TabIndex = 44;
            this.txtDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDT_KeyPress);
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelDT.Location = new System.Drawing.Point(29, 214);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(123, 23);
            this.labelDT.TabIndex = 43;
            this.labelDT.Text = "Điện thoại";
            // 
            // txtDC
            // 
            this.txtDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDC.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.ForeColor = System.Drawing.Color.White;
            this.txtDC.Location = new System.Drawing.Point(32, 161);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(198, 24);
            this.txtDC.TabIndex = 42;
            // 
            // labelDC
            // 
            this.labelDC.AutoSize = true;
            this.labelDC.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelDC.Location = new System.Drawing.Point(29, 128);
            this.labelDC.Name = "labelDC";
            this.labelDC.Size = new System.Drawing.Size(85, 23);
            this.labelDC.TabIndex = 41;
            this.labelDC.Text = "Địa chỉ";
            // 
            // labelGT
            // 
            this.labelGT.AutoSize = true;
            this.labelGT.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelGT.Location = new System.Drawing.Point(29, 41);
            this.labelGT.Name = "labelGT";
            this.labelGT.Size = new System.Drawing.Size(103, 23);
            this.labelGT.TabIndex = 39;
            this.labelGT.Text = "Giới tính";
            // 
            // panel3in6
            // 
            this.panel3in6.Controls.Add(this.txtCD);
            this.panel3in6.Controls.Add(this.labelCD);
            this.panel3in6.Controls.Add(this.txtTD);
            this.panel3in6.Controls.Add(this.labelTD);
            this.panel3in6.Controls.Add(this.txtAnh);
            this.panel3in6.Controls.Add(this.labelAnh);
            this.panel3in6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3in6.Location = new System.Drawing.Point(518, 0);
            this.panel3in6.Name = "panel3in6";
            this.panel3in6.Size = new System.Drawing.Size(259, 312);
            this.panel3in6.TabIndex = 46;
            // 
            // txtCD
            // 
            this.txtCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCD.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCD.ForeColor = System.Drawing.Color.White;
            this.txtCD.Location = new System.Drawing.Point(24, 247);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(198, 24);
            this.txtCD.TabIndex = 50;
            // 
            // labelCD
            // 
            this.labelCD.AutoSize = true;
            this.labelCD.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelCD.Location = new System.Drawing.Point(21, 214);
            this.labelCD.Name = "labelCD";
            this.labelCD.Size = new System.Drawing.Size(124, 23);
            this.labelCD.TabIndex = 49;
            this.labelCD.Text = "Chức danh";
            // 
            // txtTD
            // 
            this.txtTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTD.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTD.ForeColor = System.Drawing.Color.White;
            this.txtTD.Location = new System.Drawing.Point(24, 161);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(198, 24);
            this.txtTD.TabIndex = 48;
            // 
            // labelTD
            // 
            this.labelTD.AutoSize = true;
            this.labelTD.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelTD.Location = new System.Drawing.Point(21, 128);
            this.labelTD.Name = "labelTD";
            this.labelTD.Size = new System.Drawing.Size(100, 23);
            this.labelTD.TabIndex = 47;
            this.labelTD.Text = "Trình độ";
            // 
            // txtAnh
            // 
            this.txtAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAnh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnh.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnh.ForeColor = System.Drawing.Color.White;
            this.txtAnh.Location = new System.Drawing.Point(24, 74);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(198, 24);
            this.txtAnh.TabIndex = 46;
            // 
            // labelAnh
            // 
            this.labelAnh.AutoSize = true;
            this.labelAnh.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelAnh.Location = new System.Drawing.Point(21, 41);
            this.labelAnh.Name = "labelAnh";
            this.labelAnh.Size = new System.Drawing.Size(140, 23);
            this.labelAnh.TabIndex = 45;
            this.labelAnh.Text = "Tên file ảnh";
            // 
            // panel1in6
            // 
            this.panel1in6.Controls.Add(this.dtpNS);
            this.panel1in6.Controls.Add(this.labelNS);
            this.panel1in6.Controls.Add(this.txtTenGV);
            this.panel1in6.Controls.Add(this.labelTenGV);
            this.panel1in6.Controls.Add(this.txtMaGV);
            this.panel1in6.Controls.Add(this.labelMaGV);
            this.panel1in6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1in6.Location = new System.Drawing.Point(0, 0);
            this.panel1in6.Name = "panel1in6";
            this.panel1in6.Size = new System.Drawing.Size(259, 312);
            this.panel1in6.TabIndex = 45;
            // 
            // dtpNS
            // 
            this.dtpNS.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.dtpNS.CustomFormat = "dd/MM/yyyy";
            this.dtpNS.Font = new System.Drawing.Font("Verdana", 11F);
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNS.Location = new System.Drawing.Point(35, 247);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(198, 25);
            this.dtpNS.TabIndex = 51;
            // 
            // labelNS
            // 
            this.labelNS.AutoSize = true;
            this.labelNS.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelNS.Location = new System.Drawing.Point(32, 214);
            this.labelNS.Name = "labelNS";
            this.labelNS.Size = new System.Drawing.Size(117, 23);
            this.labelNS.TabIndex = 50;
            this.labelNS.Text = "Ngày sinh";
            // 
            // txtTenGV
            // 
            this.txtTenGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTenGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenGV.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.ForeColor = System.Drawing.Color.White;
            this.txtTenGV.Location = new System.Drawing.Point(35, 161);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(198, 24);
            this.txtTenGV.TabIndex = 49;
            this.txtTenGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenGV_KeyPress);
            // 
            // labelTenGV
            // 
            this.labelTenGV.AutoSize = true;
            this.labelTenGV.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelTenGV.Location = new System.Drawing.Point(32, 128);
            this.labelTenGV.Name = "labelTenGV";
            this.labelTenGV.Size = new System.Drawing.Size(156, 23);
            this.labelTenGV.TabIndex = 48;
            this.labelTenGV.Text = "Tên giáo viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMaGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaGV.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.ForeColor = System.Drawing.Color.White;
            this.txtMaGV.Location = new System.Drawing.Point(35, 74);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(198, 24);
            this.txtMaGV.TabIndex = 47;
            // 
            // labelMaGV
            // 
            this.labelMaGV.AutoSize = true;
            this.labelMaGV.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelMaGV.Location = new System.Drawing.Point(32, 41);
            this.labelMaGV.Name = "labelMaGV";
            this.labelMaGV.Size = new System.Drawing.Size(147, 23);
            this.labelMaGV.TabIndex = 46;
            this.labelMaGV.Text = "Mã giáo viên";
            // 
            // labelTTCT
            // 
            this.labelTTCT.AutoSize = true;
            this.labelTTCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTTCT.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.labelTTCT.Location = new System.Drawing.Point(0, 0);
            this.labelTTCT.Name = "labelTTCT";
            this.labelTTCT.Padding = new System.Windows.Forms.Padding(10, 20, 960, 0);
            this.labelTTCT.Size = new System.Drawing.Size(1296, 58);
            this.labelTTCT.TabIndex = 0;
            this.labelTTCT.Text = "Thông tin chi tiết";
            this.labelTTCT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // QLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(1434, 912);
            this.Controls.Add(this.MasterPanel);
            this.MinimumSize = new System.Drawing.Size(1450, 951);
            this.Name = "QLGV";
            this.Text = "Form1";
            this.MasterPanel.ResumeLayout(false);
            this.panelBTT.ResumeLayout(false);
            this.panelBTT.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelTTCT.ResumeLayout(false);
            this.panelTTCT.PerformLayout();
            this.panel2in2.ResumeLayout(false);
            this.panel5in6.ResumeLayout(false);
            this.panel5in6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4in6.ResumeLayout(false);
            this.panel4in6.PerformLayout();
            this.panel6in6.ResumeLayout(false);
            this.panel1in2.ResumeLayout(false);
            this.panel2in6.ResumeLayout(false);
            this.panel2in6.PerformLayout();
            this.panel3in6.ResumeLayout(false);
            this.panel3in6.PerformLayout();
            this.panel1in6.ResumeLayout(false);
            this.panel1in6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MasterPanel;
        private System.Windows.Forms.Panel panelBTT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnHuyTemp;
        private FontAwesome.Sharp.IconButton btnHuyDaChonTemp;
        private FontAwesome.Sharp.IconButton btnThongTinBTT;
        private FontAwesome.Sharp.IconButton btnXoaBTT;
        private FontAwesome.Sharp.IconButton btnT_SBTT;
        private System.Windows.Forms.Label labelBTT;
        private System.Windows.Forms.Panel panelTTCT;
        private System.Windows.Forms.Panel panel2in2;
        private System.Windows.Forms.Panel panel5in6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4in6;
        private System.Windows.Forms.Label labelMaCQ;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.Panel panel6in6;
        private FontAwesome.Sharp.IconButton btnLuuTTCT;
        private FontAwesome.Sharp.IconButton btnSuaTTCT;
        private FontAwesome.Sharp.IconButton btnXoaTTCT;
        private FontAwesome.Sharp.IconButton btnThemTTCT;
        private System.Windows.Forms.Panel panel1in2;
        private System.Windows.Forms.Panel panel2in6;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label labelDC;
        private System.Windows.Forms.Label labelGT;
        private System.Windows.Forms.Panel panel3in6;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.Label labelCD;
        private System.Windows.Forms.TextBox txtTD;
        private System.Windows.Forms.Label labelTD;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label labelAnh;
        private System.Windows.Forms.Panel panel1in6;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.Label labelNS;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label labelTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label labelMaGV;
        private System.Windows.Forms.Label labelTTCT;
        private System.Windows.Forms.ComboBox cbbGT;
        private System.Windows.Forms.ComboBox cbbMaCQ;
    }
}

