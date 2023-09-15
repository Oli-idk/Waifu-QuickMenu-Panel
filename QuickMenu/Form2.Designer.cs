namespace QuickMenu
{
    partial class TestPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPage));
            this.SongName = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NextPage = new System.Windows.Forms.Button();
            this.PrevPage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Skip = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.SessionCount = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SessionName = new System.Windows.Forms.Label();
            this.SongProgress = new QuickMenu.Resources.Custom_Controls.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.SongName.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SongName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SongName.Location = new System.Drawing.Point(12, 9);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(134, 29);
            this.SongName.TabIndex = 7;
            this.SongName.Text = "Song Name";
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.Artist.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Artist.Location = new System.Drawing.Point(12, 38);
            this.Artist.Name = "Artist";
            this.Artist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Artist.Size = new System.Drawing.Size(72, 29);
            this.Artist.TabIndex = 8;
            this.Artist.Text = "Artist";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(8, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NextPage.CausesValidation = false;
            this.NextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextPage.Image = global::QuickMenu.Properties.Resources.big_button;
            this.NextPage.Location = new System.Drawing.Point(288, 261);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(96, 35);
            this.NextPage.TabIndex = 3;
            this.NextPage.Text = "Next";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PrevPage
            // 
            this.PrevPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PrevPage.CausesValidation = false;
            this.PrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PrevPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PrevPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevPage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrevPage.Image = global::QuickMenu.Properties.Resources.big_button;
            this.PrevPage.Location = new System.Drawing.Point(8, 261);
            this.PrevPage.Name = "PrevPage";
            this.PrevPage.Size = new System.Drawing.Size(96, 35);
            this.PrevPage.TabIndex = 2;
            this.PrevPage.Text = "Prev";
            this.PrevPage.UseVisualStyleBackColor = false;
            this.PrevPage.Click += new System.EventHandler(this.PrevPage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-90, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 333);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Skip
            // 
            this.Skip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Skip.CausesValidation = false;
            this.Skip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Skip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Skip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Skip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skip.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Skip.Image = global::QuickMenu.Properties.Resources.big_button;
            this.Skip.Location = new System.Drawing.Point(288, 229);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(30, 30);
            this.Skip.TabIndex = 12;
            this.Skip.Text = ">";
            this.Skip.UseVisualStyleBackColor = false;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Prev
            // 
            this.Prev.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Prev.CausesValidation = false;
            this.Prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Prev.Image = global::QuickMenu.Properties.Resources.big_button;
            this.Prev.Location = new System.Drawing.Point(74, 229);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(30, 30);
            this.Prev.TabIndex = 13;
            this.Prev.Text = "<";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // SessionCount
            // 
            this.SessionCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.SessionCount.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SessionCount.Location = new System.Drawing.Point(110, 261);
            this.SessionCount.Name = "SessionCount";
            this.SessionCount.Size = new System.Drawing.Size(172, 36);
            this.SessionCount.TabIndex = 14;
            this.SessionCount.Text = "0/0";
            this.SessionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.pictureBox3.Location = new System.Drawing.Point(-7, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(410, 86);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // SessionName
            // 
            this.SessionName.AutoSize = true;
            this.SessionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.SessionName.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SessionName.Location = new System.Drawing.Point(12, 67);
            this.SessionName.Name = "SessionName";
            this.SessionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SessionName.Size = new System.Drawing.Size(106, 29);
            this.SessionName.TabIndex = 16;
            this.SessionName.Text = "Program";
            // 
            // SongProgress
            // 
            this.SongProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.SongProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.SongProgress.Location = new System.Drawing.Point(110, 229);
            this.SongProgress.Name = "SongProgress";
            this.SongProgress.Size = new System.Drawing.Size(172, 30);
            this.SongProgress.TabIndex = 10;
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 308);
            this.Controls.Add(this.SessionName);
            this.Controls.Add(this.SessionCount);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.SongProgress);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.PrevPage);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestPage";
            this.Text = "Media Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PrevPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label Artist;
        private Resources.Custom_Controls.CustomProgressBar SongProgress;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Label SessionCount;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label SessionName;
    }
}