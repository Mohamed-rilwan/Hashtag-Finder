namespace Hashtag_Finder
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Hashtags = new System.Windows.Forms.ListBox();
            this.AddHashtag = new System.Windows.Forms.TextBox();
            this.textFile = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.CheckBox();
            this.travel = new System.Windows.Forms.CheckBox();
            this.animal = new System.Windows.Forms.CheckBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hashtag Finder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hashtags
            // 
            this.Hashtags.FormattingEnabled = true;
            this.Hashtags.Location = new System.Drawing.Point(383, 165);
            this.Hashtags.Name = "Hashtags";
            this.Hashtags.Size = new System.Drawing.Size(369, 225);
            this.Hashtags.TabIndex = 2;
            // 
            // AddHashtag
            // 
            this.AddHashtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHashtag.Location = new System.Drawing.Point(440, 122);
            this.AddHashtag.Name = "AddHashtag";
            this.AddHashtag.Size = new System.Drawing.Size(254, 26);
            this.AddHashtag.TabIndex = 3;
            this.AddHashtag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textFile
            // 
            this.textFile.AutoSize = true;
            this.textFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFile.ForeColor = System.Drawing.Color.White;
            this.textFile.Location = new System.Drawing.Point(266, 460);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(182, 28);
            this.textFile.TabIndex = 4;
            this.textFile.Text = "Export to Text File";
            this.textFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Hashtag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose Topic";
            // 
            // bird
            // 
            this.bird.AutoSize = true;
            this.bird.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bird.ForeColor = System.Drawing.Color.White;
            this.bird.Location = new System.Drawing.Point(48, 195);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(62, 28);
            this.bird.TabIndex = 6;
            this.bird.Text = "Bird";
            this.bird.UseVisualStyleBackColor = true;
            this.bird.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // travel
            // 
            this.travel.AutoSize = true;
            this.travel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travel.ForeColor = System.Drawing.Color.White;
            this.travel.Location = new System.Drawing.Point(48, 278);
            this.travel.Name = "travel";
            this.travel.Size = new System.Drawing.Size(81, 28);
            this.travel.TabIndex = 7;
            this.travel.Text = "Travel";
            this.travel.UseVisualStyleBackColor = true;
            this.travel.CheckedChanged += new System.EventHandler(this.travel_CheckedChanged);
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animal.ForeColor = System.Drawing.Color.White;
            this.animal.Location = new System.Drawing.Point(48, 361);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(87, 28);
            this.animal.TabIndex = 8;
            this.animal.Text = "Animal";
            this.animal.UseVisualStyleBackColor = true;
            this.animal.CheckedChanged += new System.EventHandler(this.animal_CheckedChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AddBtn.Image = global::HashtagFinder.Properties.Resources.add_new_30px1;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(702, 117);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(50, 37);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.generateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Image = global::HashtagFinder.Properties.Resources.add_new_30px1;
            this.generateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateBtn.Location = new System.Drawing.Point(469, 405);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(225, 37);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "Generate Hashtag";
            this.generateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateBtn.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.travel);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.AddHashtag);
            this.Controls.Add(this.Hashtags);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Hashtags;
        private System.Windows.Forms.TextBox AddHashtag;
        private System.Windows.Forms.CheckBox textFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox bird;
        private System.Windows.Forms.CheckBox travel;
        private System.Windows.Forms.CheckBox animal;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button generateBtn;
    }
}

