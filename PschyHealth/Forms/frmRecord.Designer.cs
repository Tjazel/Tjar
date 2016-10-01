namespace PschyHealth.Panels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecord));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTimer = new MetroFramework.Controls.MetroLabel();
            this.mtStopSave = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.mtPause = new MetroFramework.Controls.MetroTile();
            this.mtRecord = new MetroFramework.Controls.MetroTile();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(241, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(241, 82);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 0);
            this.lblTimer.TabIndex = 1;
            // 
            // mtStopSave
            // 
            this.mtStopSave.ActiveControl = null;
            this.mtStopSave.Location = new System.Drawing.Point(447, 193);
            this.mtStopSave.Name = "mtStopSave";
            this.mtStopSave.Size = new System.Drawing.Size(208, 58);
            this.mtStopSave.TabIndex = 5;
           // this.mtStopSave.TileImage = global::PschyHealth.Properties.Resources.saveB;
            this.mtStopSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStopSave.UseSelectable = true;
            this.mtStopSave.UseTileImage = true;
            // 
            // mtSave
            // 
            this.mtSave.ActiveControl = null;
            this.mtSave.Location = new System.Drawing.Point(224, 193);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(217, 58);
            this.mtSave.TabIndex = 4;
            this.mtSave.TileImage = global::PschyHealth.Properties.Resources.playB;
            this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSave.UseSelectable = true;
            this.mtSave.UseTileImage = true;
            // 
            // mtPause
            // 
            this.mtPause.ActiveControl = null;
            this.mtPause.Location = new System.Drawing.Point(10, 193);
            this.mtPause.Name = "mtPause";
            this.mtPause.Size = new System.Drawing.Size(208, 58);
            this.mtPause.TabIndex = 3;
            this.mtPause.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPause.TileImage")));
            this.mtPause.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPause.UseSelectable = true;
            this.mtPause.UseTileImage = true;
            // 
            // mtRecord
            // 
            this.mtRecord.ActiveControl = null;
            this.mtRecord.Location = new System.Drawing.Point(10, 140);
            this.mtRecord.Name = "mtRecord";
            this.mtRecord.Size = new System.Drawing.Size(645, 47);
            this.mtRecord.TabIndex = 2;
            this.mtRecord.TileImage = global::PschyHealth.Properties.Resources.micOn;
            this.mtRecord.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRecord.UseSelectable = true;
            this.mtRecord.UseTileImage = true;
            this.mtRecord.Click += new System.EventHandler(this.mtRecord_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 265);
            this.Controls.Add(this.mtStopSave);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtPause);
            this.Controls.Add(this.mtRecord);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmRecord";
            this.RightToLeftLayout = true;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.frmRecord_Load);
            this.SizeChanged += new System.EventHandler(this.frmRecord_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblTimer;
        private MetroFramework.Controls.MetroTile mtRecord;
        private MetroFramework.Controls.MetroTile mtPause;
        private MetroFramework.Controls.MetroTile mtSave;
        private MetroFramework.Controls.MetroTile mtStopSave;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}