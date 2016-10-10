namespace PschyHealth
{
    partial class frmSettings
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
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.btnUserManagment = new MetroFramework.Controls.MetroTile();
            this.LogActivity = new MetroFramework.Controls.MetroTile();
            this.btnAdmin = new MetroFramework.Controls.MetroTile();
            this.tnAbout = new MetroFramework.Controls.MetroTile();
            this.btnHelp = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(0, 62);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(30, 22);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 41;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // btnUserManagment
            // 
            this.btnUserManagment.ActiveControl = null;
            this.btnUserManagment.Location = new System.Drawing.Point(0, 291);
            this.btnUserManagment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserManagment.Name = "btnUserManagment";
            this.btnUserManagment.Size = new System.Drawing.Size(209, 38);
            this.btnUserManagment.TabIndex = 42;
            this.btnUserManagment.Text = "User managment";
            this.btnUserManagment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUserManagment.UseSelectable = true;
            // 
            // LogActivity
            // 
            this.LogActivity.ActiveControl = null;
            this.LogActivity.Location = new System.Drawing.Point(0, 334);
            this.LogActivity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogActivity.Name = "LogActivity";
            this.LogActivity.Size = new System.Drawing.Size(209, 38);
            this.LogActivity.TabIndex = 43;
            this.LogActivity.Text = "Log activity";
            this.LogActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogActivity.UseSelectable = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.ActiveControl = null;
            this.btnAdmin.Location = new System.Drawing.Point(0, 377);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(209, 38);
            this.btnAdmin.TabIndex = 44;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmin.UseSelectable = true;
            // 
            // tnAbout
            // 
            this.tnAbout.ActiveControl = null;
            this.tnAbout.Location = new System.Drawing.Point(0, 420);
            this.tnAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tnAbout.Name = "tnAbout";
            this.tnAbout.Size = new System.Drawing.Size(209, 38);
            this.tnAbout.TabIndex = 45;
            this.tnAbout.Text = "About";
            this.tnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tnAbout.UseSelectable = true;
            // 
            // btnHelp
            // 
            this.btnHelp.ActiveControl = null;
            this.btnHelp.Location = new System.Drawing.Point(0, 463);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(209, 38);
            this.btnHelp.TabIndex = 46;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.UseSelectable = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 653);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tnAbout);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.LogActivity);
            this.Controls.Add(this.btnUserManagment);
            this.Controls.Add(this.pbMic);
            this.MaximumSize = new System.Drawing.Size(209, 791);
            this.MinimumSize = new System.Drawing.Size(209, 616);
            this.Movable = false;
            this.Name = "frmSettings";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroTile btnUserManagment;
        private MetroFramework.Controls.MetroTile LogActivity;
        private MetroFramework.Controls.MetroTile btnAdmin;
        private MetroFramework.Controls.MetroTile tnAbout;
        private MetroFramework.Controls.MetroTile btnHelp;
    }
}