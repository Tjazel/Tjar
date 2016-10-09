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
            this.btnTax = new MetroFramework.Controls.MetroTile();
            this.btnAnalysis = new MetroFramework.Controls.MetroTile();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.cmbYear = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatistics
            // 
            // 
            // 
            // 
            this.txtStatistics.CustomButton.Image = null;
            this.txtStatistics.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtStatistics.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatistics.CustomButton.Name = "";
            this.txtStatistics.CustomButton.Size = new System.Drawing.Size(149, 149);
            this.txtStatistics.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatistics.CustomButton.TabIndex = 1;
            this.txtStatistics.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatistics.CustomButton.UseSelectable = true;
            this.txtStatistics.CustomButton.Visible = false;
            this.txtStatistics.Lines = new string[0];
            this.txtStatistics.Location = new System.Drawing.Point(165, 63);
            this.txtStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatistics.MaxLength = 32767;
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.PasswordChar = '\0';
            this.txtStatistics.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatistics.SelectedText = "";
            this.txtStatistics.SelectionLength = 0;
            this.txtStatistics.SelectionStart = 0;
            this.txtStatistics.Size = new System.Drawing.Size(335, 154);
            this.txtStatistics.TabIndex = 0;
            this.txtStatistics.UseSelectable = true;
            this.txtStatistics.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatistics.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnTax
            // 
            this.btnTax.ActiveControl = null;
            this.btnTax.Location = new System.Drawing.Point(165, 230);
            this.btnTax.Margin = new System.Windows.Forms.Padding(2);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(119, 36);
            this.btnTax.TabIndex = 1;
            this.btnTax.Text = "Maandeliks";
            this.btnTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTax.UseSelectable = true;
            this.btnTax.Click += new System.EventHandler(this.btnMaandelikseGeld_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.ActiveControl = null;
            this.btnAnalysis.Location = new System.Drawing.Point(381, 230);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(119, 36);
            this.btnAnalysis.TabIndex = 2;
            this.btnAnalysis.Text = "Geldvloei";
            this.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnalysis.UseSelectable = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnGeldvloei_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBack.Location = new System.Drawing.Point(64, 54);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(48, 25);
            this.lblBack.TabIndex = 103;
            this.lblBack.Text = "Back";
            this.lblBack.UseStyleColors = true;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(32, 50);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(28, 23);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 102;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 23;
            this.cmbYear.Location = new System.Drawing.Point(18, 127);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 29);
            this.cmbYear.TabIndex = 104;
            this.cmbYear.UseSelectable = true;
            this.cmbYear.UseStyleColors = true;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 327);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.txtStatistics);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStatistics";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtStatistics;
        private MetroFramework.Controls.MetroTile btnTax;
        private MetroFramework.Controls.MetroTile btnAnalysis;
        private MetroFramework.Controls.MetroLabel lblBack;
        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroComboBox cmbYear;
    }
}