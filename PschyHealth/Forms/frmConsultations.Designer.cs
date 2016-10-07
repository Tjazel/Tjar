namespace PschyHealth
{
    partial class frmConsultations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultations));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.cmbConsultCrit = new MetroFramework.Controls.MetroComboBox();
            this.txtConsultationsSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvConsultations = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsDependant_Name = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsDependancy_Code = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsClient = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsDiagnostic_codes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsICD10 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsDate = new MetroFramework.Controls.MetroDateTime();
            this.txtConsultationsService_Code = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsBirthday = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsInitials = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsMember_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConsultationRatesRate = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationRatesCode = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationRatesMinutes = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationRatesAssesment_type = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnConfirm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.msmConsult = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnArchive = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.cmbConsultCrit);
            this.groupBox3.Controls.Add(this.txtConsultationsSearch);
            this.groupBox3.Controls.Add(this.metroLabel18);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(787, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 71);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Consultations";
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
            this.metroComboBox1.Location = new System.Drawing.Point(202, 23);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(54, 29);
            this.metroComboBox1.TabIndex = 62;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.Visible = false;
            // 
            // cmbConsultCrit
            // 
            this.cmbConsultCrit.FormattingEnabled = true;
            this.cmbConsultCrit.ItemHeight = 23;
            this.cmbConsultCrit.Items.AddRange(new object[] {
            "Date",
            "Number",
            "First Name",
            "Surname"});
            this.cmbConsultCrit.Location = new System.Drawing.Point(57, 23);
            this.cmbConsultCrit.Name = "cmbConsultCrit";
            this.cmbConsultCrit.Size = new System.Drawing.Size(141, 29);
            this.cmbConsultCrit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbConsultCrit.TabIndex = 3;
            this.cmbConsultCrit.UseSelectable = true;
            this.cmbConsultCrit.SelectedIndexChanged += new System.EventHandler(this.cmbConsultCrit_SelectedIndexChanged);
            // 
            // txtConsultationsSearch
            // 
            // 
            // 
            // 
            this.txtConsultationsSearch.CustomButton.Image = null;
            this.txtConsultationsSearch.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtConsultationsSearch.CustomButton.Name = "";
            this.txtConsultationsSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtConsultationsSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsSearch.CustomButton.TabIndex = 1;
            this.txtConsultationsSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsSearch.CustomButton.UseSelectable = true;
            this.txtConsultationsSearch.CustomButton.Visible = false;
            this.txtConsultationsSearch.Lines = new string[0];
            this.txtConsultationsSearch.Location = new System.Drawing.Point(333, 23);
            this.txtConsultationsSearch.MaxLength = 32767;
            this.txtConsultationsSearch.Name = "txtConsultationsSearch";
            this.txtConsultationsSearch.PasswordChar = '\0';
            this.txtConsultationsSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsSearch.SelectedText = "";
            this.txtConsultationsSearch.SelectionLength = 0;
            this.txtConsultationsSearch.SelectionStart = 0;
            this.txtConsultationsSearch.Size = new System.Drawing.Size(141, 29);
            this.txtConsultationsSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsSearch.TabIndex = 2;
            this.txtConsultationsSearch.UseSelectable = true;
            this.txtConsultationsSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsultationsSearch.TextChanged += new System.EventHandler(this.txtConsultationsSearch_TextChanged);
            this.txtConsultationsSearch.Click += new System.EventHandler(this.txtConsultationsSearch_Click);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(268, 27);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(76, 19);
            this.metroLabel18.TabIndex = 1;
            this.metroLabel18.Text = "Search For:";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1282, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // dgvConsultations
            // 
            this.dgvConsultations.AllowUserToResizeRows = false;
            this.dgvConsultations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConsultations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsultations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultations.EnableHeadersVisualStyles = false;
            this.dgvConsultations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConsultations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConsultations.Location = new System.Drawing.Point(776, 146);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultations.Size = new System.Drawing.Size(543, 470);
            this.dgvConsultations.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvConsultations.TabIndex = 38;
            this.dgvConsultations.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConsultations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvConsultations.SelectionChanged += new System.EventHandler(this.dgvConsultations_SelectionChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel19);
            this.groupBox1.Controls.Add(this.txtConsultationsDependant_Name);
            this.groupBox1.Controls.Add(this.txtConsultationsDependancy_Code);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.txtConsultationsClient);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.txtConsultationsAmount);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.cmbConsultationsDiagnostic_codes);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.cmbConsultationsICD10);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtConsultationsDate);
            this.groupBox1.Controls.Add(this.txtConsultationsService_Code);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtConsultationsBirthday);
            this.groupBox1.Controls.Add(this.txtConsultationsSurname);
            this.groupBox1.Controls.Add(this.txtConsultationsInitials);
            this.groupBox1.Controls.Add(this.txtConsultationsMember_Number);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 566);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(11, 393);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(120, 19);
            this.metroLabel19.TabIndex = 44;
            this.metroLabel19.Text = "Dependant Name:";
            // 
            // txtConsultationsDependant_Name
            // 
            // 
            // 
            // 
            this.txtConsultationsDependant_Name.CustomButton.Image = null;
            this.txtConsultationsDependant_Name.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsDependant_Name.CustomButton.Name = "";
            this.txtConsultationsDependant_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsDependant_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDependant_Name.CustomButton.TabIndex = 1;
            this.txtConsultationsDependant_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsDependant_Name.CustomButton.UseSelectable = true;
            this.txtConsultationsDependant_Name.CustomButton.Visible = false;
            this.txtConsultationsDependant_Name.Lines = new string[0];
            this.txtConsultationsDependant_Name.Location = new System.Drawing.Point(140, 393);
            this.txtConsultationsDependant_Name.MaxLength = 32767;
            this.txtConsultationsDependant_Name.Name = "txtConsultationsDependant_Name";
            this.txtConsultationsDependant_Name.PasswordChar = '\0';
            this.txtConsultationsDependant_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsDependant_Name.SelectedText = "";
            this.txtConsultationsDependant_Name.SelectionLength = 0;
            this.txtConsultationsDependant_Name.SelectionStart = 0;
            this.txtConsultationsDependant_Name.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsDependant_Name.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDependant_Name.TabIndex = 43;
            this.txtConsultationsDependant_Name.UseSelectable = true;
            this.txtConsultationsDependant_Name.WaterMark = "Enter Name";
            this.txtConsultationsDependant_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsDependant_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsDependancy_Code
            // 
            // 
            // 
            // 
            this.txtConsultationsDependancy_Code.CustomButton.Image = null;
            this.txtConsultationsDependancy_Code.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsDependancy_Code.CustomButton.Name = "";
            this.txtConsultationsDependancy_Code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsDependancy_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDependancy_Code.CustomButton.TabIndex = 1;
            this.txtConsultationsDependancy_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsDependancy_Code.CustomButton.UseSelectable = true;
            this.txtConsultationsDependancy_Code.CustomButton.Visible = false;
            this.txtConsultationsDependancy_Code.Lines = new string[0];
            this.txtConsultationsDependancy_Code.Location = new System.Drawing.Point(142, 421);
            this.txtConsultationsDependancy_Code.MaxLength = 32767;
            this.txtConsultationsDependancy_Code.Name = "txtConsultationsDependancy_Code";
            this.txtConsultationsDependancy_Code.PasswordChar = '\0';
            this.txtConsultationsDependancy_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsDependancy_Code.SelectedText = "";
            this.txtConsultationsDependancy_Code.SelectionLength = 0;
            this.txtConsultationsDependancy_Code.SelectionStart = 0;
            this.txtConsultationsDependancy_Code.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsDependancy_Code.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDependancy_Code.TabIndex = 42;
            this.txtConsultationsDependancy_Code.UseSelectable = true;
            this.txtConsultationsDependancy_Code.WaterMark = "Enter Dependancy Code";
            this.txtConsultationsDependancy_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsDependancy_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(15, 421);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 19);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Dependancy Code:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(19, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(142, 449);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(115, 98);
            this.metroTextBox1.TabIndex = 40;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsClient
            // 
            // 
            // 
            // 
            this.txtConsultationsClient.CustomButton.Image = null;
            this.txtConsultationsClient.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsClient.CustomButton.Name = "";
            this.txtConsultationsClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsClient.CustomButton.TabIndex = 1;
            this.txtConsultationsClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsClient.CustomButton.UseSelectable = true;
            this.txtConsultationsClient.CustomButton.Visible = false;
            this.txtConsultationsClient.Lines = new string[0];
            this.txtConsultationsClient.Location = new System.Drawing.Point(142, 214);
            this.txtConsultationsClient.MaxLength = 32767;
            this.txtConsultationsClient.Name = "txtConsultationsClient";
            this.txtConsultationsClient.PasswordChar = '\0';
            this.txtConsultationsClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsClient.SelectedText = "";
            this.txtConsultationsClient.SelectionLength = 0;
            this.txtConsultationsClient.SelectionStart = 0;
            this.txtConsultationsClient.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsClient.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsClient.TabIndex = 39;
            this.txtConsultationsClient.UseSelectable = true;
            this.txtConsultationsClient.WaterMark = "Enter Number";
            this.txtConsultationsClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(84, 214);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Client :";
            // 
            // txtConsultationsAmount
            // 
            // 
            // 
            // 
            this.txtConsultationsAmount.CustomButton.Image = null;
            this.txtConsultationsAmount.CustomButton.Location = new System.Drawing.Point(96, 2);
            this.txtConsultationsAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationsAmount.CustomButton.Name = "";
            this.txtConsultationsAmount.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsultationsAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsAmount.CustomButton.TabIndex = 1;
            this.txtConsultationsAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsAmount.CustomButton.UseSelectable = true;
            this.txtConsultationsAmount.CustomButton.Visible = false;
            this.txtConsultationsAmount.Lines = new string[0];
            this.txtConsultationsAmount.Location = new System.Drawing.Point(144, 143);
            this.txtConsultationsAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationsAmount.MaxLength = 32767;
            this.txtConsultationsAmount.Name = "txtConsultationsAmount";
            this.txtConsultationsAmount.PasswordChar = '\0';
            this.txtConsultationsAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsAmount.SelectedText = "";
            this.txtConsultationsAmount.SelectionLength = 0;
            this.txtConsultationsAmount.SelectionStart = 0;
            this.txtConsultationsAmount.Size = new System.Drawing.Size(114, 20);
            this.txtConsultationsAmount.TabIndex = 37;
            this.txtConsultationsAmount.UseSelectable = true;
            this.txtConsultationsAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(77, 145);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(66, 19);
            this.metroLabel15.TabIndex = 36;
            this.metroLabel15.Text = "Amount :";
            // 
            // cmbConsultationsDiagnostic_codes
            // 
            this.cmbConsultationsDiagnostic_codes.FormattingEnabled = true;
            this.cmbConsultationsDiagnostic_codes.ItemHeight = 23;
            this.cmbConsultationsDiagnostic_codes.Location = new System.Drawing.Point(144, 102);
            this.cmbConsultationsDiagnostic_codes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbConsultationsDiagnostic_codes.Name = "cmbConsultationsDiagnostic_codes";
            this.cmbConsultationsDiagnostic_codes.Size = new System.Drawing.Size(116, 29);
            this.cmbConsultationsDiagnostic_codes.TabIndex = 35;
            this.cmbConsultationsDiagnostic_codes.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(31, 110);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(122, 19);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Diagnostics Code :";
            // 
            // cmbConsultationsICD10
            // 
            this.cmbConsultationsICD10.FormattingEnabled = true;
            this.cmbConsultationsICD10.ItemHeight = 23;
            this.cmbConsultationsICD10.Location = new System.Drawing.Point(144, 61);
            this.cmbConsultationsICD10.Margin = new System.Windows.Forms.Padding(2);
            this.cmbConsultationsICD10.Name = "cmbConsultationsICD10";
            this.cmbConsultationsICD10.Size = new System.Drawing.Size(117, 29);
            this.cmbConsultationsICD10.TabIndex = 33;
            this.cmbConsultationsICD10.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(54, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "ICD 10 Codes:";
            // 
            // txtConsultationsDate
            // 
            this.txtConsultationsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtConsultationsDate.Location = new System.Drawing.Point(143, 27);
            this.txtConsultationsDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtConsultationsDate.Name = "txtConsultationsDate";
            this.txtConsultationsDate.Size = new System.Drawing.Size(118, 29);
            this.txtConsultationsDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDate.TabIndex = 31;
            // 
            // txtConsultationsService_Code
            // 
            // 
            // 
            // 
            this.txtConsultationsService_Code.CustomButton.Image = null;
            this.txtConsultationsService_Code.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsService_Code.CustomButton.Name = "";
            this.txtConsultationsService_Code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsService_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsService_Code.CustomButton.TabIndex = 1;
            this.txtConsultationsService_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsService_Code.CustomButton.UseSelectable = true;
            this.txtConsultationsService_Code.CustomButton.Visible = false;
            this.txtConsultationsService_Code.Lines = new string[0];
            this.txtConsultationsService_Code.Location = new System.Drawing.Point(140, 364);
            this.txtConsultationsService_Code.MaxLength = 32767;
            this.txtConsultationsService_Code.Name = "txtConsultationsService_Code";
            this.txtConsultationsService_Code.PasswordChar = '\0';
            this.txtConsultationsService_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsService_Code.SelectedText = "";
            this.txtConsultationsService_Code.SelectionLength = 0;
            this.txtConsultationsService_Code.SelectionStart = 0;
            this.txtConsultationsService_Code.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsService_Code.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsService_Code.TabIndex = 15;
            this.txtConsultationsService_Code.UseSelectable = true;
            this.txtConsultationsService_Code.WaterMark = "Enter Service Code";
            this.txtConsultationsService_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsService_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(58, 442);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Description:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(44, 364);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Service Code:";
            // 
            // txtConsultationsBirthday
            // 
            // 
            // 
            // 
            this.txtConsultationsBirthday.CustomButton.Image = null;
            this.txtConsultationsBirthday.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsBirthday.CustomButton.Name = "";
            this.txtConsultationsBirthday.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsBirthday.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsBirthday.CustomButton.TabIndex = 1;
            this.txtConsultationsBirthday.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsBirthday.CustomButton.UseSelectable = true;
            this.txtConsultationsBirthday.CustomButton.Visible = false;
            this.txtConsultationsBirthday.Lines = new string[0];
            this.txtConsultationsBirthday.Location = new System.Drawing.Point(140, 336);
            this.txtConsultationsBirthday.MaxLength = 32767;
            this.txtConsultationsBirthday.Name = "txtConsultationsBirthday";
            this.txtConsultationsBirthday.PasswordChar = '\0';
            this.txtConsultationsBirthday.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsBirthday.SelectedText = "";
            this.txtConsultationsBirthday.SelectionLength = 0;
            this.txtConsultationsBirthday.SelectionStart = 0;
            this.txtConsultationsBirthday.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsBirthday.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsBirthday.TabIndex = 11;
            this.txtConsultationsBirthday.UseSelectable = true;
            this.txtConsultationsBirthday.WaterMark = "Enter Date of birth";
            this.txtConsultationsBirthday.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsBirthday.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsSurname
            // 
            // 
            // 
            // 
            this.txtConsultationsSurname.CustomButton.Image = null;
            this.txtConsultationsSurname.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsSurname.CustomButton.Name = "";
            this.txtConsultationsSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsSurname.CustomButton.TabIndex = 1;
            this.txtConsultationsSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsSurname.CustomButton.UseSelectable = true;
            this.txtConsultationsSurname.CustomButton.Visible = false;
            this.txtConsultationsSurname.Lines = new string[0];
            this.txtConsultationsSurname.Location = new System.Drawing.Point(143, 280);
            this.txtConsultationsSurname.MaxLength = 32767;
            this.txtConsultationsSurname.Name = "txtConsultationsSurname";
            this.txtConsultationsSurname.PasswordChar = '\0';
            this.txtConsultationsSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsSurname.SelectedText = "";
            this.txtConsultationsSurname.SelectionLength = 0;
            this.txtConsultationsSurname.SelectionStart = 0;
            this.txtConsultationsSurname.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsSurname.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsSurname.TabIndex = 10;
            this.txtConsultationsSurname.UseSelectable = true;
            this.txtConsultationsSurname.WaterMark = "Enter Surname";
            this.txtConsultationsSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsInitials
            // 
            // 
            // 
            // 
            this.txtConsultationsInitials.CustomButton.Image = null;
            this.txtConsultationsInitials.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsInitials.CustomButton.Name = "";
            this.txtConsultationsInitials.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsInitials.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsInitials.CustomButton.TabIndex = 1;
            this.txtConsultationsInitials.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsInitials.CustomButton.UseSelectable = true;
            this.txtConsultationsInitials.CustomButton.Visible = false;
            this.txtConsultationsInitials.Lines = new string[0];
            this.txtConsultationsInitials.Location = new System.Drawing.Point(143, 251);
            this.txtConsultationsInitials.MaxLength = 32767;
            this.txtConsultationsInitials.Name = "txtConsultationsInitials";
            this.txtConsultationsInitials.PasswordChar = '\0';
            this.txtConsultationsInitials.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsInitials.SelectedText = "";
            this.txtConsultationsInitials.SelectionLength = 0;
            this.txtConsultationsInitials.SelectionStart = 0;
            this.txtConsultationsInitials.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsInitials.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsInitials.TabIndex = 8;
            this.txtConsultationsInitials.UseSelectable = true;
            this.txtConsultationsInitials.WaterMark = "Enter Initials";
            this.txtConsultationsInitials.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsInitials.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsMember_Number
            // 
            // 
            // 
            // 
            this.txtConsultationsMember_Number.CustomButton.Image = null;
            this.txtConsultationsMember_Number.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtConsultationsMember_Number.CustomButton.Name = "";
            this.txtConsultationsMember_Number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsMember_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsMember_Number.CustomButton.TabIndex = 1;
            this.txtConsultationsMember_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsMember_Number.CustomButton.UseSelectable = true;
            this.txtConsultationsMember_Number.CustomButton.Visible = false;
            this.txtConsultationsMember_Number.Lines = new string[0];
            this.txtConsultationsMember_Number.Location = new System.Drawing.Point(140, 310);
            this.txtConsultationsMember_Number.MaxLength = 32767;
            this.txtConsultationsMember_Number.Name = "txtConsultationsMember_Number";
            this.txtConsultationsMember_Number.PasswordChar = '\0';
            this.txtConsultationsMember_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsMember_Number.SelectedText = "";
            this.txtConsultationsMember_Number.SelectionLength = 0;
            this.txtConsultationsMember_Number.SelectionStart = 0;
            this.txtConsultationsMember_Number.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsMember_Number.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsMember_Number.TabIndex = 7;
            this.txtConsultationsMember_Number.UseSelectable = true;
            this.txtConsultationsMember_Number.WaterMark = "Enter Number";
            this.txtConsultationsMember_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsMember_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(47, 336);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Date of birth:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(71, 280);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Surname:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(81, 251);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Initials:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(71, 310);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Number:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(95, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date:";
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(23, 40);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(28, 22);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 41;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 661);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(179, 661);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 32);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 661);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 32);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConsultationRatesRate);
            this.groupBox2.Controls.Add(this.txtConsultationRatesCode);
            this.groupBox2.Controls.Add(this.txtConsultationRatesMinutes);
            this.groupBox2.Controls.Add(this.txtConsultationRatesAssesment_type);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Location = new System.Drawing.Point(362, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(266, 283);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultation rates";
            // 
            // txtConsultationRatesRate
            // 
            // 
            // 
            // 
            this.txtConsultationRatesRate.CustomButton.Image = null;
            this.txtConsultationRatesRate.CustomButton.Location = new System.Drawing.Point(96, 2);
            this.txtConsultationRatesRate.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesRate.CustomButton.Name = "";
            this.txtConsultationRatesRate.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsultationRatesRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesRate.CustomButton.TabIndex = 1;
            this.txtConsultationRatesRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesRate.CustomButton.UseSelectable = true;
            this.txtConsultationRatesRate.CustomButton.Visible = false;
            this.txtConsultationRatesRate.Lines = new string[0];
            this.txtConsultationRatesRate.Location = new System.Drawing.Point(130, 141);
            this.txtConsultationRatesRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesRate.MaxLength = 32767;
            this.txtConsultationRatesRate.Name = "txtConsultationRatesRate";
            this.txtConsultationRatesRate.PasswordChar = '\0';
            this.txtConsultationRatesRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesRate.SelectedText = "";
            this.txtConsultationRatesRate.SelectionLength = 0;
            this.txtConsultationRatesRate.SelectionStart = 0;
            this.txtConsultationRatesRate.Size = new System.Drawing.Size(114, 20);
            this.txtConsultationRatesRate.TabIndex = 7;
            this.txtConsultationRatesRate.UseSelectable = true;
            this.txtConsultationRatesRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationRatesCode
            // 
            // 
            // 
            // 
            this.txtConsultationRatesCode.CustomButton.Image = null;
            this.txtConsultationRatesCode.CustomButton.Location = new System.Drawing.Point(96, 2);
            this.txtConsultationRatesCode.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesCode.CustomButton.Name = "";
            this.txtConsultationRatesCode.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsultationRatesCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesCode.CustomButton.TabIndex = 1;
            this.txtConsultationRatesCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesCode.CustomButton.UseSelectable = true;
            this.txtConsultationRatesCode.CustomButton.Visible = false;
            this.txtConsultationRatesCode.Lines = new string[0];
            this.txtConsultationRatesCode.Location = new System.Drawing.Point(130, 103);
            this.txtConsultationRatesCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesCode.MaxLength = 32767;
            this.txtConsultationRatesCode.Name = "txtConsultationRatesCode";
            this.txtConsultationRatesCode.PasswordChar = '\0';
            this.txtConsultationRatesCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesCode.SelectedText = "";
            this.txtConsultationRatesCode.SelectionLength = 0;
            this.txtConsultationRatesCode.SelectionStart = 0;
            this.txtConsultationRatesCode.Size = new System.Drawing.Size(114, 20);
            this.txtConsultationRatesCode.TabIndex = 6;
            this.txtConsultationRatesCode.UseSelectable = true;
            this.txtConsultationRatesCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationRatesMinutes
            // 
            // 
            // 
            // 
            this.txtConsultationRatesMinutes.CustomButton.Image = null;
            this.txtConsultationRatesMinutes.CustomButton.Location = new System.Drawing.Point(96, 2);
            this.txtConsultationRatesMinutes.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesMinutes.CustomButton.Name = "";
            this.txtConsultationRatesMinutes.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsultationRatesMinutes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesMinutes.CustomButton.TabIndex = 1;
            this.txtConsultationRatesMinutes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesMinutes.CustomButton.UseSelectable = true;
            this.txtConsultationRatesMinutes.CustomButton.Visible = false;
            this.txtConsultationRatesMinutes.Lines = new string[0];
            this.txtConsultationRatesMinutes.Location = new System.Drawing.Point(130, 65);
            this.txtConsultationRatesMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesMinutes.MaxLength = 32767;
            this.txtConsultationRatesMinutes.Name = "txtConsultationRatesMinutes";
            this.txtConsultationRatesMinutes.PasswordChar = '\0';
            this.txtConsultationRatesMinutes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesMinutes.SelectedText = "";
            this.txtConsultationRatesMinutes.SelectionLength = 0;
            this.txtConsultationRatesMinutes.SelectionStart = 0;
            this.txtConsultationRatesMinutes.Size = new System.Drawing.Size(114, 20);
            this.txtConsultationRatesMinutes.TabIndex = 5;
            this.txtConsultationRatesMinutes.UseSelectable = true;
            this.txtConsultationRatesMinutes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesMinutes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationRatesAssesment_type
            // 
            // 
            // 
            // 
            this.txtConsultationRatesAssesment_type.CustomButton.Image = null;
            this.txtConsultationRatesAssesment_type.CustomButton.Location = new System.Drawing.Point(96, 2);
            this.txtConsultationRatesAssesment_type.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesAssesment_type.CustomButton.Name = "";
            this.txtConsultationRatesAssesment_type.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsultationRatesAssesment_type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesAssesment_type.CustomButton.TabIndex = 1;
            this.txtConsultationRatesAssesment_type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesAssesment_type.CustomButton.UseSelectable = true;
            this.txtConsultationRatesAssesment_type.CustomButton.Visible = false;
            this.txtConsultationRatesAssesment_type.Lines = new string[0];
            this.txtConsultationRatesAssesment_type.Location = new System.Drawing.Point(130, 32);
            this.txtConsultationRatesAssesment_type.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultationRatesAssesment_type.MaxLength = 32767;
            this.txtConsultationRatesAssesment_type.Name = "txtConsultationRatesAssesment_type";
            this.txtConsultationRatesAssesment_type.PasswordChar = '\0';
            this.txtConsultationRatesAssesment_type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesAssesment_type.SelectedText = "";
            this.txtConsultationRatesAssesment_type.SelectionLength = 0;
            this.txtConsultationRatesAssesment_type.SelectionStart = 0;
            this.txtConsultationRatesAssesment_type.Size = new System.Drawing.Size(114, 20);
            this.txtConsultationRatesAssesment_type.TabIndex = 4;
            this.txtConsultationRatesAssesment_type.UseSelectable = true;
            this.txtConsultationRatesAssesment_type.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesAssesment_type.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(68, 132);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(38, 19);
            this.metroLabel16.TabIndex = 3;
            this.metroLabel16.Text = "Rate:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(61, 98);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(48, 19);
            this.metroLabel14.TabIndex = 2;
            this.metroLabel14.Text = "Code :";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(52, 65);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(57, 19);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Minutes:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(15, 32);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(102, 19);
            this.metroLabel12.TabIndex = 0;
            this.metroLabel12.Text = "Assesment type:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Maroon;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(16, 661);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(76, 32);
            this.btnConfirm.TabIndex = 64;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseCustomBackColor = true;
            this.btnConfirm.UseCustomForeColor = true;
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBack.Location = new System.Drawing.Point(56, 41);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(48, 25);
            this.lblBack.TabIndex = 101;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(449, 41);
            this.metroLabel20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(120, 25);
            this.metroLabel20.TabIndex = 100;
            this.metroLabel20.Text = "Consultations";
            // 
            // msmConsult
            // 
            this.msmConsult.Owner = this;
            // 
            // btnArchive
            // 
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(449, 369);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(104, 23);
            this.btnArchive.TabIndex = 102;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // frmConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 788);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(2083, 788);
            this.MinimumSize = new System.Drawing.Size(1438, 708);
            this.Movable = false;
            this.Name = "frmConsultations";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Consultations_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmConsult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cmbConsultCrit;
        private MetroFramework.Controls.MetroTextBox txtConsultationsSearch;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid dgvConsultations;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroComboBox cmbConsultationsDiagnostic_codes;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cmbConsultationsICD10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtConsultationsAmount;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox txtConsultationsService_Code;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtConsultationsDependancy_Code;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox txtConsultationsClient;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime txtConsultationsDate;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtConsultationsBirthday;
        private MetroFramework.Controls.MetroTextBox txtConsultationsSurname;
        private MetroFramework.Controls.MetroTextBox txtConsultationsInitials;
        private MetroFramework.Controls.MetroTextBox txtConsultationsMember_Number;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtConsultationRatesRate;
        private MetroFramework.Controls.MetroTextBox txtConsultationRatesCode;
        private MetroFramework.Controls.MetroTextBox txtConsultationRatesMinutes;
        private MetroFramework.Controls.MetroTextBox txtConsultationRatesAssesment_type;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txtConsultationsDependant_Name;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConfirm;
        private MetroFramework.Controls.MetroLabel lblBack;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Components.MetroStyleManager msmConsult;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnArchive;
    }
}