namespace PschyHealth
{
    partial class frmArchive
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
            this.cmbFolder = new MetroFramework.Controls.MetroComboBox();
            this.cmbFile = new MetroFramework.Controls.MetroComboBox();
            this.lbArcList = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(17, 50);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(28, 22);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 45;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // cmbFolder
            // 
            this.cmbFolder.FormattingEnabled = true;
            this.cmbFolder.ItemHeight = 23;
            this.cmbFolder.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "null"});
            this.cmbFolder.Location = new System.Drawing.Point(81, 169);
            this.cmbFolder.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(135, 29);
            this.cmbFolder.TabIndex = 62;
            this.cmbFolder.UseSelectable = true;
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // cmbFile
            // 
            this.cmbFile.FormattingEnabled = true;
            this.cmbFile.ItemHeight = 23;
            this.cmbFile.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "null"});
            this.cmbFile.Location = new System.Drawing.Point(291, 169);
            this.cmbFile.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFile.Name = "cmbFile";
            this.cmbFile.Size = new System.Drawing.Size(151, 29);
            this.cmbFile.TabIndex = 63;
            this.cmbFile.UseSelectable = true;
            this.cmbFile.SelectedIndexChanged += new System.EventHandler(this.cmbFile_SelectedIndexChanged);
            // 
            // lbArcList
            // 
            this.lbArcList.FormattingEnabled = true;
            this.lbArcList.Location = new System.Drawing.Point(274, 246);
            this.lbArcList.Name = "lbArcList";
            this.lbArcList.Size = new System.Drawing.Size(591, 264);
            this.lbArcList.TabIndex = 64;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(883, 208);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 65;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // frmArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 627);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lbArcList);
            this.Controls.Add(this.cmbFile);
            this.Controls.Add(this.cmbFolder);
            this.Controls.Add(this.pbMic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmArchive";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "frmArchive";
            this.Load += new System.EventHandler(this.frmArchive_Load);
            this.Shown += new System.EventHandler(this.frmArchive_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroComboBox cmbFolder;
        private MetroFramework.Controls.MetroComboBox cmbFile;
        private System.Windows.Forms.ListBox lbArcList;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}