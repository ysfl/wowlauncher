namespace Launcher
{
    partial class MainLauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLauncherForm));
            this.PlayButton = new System.Windows.Forms.Button();
            this.CacheButton = new System.Windows.Forms.Button();
            this.VoteButton = new System.Windows.Forms.Button();
            this.WebsiteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.BackgroundImage = global::Launcher.Properties.Resources.launcher1_03;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Image = global::Launcher.Properties.Resources.launcher1_03;
            this.PlayButton.Location = new System.Drawing.Point(574, 404);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(198, 84);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.TabStop = false;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // CacheButton
            // 
            this.CacheButton.BackgroundImage = global::Launcher.Properties.Resources.launcher1_06;
            this.CacheButton.FlatAppearance.BorderSize = 0;
            this.CacheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CacheButton.Location = new System.Drawing.Point(24, 425);
            this.CacheButton.Name = "CacheButton";
            this.CacheButton.Size = new System.Drawing.Size(135, 63);
            this.CacheButton.TabIndex = 1;
            this.CacheButton.UseVisualStyleBackColor = true;
            this.CacheButton.Click += new System.EventHandler(this.CacheButton_Click);
            // 
            // VoteButton
            // 
            this.VoteButton.BackgroundImage = global::Launcher.Properties.Resources.launcher1_08;
            this.VoteButton.FlatAppearance.BorderSize = 0;
            this.VoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoteButton.Location = new System.Drawing.Point(171, 425);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(135, 63);
            this.VoteButton.TabIndex = 2;
            this.VoteButton.UseVisualStyleBackColor = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // WebsiteButton
            // 
            this.WebsiteButton.BackgroundImage = global::Launcher.Properties.Resources.launcher1_10;
            this.WebsiteButton.FlatAppearance.BorderSize = 0;
            this.WebsiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebsiteButton.Location = new System.Drawing.Point(318, 425);
            this.WebsiteButton.Name = "WebsiteButton";
            this.WebsiteButton.Size = new System.Drawing.Size(135, 63);
            this.WebsiteButton.TabIndex = 3;
            this.WebsiteButton.UseVisualStyleBackColor = true;
            this.WebsiteButton.Click += new System.EventHandler(this.WebsiteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(778, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 20);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "C:";
            this.openFileDialog1.Title = "Select Wow.exe";
            // 
            // MainLauncherForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.launcher1;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WebsiteButton);
            this.Controls.Add(this.VoteButton);
            this.Controls.Add(this.CacheButton);
            this.Controls.Add(this.PlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainLauncherForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.MainLauncherForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainLauncherForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button CacheButton;
        private System.Windows.Forms.Button VoteButton;
        private System.Windows.Forms.Button WebsiteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

