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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.cmbConsultCrit = new MetroFramework.Controls.MetroComboBox();
            this.txtConsultationsSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvConsultations = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConsultationsAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsDiagnostic_codes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsICD10 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsService_Code = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsBirthday = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsMember_Number = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsInitials = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsClient = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsDependancy_Code = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationRatesAssesment_type = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationRatesMinutes = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationRatesCode = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationRatesRate = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.cmbConsultCrit);
            this.groupBox3.Controls.Add(this.txtConsultationsSearch);
            this.groupBox3.Controls.Add(this.metroLabel18);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(1049, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(640, 87);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Consultations";
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
            this.metroComboBox1.Location = new System.Drawing.Point(269, 28);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(71, 30);
            this.metroComboBox1.TabIndex = 62;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.Visible = false;
            // 
            // cmbConsultCrit
            // 
            this.cmbConsultCrit.FormattingEnabled = true;
            this.cmbConsultCrit.ItemHeight = 24;
            this.cmbConsultCrit.Items.AddRange(new object[] {
            "Date",
            "Number",
            "First Name",
            "Surname"});
            this.cmbConsultCrit.Location = new System.Drawing.Point(76, 28);
            this.cmbConsultCrit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConsultCrit.Name = "cmbConsultCrit";
            this.cmbConsultCrit.Size = new System.Drawing.Size(187, 30);
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
            this.txtConsultationsSearch.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.txtConsultationsSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsSearch.CustomButton.Name = "";
            this.txtConsultationsSearch.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtConsultationsSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsSearch.CustomButton.TabIndex = 1;
            this.txtConsultationsSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsSearch.CustomButton.UseSelectable = true;
            this.txtConsultationsSearch.CustomButton.Visible = false;
            this.txtConsultationsSearch.Lines = new string[0];
            this.txtConsultationsSearch.Location = new System.Drawing.Point(444, 28);
            this.txtConsultationsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsSearch.MaxLength = 32767;
            this.txtConsultationsSearch.Name = "txtConsultationsSearch";
            this.txtConsultationsSearch.PasswordChar = '\0';
            this.txtConsultationsSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsSearch.SelectedText = "";
            this.txtConsultationsSearch.SelectionLength = 0;
            this.txtConsultationsSearch.SelectionStart = 0;
            this.txtConsultationsSearch.Size = new System.Drawing.Size(188, 36);
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
            this.metroLabel18.Location = new System.Drawing.Point(357, 33);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(79, 20);
            this.metroLabel18.TabIndex = 1;
            this.metroLabel18.Text = "Search For:";
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1710, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
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
            this.dgvConsultations.Location = new System.Drawing.Point(1034, 180);
            this.dgvConsultations.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvConsultations.Size = new System.Drawing.Size(724, 578);
            this.dgvConsultations.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvConsultations.TabIndex = 38;
            this.dgvConsultations.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConsultations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvConsultations.SelectionChanged += new System.EventHandler(this.dgvConsultations_SelectionChanged_1);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(31, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(374, 697);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // txtConsultationsAmount
            // 
            // 
            // 
            // 
            this.txtConsultationsAmount.CustomButton.Image = null;
            this.txtConsultationsAmount.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtConsultationsAmount.CustomButton.Name = "";
            this.txtConsultationsAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsAmount.CustomButton.TabIndex = 1;
            this.txtConsultationsAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsAmount.CustomButton.UseSelectable = true;
            this.txtConsultationsAmount.CustomButton.Visible = false;
            this.txtConsultationsAmount.Lines = new string[0];
            this.txtConsultationsAmount.Location = new System.Drawing.Point(172, 176);
            this.txtConsultationsAmount.MaxLength = 32767;
            this.txtConsultationsAmount.Name = "txtConsultationsAmount";
            this.txtConsultationsAmount.PasswordChar = '\0';
            this.txtConsultationsAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsAmount.SelectedText = "";
            this.txtConsultationsAmount.SelectionLength = 0;
            this.txtConsultationsAmount.SelectionStart = 0;
            this.txtConsultationsAmount.Size = new System.Drawing.Size(152, 23);
            this.txtConsultationsAmount.TabIndex = 37;
            this.txtConsultationsAmount.UseSelectable = true;
            this.txtConsultationsAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(82, 179);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(69, 20);
            this.metroLabel15.TabIndex = 36;
            this.metroLabel15.Text = "Amount :";
            // 
            // cmbConsultationsDiagnostic_codes
            // 
            this.cmbConsultationsDiagnostic_codes.FormattingEnabled = true;
            this.cmbConsultationsDiagnostic_codes.ItemHeight = 24;
            this.cmbConsultationsDiagnostic_codes.Location = new System.Drawing.Point(172, 125);
            this.cmbConsultationsDiagnostic_codes.Name = "cmbConsultationsDiagnostic_codes";
            this.cmbConsultationsDiagnostic_codes.Size = new System.Drawing.Size(154, 30);
            this.cmbConsultationsDiagnostic_codes.TabIndex = 35;
            this.cmbConsultationsDiagnostic_codes.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(21, 135);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(132, 20);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Diagnostics Code :";
            // 
            // cmbConsultationsICD10
            // 
            this.cmbConsultationsICD10.FormattingEnabled = true;
            this.cmbConsultationsICD10.ItemHeight = 24;
            this.cmbConsultationsICD10.Location = new System.Drawing.Point(172, 75);
            this.cmbConsultationsICD10.Name = "cmbConsultationsICD10";
            this.cmbConsultationsICD10.Size = new System.Drawing.Size(155, 30);
            this.cmbConsultationsICD10.TabIndex = 33;
            this.cmbConsultationsICD10.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(52, 75);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 20);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "ICD 10 Codes:";
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(31, 49);
            this.pbMic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(37, 27);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 41;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(707, 822);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 40);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(855, 822);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 40);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1019, 822);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 40);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(39, 448);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 20);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Service Code:";
            // 
            // txtConsultationsService_Code
            // 
            // 
            // 
            // 
            this.txtConsultationsService_Code.CustomButton.Image = null;
            this.txtConsultationsService_Code.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtConsultationsService_Code.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsService_Code.CustomButton.Name = "";
            this.txtConsultationsService_Code.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsService_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsService_Code.CustomButton.TabIndex = 1;
            this.txtConsultationsService_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsService_Code.CustomButton.UseSelectable = true;
            this.txtConsultationsService_Code.CustomButton.Visible = false;
            this.txtConsultationsService_Code.Lines = new string[0];
            this.txtConsultationsService_Code.Location = new System.Drawing.Point(167, 448);
            this.txtConsultationsService_Code.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsService_Code.MaxLength = 32767;
            this.txtConsultationsService_Code.Name = "txtConsultationsService_Code";
            this.txtConsultationsService_Code.PasswordChar = '\0';
            this.txtConsultationsService_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsService_Code.SelectedText = "";
            this.txtConsultationsService_Code.SelectionLength = 0;
            this.txtConsultationsService_Code.SelectionStart = 0;
            this.txtConsultationsService_Code.Size = new System.Drawing.Size(157, 28);
            this.txtConsultationsService_Code.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsService_Code.TabIndex = 15;
            this.txtConsultationsService_Code.UseSelectable = true;
            this.txtConsultationsService_Code.WaterMark = "Enter Service Code";
            this.txtConsultationsService_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsService_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(107, 36);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date:";
            // 
            // txtConsultationsDate
            // 
            this.txtConsultationsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtConsultationsDate.Location = new System.Drawing.Point(170, 33);
            this.txtConsultationsDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtConsultationsDate.Name = "txtConsultationsDate";
            this.txtConsultationsDate.Size = new System.Drawing.Size(156, 30);
            this.txtConsultationsDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDate.TabIndex = 31;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(57, 544);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(88, 20);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Description:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(42, 413);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 20);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Date of birth:";
            // 
            // txtConsultationsBirthday
            // 
            // 
            // 
            // 
            this.txtConsultationsBirthday.CustomButton.Image = null;
            this.txtConsultationsBirthday.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtConsultationsBirthday.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsBirthday.CustomButton.Name = "";
            this.txtConsultationsBirthday.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsBirthday.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsBirthday.CustomButton.TabIndex = 1;
            this.txtConsultationsBirthday.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsBirthday.CustomButton.UseSelectable = true;
            this.txtConsultationsBirthday.CustomButton.Visible = false;
            this.txtConsultationsBirthday.Lines = new string[0];
            this.txtConsultationsBirthday.Location = new System.Drawing.Point(167, 413);
            this.txtConsultationsBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsBirthday.MaxLength = 32767;
            this.txtConsultationsBirthday.Name = "txtConsultationsBirthday";
            this.txtConsultationsBirthday.PasswordChar = '\0';
            this.txtConsultationsBirthday.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsBirthday.SelectedText = "";
            this.txtConsultationsBirthday.SelectionLength = 0;
            this.txtConsultationsBirthday.SelectionStart = 0;
            this.txtConsultationsBirthday.Size = new System.Drawing.Size(157, 28);
            this.txtConsultationsBirthday.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsBirthday.TabIndex = 11;
            this.txtConsultationsBirthday.UseSelectable = true;
            this.txtConsultationsBirthday.WaterMark = "Enter Date of birth";
            this.txtConsultationsBirthday.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsBirthday.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(75, 381);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Number:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(88, 309);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Initials:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(75, 345);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Surname:";
            // 
            // txtConsultationsMember_Number
            // 
            // 
            // 
            // 
            this.txtConsultationsMember_Number.CustomButton.Image = null;
            this.txtConsultationsMember_Number.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtConsultationsMember_Number.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsMember_Number.CustomButton.Name = "";
            this.txtConsultationsMember_Number.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsMember_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsMember_Number.CustomButton.TabIndex = 1;
            this.txtConsultationsMember_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsMember_Number.CustomButton.UseSelectable = true;
            this.txtConsultationsMember_Number.CustomButton.Visible = false;
            this.txtConsultationsMember_Number.Lines = new string[0];
            this.txtConsultationsMember_Number.Location = new System.Drawing.Point(167, 381);
            this.txtConsultationsMember_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsMember_Number.MaxLength = 32767;
            this.txtConsultationsMember_Number.Name = "txtConsultationsMember_Number";
            this.txtConsultationsMember_Number.PasswordChar = '\0';
            this.txtConsultationsMember_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsMember_Number.SelectedText = "";
            this.txtConsultationsMember_Number.SelectionLength = 0;
            this.txtConsultationsMember_Number.SelectionStart = 0;
            this.txtConsultationsMember_Number.Size = new System.Drawing.Size(157, 28);
            this.txtConsultationsMember_Number.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsMember_Number.TabIndex = 7;
            this.txtConsultationsMember_Number.UseSelectable = true;
            this.txtConsultationsMember_Number.WaterMark = "Enter Number";
            this.txtConsultationsMember_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsMember_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsInitials
            // 
            // 
            // 
            // 
            this.txtConsultationsInitials.CustomButton.Image = null;
            this.txtConsultationsInitials.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtConsultationsInitials.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsInitials.CustomButton.Name = "";
            this.txtConsultationsInitials.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsInitials.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsInitials.CustomButton.TabIndex = 1;
            this.txtConsultationsInitials.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsInitials.CustomButton.UseSelectable = true;
            this.txtConsultationsInitials.CustomButton.Visible = false;
            this.txtConsultationsInitials.Lines = new string[0];
            this.txtConsultationsInitials.Location = new System.Drawing.Point(171, 309);
            this.txtConsultationsInitials.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsInitials.MaxLength = 32767;
            this.txtConsultationsInitials.Name = "txtConsultationsInitials";
            this.txtConsultationsInitials.PasswordChar = '\0';
            this.txtConsultationsInitials.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsInitials.SelectedText = "";
            this.txtConsultationsInitials.SelectionLength = 0;
            this.txtConsultationsInitials.SelectionStart = 0;
            this.txtConsultationsInitials.Size = new System.Drawing.Size(157, 28);
            this.txtConsultationsInitials.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsInitials.TabIndex = 8;
            this.txtConsultationsInitials.UseSelectable = true;
            this.txtConsultationsInitials.WaterMark = "Enter Initials";
            this.txtConsultationsInitials.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsInitials.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsSurname
            // 
            // 
            // 
            // 
            this.txtConsultationsSurname.CustomButton.Image = null;
            this.txtConsultationsSurname.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtConsultationsSurname.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsSurname.CustomButton.Name = "";
            this.txtConsultationsSurname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsSurname.CustomButton.TabIndex = 1;
            this.txtConsultationsSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsSurname.CustomButton.UseSelectable = true;
            this.txtConsultationsSurname.CustomButton.Visible = false;
            this.txtConsultationsSurname.Lines = new string[0];
            this.txtConsultationsSurname.Location = new System.Drawing.Point(171, 345);
            this.txtConsultationsSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsSurname.MaxLength = 32767;
            this.txtConsultationsSurname.Name = "txtConsultationsSurname";
            this.txtConsultationsSurname.PasswordChar = '\0';
            this.txtConsultationsSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsSurname.SelectedText = "";
            this.txtConsultationsSurname.SelectionLength = 0;
            this.txtConsultationsSurname.SelectionStart = 0;
            this.txtConsultationsSurname.Size = new System.Drawing.Size(157, 28);
            this.txtConsultationsSurname.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsSurname.TabIndex = 10;
            this.txtConsultationsSurname.UseSelectable = true;
            this.txtConsultationsSurname.WaterMark = "Enter Surname";
            this.txtConsultationsSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(92, 263);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 20);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Client :";
            // 
            // txtConsultationsClient
            // 
            // 
            // 
            // 
            this.txtConsultationsClient.CustomButton.Image = null;
            this.txtConsultationsClient.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtConsultationsClient.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsClient.CustomButton.Name = "";
            this.txtConsultationsClient.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsClient.CustomButton.TabIndex = 1;
            this.txtConsultationsClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsClient.CustomButton.UseSelectable = true;
            this.txtConsultationsClient.CustomButton.Visible = false;
            this.txtConsultationsClient.Lines = new string[0];
            this.txtConsultationsClient.Location = new System.Drawing.Point(169, 263);
            this.txtConsultationsClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsClient.MaxLength = 32767;
            this.txtConsultationsClient.Name = "txtConsultationsClient";
            this.txtConsultationsClient.PasswordChar = '\0';
            this.txtConsultationsClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsClient.SelectedText = "";
            this.txtConsultationsClient.SelectionLength = 0;
            this.txtConsultationsClient.SelectionStart = 0;
            this.txtConsultationsClient.Size = new System.Drawing.Size(157, 28);
            this.txtConsultationsClient.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsClient.TabIndex = 39;
            this.txtConsultationsClient.UseSelectable = true;
            this.txtConsultationsClient.WaterMark = "Enter Number";
            this.txtConsultationsClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(35, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(169, 553);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(153, 120);
            this.metroTextBox1.TabIndex = 40;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsDependancy_Code
            // 
            // 
            // 
            // 
            this.txtConsultationsDependancy_Code.CustomButton.Image = null;
            this.txtConsultationsDependancy_Code.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtConsultationsDependancy_Code.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsDependancy_Code.CustomButton.Name = "";
            this.txtConsultationsDependancy_Code.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsDependancy_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDependancy_Code.CustomButton.TabIndex = 1;
            this.txtConsultationsDependancy_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsDependancy_Code.CustomButton.UseSelectable = true;
            this.txtConsultationsDependancy_Code.CustomButton.Visible = false;
            this.txtConsultationsDependancy_Code.Lines = new string[0];
            this.txtConsultationsDependancy_Code.Location = new System.Drawing.Point(167, 504);
            this.txtConsultationsDependancy_Code.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsDependancy_Code.MaxLength = 32767;
            this.txtConsultationsDependancy_Code.Name = "txtConsultationsDependancy_Code";
            this.txtConsultationsDependancy_Code.PasswordChar = '\0';
            this.txtConsultationsDependancy_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsDependancy_Code.SelectedText = "";
            this.txtConsultationsDependancy_Code.SelectionLength = 0;
            this.txtConsultationsDependancy_Code.SelectionStart = 0;
            this.txtConsultationsDependancy_Code.Size = new System.Drawing.Size(157, 28);
            this.txtConsultationsDependancy_Code.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDependancy_Code.TabIndex = 42;
            this.txtConsultationsDependancy_Code.UseSelectable = true;
            this.txtConsultationsDependancy_Code.WaterMark = "Enter Service Code";
            this.txtConsultationsDependancy_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsDependancy_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(11, 504);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(134, 20);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Dependancy Code:";
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
            this.groupBox2.Location = new System.Drawing.Point(482, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 348);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultation rates";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(20, 39);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(110, 20);
            this.metroLabel12.TabIndex = 0;
            this.metroLabel12.Text = "Assesment type:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(69, 80);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(61, 20);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Minutes:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(81, 120);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(49, 20);
            this.metroLabel14.TabIndex = 2;
            this.metroLabel14.Text = "Code :";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(91, 162);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(39, 20);
            this.metroLabel16.TabIndex = 3;
            this.metroLabel16.Text = "Rate:";
            // 
            // txtConsultationRatesAssesment_type
            // 
            // 
            // 
            // 
            this.txtConsultationRatesAssesment_type.CustomButton.Image = null;
            this.txtConsultationRatesAssesment_type.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtConsultationRatesAssesment_type.CustomButton.Name = "";
            this.txtConsultationRatesAssesment_type.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationRatesAssesment_type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesAssesment_type.CustomButton.TabIndex = 1;
            this.txtConsultationRatesAssesment_type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesAssesment_type.CustomButton.UseSelectable = true;
            this.txtConsultationRatesAssesment_type.CustomButton.Visible = false;
            this.txtConsultationRatesAssesment_type.Lines = new string[0];
            this.txtConsultationRatesAssesment_type.Location = new System.Drawing.Point(174, 39);
            this.txtConsultationRatesAssesment_type.MaxLength = 32767;
            this.txtConsultationRatesAssesment_type.Name = "txtConsultationRatesAssesment_type";
            this.txtConsultationRatesAssesment_type.PasswordChar = '\0';
            this.txtConsultationRatesAssesment_type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesAssesment_type.SelectedText = "";
            this.txtConsultationRatesAssesment_type.SelectionLength = 0;
            this.txtConsultationRatesAssesment_type.SelectionStart = 0;
            this.txtConsultationRatesAssesment_type.Size = new System.Drawing.Size(140, 23);
            this.txtConsultationRatesAssesment_type.TabIndex = 4;
            this.txtConsultationRatesAssesment_type.UseSelectable = true;
            this.txtConsultationRatesAssesment_type.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesAssesment_type.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationRatesMinutes
            // 
            // 
            // 
            // 
            this.txtConsultationRatesMinutes.CustomButton.Image = null;
            this.txtConsultationRatesMinutes.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtConsultationRatesMinutes.CustomButton.Name = "";
            this.txtConsultationRatesMinutes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationRatesMinutes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesMinutes.CustomButton.TabIndex = 1;
            this.txtConsultationRatesMinutes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesMinutes.CustomButton.UseSelectable = true;
            this.txtConsultationRatesMinutes.CustomButton.Visible = false;
            this.txtConsultationRatesMinutes.Lines = new string[0];
            this.txtConsultationRatesMinutes.Location = new System.Drawing.Point(174, 80);
            this.txtConsultationRatesMinutes.MaxLength = 32767;
            this.txtConsultationRatesMinutes.Name = "txtConsultationRatesMinutes";
            this.txtConsultationRatesMinutes.PasswordChar = '\0';
            this.txtConsultationRatesMinutes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesMinutes.SelectedText = "";
            this.txtConsultationRatesMinutes.SelectionLength = 0;
            this.txtConsultationRatesMinutes.SelectionStart = 0;
            this.txtConsultationRatesMinutes.Size = new System.Drawing.Size(140, 23);
            this.txtConsultationRatesMinutes.TabIndex = 5;
            this.txtConsultationRatesMinutes.UseSelectable = true;
            this.txtConsultationRatesMinutes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesMinutes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationRatesCode
            // 
            // 
            // 
            // 
            this.txtConsultationRatesCode.CustomButton.Image = null;
            this.txtConsultationRatesCode.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtConsultationRatesCode.CustomButton.Name = "";
            this.txtConsultationRatesCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationRatesCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesCode.CustomButton.TabIndex = 1;
            this.txtConsultationRatesCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesCode.CustomButton.UseSelectable = true;
            this.txtConsultationRatesCode.CustomButton.Visible = false;
            this.txtConsultationRatesCode.Lines = new string[0];
            this.txtConsultationRatesCode.Location = new System.Drawing.Point(174, 127);
            this.txtConsultationRatesCode.MaxLength = 32767;
            this.txtConsultationRatesCode.Name = "txtConsultationRatesCode";
            this.txtConsultationRatesCode.PasswordChar = '\0';
            this.txtConsultationRatesCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesCode.SelectedText = "";
            this.txtConsultationRatesCode.SelectionLength = 0;
            this.txtConsultationRatesCode.SelectionStart = 0;
            this.txtConsultationRatesCode.Size = new System.Drawing.Size(140, 23);
            this.txtConsultationRatesCode.TabIndex = 6;
            this.txtConsultationRatesCode.UseSelectable = true;
            this.txtConsultationRatesCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationRatesRate
            // 
            // 
            // 
            // 
            this.txtConsultationRatesRate.CustomButton.Image = null;
            this.txtConsultationRatesRate.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtConsultationRatesRate.CustomButton.Name = "";
            this.txtConsultationRatesRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationRatesRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationRatesRate.CustomButton.TabIndex = 1;
            this.txtConsultationRatesRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationRatesRate.CustomButton.UseSelectable = true;
            this.txtConsultationRatesRate.CustomButton.Visible = false;
            this.txtConsultationRatesRate.Lines = new string[0];
            this.txtConsultationRatesRate.Location = new System.Drawing.Point(174, 174);
            this.txtConsultationRatesRate.MaxLength = 32767;
            this.txtConsultationRatesRate.Name = "txtConsultationRatesRate";
            this.txtConsultationRatesRate.PasswordChar = '\0';
            this.txtConsultationRatesRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationRatesRate.SelectedText = "";
            this.txtConsultationRatesRate.SelectionLength = 0;
            this.txtConsultationRatesRate.SelectionStart = 0;
            this.txtConsultationRatesRate.Size = new System.Drawing.Size(140, 23);
            this.txtConsultationRatesRate.TabIndex = 7;
            this.txtConsultationRatesRate.UseSelectable = true;
            this.txtConsultationRatesRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationRatesRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2777, 970);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2777, 970);
            this.MinimumSize = new System.Drawing.Size(1918, 872);
            this.Movable = false;
            this.Name = "frmConsultations";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
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
            this.ResumeLayout(false);

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
    }
}