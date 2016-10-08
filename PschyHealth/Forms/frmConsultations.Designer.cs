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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtConsultationsConsultation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsDependant_Name = new MetroFramework.Controls.MetroComboBox();
            this.txtConsultationsAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsSurname = new MetroFramework.Controls.MetroComboBox();
            this.cmbConsultationsDiagnostic_codes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsName = new MetroFramework.Controls.MetroComboBox();
            this.cmbConsultationsICD10 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsDate = new MetroFramework.Controls.MetroDateTime();
            this.txtConsultationsDependancy_Code = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsMember_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.msmConsult = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnArchive = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmbConsultationsDate_Of_Birth = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsPaid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsDate_Finished = new MetroFramework.Controls.MetroDateTime();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(1709, 132);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultations.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultations.EnableHeadersVisualStyles = false;
            this.dgvConsultations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConsultations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConsultations.Location = new System.Drawing.Point(805, 180);
            this.dgvConsultations.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsultations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultations.Size = new System.Drawing.Size(954, 578);
            this.dgvConsultations.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvConsultations.TabIndex = 38;
            this.dgvConsultations.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConsultations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvConsultations.SelectionChanged += new System.EventHandler(this.dgvConsultations_SelectionChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbConsultationsDate_Finished);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtConsultationsPaid);
            this.groupBox1.Controls.Add(this.txtConsultationsDescription);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.cmbConsultationsDate_Of_Birth);
            this.groupBox1.Controls.Add(this.txtConsultationsConsultation);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cmbConsultationsDependant_Name);
            this.groupBox1.Controls.Add(this.txtConsultationsAmount);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.cmbConsultationsSurname);
            this.groupBox1.Controls.Add(this.cmbConsultationsDiagnostic_codes);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.cmbConsultationsName);
            this.groupBox1.Controls.Add(this.cmbConsultationsICD10);
            this.groupBox1.Controls.Add(this.metroLabel19);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtConsultationsDate);
            this.groupBox1.Controls.Add(this.txtConsultationsDependancy_Code);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.txtConsultationsMember_Number);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(21, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(383, 822);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // txtConsultationsConsultation
            // 
            // 
            // 
            // 
            this.txtConsultationsConsultation.CustomButton.Image = null;
            this.txtConsultationsConsultation.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtConsultationsConsultation.CustomButton.Name = "";
            this.txtConsultationsConsultation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsConsultation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsConsultation.CustomButton.TabIndex = 1;
            this.txtConsultationsConsultation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsConsultation.CustomButton.UseSelectable = true;
            this.txtConsultationsConsultation.CustomButton.Visible = false;
            this.txtConsultationsConsultation.Lines = new string[0];
            this.txtConsultationsConsultation.Location = new System.Drawing.Point(179, 233);
            this.txtConsultationsConsultation.MaxLength = 32767;
            this.txtConsultationsConsultation.Name = "txtConsultationsConsultation";
            this.txtConsultationsConsultation.PasswordChar = '\0';
            this.txtConsultationsConsultation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsConsultation.SelectedText = "";
            this.txtConsultationsConsultation.SelectionLength = 0;
            this.txtConsultationsConsultation.SelectionStart = 0;
            this.txtConsultationsConsultation.Size = new System.Drawing.Size(158, 23);
            this.txtConsultationsConsultation.TabIndex = 49;
            this.txtConsultationsConsultation.UseSelectable = true;
            this.txtConsultationsConsultation.UseStyleColors = true;
            this.txtConsultationsConsultation.WaterMark = "Enter the number of consultation";
            this.txtConsultationsConsultation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsConsultation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(74, 236);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 20);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Consultations :";
            // 
            // cmbConsultationsDependant_Name
            // 
            this.cmbConsultationsDependant_Name.FormattingEnabled = true;
            this.cmbConsultationsDependant_Name.ItemHeight = 24;
            this.cmbConsultationsDependant_Name.Location = new System.Drawing.Point(175, 686);
            this.cmbConsultationsDependant_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConsultationsDependant_Name.Name = "cmbConsultationsDependant_Name";
            this.cmbConsultationsDependant_Name.Size = new System.Drawing.Size(157, 30);
            this.cmbConsultationsDependant_Name.TabIndex = 47;
            this.cmbConsultationsDependant_Name.UseSelectable = true;
            // 
            // txtConsultationsAmount
            // 
            // 
            // 
            // 
            this.txtConsultationsAmount.CustomButton.Image = null;
            this.txtConsultationsAmount.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtConsultationsAmount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultationsAmount.CustomButton.Name = "";
            this.txtConsultationsAmount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultationsAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsAmount.CustomButton.TabIndex = 1;
            this.txtConsultationsAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsAmount.CustomButton.UseSelectable = true;
            this.txtConsultationsAmount.CustomButton.Visible = false;
            this.txtConsultationsAmount.Lines = new string[0];
            this.txtConsultationsAmount.Location = new System.Drawing.Point(175, 506);
            this.txtConsultationsAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultationsAmount.MaxLength = 32767;
            this.txtConsultationsAmount.Name = "txtConsultationsAmount";
            this.txtConsultationsAmount.PasswordChar = '\0';
            this.txtConsultationsAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsAmount.SelectedText = "";
            this.txtConsultationsAmount.SelectionLength = 0;
            this.txtConsultationsAmount.SelectionStart = 0;
            this.txtConsultationsAmount.Size = new System.Drawing.Size(167, 25);
            this.txtConsultationsAmount.TabIndex = 37;
            this.txtConsultationsAmount.UseSelectable = true;
            this.txtConsultationsAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(85, 506);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(69, 20);
            this.metroLabel15.TabIndex = 36;
            this.metroLabel15.Text = "Amount :";
            // 
            // cmbConsultationsSurname
            // 
            this.cmbConsultationsSurname.FormattingEnabled = true;
            this.cmbConsultationsSurname.ItemHeight = 24;
            this.cmbConsultationsSurname.Location = new System.Drawing.Point(183, 93);
            this.cmbConsultationsSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConsultationsSurname.Name = "cmbConsultationsSurname";
            this.cmbConsultationsSurname.Size = new System.Drawing.Size(153, 30);
            this.cmbConsultationsSurname.TabIndex = 46;
            this.cmbConsultationsSurname.UseSelectable = true;
            // 
            // cmbConsultationsDiagnostic_codes
            // 
            this.cmbConsultationsDiagnostic_codes.FormattingEnabled = true;
            this.cmbConsultationsDiagnostic_codes.ItemHeight = 24;
            this.cmbConsultationsDiagnostic_codes.Location = new System.Drawing.Point(180, 399);
            this.cmbConsultationsDiagnostic_codes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConsultationsDiagnostic_codes.Name = "cmbConsultationsDiagnostic_codes";
            this.cmbConsultationsDiagnostic_codes.Size = new System.Drawing.Size(153, 30);
            this.cmbConsultationsDiagnostic_codes.TabIndex = 35;
            this.cmbConsultationsDiagnostic_codes.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(29, 408);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(132, 20);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Diagnostics Code :";
            // 
            // cmbConsultationsName
            // 
            this.cmbConsultationsName.FormattingEnabled = true;
            this.cmbConsultationsName.ItemHeight = 24;
            this.cmbConsultationsName.Location = new System.Drawing.Point(183, 59);
            this.cmbConsultationsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConsultationsName.Name = "cmbConsultationsName";
            this.cmbConsultationsName.Size = new System.Drawing.Size(153, 30);
            this.cmbConsultationsName.TabIndex = 45;
            this.cmbConsultationsName.UseSelectable = true;
            // 
            // cmbConsultationsICD10
            // 
            this.cmbConsultationsICD10.FormattingEnabled = true;
            this.cmbConsultationsICD10.ItemHeight = 24;
            this.cmbConsultationsICD10.Location = new System.Drawing.Point(175, 450);
            this.cmbConsultationsICD10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConsultationsICD10.Name = "cmbConsultationsICD10";
            this.cmbConsultationsICD10.Size = new System.Drawing.Size(155, 30);
            this.cmbConsultationsICD10.TabIndex = 33;
            this.cmbConsultationsICD10.UseSelectable = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(21, 688);
            this.metroLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(130, 20);
            this.metroLabel19.TabIndex = 44;
            this.metroLabel19.Text = "Dependant Name:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(55, 450);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 20);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "ICD 10 Codes:";
            // 
            // txtConsultationsDate
            // 
            this.txtConsultationsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtConsultationsDate.Location = new System.Drawing.Point(181, 272);
            this.txtConsultationsDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultationsDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtConsultationsDate.Name = "txtConsultationsDate";
            this.txtConsultationsDate.Size = new System.Drawing.Size(156, 30);
            this.txtConsultationsDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDate.TabIndex = 31;
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
            this.txtConsultationsDependancy_Code.Location = new System.Drawing.Point(173, 722);
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
            this.txtConsultationsDependancy_Code.WaterMark = "Enter Dependancy Code";
            this.txtConsultationsDependancy_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsDependancy_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(117, 275);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(54, 59);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(95, 20);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Client name :";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(26, 722);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(134, 20);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Dependancy Code:";
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
            this.txtConsultationsMember_Number.Location = new System.Drawing.Point(179, 142);
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(53, 188);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 20);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Date of birth:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(39, 103);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Client Surname:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(85, 150);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Number:";
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
            this.btnAdd.Location = new System.Drawing.Point(805, 784);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 39);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(916, 784);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 39);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1026, 784);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 39);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Maroon;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(697, 784);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(101, 39);
            this.btnConfirm.TabIndex = 64;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseStyleColors = true;
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
            this.lblBack.Location = new System.Drawing.Point(75, 50);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(51, 25);
            this.lblBack.TabIndex = 101;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // msmConsult
            // 
            this.msmConsult.Owner = this;
            // 
            // btnArchive
            // 
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(1137, 784);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(104, 39);
            this.btnArchive.TabIndex = 102;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // cmbConsultationsDate_Of_Birth
            // 
            this.cmbConsultationsDate_Of_Birth.Location = new System.Drawing.Point(177, 188);
            this.cmbConsultationsDate_Of_Birth.MinimumSize = new System.Drawing.Size(0, 30);
            this.cmbConsultationsDate_Of_Birth.Name = "cmbConsultationsDate_Of_Birth";
            this.cmbConsultationsDate_Of_Birth.Size = new System.Drawing.Size(159, 30);
            this.cmbConsultationsDate_Of_Birth.TabIndex = 103;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(71, 333);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(86, 20);
            this.metroLabel12.TabIndex = 104;
            this.metroLabel12.Text = "Description :";
            // 
            // txtConsultationsDescription
            // 
            // 
            // 
            // 
            this.txtConsultationsDescription.CustomButton.Image = null;
            this.txtConsultationsDescription.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txtConsultationsDescription.CustomButton.Name = "";
            this.txtConsultationsDescription.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtConsultationsDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDescription.CustomButton.TabIndex = 1;
            this.txtConsultationsDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsDescription.CustomButton.UseSelectable = true;
            this.txtConsultationsDescription.CustomButton.Visible = false;
            this.txtConsultationsDescription.Lines = new string[0];
            this.txtConsultationsDescription.Location = new System.Drawing.Point(180, 330);
            this.txtConsultationsDescription.MaxLength = 32767;
            this.txtConsultationsDescription.Multiline = true;
            this.txtConsultationsDescription.Name = "txtConsultationsDescription";
            this.txtConsultationsDescription.PasswordChar = '\0';
            this.txtConsultationsDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsDescription.SelectedText = "";
            this.txtConsultationsDescription.SelectionLength = 0;
            this.txtConsultationsDescription.SelectionStart = 0;
            this.txtConsultationsDescription.Size = new System.Drawing.Size(162, 64);
            this.txtConsultationsDescription.TabIndex = 105;
            this.txtConsultationsDescription.UseSelectable = true;
            this.txtConsultationsDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsPaid
            // 
            // 
            // 
            // 
            this.txtConsultationsPaid.CustomButton.Image = null;
            this.txtConsultationsPaid.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtConsultationsPaid.CustomButton.Name = "";
            this.txtConsultationsPaid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConsultationsPaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsPaid.CustomButton.TabIndex = 1;
            this.txtConsultationsPaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsPaid.CustomButton.UseSelectable = true;
            this.txtConsultationsPaid.CustomButton.Visible = false;
            this.txtConsultationsPaid.Lines = new string[0];
            this.txtConsultationsPaid.Location = new System.Drawing.Point(175, 571);
            this.txtConsultationsPaid.MaxLength = 32767;
            this.txtConsultationsPaid.Name = "txtConsultationsPaid";
            this.txtConsultationsPaid.PasswordChar = '\0';
            this.txtConsultationsPaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsPaid.SelectedText = "";
            this.txtConsultationsPaid.SelectionLength = 0;
            this.txtConsultationsPaid.SelectionStart = 0;
            this.txtConsultationsPaid.Size = new System.Drawing.Size(167, 23);
            this.txtConsultationsPaid.TabIndex = 106;
            this.txtConsultationsPaid.UseSelectable = true;
            this.txtConsultationsPaid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsPaid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(108, 574);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 20);
            this.metroLabel7.TabIndex = 107;
            this.metroLabel7.Text = "Paid :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(54, 640);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 20);
            this.metroLabel8.TabIndex = 108;
            this.metroLabel8.Text = "Date finished :";
            // 
            // cmbConsultationsDate_Finished
            // 
            this.cmbConsultationsDate_Finished.Location = new System.Drawing.Point(175, 630);
            this.cmbConsultationsDate_Finished.MinimumSize = new System.Drawing.Size(0, 30);
            this.cmbConsultationsDate_Finished.Name = "cmbConsultationsDate_Finished";
            this.cmbConsultationsDate_Finished.Size = new System.Drawing.Size(162, 30);
            this.cmbConsultationsDate_Finished.TabIndex = 109;
            // 
            // frmConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 960);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnConfirm);
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
            this.MinimumSize = new System.Drawing.Size(1819, 871);
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
        private MetroFramework.Controls.MetroTextBox txtConsultationsDependancy_Code;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime txtConsultationsDate;
        private MetroFramework.Controls.MetroTextBox txtConsultationsMember_Number;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConfirm;
        private MetroFramework.Controls.MetroLabel lblBack;
        private MetroFramework.Components.MetroStyleManager msmConsult;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnArchive;
        private MetroFramework.Controls.MetroComboBox cmbConsultationsDependant_Name;
        private MetroFramework.Controls.MetroComboBox cmbConsultationsSurname;
        private MetroFramework.Controls.MetroComboBox cmbConsultationsName;
        private MetroFramework.Controls.MetroTextBox txtConsultationsConsultation;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime cmbConsultationsDate_Of_Birth;
        private MetroFramework.Controls.MetroDateTime cmbConsultationsDate_Finished;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtConsultationsPaid;
        private MetroFramework.Controls.MetroTextBox txtConsultationsDescription;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}