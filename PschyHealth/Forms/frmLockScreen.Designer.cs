namespace PschyHealth
{
    partial class frmLockScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLockScreen));
            this.mtxb_Password = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ctxLock = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtxb_Username = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ctxLock.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxb_Password
            // 
            this.mtxb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mtxb_Password.CustomButton.Image = null;
            this.mtxb_Password.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.mtxb_Password.CustomButton.Name = "";
            this.mtxb_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxb_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Password.CustomButton.TabIndex = 1;
            this.mtxb_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Password.CustomButton.UseSelectable = true;
            this.mtxb_Password.CustomButton.Visible = false;
            this.mtxb_Password.Lines = new string[0];
            this.mtxb_Password.Location = new System.Drawing.Point(705, 604);
            this.mtxb_Password.MaxLength = 32767;
            this.mtxb_Password.Name = "mtxb_Password";
            this.mtxb_Password.PasswordChar = '*';
            this.mtxb_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Password.SelectedText = "";
            this.mtxb_Password.SelectionLength = 0;
            this.mtxb_Password.SelectionStart = 0;
            this.mtxb_Password.Size = new System.Drawing.Size(147, 23);
            this.mtxb_Password.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtxb_Password.TabIndex = 10;
            this.mtxb_Password.UseSelectable = true;
            this.mtxb_Password.WaterMark = "Enter Password";
            this.mtxb_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(700, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Locked";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(697, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PschyHealth.Properties.Resources.swat;
            this.pictureBox1.Location = new System.Drawing.Point(705, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(839, 604);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PschyHealth.Properties.Resources.ic_power_settings_new_white_24dp_2x;
            this.pictureBox3.Location = new System.Drawing.Point(641, 545);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ctxLock
            // 
            this.ctxLock.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxLock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ctxLock.Name = "ctxLock";
            this.ctxLock.Size = new System.Drawing.Size(135, 48);
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.switchToolStripMenuItem.Text = "Switch user";
            this.switchToolStripMenuItem.Click += new System.EventHandler(this.switchToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mtxb_Username
            // 
            this.mtxb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mtxb_Username.CustomButton.Image = null;
            this.mtxb_Username.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.mtxb_Username.CustomButton.Name = "";
            this.mtxb_Username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxb_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxb_Username.CustomButton.TabIndex = 1;
            this.mtxb_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxb_Username.CustomButton.UseSelectable = true;
            this.mtxb_Username.CustomButton.Visible = false;
            this.mtxb_Username.Lines = new string[0];
            this.mtxb_Username.Location = new System.Drawing.Point(705, 575);
            this.mtxb_Username.MaxLength = 32767;
            this.mtxb_Username.Name = "mtxb_Username";
            this.mtxb_Username.PasswordChar = '*';
            this.mtxb_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxb_Username.SelectedText = "";
            this.mtxb_Username.SelectionLength = 0;
            this.mtxb_Username.SelectionStart = 0;
            this.mtxb_Username.Size = new System.Drawing.Size(134, 23);
            this.mtxb_Username.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtxb_Username.TabIndex = 14;
            this.mtxb_Username.UseSelectable = true;
            this.mtxb_Username.WaterMark = "Enter Username";
            this.mtxb_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxb_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmLockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PschyHealth.Properties.Resources.WDF_653938;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 804);
            this.Controls.Add(this.mtxb_Username);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtxb_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLockScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLockScreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLockScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ctxLock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox mtxb_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroContextMenu ctxLock;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox mtxb_Username;
    }
}