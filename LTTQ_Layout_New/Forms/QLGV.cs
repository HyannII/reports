using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_Layout_New.Forms
{
    public partial class QLGV : Form
    {
        private bool _DarkModeOn;
        public QLGV(bool DarkModeOn)
        {
            InitializeComponent();
            _DarkModeOn = DarkModeOn;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnClick(object sender, MouseEventArgs e)
        {
            IconButton btn = (IconButton)sender;
             if (_DarkModeOn)
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
             if (_DarkModeOn)
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            }
            else
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            }
        }
    }
}
