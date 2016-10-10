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
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbRec = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.rdRecord = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdSave = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdPause = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdPlay = new DevComponents.DotNetBar.RadialMenuItem();
            this.pbWave = new System.Windows.Forms.PictureBox();
            this.lblPlayBack = new MetroFramework.Controls.MetroLabel();
            this.msmRecording = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblPlayName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmRecording)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(152, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(60, 19);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTime.Location = new System.Drawing.Point(155, 77);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 0);
            this.lblTime.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbRec
            // 
            this.pbRec.Image = global::PschyHealth.Properties.Resources.Record_48px_3;
            this.pbRec.Location = new System.Drawing.Point(244, 88);
            this.pbRec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRec.Name = "pbRec";
            this.pbRec.Size = new System.Drawing.Size(20, 13);
            this.pbRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRec.TabIndex = 50;
            this.pbRec.TabStop = false;
            this.pbRec.Visible = false;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = global::PschyHealth.Properties.Resources.Minimize_Window_48px;
            this.pbMinimize.Location = new System.Drawing.Point(298, 9);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(23, 23);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 49;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::PschyHealth.Properties.Resources.Close_Window_48px;
            this.pbExit.Location = new System.Drawing.Point(327, 9);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(22, 23);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 48;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // radialMenu1
            // 
            this.radialMenu1.Image = global::PschyHealth.Properties.Resources.Tape_Drive_48px_1;
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rdRecord,
            this.rdSave,
            this.rdPause,
            this.rdPlay});
            this.radialMenu1.Location = new System.Drawing.Point(152, 130);
            this.radialMenu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(60, 65);
            this.radialMenu1.SymbolSize = 30F;
            this.radialMenu1.TabIndex = 0;
            this.radialMenu1.Text = "radialMenu1";
            // 
            // rdRecord
            // 
            this.rdRecord.Name = "rdRecord";
            this.rdRecord.Symbol = "";
            this.rdRecord.Text = "Record";
            this.rdRecord.Click += new System.EventHandler(this.rdRecord_Click);
            // 
            // rdSave
            // 
            this.rdSave.Name = "rdSave";
            this.rdSave.Symbol = "";
            this.rdSave.Text = "Save/Stop";
            this.rdSave.Click += new System.EventHandler(this.rdSave_Click);
            // 
            // rdPause
            // 
            this.rdPause.Name = "rdPause";
            this.rdPause.Symbol = "";
            this.rdPause.Text = "Pause";
            this.rdPause.Click += new System.EventHandler(this.rdPause_Click);
            // 
            // rdPlay
            // 
            this.rdPlay.Name = "rdPlay";
            this.rdPlay.Symbol = "";
            this.rdPlay.Text = "Play";
            this.rdPlay.Click += new System.EventHandler(this.rdPlay_Click);
            // 
            // pbWave
            // 
            this.pbWave.Image = global::PschyHealth.Properties.Resources.Audio_Wave_48px_1;
            this.pbWave.Location = new System.Drawing.Point(160, 63);
            this.pbWave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbWave.Name = "pbWave";
            this.pbWave.Size = new System.Drawing.Size(45, 37);
            this.pbWave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWave.TabIndex = 51;
            this.pbWave.TabStop = false;
            this.pbWave.Visible = false;
            // 
            // lblPlayBack
            // 
            this.lblPlayBack.AutoSize = true;
            this.lblPlayBack.Location = new System.Drawing.Point(134, 103);
            this.lblPlayBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayBack.Name = "lblPlayBack";
            this.lblPlayBack.Size = new System.Drawing.Size(129, 19);
            this.lblPlayBack.TabIndex = 52;
            this.lblPlayBack.Text = "Playback in progress";
            this.lblPlayBack.UseStyleColors = true;
            this.lblPlayBack.Visible = false;
            // 
            // msmRecording
            // 
            this.msmRecording.Owner = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(160, 6);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "Name";
            // 
            // lblPlayName
            // 
            this.lblPlayName.AutoSize = true;
            this.lblPlayName.Location = new System.Drawing.Point(66, 81);
            this.lblPlayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayName.Name = "lblPlayName";
            this.lblPlayName.Size = new System.Drawing.Size(0, 0);
            this.lblPlayName.TabIndex = 54;
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(354, 206);
            this.Controls.Add(this.lblPlayName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblPlayBack);
            this.Controls.Add(this.pbWave);
            this.Controls.Add(this.pbRec);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radialMenu1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRecord";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.frmRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmRecording)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem rdRecord;
        private DevComponents.DotNetBar.RadialMenuItem rdSave;
        private DevComponents.DotNetBar.RadialMenuItem rdPause;
        private DevComponents.DotNetBar.RadialMenuItem rdPlay;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbRec;
        private System.Windows.Forms.PictureBox pbWave;
        private MetroFramework.Controls.MetroLabel lblPlayBack;
        private MetroFramework.Components.MetroStyleManager msmRecording;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblPlayName;
    }
}