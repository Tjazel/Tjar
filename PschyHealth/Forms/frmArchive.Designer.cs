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
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(23, 62);
            this.pbMic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(37, 27);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 45;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // frmArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 772);
            this.Controls.Add(this.pbMic);
            this.Name = "frmArchive";
            this.Text = "frmArchive";
            this.Load += new System.EventHandler(this.frmArchive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMic;
    }
}