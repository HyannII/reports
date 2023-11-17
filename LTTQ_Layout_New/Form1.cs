using FontAwesome.Sharp;
using LTTQ_Layout_New.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace LTTQ_Layout_New
{
    public partial class Form1 : Form
    {
        public SqlConnection con;
        private int borderSize = 2;
        private Size formSize;
        private Form currentChildForm = null;
        private List<Form> innerForms = new List<Form>();
        private QLHV QuanLiHocVien;
        private QLD QuanLiDiem = new QLD();
        private QLL QuanLiLop = new QLL();
        private QLGV QuanLiGiangVien;
        private bool _DarkModeOn = true;
        public bool DarkModeOn
        {
            get { return _DarkModeOn; }
            set
            {
                _DarkModeOn = value;
            }
        }
        private struct RGBColors
        {
            public static Color colorBlack = Color.FromArgb(8, 8, 8);
            public static Color colorWhite = Color.FromArgb(214, 214, 214);
            public static Color colorLessBlack = Color.FromArgb(50,50,50);
            public static Color colorLessWhite = Color.FromArgb(160,160,160);
            public static Color colorPureWhite = Color.FromArgb(255, 255, 255);
            public static Color colorPureBlack = Color.FromArgb(0, 0, 0);
        }

        public Form1()
        {
            InitializeComponent();
            connect();
            CollapseMenu();
            QuanLiGiangVien = new QLGV(this, con);
            QuanLiHocVien = new QLHV(this, con);
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(210, 180, 140);
            InitializeInnerForms();
            foreach (var innerForm in innerForms)
            {
                InitializeChildForm(innerForm, panelDesktop);
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
            //PrintInnerFormNames();
        }
        private void connect()
        {
            string connectionString = "Data Source=DESKTOP-43NA2S5\\SQLEXPRESS;Initial Catalog=QLTrungTamDayHoc;Integrated Security=True;";
            con = new SqlConnection(connectionString); //Khởi tạo đối tượng
            con.Open(); //Mở kết nối
        }
        private void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 0, 0, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize) this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void menuExpander_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 75;
                homePicture.Visible = false;
                menuExpander.Dock = DockStyle.Fill;
                menuExpander.IconChar = IconChar.Bars;
                iconDark.Visible = false;
                iconLight.Visible = false;
                iconToggle.Visible = false;
                iconVi.Visible = false;
                iconEng.Visible = false;
                hideSubMenu();
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 350;
                homePicture.Visible = true;
                menuExpander.Dock = DockStyle.Left;
                menuExpander.IconChar = IconChar.BarsStaggered;
                iconDark.Visible = true;
                iconLight.Visible = true;
                iconToggle.Visible = true;
                iconVi.Visible = true;
                iconEng.Visible = true;
                foreach (IconButton menuButton in panelMenu.Controls.OfType<IconButton>())
                {
                    menuButton.Text = "   " + menuButton.Tag;
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        private void hideSubMenu()
        {
            panelSearch.Visible = false;
            panelQLDLK.Visible = false;
            panelBC.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void InitializeChildForm(Form childForm, Panel panel)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.Hide(); // Hide the form initially
        }
        private void OpenChildForm(Form childForm, Panel panel)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide(); // Hide the current child form
            }

            currentChildForm = childForm; // Set the new child form as the current child form
            childForm.BringToFront();
            childForm.Show(); // Show the form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = IconChar.Clone;
                btnMaximize.IconSize = 25;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.IconChar = IconChar.Square;
                btnMaximize.IconSize = 20;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }
        private void ItemExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homePicture_Click(object sender, EventArgs e)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            labelTitle.Text = labelTitle.Tag.ToString();
            hideSubMenu();
        }

        private void InitializeInnerForms()
        {
            innerForms.Add(QuanLiHocVien);
            innerForms.Add(QuanLiDiem);
            innerForms.Add(QuanLiLop);
            innerForms.Add(QuanLiGiangVien);
        }

        private void iconToggle_Click(object sender, EventArgs e)
        {
            if (iconToggle.IconChar == IconChar.ToggleOn && DarkModeOn)
            {
                iconToggle.IconChar = IconChar.ToggleOff;
                iconToggle.IconFont = IconFont.Solid;
                MasterPanel.BackColor = RGBColors.colorWhite;
                iconLight.IconColor = RGBColors.colorBlack;
                iconDark.IconColor = RGBColors.colorBlack;
                iconToggle.IconColor = RGBColors.colorBlack;
                ChangeMode(this, RGBColors.colorBlack, RGBColors.colorWhite);
                foreach (var innerForm in innerForms)
                {
                    ChangeMode(innerForm, RGBColors.colorBlack, RGBColors.colorWhite);
                    ChangeModeTextBox(innerForm, RGBColors.colorLessWhite, RGBColors.colorPureBlack); // Change inner form color
                }
                DarkModeOn = !DarkModeOn;
                panelMenu.Invalidate();
                panelTitle.Invalidate();
            }
            else
            {
                iconToggle.IconChar = IconChar.ToggleOn;
                iconToggle.IconFont = IconFont.Solid;
                MasterPanel.BackColor = RGBColors.colorBlack;
                iconLight.IconColor = RGBColors.colorWhite;
                iconDark.IconColor = RGBColors.colorWhite;
                iconToggle.IconColor = RGBColors.colorWhite;
                ChangeMode(this, RGBColors.colorWhite, RGBColors.colorBlack);
                foreach (var innerForm in innerForms)
                {
                    ChangeMode(innerForm, RGBColors.colorWhite, RGBColors.colorBlack);
                    ChangeModeTextBox(innerForm, RGBColors.colorLessBlack, RGBColors.colorPureWhite); // Change inner form color back to default
                }
                DarkModeOn = !DarkModeOn;
                panelMenu.Invalidate();
                panelTitle.Invalidate();
            }
        }
        private void ChangeMode(Control control, Color color, Color panelColor)
        {
            if (control is IconButton || control is Label)
            {
                control.ForeColor = color;
                if (control is IconButton iconButton)
                {
                    iconButton.IconColor = color;
                }
            }
            else if (control is Panel && control.Name == "MasterPanel")
            {
                control.BackColor = panelColor;
            }

            foreach (Control childControl in control.Controls)
            {
                ChangeMode(childControl, color, panelColor);
            }
        }
        private void ChangeModeTextBox(Control control, Color color, Color textColor)
        {
            if (control is TextBox || control is ComboBox)
            {
                control.BackColor = color;
                control.ForeColor = textColor;
            }

            foreach (Control childControl in control.Controls)
            {
                ChangeModeTextBox(childControl, color, textColor);
            }
        }
        private void iconVi_Click(object sender, EventArgs e)
        {
            //    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            //    Controls.Clear();
            //    InitializeComponent();
        }

        private void iconEng_Click(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
            //Controls.Clear();
            //InitializeComponent();
        }

        private void btnQLHV_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnQLHV.Tag.ToString();
            hideSubMenu();
        }

        private void btnQLD_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiDiem, panelDesktop);
            labelTitle.Text = btnQLD.Tag.ToString();
            hideSubMenu();
        }

        private void btnQLL_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiLop, panelDesktop);
            labelTitle.Text = btnQLL.Tag.ToString();
            hideSubMenu();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiGiangVien, panelDesktop);
            labelTitle.Text = btnQLGV.Tag.ToString();
            hideSubMenu();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (homePicture.Visible == true)
            {
                showSubMenu(panelSearch);
            }
        }

        private void btnTKMH_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnTKMH.Tag.ToString();
        }

        private void btnTKGV_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnTKGV.Tag.ToString();
        }

        private void btnQLDLK_Click(object sender, EventArgs e)
        {
            if (homePicture.Visible == true)
            {
                showSubMenu(panelQLDLK);
            }
        }

        private void btnQLDLK1_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnQLDLK1.Tag.ToString();
        }

        private void btnQLDLK2_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnQLDLK2.Tag.ToString();
        }

        private void btnQLDLK3_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnQLDLK3.Tag.ToString();
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            if (homePicture.Visible == true)
            {
                showSubMenu(panelBC);
            }
        }

        private void btnBC1_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnBC1.Tag.ToString();
        }

        private void btnBC2_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnBC2.Tag.ToString();
        }

        private void btnBC3_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnBC3.Tag.ToString();
        }

        private void btnBC4_Click(object sender, EventArgs e)
        {
            OpenChildForm(QuanLiHocVien, panelDesktop);
            labelTitle.Text = btnBC4.Tag.ToString();
        }
        private void btnClick(object sender, MouseEventArgs e)
        {
            IconButton btn = (IconButton)sender;
            if (btn.Name == "iconToggle")
            {
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            }
            else if (DarkModeOn)
            {
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            }
            else
            {
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 160, 160);
            }
        }
        private void btnHover(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            if (btn.Name == "iconToggle")
            {
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
            else if (DarkModeOn)
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30,30,30);
            }
            else
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200,200,200);
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            Color color = DarkModeOn ? RGBColors.colorBlack : RGBColors.colorWhite;
            // Create a pen to draw the border with the chosen color and a specified thickness
            Pen p = new Pen(color, 2);

            // Draw the border on the right side
            e.Graphics.DrawLine(p, this.Width - 1, 0, this.Width - 1, this.Height);
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
            Color color = DarkModeOn ? RGBColors.colorBlack : RGBColors.colorWhite;
            // Create a pen to draw the border with the chosen color and a specified thickness
            Pen p = new Pen(color, 2);

            // Draw the border at the bottom
            e.Graphics.DrawLine(p, 0, this.Height - 1, this.Width, this.Height - 1);
        }
    }
}
