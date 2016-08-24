namespace PschyHealth
{
    partial class pnlSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlSettings));
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.icSettings = new DevComponents.DotNetBar.ItemContainer();
            this.btnUpdates = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnUserManagment = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnLogActivity = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnPersonalization = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnAbout = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnHelp = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnBackup = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnRecord = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SuspendLayout();
            // 
            // metroTilePanel1
            // 
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.EnableDragDrop = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.icSettings});
            this.metroTilePanel1.Location = new System.Drawing.Point(25, 25);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(859, 613);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            this.metroTilePanel1.ItemClick += new System.EventHandler(this.metroTilePanel1_ItemClick);
            // 
            // icSettings
            // 
            // 
            // 
            // 
            this.icSettings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.icSettings.ItemSpacing = 30;
            this.icSettings.MinimumSize = new System.Drawing.Size(800, 500);
            this.icSettings.MultiLine = true;
            this.icSettings.Name = "icSettings";
            this.icSettings.ResizeItemsToFit = false;
            this.icSettings.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUpdates,
            this.btnUserManagment,
            this.btnLogActivity,
            this.btnPersonalization,
            this.btnAbout,
            this.btnHelp,
            this.btnBackup,
            this.btnRecord});
            // 
            // 
            // 
            this.icSettings.TitleStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.icSettings.TitleStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.icSettings.TitleStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.icSettings.TitleStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.icSettings.TitleStyle.Class = "MetroTileGroupTitle";
            this.icSettings.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.icSettings.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.icSettings.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.icSettings.TitleText = "Settings";
            // 
            // btnUpdates
            // 
            this.btnUpdates.DisabledBackColor = System.Drawing.Color.White;
            this.btnUpdates.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdates.Image")));
            this.btnUpdates.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Symbol = "";
            this.btnUpdates.SymbolColor = System.Drawing.Color.Black;
            this.btnUpdates.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnUpdates.TileSize = new System.Drawing.Size(210, 120);
            // 
            // 
            // 
            this.btnUpdates.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdates.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdates.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdates.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnUpdates.TitleText = "Updates";
            this.btnUpdates.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdates.TitleTextColor = System.Drawing.Color.Black;
            this.btnUpdates.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUserManagment
            // 
            this.btnUserManagment.DisabledBackColor = System.Drawing.Color.White;
            this.btnUserManagment.Image = ((System.Drawing.Image)(resources.GetObject("btnUserManagment.Image")));
            this.btnUserManagment.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUserManagment.Name = "btnUserManagment";
            this.btnUserManagment.Symbol = "";
            this.btnUserManagment.SymbolColor = System.Drawing.Color.Empty;
            this.btnUserManagment.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnUserManagment.TileSize = new System.Drawing.Size(250, 120);
            // 
            // 
            // 
            this.btnUserManagment.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUserManagment.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUserManagment.TileStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUserManagment.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUserManagment.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnUserManagment.TileStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUserManagment.TitleText = "User Management";
            this.btnUserManagment.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserManagment.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLogActivity
            // 
            this.btnLogActivity.Image = global::PschyHealth.Properties.Resources._1470605358_text_x_log;
            this.btnLogActivity.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogActivity.Name = "btnLogActivity";
            this.btnLogActivity.Symbol = "";
            this.btnLogActivity.SymbolColor = System.Drawing.Color.Empty;
            this.btnLogActivity.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnLogActivity.TileSize = new System.Drawing.Size(180, 120);
            // 
            // 
            // 
            this.btnLogActivity.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogActivity.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogActivity.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogActivity.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnLogActivity.TileStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogActivity.TitleText = "Log Activity";
            this.btnLogActivity.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogActivity.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPersonalization
            // 
            this.btnPersonalization.Image = global::PschyHealth.Properties.Resources._1470752183_emblem_art2;
            this.btnPersonalization.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonalization.Name = "btnPersonalization";
            this.btnPersonalization.Symbol = "";
            this.btnPersonalization.SymbolColor = System.Drawing.Color.Black;
            this.btnPersonalization.Text = "Personalization";
            this.btnPersonalization.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnPersonalization.TileSize = new System.Drawing.Size(210, 120);
            // 
            // 
            // 
            this.btnPersonalization.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPersonalization.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPersonalization.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPersonalization.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnPersonalization.TitleText = "Personalization";
            this.btnPersonalization.TitleTextColor = System.Drawing.Color.Black;
            this.btnPersonalization.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::PschyHealth.Properties.Resources._1470605616_19;
            this.btnAbout.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Symbol = "";
            this.btnAbout.SymbolColor = System.Drawing.Color.Black;
            this.btnAbout.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnAbout.TileSize = new System.Drawing.Size(180, 120);
            // 
            // 
            // 
            this.btnAbout.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbout.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbout.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbout.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnAbout.TitleText = "About";
            this.btnAbout.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.TitleTextColor = System.Drawing.Color.Black;
            this.btnAbout.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::PschyHealth.Properties.Resources._1470605722_help_file;
            this.btnHelp.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Symbol = "";
            this.btnHelp.SymbolColor = System.Drawing.Color.Black;
            this.btnHelp.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnHelp.TileSize = new System.Drawing.Size(180, 120);
            // 
            // 
            // 
            this.btnHelp.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHelp.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHelp.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHelp.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnHelp.TitleText = "Help";
            this.btnHelp.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.TitleTextColor = System.Drawing.Color.Black;
            this.btnHelp.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBackup
            // 
            this.btnBackup.Image = global::PschyHealth.Properties.Resources._1470605335_cmyk_03;
            this.btnBackup.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Symbol = "";
            this.btnBackup.SymbolColor = System.Drawing.Color.Black;
            this.btnBackup.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnBackup.TileSize = new System.Drawing.Size(210, 120);
            // 
            // 
            // 
            this.btnBackup.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackup.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackup.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackup.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnBackup.TitleText = "Backup Database";
            this.btnBackup.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackup.TitleTextColor = System.Drawing.Color.Black;
            this.btnBackup.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRecord
            // 
            this.btnRecord.Image = global::PschyHealth.Properties.Resources._1470605497_microphone;
            this.btnRecord.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Symbol = "";
            this.btnRecord.SymbolColor = System.Drawing.Color.Black;
            this.btnRecord.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            this.btnRecord.TileSize = new System.Drawing.Size(180, 120);
            // 
            // 
            // 
            this.btnRecord.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRecord.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRecord.TileStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRecord.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnRecord.TitleText = "Record";
            this.btnRecord.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecord.TitleTextColor = System.Drawing.Color.Black;
            this.btnRecord.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // pnlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTilePanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "pnlSettings";
            this.Size = new System.Drawing.Size(858, 664);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.pnlSettings_Load);
            this.Leave += new System.EventHandler(this.pnlSettings_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer icSettings;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnUpdates;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnUserManagment;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnLogActivity;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnPersonalization;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnBackup;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnRecord;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnAbout;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnHelp;
    }
}
