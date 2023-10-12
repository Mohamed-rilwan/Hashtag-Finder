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
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.Hashtags = new System.Windows.Forms.ListBox();
            this.AddHashtag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.CheckBox();
            this.travel = new System.Windows.Forms.CheckBox();
            this.animal = new System.Windows.Forms.CheckBox();
            this.removeAddedTag = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MovePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.closeBtn.Image = global::HashtagFinder.Properties.Resources.cancel_30px;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(731, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 37);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hashtag Finder";
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Controls.Add(this.minimizeBtn);
            this.MovePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(800, 63);
            this.MovePanel.TabIndex = 15;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            this.MovePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseUp);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeBtn.Image = global::HashtagFinder.Properties.Resources.minus_30px;
            this.minimizeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeBtn.Location = new System.Drawing.Point(684, 11);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(41, 37);
            this.minimizeBtn.TabIndex = 16;
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hashtags
            // 
            this.Hashtags.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hashtags.FormattingEnabled = true;
            this.Hashtags.ItemHeight = 24;
            this.Hashtags.Location = new System.Drawing.Point(383, 155);
            this.Hashtags.Name = "Hashtags";
            this.Hashtags.Size = new System.Drawing.Size(369, 196);
            this.Hashtags.TabIndex = 2;
            // 
            // AddHashtag
            // 
            this.AddHashtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHashtag.Location = new System.Drawing.Point(428, 109);
            this.AddHashtag.Name = "AddHashtag";
            this.AddHashtag.Size = new System.Drawing.Size(254, 27);
            this.AddHashtag.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Hashtag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose Topic";
            // 
            // bird
            // 
            this.bird.AutoSize = true;
            this.bird.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bird.ForeColor = System.Drawing.Color.White;
            this.bird.Location = new System.Drawing.Point(48, 199);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(75, 34);
            this.bird.TabIndex = 6;
            this.bird.Text = "Bird";
            this.bird.UseVisualStyleBackColor = true;
            this.bird.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // travel
            // 
            this.travel.AutoSize = true;
            this.travel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travel.ForeColor = System.Drawing.Color.White;
            this.travel.Location = new System.Drawing.Point(48, 278);
            this.travel.Name = "travel";
            this.travel.Size = new System.Drawing.Size(103, 34);
            this.travel.TabIndex = 7;
            this.travel.Text = "Travel";
            this.travel.UseVisualStyleBackColor = true;
            this.travel.CheckedChanged += new System.EventHandler(this.travel_CheckedChanged);
            // 
            // animal
            // 
            this.animal.AutoSize = true;
            this.animal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animal.ForeColor = System.Drawing.Color.White;
            this.animal.Location = new System.Drawing.Point(48, 361);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(116, 34);
            this.animal.TabIndex = 8;
            this.animal.Text = "Animal";
            this.animal.UseVisualStyleBackColor = true;
            this.animal.CheckedChanged += new System.EventHandler(this.animal_CheckedChanged);
            // 
            // removeAddedTag
            // 
            this.removeAddedTag.BackColor = System.Drawing.Color.MidnightBlue;
            this.removeAddedTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeAddedTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAddedTag.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAddedTag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.removeAddedTag.Image = global::HashtagFinder.Properties.Resources.reduce_30px;
            this.removeAddedTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeAddedTag.Location = new System.Drawing.Point(721, 103);
            this.removeAddedTag.Name = "removeAddedTag";
            this.removeAddedTag.Size = new System.Drawing.Size(50, 37);
            this.removeAddedTag.TabIndex = 16;
            this.removeAddedTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeAddedTag.UseVisualStyleBackColor = false;
            this.removeAddedTag.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkGray;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::HashtagFinder.Properties.Resources.save_30px;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(238, 451);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(219, 37);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save as text file";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.EnabledChanged += new System.EventHandler(this.saveBtn_EnabledChanged);
            this.saveBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.MidnightBlue;
            this.copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.copy.Image = global::HashtagFinder.Properties.Resources.copy_30px;
            this.copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copy.Location = new System.Drawing.Point(711, 363);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(41, 37);
            this.copy.TabIndex = 14;
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
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
            this.generateBtn.Location = new System.Drawing.Point(441, 363);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(241, 37);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "Generate Hashtag";
            this.generateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
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
            this.AddBtn.Location = new System.Drawing.Point(685, 103);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(50, 37);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.removeAddedTag);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.travel);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddHashtag);
            this.Controls.Add(this.Hashtags);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MovePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Hashtags;
        private System.Windows.Forms.TextBox AddHashtag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox bird;
        private System.Windows.Forms.CheckBox travel;
        private System.Windows.Forms.CheckBox animal;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeAddedTag;
    }
}

