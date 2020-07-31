
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

namespace Hashtag_Finder
{
    public partial class Home : Form
    {
        int type = 4;
        private GroupBox box;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void MovePanel_MouseDown_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void MovePanel_MouseMove_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 700;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void MovePanel_MouseUp_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> test1 = new List<string>();
            List<string> test2 = new List<string>();
            //FullWidthToHalfWidth.FwHw(test1,test2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(bird.Checked)
            {
                type = 1;
            }
            else
            {
                type = 4;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Hashtag_Finder.HashtagFinder.HashtagFind(AddHashtag.Text, type);
        }

        private void travel_CheckedChanged(object sender, EventArgs e)
        {
            if (travel.Checked)
            {
                type = 2;
            }
            else
            {
                type = 4;
            }
        }

        private void animal_CheckedChanged(object sender, EventArgs e)
        {
            if (animal.Checked)
            {
                type = 3;
            }
            else
            {
                type = 4;
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
    class ElipseControl : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
            );
        private Control _cntrl;
        private int _CornerRadius = 30;

        public Control TargetControl
        {
            get { return _cntrl; }
            set
            {
                _cntrl = value;
                _cntrl.SizeChanged += (sender, eventArgs) => _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
            }
        }

        public int CornerRadius
        {
            get { return _CornerRadius; }
            set
            {
                _CornerRadius = value;
                if (_cntrl != null)
                    _cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _cntrl.Width, _cntrl.Height, _CornerRadius, _CornerRadius));
            }
        }
    }
}
