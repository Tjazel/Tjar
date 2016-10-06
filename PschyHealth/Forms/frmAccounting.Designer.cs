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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounting));
            this.dgvAccount = new MetroFramework.Controls.MetroGrid();
            this.btnRefresh = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtAccAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtAccType = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccDate = new MetroFramework.Controls.MetroTextBox();
            this.txtAccDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtAccTransaction_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDeleteAccount = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnUpdateAccount = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btnSearch = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmbAccCriteria = new MetroFramework.Controls.MetroComboBox();
            this.txtAccSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnAddAcount = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToOrderColumns = true;
            this.dgvAccount.AllowUserToResizeRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAccount.Location = new System.Drawing.Point(329, 141);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(654, 436);
            this.dgvAccount.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvAccount.TabIndex = 60;
            this.dgvAccount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvAccount.SelectionChanged += new System.EventHandler(this.dgvAccount_SelectionChanged_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = null;
            this.btnRefresh.Location = new System.Drawing.Point(904, 104);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 29);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.UseCustomForeColor = true;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.UseVisualStyleBackColor = false;
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
            this.txtAccAmount.Lines = new string[0];
            this.txtAccAmount.Location = new System.Drawing.Point(123, 151);
            this.txtAccAmount.MaxLength = 32767;
            this.txtAccAmount.Name = "txtAccAmount";
            this.txtAccAmount.PasswordChar = '\0';
            this.txtAccAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccAmount.SelectedText = "";
            this.txtAccAmount.SelectionLength = 0;
            this.txtAccAmount.SelectionStart = 0;
            this.txtAccAmount.Size = new System.Drawing.Size(125, 23);
            this.txtAccAmount.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccAmount.TabIndex = 13;
            this.txtAccAmount.UseSelectable = true;
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
            this.txtAccType.Lines = new string[0];
            this.txtAccType.Location = new System.Drawing.Point(123, 122);
            this.txtAccType.MaxLength = 32767;
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.PasswordChar = '\0';
            this.txtAccType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccType.SelectedText = "";
            this.txtAccType.SelectionLength = 0;
            this.txtAccType.SelectionStart = 0;
            this.txtAccType.Size = new System.Drawing.Size(125, 23);
            this.txtAccType.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccType.TabIndex = 11;
            this.txtAccType.UseSelectable = true;
            this.txtAccType.WaterMark = "Enter Type";
            this.txtAccType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccAmount);
            this.groupBox1.Controls.Add(this.txtAccType);
            this.groupBox1.Controls.Add(this.txtAccDate);
            this.groupBox1.Controls.Add(this.txtAccDescription);
            this.groupBox1.Controls.Add(this.txtAccTransaction_Number);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 194);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // txtAccDate
            // 
            // 
            // 
            // 
            this.txtAccDate.CustomButton.Image = null;
            this.txtAccDate.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAccDate.CustomButton.Name = "";
            this.txtAccDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDate.CustomButton.TabIndex = 1;
            this.txtAccDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccDate.CustomButton.UseSelectable = true;
            this.txtAccDate.CustomButton.Visible = false;
            this.txtAccDate.Lines = new string[0];
            this.txtAccDate.Location = new System.Drawing.Point(123, 93);
            this.txtAccDate.MaxLength = 32767;
            this.txtAccDate.Name = "txtAccDate";
            this.txtAccDate.PasswordChar = '\0';
            this.txtAccDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccDate.SelectedText = "";
            this.txtAccDate.SelectionLength = 0;
            this.txtAccDate.SelectionStart = 0;
            this.txtAccDate.Size = new System.Drawing.Size(125, 23);
            this.txtAccDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDate.TabIndex = 10;
            this.txtAccDate.UseSelectable = true;
            this.txtAccDate.WaterMark = "Enter Date";
            this.txtAccDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtAccDescription.Lines = new string[0];
            this.txtAccDescription.Location = new System.Drawing.Point(123, 64);
            this.txtAccDescription.MaxLength = 32767;
            this.txtAccDescription.Name = "txtAccDescription";
            this.txtAccDescription.PasswordChar = '\0';
            this.txtAccDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccDescription.SelectedText = "";
            this.txtAccDescription.SelectionLength = 0;
            this.txtAccDescription.SelectionStart = 0;
            this.txtAccDescription.Size = new System.Drawing.Size(125, 23);
            this.txtAccDescription.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDescription.TabIndex = 9;
            this.txtAccDescription.UseSelectable = true;
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
            this.txtAccTransaction_Number.Lines = new string[0];
            this.txtAccTransaction_Number.Location = new System.Drawing.Point(123, 35);
            this.txtAccTransaction_Number.MaxLength = 32767;
            this.txtAccTransaction_Number.Name = "txtAccTransaction_Number";
            this.txtAccTransaction_Number.PasswordChar = '\0';
            this.txtAccTransaction_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccTransaction_Number.SelectedText = "";
            this.txtAccTransaction_Number.SelectionLength = 0;
            this.txtAccTransaction_Number.SelectionStart = 0;
            this.txtAccTransaction_Number.ShowClearButton = true;
            this.txtAccTransaction_Number.Size = new System.Drawing.Size(125, 23);
            this.txtAccTransaction_Number.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccTransaction_Number.TabIndex = 7;
            this.txtAccTransaction_Number.UseSelectable = true;
            this.txtAccTransaction_Number.WaterMark = "Enter Transaction";
            this.txtAccTransaction_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccTransaction_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(56, 151);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Amount:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(76, 121);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Type:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(76, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Date:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Description:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Transaction:";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.Location = new System.Drawing.Point(548, 594);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteAccount.TabIndex = 58;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseSelectable = true;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAccount.Image")));
            this.btnUpdateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.Location = new System.Drawing.Point(435, 594);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateAccount.TabIndex = 57;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseSelectable = true;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(17, 27);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(55, 19);
            this.metroLabel17.TabIndex = 0;
            this.metroLabel17.Text = "Criteria:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.btnSearch);
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
            this.metroComboBox1.Visible = false;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            this.metroComboBox1.VisibleChanged += new System.EventHandler(this.metroComboBox1_VisibleChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = null;
            this.btnSearch.Location = new System.Drawing.Point(427, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 29);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.cmbAccCriteria.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbAccCriteria.TabIndex = 3;
            this.cmbAccCriteria.UseSelectable = true;
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
            this.txtAccSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccSearch.TabIndex = 2;
            this.txtAccSearch.UseSelectable = true;
            this.txtAccSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccSearch.TextChanged += new System.EventHandler(this.txtAccSearch_TextChanged_1);
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.BackColor = System.Drawing.Color.Maroon;
            this.btnAddAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcount.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddAcount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAcount.Image")));
            this.btnAddAcount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAcount.Location = new System.Drawing.Point(329, 594);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(97, 23);
            this.btnAddAcount.TabIndex = 56;
            this.btnAddAcount.Text = "Add";
            this.btnAddAcount.UseCustomBackColor = true;
            this.btnAddAcount.UseCustomForeColor = true;
            this.btnAddAcount.UseSelectable = true;
            this.btnAddAcount.UseVisualStyleBackColor = false;
            this.btnAddAcount.Click += new System.EventHandler(this.btnAddAcount_Click);
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
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Maroon;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(99, 298);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 23);
            this.btnConfirm.TabIndex = 62;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseCustomBackColor = true;
            this.btnConfirm.UseCustomForeColor = true;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAddAcount);
            this.MaximumSize = new System.Drawing.Size(2083, 788);
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvAccount;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtAccAmount;
        private MetroFramework.Controls.MetroTextBox txtAccType;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtAccDate;
        private MetroFramework.Controls.MetroTextBox txtAccDescription;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnDeleteAccount;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnUpdateAccount;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSearch;
        private MetroFramework.Controls.MetroComboBox cmbAccCriteria;
        private MetroFramework.Controls.MetroTextBox txtAccSearch;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnAddAcount;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConfirm;
        private MetroFramework.Controls.MetroTextBox txtAccTransaction_Number;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}