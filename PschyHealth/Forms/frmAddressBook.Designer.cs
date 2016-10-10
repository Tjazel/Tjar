namespace PschyHealth
{
    partial class frmAddressBook
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
            this.cmbAddressBookCriteria = new MetroFramework.Controls.MetroComboBox();
            this.txtAddressBookSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.dgvAddressBook = new MetroFramework.Controls.MetroGrid();
            this.txtAddressBookZip_Code = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookAddress3 = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookAddress2 = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookAddress1 = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookWebsite = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookEmail_Address = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookCellphone_Number = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookFax_Number = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookTelephone_Number = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookName = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressBookNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.msmAdBook = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnArchive = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmAdBook)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbAddressBookCriteria);
            this.groupBox3.Controls.Add(this.txtAddressBookSearch);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(491, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 71);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Address Book";
            // 
            // cmbAddressBookCriteria
            // 
            this.cmbAddressBookCriteria.FormattingEnabled = true;
            this.cmbAddressBookCriteria.ItemHeight = 23;
            this.cmbAddressBookCriteria.Items.AddRange(new object[] {
            "Name",
            "Email",
            "Tel"});
            this.cmbAddressBookCriteria.Location = new System.Drawing.Point(78, 23);
            this.cmbAddressBookCriteria.Name = "cmbAddressBookCriteria";
            this.cmbAddressBookCriteria.Size = new System.Drawing.Size(141, 29);
            this.cmbAddressBookCriteria.TabIndex = 3;
            this.cmbAddressBookCriteria.UseSelectable = true;
            this.cmbAddressBookCriteria.UseStyleColors = true;
            // 
            // txtAddressBookSearch
            // 
            // 
            // 
            // 
            this.txtAddressBookSearch.CustomButton.Image = null;
            this.txtAddressBookSearch.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtAddressBookSearch.CustomButton.Name = "";
            this.txtAddressBookSearch.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtAddressBookSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookSearch.CustomButton.TabIndex = 1;
            this.txtAddressBookSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookSearch.CustomButton.UseSelectable = true;
            this.txtAddressBookSearch.CustomButton.Visible = false;
            this.txtAddressBookSearch.Lines = new string[0];
            this.txtAddressBookSearch.Location = new System.Drawing.Point(254, 23);
            this.txtAddressBookSearch.MaxLength = 32767;
            this.txtAddressBookSearch.Name = "txtAddressBookSearch";
            this.txtAddressBookSearch.PasswordChar = '\0';
            this.txtAddressBookSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookSearch.SelectedText = "";
            this.txtAddressBookSearch.SelectionLength = 0;
            this.txtAddressBookSearch.SelectionStart = 0;
            this.txtAddressBookSearch.Size = new System.Drawing.Size(141, 29);
            this.txtAddressBookSearch.TabIndex = 2;
            this.txtAddressBookSearch.UseSelectable = true;
            this.txtAddressBookSearch.UseStyleColors = true;
            this.txtAddressBookSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // dgvAddressBook
            // 
            this.dgvAddressBook.AllowUserToResizeRows = false;
            this.dgvAddressBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAddressBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddressBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAddressBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddressBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddressBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddressBook.EnableHeadersVisualStyles = false;
            this.dgvAddressBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAddressBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAddressBook.Location = new System.Drawing.Point(491, 180);
            this.dgvAddressBook.Name = "dgvAddressBook";
            this.dgvAddressBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddressBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddressBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAddressBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddressBook.Size = new System.Drawing.Size(480, 397);
            this.dgvAddressBook.TabIndex = 94;
            this.dgvAddressBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAddressBookZip_Code
            // 
            // 
            // 
            // 
            this.txtAddressBookZip_Code.CustomButton.Image = null;
            this.txtAddressBookZip_Code.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookZip_Code.CustomButton.Name = "";
            this.txtAddressBookZip_Code.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookZip_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookZip_Code.CustomButton.TabIndex = 1;
            this.txtAddressBookZip_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookZip_Code.CustomButton.UseSelectable = true;
            this.txtAddressBookZip_Code.CustomButton.Visible = false;
            this.txtAddressBookZip_Code.Lines = new string[0];
            this.txtAddressBookZip_Code.Location = new System.Drawing.Point(93, 428);
            this.txtAddressBookZip_Code.MaxLength = 32767;
            this.txtAddressBookZip_Code.Name = "txtAddressBookZip_Code";
            this.txtAddressBookZip_Code.PasswordChar = '\0';
            this.txtAddressBookZip_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookZip_Code.SelectedText = "";
            this.txtAddressBookZip_Code.SelectionLength = 0;
            this.txtAddressBookZip_Code.SelectionStart = 0;
            this.txtAddressBookZip_Code.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookZip_Code.TabIndex = 89;
            this.txtAddressBookZip_Code.UseSelectable = true;
            this.txtAddressBookZip_Code.UseStyleColors = true;
            this.txtAddressBookZip_Code.WaterMark = "Enter Zip Code";
            this.txtAddressBookZip_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookZip_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookAddress3
            // 
            // 
            // 
            // 
            this.txtAddressBookAddress3.CustomButton.Image = null;
            this.txtAddressBookAddress3.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookAddress3.CustomButton.Name = "";
            this.txtAddressBookAddress3.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookAddress3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookAddress3.CustomButton.TabIndex = 1;
            this.txtAddressBookAddress3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookAddress3.CustomButton.UseSelectable = true;
            this.txtAddressBookAddress3.CustomButton.Visible = false;
            this.txtAddressBookAddress3.Lines = new string[0];
            this.txtAddressBookAddress3.Location = new System.Drawing.Point(93, 397);
            this.txtAddressBookAddress3.MaxLength = 32767;
            this.txtAddressBookAddress3.Name = "txtAddressBookAddress3";
            this.txtAddressBookAddress3.PasswordChar = '\0';
            this.txtAddressBookAddress3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookAddress3.SelectedText = "";
            this.txtAddressBookAddress3.SelectionLength = 0;
            this.txtAddressBookAddress3.SelectionStart = 0;
            this.txtAddressBookAddress3.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookAddress3.TabIndex = 88;
            this.txtAddressBookAddress3.UseSelectable = true;
            this.txtAddressBookAddress3.UseStyleColors = true;
            this.txtAddressBookAddress3.WaterMark = "Enter Address 3";
            this.txtAddressBookAddress3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookAddress3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookAddress2
            // 
            // 
            // 
            // 
            this.txtAddressBookAddress2.CustomButton.Image = null;
            this.txtAddressBookAddress2.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookAddress2.CustomButton.Name = "";
            this.txtAddressBookAddress2.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookAddress2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookAddress2.CustomButton.TabIndex = 1;
            this.txtAddressBookAddress2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookAddress2.CustomButton.UseSelectable = true;
            this.txtAddressBookAddress2.CustomButton.Visible = false;
            this.txtAddressBookAddress2.Lines = new string[0];
            this.txtAddressBookAddress2.Location = new System.Drawing.Point(93, 366);
            this.txtAddressBookAddress2.MaxLength = 32767;
            this.txtAddressBookAddress2.Name = "txtAddressBookAddress2";
            this.txtAddressBookAddress2.PasswordChar = '\0';
            this.txtAddressBookAddress2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookAddress2.SelectedText = "";
            this.txtAddressBookAddress2.SelectionLength = 0;
            this.txtAddressBookAddress2.SelectionStart = 0;
            this.txtAddressBookAddress2.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookAddress2.TabIndex = 87;
            this.txtAddressBookAddress2.UseSelectable = true;
            this.txtAddressBookAddress2.UseStyleColors = true;
            this.txtAddressBookAddress2.WaterMark = "Enter Address 2";
            this.txtAddressBookAddress2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookAddress2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookAddress1
            // 
            // 
            // 
            // 
            this.txtAddressBookAddress1.CustomButton.Image = null;
            this.txtAddressBookAddress1.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookAddress1.CustomButton.Name = "";
            this.txtAddressBookAddress1.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookAddress1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookAddress1.CustomButton.TabIndex = 1;
            this.txtAddressBookAddress1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookAddress1.CustomButton.UseSelectable = true;
            this.txtAddressBookAddress1.CustomButton.Visible = false;
            this.txtAddressBookAddress1.Lines = new string[0];
            this.txtAddressBookAddress1.Location = new System.Drawing.Point(93, 335);
            this.txtAddressBookAddress1.MaxLength = 32767;
            this.txtAddressBookAddress1.Name = "txtAddressBookAddress1";
            this.txtAddressBookAddress1.PasswordChar = '\0';
            this.txtAddressBookAddress1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookAddress1.SelectedText = "";
            this.txtAddressBookAddress1.SelectionLength = 0;
            this.txtAddressBookAddress1.SelectionStart = 0;
            this.txtAddressBookAddress1.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookAddress1.TabIndex = 86;
            this.txtAddressBookAddress1.UseSelectable = true;
            this.txtAddressBookAddress1.UseStyleColors = true;
            this.txtAddressBookAddress1.WaterMark = "Enter Address 1";
            this.txtAddressBookAddress1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookAddress1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookWebsite
            // 
            // 
            // 
            // 
            this.txtAddressBookWebsite.CustomButton.Image = null;
            this.txtAddressBookWebsite.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookWebsite.CustomButton.Name = "";
            this.txtAddressBookWebsite.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookWebsite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookWebsite.CustomButton.TabIndex = 1;
            this.txtAddressBookWebsite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookWebsite.CustomButton.UseSelectable = true;
            this.txtAddressBookWebsite.CustomButton.Visible = false;
            this.txtAddressBookWebsite.Lines = new string[0];
            this.txtAddressBookWebsite.Location = new System.Drawing.Point(93, 304);
            this.txtAddressBookWebsite.MaxLength = 32767;
            this.txtAddressBookWebsite.Name = "txtAddressBookWebsite";
            this.txtAddressBookWebsite.PasswordChar = '\0';
            this.txtAddressBookWebsite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookWebsite.SelectedText = "";
            this.txtAddressBookWebsite.SelectionLength = 0;
            this.txtAddressBookWebsite.SelectionStart = 0;
            this.txtAddressBookWebsite.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookWebsite.TabIndex = 85;
            this.txtAddressBookWebsite.UseSelectable = true;
            this.txtAddressBookWebsite.UseStyleColors = true;
            this.txtAddressBookWebsite.WaterMark = "Enter Website URL";
            this.txtAddressBookWebsite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookWebsite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookEmail_Address
            // 
            // 
            // 
            // 
            this.txtAddressBookEmail_Address.CustomButton.Image = null;
            this.txtAddressBookEmail_Address.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookEmail_Address.CustomButton.Name = "";
            this.txtAddressBookEmail_Address.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookEmail_Address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookEmail_Address.CustomButton.TabIndex = 1;
            this.txtAddressBookEmail_Address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookEmail_Address.CustomButton.UseSelectable = true;
            this.txtAddressBookEmail_Address.CustomButton.Visible = false;
            this.txtAddressBookEmail_Address.Lines = new string[0];
            this.txtAddressBookEmail_Address.Location = new System.Drawing.Point(93, 273);
            this.txtAddressBookEmail_Address.MaxLength = 32767;
            this.txtAddressBookEmail_Address.Name = "txtAddressBookEmail_Address";
            this.txtAddressBookEmail_Address.PasswordChar = '\0';
            this.txtAddressBookEmail_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookEmail_Address.SelectedText = "";
            this.txtAddressBookEmail_Address.SelectionLength = 0;
            this.txtAddressBookEmail_Address.SelectionStart = 0;
            this.txtAddressBookEmail_Address.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookEmail_Address.TabIndex = 84;
            this.txtAddressBookEmail_Address.UseSelectable = true;
            this.txtAddressBookEmail_Address.UseStyleColors = true;
            this.txtAddressBookEmail_Address.WaterMark = "Enter Email Address";
            this.txtAddressBookEmail_Address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookEmail_Address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookCellphone_Number
            // 
            // 
            // 
            // 
            this.txtAddressBookCellphone_Number.CustomButton.Image = null;
            this.txtAddressBookCellphone_Number.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookCellphone_Number.CustomButton.Name = "";
            this.txtAddressBookCellphone_Number.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookCellphone_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookCellphone_Number.CustomButton.TabIndex = 1;
            this.txtAddressBookCellphone_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookCellphone_Number.CustomButton.UseSelectable = true;
            this.txtAddressBookCellphone_Number.CustomButton.Visible = false;
            this.txtAddressBookCellphone_Number.Lines = new string[0];
            this.txtAddressBookCellphone_Number.Location = new System.Drawing.Point(93, 242);
            this.txtAddressBookCellphone_Number.MaxLength = 32767;
            this.txtAddressBookCellphone_Number.Name = "txtAddressBookCellphone_Number";
            this.txtAddressBookCellphone_Number.PasswordChar = '\0';
            this.txtAddressBookCellphone_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookCellphone_Number.SelectedText = "";
            this.txtAddressBookCellphone_Number.SelectionLength = 0;
            this.txtAddressBookCellphone_Number.SelectionStart = 0;
            this.txtAddressBookCellphone_Number.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookCellphone_Number.TabIndex = 83;
            this.txtAddressBookCellphone_Number.UseSelectable = true;
            this.txtAddressBookCellphone_Number.UseStyleColors = true;
            this.txtAddressBookCellphone_Number.WaterMark = "Enter Cell Number";
            this.txtAddressBookCellphone_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookCellphone_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookFax_Number
            // 
            // 
            // 
            // 
            this.txtAddressBookFax_Number.CustomButton.Image = null;
            this.txtAddressBookFax_Number.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookFax_Number.CustomButton.Name = "";
            this.txtAddressBookFax_Number.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookFax_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookFax_Number.CustomButton.TabIndex = 1;
            this.txtAddressBookFax_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookFax_Number.CustomButton.UseSelectable = true;
            this.txtAddressBookFax_Number.CustomButton.Visible = false;
            this.txtAddressBookFax_Number.Lines = new string[0];
            this.txtAddressBookFax_Number.Location = new System.Drawing.Point(93, 211);
            this.txtAddressBookFax_Number.MaxLength = 32767;
            this.txtAddressBookFax_Number.Name = "txtAddressBookFax_Number";
            this.txtAddressBookFax_Number.PasswordChar = '\0';
            this.txtAddressBookFax_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookFax_Number.SelectedText = "";
            this.txtAddressBookFax_Number.SelectionLength = 0;
            this.txtAddressBookFax_Number.SelectionStart = 0;
            this.txtAddressBookFax_Number.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookFax_Number.TabIndex = 82;
            this.txtAddressBookFax_Number.UseSelectable = true;
            this.txtAddressBookFax_Number.UseStyleColors = true;
            this.txtAddressBookFax_Number.WaterMark = "Enter Fax Number";
            this.txtAddressBookFax_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookFax_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookTelephone_Number
            // 
            // 
            // 
            // 
            this.txtAddressBookTelephone_Number.CustomButton.Image = null;
            this.txtAddressBookTelephone_Number.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookTelephone_Number.CustomButton.Name = "";
            this.txtAddressBookTelephone_Number.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookTelephone_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookTelephone_Number.CustomButton.TabIndex = 1;
            this.txtAddressBookTelephone_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookTelephone_Number.CustomButton.UseSelectable = true;
            this.txtAddressBookTelephone_Number.CustomButton.Visible = false;
            this.txtAddressBookTelephone_Number.Lines = new string[0];
            this.txtAddressBookTelephone_Number.Location = new System.Drawing.Point(93, 180);
            this.txtAddressBookTelephone_Number.MaxLength = 32767;
            this.txtAddressBookTelephone_Number.Name = "txtAddressBookTelephone_Number";
            this.txtAddressBookTelephone_Number.PasswordChar = '\0';
            this.txtAddressBookTelephone_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookTelephone_Number.SelectedText = "";
            this.txtAddressBookTelephone_Number.SelectionLength = 0;
            this.txtAddressBookTelephone_Number.SelectionStart = 0;
            this.txtAddressBookTelephone_Number.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookTelephone_Number.TabIndex = 81;
            this.txtAddressBookTelephone_Number.UseSelectable = true;
            this.txtAddressBookTelephone_Number.UseStyleColors = true;
            this.txtAddressBookTelephone_Number.WaterMark = "Enter Tel Number";
            this.txtAddressBookTelephone_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookTelephone_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookSurname
            // 
            // 
            // 
            // 
            this.txtAddressBookSurname.CustomButton.Image = null;
            this.txtAddressBookSurname.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookSurname.CustomButton.Name = "";
            this.txtAddressBookSurname.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookSurname.CustomButton.TabIndex = 1;
            this.txtAddressBookSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookSurname.CustomButton.UseSelectable = true;
            this.txtAddressBookSurname.CustomButton.Visible = false;
            this.txtAddressBookSurname.Lines = new string[0];
            this.txtAddressBookSurname.Location = new System.Drawing.Point(93, 149);
            this.txtAddressBookSurname.MaxLength = 32767;
            this.txtAddressBookSurname.Name = "txtAddressBookSurname";
            this.txtAddressBookSurname.PasswordChar = '\0';
            this.txtAddressBookSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookSurname.SelectedText = "";
            this.txtAddressBookSurname.SelectionLength = 0;
            this.txtAddressBookSurname.SelectionStart = 0;
            this.txtAddressBookSurname.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookSurname.TabIndex = 80;
            this.txtAddressBookSurname.UseSelectable = true;
            this.txtAddressBookSurname.UseStyleColors = true;
            this.txtAddressBookSurname.WaterMark = "Enter Contact";
            this.txtAddressBookSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookName
            // 
            // 
            // 
            // 
            this.txtAddressBookName.CustomButton.Image = null;
            this.txtAddressBookName.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtAddressBookName.CustomButton.Name = "";
            this.txtAddressBookName.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookName.CustomButton.TabIndex = 1;
            this.txtAddressBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookName.CustomButton.UseSelectable = true;
            this.txtAddressBookName.CustomButton.Visible = false;
            this.txtAddressBookName.Lines = new string[0];
            this.txtAddressBookName.Location = new System.Drawing.Point(93, 118);
            this.txtAddressBookName.MaxLength = 32767;
            this.txtAddressBookName.Name = "txtAddressBookName";
            this.txtAddressBookName.PasswordChar = '\0';
            this.txtAddressBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookName.SelectedText = "";
            this.txtAddressBookName.SelectionLength = 0;
            this.txtAddressBookName.SelectionStart = 0;
            this.txtAddressBookName.Size = new System.Drawing.Size(336, 23);
            this.txtAddressBookName.TabIndex = 79;
            this.txtAddressBookName.UseSelectable = true;
            this.txtAddressBookName.UseStyleColors = true;
            this.txtAddressBookName.WaterMark = "Enter Name";
            this.txtAddressBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressBookNumber
            // 
            // 
            // 
            // 
            this.txtAddressBookNumber.CustomButton.Image = null;
            this.txtAddressBookNumber.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtAddressBookNumber.CustomButton.Name = "";
            this.txtAddressBookNumber.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAddressBookNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressBookNumber.CustomButton.TabIndex = 1;
            this.txtAddressBookNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressBookNumber.CustomButton.UseSelectable = true;
            this.txtAddressBookNumber.CustomButton.Visible = false;
            this.txtAddressBookNumber.Lines = new string[0];
            this.txtAddressBookNumber.Location = new System.Drawing.Point(93, 86);
            this.txtAddressBookNumber.MaxLength = 32767;
            this.txtAddressBookNumber.Name = "txtAddressBookNumber";
            this.txtAddressBookNumber.PasswordChar = '\0';
            this.txtAddressBookNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressBookNumber.SelectedText = "";
            this.txtAddressBookNumber.SelectionLength = 0;
            this.txtAddressBookNumber.SelectionStart = 0;
            this.txtAddressBookNumber.Size = new System.Drawing.Size(120, 23);
            this.txtAddressBookNumber.TabIndex = 78;
            this.txtAddressBookNumber.UseSelectable = true;
            this.txtAddressBookNumber.UseStyleColors = true;
            this.txtAddressBookNumber.WaterMark = "Number";
            this.txtAddressBookNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressBookNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(56, 432);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(31, 19);
            this.metroLabel12.TabIndex = 76;
            this.metroLabel12.Text = "Zip:";
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(17, 401);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(70, 19);
            this.metroLabel11.TabIndex = 75;
            this.metroLabel11.Text = "Address 3:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(17, 370);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(70, 19);
            this.metroLabel10.TabIndex = 74;
            this.metroLabel10.Text = "Address 2:";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 339);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(68, 19);
            this.metroLabel9.TabIndex = 73;
            this.metroLabel9.Text = "Address 1:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(31, 308);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
            this.metroLabel8.TabIndex = 72;
            this.metroLabel8.Text = "Website :";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(43, 277);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 19);
            this.metroLabel7.TabIndex = 71;
            this.metroLabel7.Text = "Email:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(53, 246);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(34, 19);
            this.metroLabel6.TabIndex = 70;
            this.metroLabel6.Text = "Cell:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 215);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 69;
            this.metroLabel5.Text = "Fax:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(58, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(27, 19);
            this.metroLabel4.TabIndex = 68;
            this.metroLabel4.Text = "Tel:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Surname :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "Name:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Number:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBack.Location = new System.Drawing.Point(57, 50);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(48, 25);
            this.lblBack.TabIndex = 98;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(25, 48);
            this.pbBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 22);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 97;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(478, 48);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(119, 25);
            this.metroLabel14.TabIndex = 99;
            this.metroLabel14.Text = "Addressbook";
            // 
            // msmAdBook
            // 
            this.msmAdBook.Owner = this;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(781, 593);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(91, 42);
            this.btnArchive.TabIndex = 119;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseStyleColors = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(686, 593);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 42);
            this.btnDelete.TabIndex = 118;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(590, 593);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 42);
            this.btnUpdate.TabIndex = 117;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseStyleColors = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(491, 593);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 42);
            this.btnAdd.TabIndex = 116;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 593);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(93, 593);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 42);
            this.btnConfirm.TabIndex = 120;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseStyleColors = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 653);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvAddressBook);
            this.Controls.Add(this.txtAddressBookZip_Code);
            this.Controls.Add(this.txtAddressBookAddress3);
            this.Controls.Add(this.txtAddressBookAddress2);
            this.Controls.Add(this.txtAddressBookAddress1);
            this.Controls.Add(this.txtAddressBookWebsite);
            this.Controls.Add(this.txtAddressBookEmail_Address);
            this.Controls.Add(this.txtAddressBookCellphone_Number);
            this.Controls.Add(this.txtAddressBookFax_Number);
            this.Controls.Add(this.txtAddressBookTelephone_Number);
            this.Controls.Add(this.txtAddressBookSurname);
            this.Controls.Add(this.txtAddressBookName);
            this.Controls.Add(this.txtAddressBookNumber);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAddressBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.frmAddressBook_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmAdBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cmbAddressBookCriteria;
        private MetroFramework.Controls.MetroTextBox txtAddressBookSearch;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroGrid dgvAddressBook;
        private MetroFramework.Controls.MetroTextBox txtAddressBookZip_Code;
        private MetroFramework.Controls.MetroTextBox txtAddressBookAddress3;
        private MetroFramework.Controls.MetroTextBox txtAddressBookAddress2;
        private MetroFramework.Controls.MetroTextBox txtAddressBookAddress1;
        private MetroFramework.Controls.MetroTextBox txtAddressBookWebsite;
        private MetroFramework.Controls.MetroTextBox txtAddressBookEmail_Address;
        private MetroFramework.Controls.MetroTextBox txtAddressBookCellphone_Number;
        private MetroFramework.Controls.MetroTextBox txtAddressBookFax_Number;
        private MetroFramework.Controls.MetroTextBox txtAddressBookTelephone_Number;
        private MetroFramework.Controls.MetroTextBox txtAddressBookSurname;
        private MetroFramework.Controls.MetroTextBox txtAddressBookName;
        private MetroFramework.Controls.MetroTextBox txtAddressBookNumber;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblBack;
        private System.Windows.Forms.PictureBox pbBack;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Components.MetroStyleManager msmAdBook;
        private MetroFramework.Controls.MetroButton btnArchive;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnConfirm;
    }
}