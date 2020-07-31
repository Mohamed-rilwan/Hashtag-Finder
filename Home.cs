
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Hashtag_Finder
{
    public partial class Home : Form
    {

        List<string> hashtags = new List<string>();
        List<string> addedTags = new List<string>();

        bool birdCheck = false, animalCheck = false, travelCheck = false;
        int type = 4;
        string allHashtags = null;
        string allAddedTags = null;
        string hashtagSample = "#Phtography";
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
            saveBtn.Enabled = false;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> test1 = new List<string>();
            List<string> test2 = new List<string>();
            //FullWidthToHalfWidth.FwHw(test1,test2);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(bird.Checked)
            {
                birdCheck = true;
            }
            else
            {
                birdCheck = false;
            }
        }

     
        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if(!(AddHashtag.Text).Contains("#"))
            {
                MessageBox.Show("Enter a valid HashTag", "Incorrect Hashtag", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(addedTags.Count != 0 )
                {
                    for (int index = 0; index < addedTags.Count; index++)
                    {
                        if (addedTags[index].Contains(AddHashtag.Text))
                        {
                            MessageBox.Show("Hashtag already added", "Hashtag Exists", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            check = true;
                        }                                                                                         
                    }

                    if(!check)
                    {
                        addedTags.Add(AddHashtag.Text);
                        Hashtags.Items.Add(AddHashtag.Text);
                    }
                }
                else
                {
                    addedTags.Add(AddHashtag.Text);
                    Hashtags.Items.Add(AddHashtag.Text);                     
                }
            }          
        }

        private void travel_CheckedChanged(object sender, EventArgs e)
        {
            if (travel.Checked )
            {
                travelCheck = true;
            }
            else
            {
                travelCheck = false;
            }
        }

        private void animal_CheckedChanged(object sender, EventArgs e)
        {
            if (animal.Checked)
            {
                animalCheck = true;
            }
            else
            {
                animalCheck = false;
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
          
            if(birdCheck && !animalCheck && !travelCheck)
            {
                type = 1;
            }
            if (!birdCheck && !animalCheck && travelCheck)
            {
                type = 2;
            }
            if (!birdCheck && animalCheck && !travelCheck)
            {
                type = 3;
            }
            if (birdCheck && animalCheck && travelCheck || animalCheck && travelCheck || birdCheck && travelCheck || animalCheck && birdCheck)
            {
                type = 4;
            }
            //if (birdCheck && animalCheck && !travelCheck)
            //{
            //    type = 5;
            //}
            //if (birdCheck && !animalCheck && travelCheck)
            //{
            //    type = 6;
            //}
            //if (!birdCheck && animalCheck && travelCheck)
            //{
            //    type = 7;
            //}
            Hashtags.Items.Clear();
            hashtags = HashtagFinder.HashtagFind(hashtagSample, type);
            for(int index=0; index < hashtags.Count; index++)
            { 
              Hashtags.Items.Add(hashtags[index]);
            }
            for (int index = 0; index < addedTags.Count; index++)
            {
                Hashtags.Items.Add(addedTags[index]);
            }
            saveBtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button5_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void MovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 500;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void MovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
      

        private void copy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.Clear();
            allHashtags = null;
            for (int index= 0; index<hashtags.Count; index++)
            {
                allHashtags = allHashtags +" "+ hashtags[index];
            }
            for (int index = 0; index < addedTags.Count; index++)
            {
                allAddedTags = allAddedTags + " " + addedTags[index];
            }
            System.Windows.Forms.Clipboard.SetText(allHashtags+allAddedTags);
            addedTags.Clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName,FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    for (int index = 0; index < hashtags.Count; index++)
                    {
                        allHashtags = allHashtags + " " + hashtags[index];
                        sw.WriteLine(hashtags[index]); 
                    }
                    for (int index = 0; index < addedTags.Count; index++)
                    {
                        allAddedTags = allAddedTags + " " + addedTags[index];
                        sw.WriteLine(addedTags[index]);
                    }
                    sw.WriteLine(" ");
                    sw.WriteLine(allHashtags + allAddedTags);  
                }
            }
            addedTags.Clear();
        }

        private void saveBtn_EnabledChanged(object sender, EventArgs e)
        {
            var saveBtn = (Button)sender;
            saveBtn.BackColor = saveBtn.Enabled ? Color.MidnightBlue : Color.DarkGray;        
    }

        private void MovePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
