namespace PschyHealth
{
    partial class frmAccounting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccount = new MetroFramework.Controls.MetroGrid();
            this.txtAccAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtAccType = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAccDate = new MetroFramework.Controls.MetroDateTime();
            this.txtAccDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtAccTransaction_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.cmbAccCriteria = new MetroFramework.Controls.MetroComboBox();
            this.txtAccSearch = new MetroFramework.Controls.MetroTextBox();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.msmAcc = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnArchive = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAccount = new MetroFramework.Controls.MetroButton();
            this.btnUpdatAccount = new MetroFramework.Controls.MetroButton();
            this.btnAddAcount = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToOrderColumns = true;
            this.dgvAccount.AllowUserToResizeRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAccount.Location = new System.Drawing.Point(381, 141);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(602, 436);
            this.dgvAccount.TabIndex = 60;
            this.dgvAccount.UseStyleColors = true;
            this.dgvAccount.SelectionChanged += new System.EventHandler(this.dgvAccount_SelectionChanged_1);
            // 
            // txtAccAmount
            // 
            // 
            // 
            // 
            this.txtAccAmount.CustomButton.Image = null;
            this.txtAccAmount.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAccAmount.CustomButton.Name = "";
            this.txtAccAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccAmount.CustomButton.TabIndex = 1;
            this.txtAccAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccAmount.CustomButton.UseSelectable = true;
            this.txtAccAmount.CustomButton.Visible = false;
            this.txtAccAmount.Enabled = false;
            this.txtAccAmount.Lines = new string[0];
            this.txtAccAmount.Location = new System.Drawing.Point(185, 151);
            this.txtAccAmount.MaxLength = 32767;
            this.txtAccAmount.Name = "txtAccAmount";
            this.txtAccAmount.PasswordChar = '\0';
            this.txtAccAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccAmount.SelectedText = "";
            this.txtAccAmount.SelectionLength = 0;
            this.txtAccAmount.SelectionStart = 0;
            this.txtAccAmount.Size = new System.Drawing.Size(125, 23);
            this.txtAccAmount.TabIndex = 13;
            this.txtAccAmount.UseSelectable = true;
            this.txtAccAmount.UseStyleColors = true;
            this.txtAccAmount.WaterMark = "Enter Amount";
            this.txtAccAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccType
            // 
            // 
            // 
            // 
            this.txtAccType.CustomButton.Image = null;
            this.txtAccType.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAccType.CustomButton.Name = "";
            this.txtAccType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccType.CustomButton.TabIndex = 1;
            this.txtAccType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccType.CustomButton.UseSelectable = true;
            this.txtAccType.CustomButton.Visible = false;
            this.txtAccType.Enabled = false;
            this.txtAccType.Lines = new string[0];
            this.txtAccType.Location = new System.Drawing.Point(185, 122);
            this.txtAccType.MaxLength = 32767;
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.PasswordChar = '\0';
            this.txtAccType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccType.SelectedText = "";
            this.txtAccType.SelectionLength = 0;
            this.txtAccType.SelectionStart = 0;
            this.txtAccType.Size = new System.Drawing.Size(125, 23);
            this.txtAccType.TabIndex = 11;
            this.txtAccType.UseSelectable = true;
            this.txtAccType.UseStyleColors = true;
            this.txtAccType.WaterMark = "Enter Type";
            this.txtAccType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAccDate);
            this.groupBox1.Controls.Add(this.txtAccAmount);
            this.groupBox1.Controls.Add(this.txtAccType);
            this.groupBox1.Controls.Add(this.txtAccDescription);
            this.groupBox1.Controls.Add(this.txtAccTransaction_Number);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(22, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 194);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // cmbAccDate
            // 
            this.cmbAccDate.Enabled = false;
            this.cmbAccDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbAccDate.Location = new System.Drawing.Point(185, 93);
            this.cmbAccDate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAccDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbAccDate.Name = "cmbAccDate";
            this.cmbAccDate.Size = new System.Drawing.Size(126, 29);
            this.cmbAccDate.TabIndex = 65;
            this.cmbAccDate.UseStyleColors = true;
            // 
            // txtAccDescription
            // 
            // 
            // 
            // 
            this.txtAccDescription.CustomButton.Image = null;
            this.txtAccDescription.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAccDescription.CustomButton.Name = "";
            this.txtAccDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDescription.CustomButton.TabIndex = 1;
            this.txtAccDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccDescription.CustomButton.UseSelectable = true;
            this.txtAccDescription.CustomButton.Visible = false;
            this.txtAccDescription.Enabled = false;
            this.txtAccDescription.Lines = new string[0];
            this.txtAccDescription.Location = new System.Drawing.Point(185, 64);
            this.txtAccDescription.MaxLength = 32767;
            this.txtAccDescription.Name = "txtAccDescription";
            this.txtAccDescription.PasswordChar = '\0';
            this.txtAccDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccDescription.SelectedText = "";
            this.txtAccDescription.SelectionLength = 0;
            this.txtAccDescription.SelectionStart = 0;
            this.txtAccDescription.Size = new System.Drawing.Size(125, 23);
            this.txtAccDescription.TabIndex = 9;
            this.txtAccDescription.UseSelectable = true;
            this.txtAccDescription.UseStyleColors = true;
            this.txtAccDescription.WaterMark = "Enter Description";
            this.txtAccDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccTransaction_Number
            // 
            // 
            // 
            // 
            this.txtAccTransaction_Number.CustomButton.Image = null;
            this.txtAccTransaction_Number.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAccTransaction_Number.CustomButton.Name = "";
            this.txtAccTransaction_Number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccTransaction_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccTransaction_Number.CustomButton.TabIndex = 1;
            this.txtAccTransaction_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccTransaction_Number.CustomButton.UseSelectable = true;
            this.txtAccTransaction_Number.CustomButton.Visible = false;
            this.txtAccTransaction_Number.Enabled = false;
            this.txtAccTransaction_Number.Lines = new string[0];
            this.txtAccTransaction_Number.Location = new System.Drawing.Point(185, 35);
            this.txtAccTransaction_Number.MaxLength = 20;
            this.txtAccTransaction_Number.Name = "txtAccTransaction_Number";
            this.txtAccTransaction_Number.PasswordChar = '\0';
            this.txtAccTransaction_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccTransaction_Number.SelectedText = "";
            this.txtAccTransaction_Number.SelectionLength = 0;
            this.txtAccTransaction_Number.SelectionStart = 0;
            this.txtAccTransaction_Number.ShowClearButton = true;
            this.txtAccTransaction_Number.Size = new System.Drawing.Size(125, 23);
            this.txtAccTransaction_Number.TabIndex = 7;
            this.txtAccTransaction_Number.UseSelectable = true;
            this.txtAccTransaction_Number.UseStyleColors = true;
            this.txtAccTransaction_Number.WaterMark = "Enter Transaction";
            this.txtAccTransaction_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccTransaction_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccTransaction_Number.Enter += new System.EventHandler(this.txtAccTransaction_Number_Enter);
            this.txtAccTransaction_Number.Leave += new System.EventHandler(this.txtAccTransaction_Number_Leave);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(56, 151);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Amount:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(76, 121);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Type:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(76, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Date:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Description :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Transaction number :";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(17, 27);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(55, 19);
            this.metroLabel17.TabIndex = 0;
            this.metroLabel17.Text = "Criteria:";
            this.metroLabel17.UseStyleColors = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.cmbAccCriteria);
            this.groupBox3.Controls.Add(this.txtAccSearch);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(418, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 71);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Accounting";
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
            this.metroComboBox1.Location = new System.Drawing.Point(224, 23);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(54, 29);
            this.metroComboBox1.TabIndex = 61;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
            this.metroComboBox1.Visible = false;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            this.metroComboBox1.VisibleChanged += new System.EventHandler(this.metroComboBox1_VisibleChanged_1);
            // 
            // cmbAccCriteria
            // 
            this.cmbAccCriteria.FormattingEnabled = true;
            this.cmbAccCriteria.ItemHeight = 23;
            this.cmbAccCriteria.Items.AddRange(new object[] {
            "Transaction",
            "Number",
            "Type"});
            this.cmbAccCriteria.Location = new System.Drawing.Point(78, 23);
            this.cmbAccCriteria.Name = "cmbAccCriteria";
            this.cmbAccCriteria.Size = new System.Drawing.Size(141, 29);
            this.cmbAccCriteria.TabIndex = 3;
            this.cmbAccCriteria.UseSelectable = true;
            this.cmbAccCriteria.UseStyleColors = true;
            this.cmbAccCriteria.TextChanged += new System.EventHandler(this.cmbAccCriteria_TextChanged_1);
            // 
            // txtAccSearch
            // 
            // 
            // 
            // 
            this.txtAccSearch.CustomButton.Image = null;
            this.txtAccSearch.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtAccSearch.CustomButton.Name = "";
            this.txtAccSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAccSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccSearch.CustomButton.TabIndex = 1;
            this.txtAccSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccSearch.CustomButton.UseSelectable = true;
            this.txtAccSearch.CustomButton.Visible = false;
            this.txtAccSearch.Lines = new string[0];
            this.txtAccSearch.Location = new System.Drawing.Point(287, 19);
            this.txtAccSearch.MaxLength = 32767;
            this.txtAccSearch.Name = "txtAccSearch";
            this.txtAccSearch.PasswordChar = '\0';
            this.txtAccSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccSearch.SelectedText = "";
            this.txtAccSearch.SelectionLength = 0;
            this.txtAccSearch.SelectionStart = 0;
            this.txtAccSearch.Size = new System.Drawing.Size(141, 29);
            this.txtAccSearch.TabIndex = 2;
            this.txtAccSearch.UseSelectable = true;
            this.txtAccSearch.UseStyleColors = true;
            this.txtAccSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccSearch.TextChanged += new System.EventHandler(this.txtAccSearch_TextChanged_1);
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(22, 37);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(28, 22);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 61;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // msmAcc
            // 
            this.msmAcc.Owner = this;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(625, 622);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(2);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(91, 42);
            this.btnArchive.TabIndex = 115;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseStyleColors = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click_1);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(530, 622);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(91, 42);
            this.btnDeleteAccount.TabIndex = 114;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseSelectable = true;
            this.btnDeleteAccount.UseStyleColors = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click_1);
            // 
            // btnUpdatAccount
            // 
            this.btnUpdatAccount.Location = new System.Drawing.Point(434, 622);
            this.btnUpdatAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdatAccount.Name = "btnUpdatAccount";
            this.btnUpdatAccount.Size = new System.Drawing.Size(91, 42);
            this.btnUpdatAccount.TabIndex = 112;
            this.btnUpdatAccount.Text = "Update";
            this.btnUpdatAccount.UseSelectable = true;
            this.btnUpdatAccount.UseStyleColors = true;
            this.btnUpdatAccount.Click += new System.EventHandler(this.btnUpdatAccount_Click);
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.Location = new System.Drawing.Point(335, 622);
            this.btnAddAcount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(91, 42);
            this.btnAddAcount.TabIndex = 111;
            this.btnAddAcount.Text = "Add ";
            this.btnAddAcount.UseSelectable = true;
            this.btnAddAcount.UseStyleColors = true;
            this.btnAddAcount.Click += new System.EventHandler(this.btnAddAcount_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 518);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 117;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCanccel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(22, 518);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 42);
            this.btnConfirm.TabIndex = 116;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseStyleColors = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConnfirm_Click);
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 887);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdatAccount);
            this.Controls.Add(this.btnAddAcount);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MinimumSize = new System.Drawing.Size(1364, 708);
            this.Movable = false;
            this.Name = "frmAccounting";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmAccounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvAccount;
        private MetroFramework.Controls.MetroTextBox txtAccAmount;
        private MetroFramework.Controls.MetroTextBox txtAccType;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtAccDescription;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cmbAccCriteria;
        private MetroFramework.Controls.MetroTextBox txtAccSearch;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAccTransaction_Number;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager msmAcc;
        private MetroFramework.Controls.MetroDateTime cmbAccDate;
        private MetroFramework.Controls.MetroButton btnArchive;
        private MetroFramework.Controls.MetroButton btnDeleteAccount;
        private MetroFramework.Controls.MetroButton btnUpdatAccount;
        private MetroFramework.Controls.MetroButton btnAddAcount;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnConfirm;
    }
}