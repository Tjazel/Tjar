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
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.rdRecord = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdSave = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdPause = new DevComponents.DotNetBar.RadialMenuItem();
            this.rdPlay = new DevComponents.DotNetBar.RadialMenuItem();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
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
            // rdRecord
            // 
            this.rdRecord.Name = "rdRecord";
            this.rdRecord.Symbol = "";
            this.rdRecord.Text = "Record";
            // 
            // rdSave
            // 
            this.rdSave.Name = "rdSave";
            this.rdSave.Symbol = "";
            this.rdSave.Text = "Save/Stop";
            // 
            // rdPause
            // 
            this.rdPause.Name = "rdPause";
            this.rdPause.Symbol = "";
            this.rdPause.Text = "Pause";
            // 
            // rdPlay
            // 
            this.rdPlay.Name = "rdPlay";
            this.rdPlay.Symbol = "";
            this.rdPlay.Text = "Play";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(207, 31);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 253);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.radialMenu1);
            this.Name = "frmRecord";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.frmRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem rdRecord;
        private DevComponents.DotNetBar.RadialMenuItem rdSave;
        private DevComponents.DotNetBar.RadialMenuItem rdPause;
        private DevComponents.DotNetBar.RadialMenuItem rdPlay;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}