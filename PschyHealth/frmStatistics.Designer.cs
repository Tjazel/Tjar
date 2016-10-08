namespace PschyHealth
{
    partial class frmStatistics
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
            this.txtStatistics = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.pbMic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatistics
            // 
            // 
            // 
            // 
            this.txtStatistics.CustomButton.Image = null;
            this.txtStatistics.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.txtStatistics.CustomButton.Name = "";
            this.txtStatistics.CustomButton.Size = new System.Drawing.Size(185, 185);
            this.txtStatistics.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatistics.CustomButton.TabIndex = 1;
            this.txtStatistics.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatistics.CustomButton.UseSelectable = true;
            this.txtStatistics.CustomButton.Visible = false;
            this.txtStatistics.Lines = new string[0];
            this.txtStatistics.Location = new System.Drawing.Point(220, 77);
            this.txtStatistics.MaxLength = 32767;
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.PasswordChar = '\0';
            this.txtStatistics.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatistics.SelectedText = "";
            this.txtStatistics.SelectionLength = 0;
            this.txtStatistics.SelectionStart = 0;
            this.txtStatistics.Size = new System.Drawing.Size(447, 190);
            this.txtStatistics.TabIndex = 0;
            this.txtStatistics.UseSelectable = true;
            this.txtStatistics.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatistics.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(220, 283);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(159, 44);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Elke maand";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(508, 283);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(159, 44);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Huidige maand";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBack.Location = new System.Drawing.Point(85, 66);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(51, 25);
            this.lblBack.TabIndex = 103;
            this.lblBack.Text = "Back";
            this.lblBack.UseStyleColors = true;
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(42, 62);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(38, 28);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 102;
            this.pbMic.TabStop = false;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 402);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txtStatistics);
            this.Name = "frmStatistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtStatistics;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel lblBack;
        private System.Windows.Forms.PictureBox pbMic;
    }
}