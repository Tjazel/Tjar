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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounting));
            this.dgvAccount = new MetroFramework.Controls.MetroGrid();
            this.txtAccAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtAccType = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.cmbAccCriteria = new MetroFramework.Controls.MetroComboBox();
            this.txtAccSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnAddAcount = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnArchive = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.msmAcc = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.cmbAccountingDate = new MetroFramework.Controls.MetroDateTime();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAccount.Location = new System.Drawing.Point(508, 174);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(803, 537);
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
            this.txtAccAmount.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtAccAmount.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccAmount.CustomButton.Name = "";
            this.txtAccAmount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAccAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccAmount.CustomButton.TabIndex = 1;
            this.txtAccAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccAmount.CustomButton.UseSelectable = true;
            this.txtAccAmount.CustomButton.Visible = false;
            this.txtAccAmount.Lines = new string[0];
            this.txtAccAmount.Location = new System.Drawing.Point(247, 186);
            this.txtAccAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccAmount.MaxLength = 32767;
            this.txtAccAmount.Name = "txtAccAmount";
            this.txtAccAmount.PasswordChar = '\0';
            this.txtAccAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccAmount.SelectedText = "";
            this.txtAccAmount.SelectionLength = 0;
            this.txtAccAmount.SelectionStart = 0;
            this.txtAccAmount.Size = new System.Drawing.Size(167, 28);
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
            this.txtAccType.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtAccType.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccType.CustomButton.Name = "";
            this.txtAccType.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAccType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccType.CustomButton.TabIndex = 1;
            this.txtAccType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccType.CustomButton.UseSelectable = true;
            this.txtAccType.CustomButton.Visible = false;
            this.txtAccType.Lines = new string[0];
            this.txtAccType.Location = new System.Drawing.Point(247, 150);
            this.txtAccType.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccType.MaxLength = 32767;
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.PasswordChar = '\0';
            this.txtAccType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccType.SelectedText = "";
            this.txtAccType.SelectionLength = 0;
            this.txtAccType.SelectionStart = 0;
            this.txtAccType.Size = new System.Drawing.Size(167, 28);
            this.txtAccType.TabIndex = 11;
            this.txtAccType.UseSelectable = true;
            this.txtAccType.UseStyleColors = true;
            this.txtAccType.WaterMark = "Enter Type";
            this.txtAccType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAccountingDate);
            this.groupBox1.Controls.Add(this.txtAccAmount);
            this.groupBox1.Controls.Add(this.txtAccType);
            this.groupBox1.Controls.Add(this.txtAccDescription);
            this.groupBox1.Controls.Add(this.txtAccTransaction_Number);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(29, 343);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(471, 239);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // txtAccDescription
            // 
            // 
            // 
            // 
            this.txtAccDescription.CustomButton.Image = null;
            this.txtAccDescription.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtAccDescription.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccDescription.CustomButton.Name = "";
            this.txtAccDescription.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAccDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDescription.CustomButton.TabIndex = 1;
            this.txtAccDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccDescription.CustomButton.UseSelectable = true;
            this.txtAccDescription.CustomButton.Visible = false;
            this.txtAccDescription.Lines = new string[0];
            this.txtAccDescription.Location = new System.Drawing.Point(247, 79);
            this.txtAccDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccDescription.MaxLength = 32767;
            this.txtAccDescription.Name = "txtAccDescription";
            this.txtAccDescription.PasswordChar = '\0';
            this.txtAccDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccDescription.SelectedText = "";
            this.txtAccDescription.SelectionLength = 0;
            this.txtAccDescription.SelectionStart = 0;
            this.txtAccDescription.Size = new System.Drawing.Size(167, 28);
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
            this.txtAccTransaction_Number.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtAccTransaction_Number.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccTransaction_Number.CustomButton.Name = "";
            this.txtAccTransaction_Number.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAccTransaction_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccTransaction_Number.CustomButton.TabIndex = 1;
            this.txtAccTransaction_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccTransaction_Number.CustomButton.UseSelectable = true;
            this.txtAccTransaction_Number.CustomButton.Visible = false;
            this.txtAccTransaction_Number.Lines = new string[0];
            this.txtAccTransaction_Number.Location = new System.Drawing.Point(247, 43);
            this.txtAccTransaction_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccTransaction_Number.MaxLength = 32767;
            this.txtAccTransaction_Number.Name = "txtAccTransaction_Number";
            this.txtAccTransaction_Number.PasswordChar = '\0';
            this.txtAccTransaction_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccTransaction_Number.SelectedText = "";
            this.txtAccTransaction_Number.SelectionLength = 0;
            this.txtAccTransaction_Number.SelectionStart = 0;
            this.txtAccTransaction_Number.ShowClearButton = true;
            this.txtAccTransaction_Number.Size = new System.Drawing.Size(167, 28);
            this.txtAccTransaction_Number.TabIndex = 7;
            this.txtAccTransaction_Number.UseSelectable = true;
            this.txtAccTransaction_Number.UseStyleColors = true;
            this.txtAccTransaction_Number.WaterMark = "Enter Transaction";
            this.txtAccTransaction_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccTransaction_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(75, 186);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 20);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Amount:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(101, 149);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Type:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(102, 114);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Date:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(70, 79);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Description :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 43);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Transaction number :";
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.Location = new System.Drawing.Point(731, 731);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(139, 28);
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
            this.btnUpdateAccount.Location = new System.Drawing.Point(580, 731);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(143, 28);
            this.btnUpdateAccount.TabIndex = 57;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseSelectable = true;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(23, 33);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(56, 20);
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
            this.groupBox3.Location = new System.Drawing.Point(557, 78);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(640, 87);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Accounting";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "null"});
            this.metroComboBox1.Location = new System.Drawing.Point(299, 28);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(71, 30);
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
            this.cmbAccCriteria.ItemHeight = 24;
            this.cmbAccCriteria.Items.AddRange(new object[] {
            "Transaction",
            "Number",
            "Type"});
            this.cmbAccCriteria.Location = new System.Drawing.Point(104, 28);
            this.cmbAccCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAccCriteria.Name = "cmbAccCriteria";
            this.cmbAccCriteria.Size = new System.Drawing.Size(187, 30);
            this.cmbAccCriteria.Style = MetroFramework.MetroColorStyle.Blue;
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
            this.txtAccSearch.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.txtAccSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccSearch.CustomButton.Name = "";
            this.txtAccSearch.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtAccSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccSearch.CustomButton.TabIndex = 1;
            this.txtAccSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccSearch.CustomButton.UseSelectable = true;
            this.txtAccSearch.CustomButton.Visible = false;
            this.txtAccSearch.Lines = new string[0];
            this.txtAccSearch.Location = new System.Drawing.Point(383, 23);
            this.txtAccSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccSearch.MaxLength = 32767;
            this.txtAccSearch.Name = "txtAccSearch";
            this.txtAccSearch.PasswordChar = '\0';
            this.txtAccSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccSearch.SelectedText = "";
            this.txtAccSearch.SelectionLength = 0;
            this.txtAccSearch.SelectionStart = 0;
            this.txtAccSearch.Size = new System.Drawing.Size(188, 36);
            this.txtAccSearch.TabIndex = 2;
            this.txtAccSearch.UseSelectable = true;
            this.txtAccSearch.UseStyleColors = true;
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
            this.btnAddAcount.Location = new System.Drawing.Point(439, 731);
            this.btnAddAcount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(129, 28);
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
            this.pbMic.Location = new System.Drawing.Point(29, 46);
            this.pbMic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(37, 27);
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
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(29, 590);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 28);
            this.btnConfirm.TabIndex = 62;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseCustomBackColor = true;
            this.btnConfirm.UseCustomForeColor = true;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(893, 731);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(139, 28);
            this.btnArchive.TabIndex = 63;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // msmAcc
            // 
            this.msmAcc.Owner = this;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.Location = new System.Drawing.Point(165, 590);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 28);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbAccountingDate
            // 
            this.cmbAccountingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbAccountingDate.Location = new System.Drawing.Point(247, 114);
            this.cmbAccountingDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.cmbAccountingDate.Name = "cmbAccountingDate";
            this.cmbAccountingDate.Size = new System.Drawing.Size(167, 30);
            this.cmbAccountingDate.TabIndex = 65;
            this.cmbAccountingDate.UseStyleColors = true;
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2304, 1092);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAddAcount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1819, 871);
            this.Movable = false;
            this.Name = "frmAccounting";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnDeleteAccount;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnUpdateAccount;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cmbAccCriteria;
        private MetroFramework.Controls.MetroTextBox txtAccSearch;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnAddAcount;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConfirm;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnArchive;
        private MetroFramework.Controls.MetroTextBox txtAccTransaction_Number;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager msmAcc;
        private MetroFramework.Controls.MetroTile btnCancel;
        private MetroFramework.Controls.MetroDateTime cmbAccountingDate;
    }
}