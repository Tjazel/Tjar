namespace PschyHealth.Forms
{
    partial class frmRecord
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
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.rdPlay = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdPause = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdSave = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdRecord = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPlayBack = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.pbWave = new System.Windows.Forms.PictureBox();
            this.pbRec = new System.Windows.Forms.PictureBox();
            this.lblPlayName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRec)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(212, 39);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(75, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rdPlay
            // 
            this.rdPlay.Name = "rdPlay";
            this.rdPlay.Symbol = "";
            this.rdPlay.Text = "Play";
            // 
            // rdPause
            // 
            this.rdPause.Name = "rdPause";
            this.rdPause.Symbol = "";
            this.rdPause.Text = "Pause";
            // 
            // rdSave
            // 
            this.rdSave.Name = "rdSave";
            this.rdSave.Symbol = "";
            this.rdSave.Text = "Save/Stop";
            // 
            // rdRecord
            // 
            this.rdRecord.Name = "rdRecord";
            this.rdRecord.Symbol = "";
            this.rdRecord.Text = "Record";
            // 
            // radialMenu1
            // 
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rdRecord,
            this.rdSave,
            this.rdPause,
            this.rdPlay});
            this.radialMenu1.Location = new System.Drawing.Point(207, 150);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(80, 80);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 30F;
            this.radialMenu1.TabIndex = 0;
            this.radialMenu1.Text = "radialMenu1";
            // 
            // lblPlayBack
            // 
            this.lblPlayBack.AutoSize = true;
            this.lblPlayBack.Location = new System.Drawing.Point(184, 127);
            this.lblPlayBack.Name = "lblPlayBack";
            this.lblPlayBack.Size = new System.Drawing.Size(136, 20);
            this.lblPlayBack.TabIndex = 56;
            this.lblPlayBack.Text = "Playback in progress";
            this.lblPlayBack.UseStyleColors = true;
            this.lblPlayBack.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTime.Location = new System.Drawing.Point(216, 93);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 0);
            this.lblTime.TabIndex = 53;
            // 
            // pbWave
            // 
            this.pbWave.Image = global::PschyHealth.Properties.Resources.Audio_Wave_48px_3;
            this.pbWave.Location = new System.Drawing.Point(222, 78);
            this.pbWave.Name = "pbWave";
            this.pbWave.Size = new System.Drawing.Size(60, 46);
            this.pbWave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWave.TabIndex = 55;
            this.pbWave.TabStop = false;
            this.pbWave.Visible = false;
            // 
            // pbRec
            // 
            this.pbRec.Image = global::PschyHealth.Properties.Resources.Record_48px_4;
            this.pbRec.Location = new System.Drawing.Point(338, 127);
            this.pbRec.Name = "pbRec";
            this.pbRec.Size = new System.Drawing.Size(26, 16);
            this.pbRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRec.TabIndex = 54;
            this.pbRec.TabStop = false;
            this.pbRec.Visible = false;
            // 
            // lblPlayName
            // 
            this.lblPlayName.AutoSize = true;
            this.lblPlayName.Location = new System.Drawing.Point(212, 16);
            this.lblPlayName.Name = "lblPlayName";
            this.lblPlayName.Size = new System.Drawing.Size(0, 0);
            this.lblPlayName.TabIndex = 57;
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 253);
            this.Controls.Add(this.lblPlayName);
            this.Controls.Add(this.lblPlayBack);
            this.Controls.Add(this.pbWave);
            this.Controls.Add(this.pbRec);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radialMenu1);
            this.Name = "frmRecord";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.frmRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtName;
        private DevComponents.DotNetBar.RadialMenuItem rdPlay;
        private DevComponents.DotNetBar.RadialMenuItem rdPause;
        private DevComponents.DotNetBar.RadialMenuItem rdSave;
        private DevComponents.DotNetBar.RadialMenuItem rdRecord;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblPlayBack;
        private System.Windows.Forms.PictureBox pbWave;
        private System.Windows.Forms.PictureBox pbRec;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblPlayName;
    }
}