namespace PschyHealth
{
    partial class frmStatements
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.cmbStatCrit = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox17 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroTextButton5 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton4 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.BtnPrintStatement = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvStatements = new MetroFramework.Controls.MetroGrid();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.cmbClient = new MetroFramework.Controls.MetroComboBox();
            this.lbStatements = new System.Windows.Forms.ListBox();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.cmbFormat = new MetroFramework.Controls.MetroComboBox();
            this.msmStatements = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmStatements)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.cmbStatCrit);
            this.groupBox3.Controls.Add(this.metroTextBox17);
            this.groupBox3.Controls.Add(this.metroLabel18);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(349, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 71);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Statements";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "null"});
            this.metroComboBox1.Location = new System.Drawing.Point(231, 28);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(54, 29);
            this.metroComboBox1.TabIndex = 62;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.Visible = false;
            // 
            // cmbStatCrit
            // 
            this.cmbStatCrit.FormattingEnabled = true;
            this.cmbStatCrit.ItemHeight = 23;
            this.cmbStatCrit.Items.AddRange(new object[] {
            "Number",
            "Date",
            "Code",
            "Patient Name",
            "Patient Surname",
            "Consultant ID"});
            this.cmbStatCrit.Location = new System.Drawing.Point(61, 27);
            this.cmbStatCrit.Name = "cmbStatCrit";
            this.cmbStatCrit.Size = new System.Drawing.Size(141, 29);
            this.cmbStatCrit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbStatCrit.TabIndex = 3;
            this.cmbStatCrit.UseSelectable = true;
            this.cmbStatCrit.SelectedIndexChanged += new System.EventHandler(this.cmbStatCrit_SelectedIndexChanged);
            // 
            // metroTextBox17
            // 
            // 
            // 
            // 
            this.metroTextBox17.CustomButton.Image = null;
            this.metroTextBox17.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.metroTextBox17.CustomButton.Name = "";
            this.metroTextBox17.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.metroTextBox17.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox17.CustomButton.TabIndex = 1;
            this.metroTextBox17.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox17.CustomButton.UseSelectable = true;
            this.metroTextBox17.CustomButton.Visible = false;
            this.metroTextBox17.Lines = new string[0];
            this.metroTextBox17.Location = new System.Drawing.Point(368, 23);
            this.metroTextBox17.MaxLength = 32767;
            this.metroTextBox17.Name = "metroTextBox17";
            this.metroTextBox17.PasswordChar = '\0';
            this.metroTextBox17.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox17.SelectedText = "";
            this.metroTextBox17.SelectionLength = 0;
            this.metroTextBox17.SelectionStart = 0;
            this.metroTextBox17.Size = new System.Drawing.Size(141, 29);
            this.metroTextBox17.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox17.TabIndex = 2;
            this.metroTextBox17.UseSelectable = true;
            this.metroTextBox17.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox17.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(303, 36);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(76, 19);
            this.metroLabel18.TabIndex = 1;
            this.metroLabel18.Text = "Search For:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(6, 35);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(55, 19);
            this.metroLabel17.TabIndex = 0;
            this.metroLabel17.Text = "Criteria:";
            // 
            // metroTextButton5
            // 
            this.metroTextButton5.Image = null;
            this.metroTextButton5.Location = new System.Drawing.Point(749, 656);
            this.metroTextButton5.Name = "metroTextButton5";
            this.metroTextButton5.Size = new System.Drawing.Size(146, 23);
            this.metroTextButton5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton5.TabIndex = 41;
            this.metroTextButton5.Text = "View Statement";
            this.metroTextButton5.UseSelectable = true;
            this.metroTextButton5.UseVisualStyleBackColor = true;
            // 
            // metroTextButton4
            // 
            this.metroTextButton4.Image = null;
            this.metroTextButton4.Location = new System.Drawing.Point(580, 656);
            this.metroTextButton4.Name = "metroTextButton4";
            this.metroTextButton4.Size = new System.Drawing.Size(146, 23);
            this.metroTextButton4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton4.TabIndex = 40;
            this.metroTextButton4.Text = "E-mail";
            this.metroTextButton4.UseSelectable = true;
            this.metroTextButton4.UseVisualStyleBackColor = true;
            // 
            // BtnPrintStatement
            // 
            this.BtnPrintStatement.Image = null;
            this.BtnPrintStatement.Location = new System.Drawing.Point(410, 656);
            this.BtnPrintStatement.Name = "BtnPrintStatement";
            this.BtnPrintStatement.Size = new System.Drawing.Size(146, 23);
            this.BtnPrintStatement.Style = MetroFramework.MetroColorStyle.Red;
            this.BtnPrintStatement.TabIndex = 39;
            this.BtnPrintStatement.Text = "Print";
            this.BtnPrintStatement.UseSelectable = true;
            this.BtnPrintStatement.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(870, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // dgvStatements
            // 
            this.dgvStatements.AllowUserToResizeRows = false;
            this.dgvStatements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvStatements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStatements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatements.EnableHeadersVisualStyles = false;
            this.dgvStatements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStatements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvStatements.Location = new System.Drawing.Point(12, 254);
            this.dgvStatements.Name = "dgvStatements";
            this.dgvStatements.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatements.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatements.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStatements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatements.Size = new System.Drawing.Size(656, 472);
            this.dgvStatements.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvStatements.TabIndex = 37;
            this.dgvStatements.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvStatements.Visible = false;
            this.dgvStatements.SelectionChanged += new System.EventHandler(this.dgvStatements_SelectionChanged_1);
            // 
            // pbBack
            // 
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(22, 37);
            this.pbBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 22);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 44;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click_1);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ItemHeight = 23;
            this.cmbClient.Location = new System.Drawing.Point(40, 147);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 29);
            this.cmbClient.TabIndex = 45;
            this.cmbClient.UseSelectable = true;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // lbStatements
            // 
            this.lbStatements.FormattingEnabled = true;
            this.lbStatements.Location = new System.Drawing.Point(349, 173);
            this.lbStatements.Name = "lbStatements";
            this.lbStatements.Size = new System.Drawing.Size(906, 472);
            this.lbStatements.TabIndex = 46;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(115, 216);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 47;
            this.btnCreate.Text = "metroButton1";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.ItemHeight = 23;
            this.cmbFormat.Location = new System.Drawing.Point(40, 105);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(286, 29);
            this.cmbFormat.TabIndex = 48;
            this.cmbFormat.UseSelectable = true;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // msmStatements
            // 
            this.msmStatements.Owner = this;
            // 
            // frmStatements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbStatements);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroTextButton5);
            this.Controls.Add(this.metroTextButton4);
            this.Controls.Add(this.BtnPrintStatement);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvStatements);
            this.Movable = false;
            this.Name = "frmStatements";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmStatements_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmStatements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cmbStatCrit;
        private MetroFramework.Controls.MetroTextBox metroTextBox17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton5;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton4;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton BtnPrintStatement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid dgvStatements;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pbBack;
        private MetroFramework.Controls.MetroComboBox cmbClient;
        private System.Windows.Forms.ListBox lbStatements;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroComboBox cmbFormat;
        private MetroFramework.Components.MetroStyleManager msmStatements;
    }
}