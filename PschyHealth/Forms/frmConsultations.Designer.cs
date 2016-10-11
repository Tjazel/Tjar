﻿namespace PschyHealth
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.cmbConsultCrit = new MetroFramework.Controls.MetroComboBox();
            this.txtConsultationsSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.dgvConsultations = new MetroFramework.Controls.MetroGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbConsultationsDate_Finished = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtConsultationsPaid = new MetroFramework.Controls.MetroTextBox();
            this.txtConsultationsDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cmbConsultationsDate_Of_Birth = new MetroFramework.Controls.MetroDateTime();
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
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.msmConsult = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.btnArchive = new MetroFramework.Controls.MetroButton();
            this.groupBox3.SuspendLayout();
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
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(54, 29);
            this.metroComboBox1.TabIndex = 62;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
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
            this.cmbConsultCrit.TabIndex = 3;
            this.cmbConsultCrit.UseSelectable = true;
            this.cmbConsultCrit.UseStyleColors = true;
            this.cmbConsultCrit.SelectedIndexChanged += new System.EventHandler(this.cmbConsultCrit_SelectedIndexChanged);
            // 
            // txtConsultationsSearch
            // 
            // 
            // 
            // 
            this.txtConsultationsSearch.CustomButton.Image = null;
            this.txtConsultationsSearch.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtConsultationsSearch.CustomButton.Name = "";
            this.txtConsultationsSearch.CustomButton.Size = new System.Drawing.Size(20, 22);
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
            this.txtConsultationsSearch.TabIndex = 2;
            this.txtConsultationsSearch.UseSelectable = true;
            this.txtConsultationsSearch.UseStyleColors = true;
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
            this.metroLabel18.UseStyleColors = true;
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
            // dgvConsultations
            // 
            this.dgvConsultations.AllowUserToResizeRows = false;
            this.dgvConsultations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvConsultations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsultations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultations.EnableHeadersVisualStyles = false;
            this.dgvConsultations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConsultations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvConsultations.Location = new System.Drawing.Point(604, 146);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultations.Size = new System.Drawing.Size(716, 470);
            this.dgvConsultations.TabIndex = 38;
            this.dgvConsultations.UseStyleColors = true;
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
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 622);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // cmbConsultationsDate_Finished
            // 
            this.cmbConsultationsDate_Finished.Enabled = false;
            this.cmbConsultationsDate_Finished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbConsultationsDate_Finished.Location = new System.Drawing.Point(131, 512);
            this.cmbConsultationsDate_Finished.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConsultationsDate_Finished.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbConsultationsDate_Finished.Name = "cmbConsultationsDate_Finished";
            this.cmbConsultationsDate_Finished.Size = new System.Drawing.Size(122, 30);
            this.cmbConsultationsDate_Finished.TabIndex = 109;
            this.cmbConsultationsDate_Finished.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Enabled = false;
            this.metroLabel8.Location = new System.Drawing.Point(40, 520);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(91, 19);
            this.metroLabel8.TabIndex = 108;
            this.metroLabel8.Text = "Date finished :";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Enabled = false;
            this.metroLabel7.Location = new System.Drawing.Point(81, 466);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 107;
            this.metroLabel7.Text = "Paid :";
            this.metroLabel7.UseStyleColors = true;
            // 
            // txtConsultationsPaid
            // 
            // 
            // 
            // 
            this.txtConsultationsPaid.CustomButton.Image = null;
            this.txtConsultationsPaid.CustomButton.Location = new System.Drawing.Point(107, 2);
            this.txtConsultationsPaid.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsPaid.CustomButton.Name = "";
            this.txtConsultationsPaid.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsultationsPaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsPaid.CustomButton.TabIndex = 1;
            this.txtConsultationsPaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsPaid.CustomButton.UseSelectable = true;
            this.txtConsultationsPaid.CustomButton.Visible = false;
            this.txtConsultationsPaid.Enabled = false;
            this.txtConsultationsPaid.Lines = new string[0];
            this.txtConsultationsPaid.Location = new System.Drawing.Point(131, 464);
            this.txtConsultationsPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsPaid.MaxLength = 32767;
            this.txtConsultationsPaid.Name = "txtConsultationsPaid";
            this.txtConsultationsPaid.PasswordChar = '\0';
            this.txtConsultationsPaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsPaid.SelectedText = "";
            this.txtConsultationsPaid.SelectionLength = 0;
            this.txtConsultationsPaid.SelectionStart = 0;
            this.txtConsultationsPaid.Size = new System.Drawing.Size(125, 20);
            this.txtConsultationsPaid.TabIndex = 106;
            this.txtConsultationsPaid.UseSelectable = true;
            this.txtConsultationsPaid.UseStyleColors = true;
            this.txtConsultationsPaid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsPaid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsultationsDescription
            // 
            // 
            // 
            // 
            this.txtConsultationsDescription.CustomButton.Image = null;
            this.txtConsultationsDescription.CustomButton.Location = new System.Drawing.Point(54, 2);
            this.txtConsultationsDescription.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsDescription.CustomButton.Name = "";
            this.txtConsultationsDescription.CustomButton.Size = new System.Drawing.Size(35, 38);
            this.txtConsultationsDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDescription.CustomButton.TabIndex = 1;
            this.txtConsultationsDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsDescription.CustomButton.UseSelectable = true;
            this.txtConsultationsDescription.CustomButton.Visible = false;
            this.txtConsultationsDescription.Enabled = false;
            this.txtConsultationsDescription.Lines = new string[0];
            this.txtConsultationsDescription.Location = new System.Drawing.Point(135, 268);
            this.txtConsultationsDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsDescription.MaxLength = 32767;
            this.txtConsultationsDescription.Multiline = true;
            this.txtConsultationsDescription.Name = "txtConsultationsDescription";
            this.txtConsultationsDescription.PasswordChar = '\0';
            this.txtConsultationsDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsDescription.SelectedText = "";
            this.txtConsultationsDescription.SelectionLength = 0;
            this.txtConsultationsDescription.SelectionStart = 0;
            this.txtConsultationsDescription.Size = new System.Drawing.Size(122, 52);
            this.txtConsultationsDescription.TabIndex = 105;
            this.txtConsultationsDescription.UseSelectable = true;
            this.txtConsultationsDescription.UseStyleColors = true;
            this.txtConsultationsDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Enabled = false;
            this.metroLabel12.Location = new System.Drawing.Point(53, 271);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(81, 19);
            this.metroLabel12.TabIndex = 104;
            this.metroLabel12.Text = "Description :";
            this.metroLabel12.UseStyleColors = true;
            // 
            // cmbConsultationsDate_Of_Birth
            // 
            this.cmbConsultationsDate_Of_Birth.Enabled = false;
            this.cmbConsultationsDate_Of_Birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbConsultationsDate_Of_Birth.Location = new System.Drawing.Point(133, 153);
            this.cmbConsultationsDate_Of_Birth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConsultationsDate_Of_Birth.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbConsultationsDate_Of_Birth.Name = "cmbConsultationsDate_Of_Birth";
            this.cmbConsultationsDate_Of_Birth.Size = new System.Drawing.Size(120, 30);
            this.cmbConsultationsDate_Of_Birth.TabIndex = 103;
            this.cmbConsultationsDate_Of_Birth.UseStyleColors = true;
            // 
            // txtConsultationsConsultation
            // 
            // 
            // 
            // 
            this.txtConsultationsConsultation.CustomButton.Image = null;
            this.txtConsultationsConsultation.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txtConsultationsConsultation.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsConsultation.CustomButton.Name = "";
            this.txtConsultationsConsultation.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtConsultationsConsultation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsConsultation.CustomButton.TabIndex = 1;
            this.txtConsultationsConsultation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsConsultation.CustomButton.UseSelectable = true;
            this.txtConsultationsConsultation.CustomButton.Visible = false;
            this.txtConsultationsConsultation.Enabled = false;
            this.txtConsultationsConsultation.Lines = new string[0];
            this.txtConsultationsConsultation.Location = new System.Drawing.Point(134, 189);
            this.txtConsultationsConsultation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsConsultation.MaxLength = 32767;
            this.txtConsultationsConsultation.Name = "txtConsultationsConsultation";
            this.txtConsultationsConsultation.PasswordChar = '\0';
            this.txtConsultationsConsultation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsConsultation.SelectedText = "";
            this.txtConsultationsConsultation.SelectionLength = 0;
            this.txtConsultationsConsultation.SelectionStart = 0;
            this.txtConsultationsConsultation.Size = new System.Drawing.Size(118, 20);
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
            this.metroLabel3.Enabled = false;
            this.metroLabel3.Location = new System.Drawing.Point(56, 192);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Consultations :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // cmbConsultationsDependant_Name
            // 
            this.cmbConsultationsDependant_Name.Enabled = false;
            this.cmbConsultationsDependant_Name.FormattingEnabled = true;
            this.cmbConsultationsDependant_Name.ItemHeight = 23;
            this.cmbConsultationsDependant_Name.Location = new System.Drawing.Point(131, 557);
            this.cmbConsultationsDependant_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConsultationsDependant_Name.Name = "cmbConsultationsDependant_Name";
            this.cmbConsultationsDependant_Name.Size = new System.Drawing.Size(119, 29);
            this.cmbConsultationsDependant_Name.TabIndex = 47;
            this.cmbConsultationsDependant_Name.UseSelectable = true;
            this.cmbConsultationsDependant_Name.UseStyleColors = true;
            // 
            // txtConsultationsAmount
            // 
            // 
            // 
            // 
            this.txtConsultationsAmount.CustomButton.Image = null;
            this.txtConsultationsAmount.CustomButton.Location = new System.Drawing.Point(80, 2);
            this.txtConsultationsAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsAmount.CustomButton.Name = "";
            this.txtConsultationsAmount.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtConsultationsAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsAmount.CustomButton.TabIndex = 1;
            this.txtConsultationsAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsAmount.CustomButton.UseSelectable = true;
            this.txtConsultationsAmount.CustomButton.Visible = false;
            this.txtConsultationsAmount.Enabled = false;
            this.txtConsultationsAmount.Lines = new string[0];
            this.txtConsultationsAmount.Location = new System.Drawing.Point(131, 411);
            this.txtConsultationsAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultationsAmount.MaxLength = 32767;
            this.txtConsultationsAmount.Name = "txtConsultationsAmount";
            this.txtConsultationsAmount.PasswordChar = '\0';
            this.txtConsultationsAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsAmount.SelectedText = "";
            this.txtConsultationsAmount.SelectionLength = 0;
            this.txtConsultationsAmount.SelectionStart = 0;
            this.txtConsultationsAmount.Size = new System.Drawing.Size(125, 20);
            this.txtConsultationsAmount.TabIndex = 37;
            this.txtConsultationsAmount.UseSelectable = true;
            this.txtConsultationsAmount.UseStyleColors = true;
            this.txtConsultationsAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Enabled = false;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(64, 411);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(66, 19);
            this.metroLabel15.TabIndex = 36;
            this.metroLabel15.Text = "Amount :";
            this.metroLabel15.UseStyleColors = true;
            // 
            // cmbConsultationsSurname
            // 
            this.cmbConsultationsSurname.Enabled = false;
            this.cmbConsultationsSurname.FormattingEnabled = true;
            this.cmbConsultationsSurname.ItemHeight = 23;
            this.cmbConsultationsSurname.Location = new System.Drawing.Point(137, 76);
            this.cmbConsultationsSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConsultationsSurname.Name = "cmbConsultationsSurname";
            this.cmbConsultationsSurname.Size = new System.Drawing.Size(116, 29);
            this.cmbConsultationsSurname.TabIndex = 46;
            this.cmbConsultationsSurname.UseSelectable = true;
            this.cmbConsultationsSurname.UseStyleColors = true;
            // 
            // cmbConsultationsDiagnostic_codes
            // 
            this.cmbConsultationsDiagnostic_codes.Enabled = false;
            this.cmbConsultationsDiagnostic_codes.FormattingEnabled = true;
            this.cmbConsultationsDiagnostic_codes.ItemHeight = 23;
            this.cmbConsultationsDiagnostic_codes.Items.AddRange(new object[] {
            "86200",
            "86201",
            "86202",
            "86203",
            "86204",
            "86205",
            "86206",
            "86207",
            "86208",
            "86209",
            "86210",
            "86211",
            "86300",
            "86301",
            "86302",
            "86303",
            "86304",
            "86305",
            "86306",
            "86307",
            "86308",
            "86309",
            "86310",
            "86311"});
            this.cmbConsultationsDiagnostic_codes.Location = new System.Drawing.Point(135, 324);
            this.cmbConsultationsDiagnostic_codes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConsultationsDiagnostic_codes.Name = "cmbConsultationsDiagnostic_codes";
            this.cmbConsultationsDiagnostic_codes.Size = new System.Drawing.Size(116, 29);
            this.cmbConsultationsDiagnostic_codes.TabIndex = 35;
            this.cmbConsultationsDiagnostic_codes.UseSelectable = true;
            this.cmbConsultationsDiagnostic_codes.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Enabled = false;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(22, 332);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(122, 19);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Diagnostics Code :";
            this.metroLabel9.UseStyleColors = true;
            // 
            // cmbConsultationsName
            // 
            this.cmbConsultationsName.Enabled = false;
            this.cmbConsultationsName.FormattingEnabled = true;
            this.cmbConsultationsName.ItemHeight = 23;
            this.cmbConsultationsName.Location = new System.Drawing.Point(137, 48);
            this.cmbConsultationsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConsultationsName.Name = "cmbConsultationsName";
            this.cmbConsultationsName.Size = new System.Drawing.Size(116, 29);
            this.cmbConsultationsName.TabIndex = 45;
            this.cmbConsultationsName.UseSelectable = true;
            this.cmbConsultationsName.UseStyleColors = true;
            // 
            // cmbConsultationsICD10
            // 
            this.cmbConsultationsICD10.Enabled = false;
            this.cmbConsultationsICD10.FormattingEnabled = true;
            this.cmbConsultationsICD10.ItemHeight = 23;
            this.cmbConsultationsICD10.Items.AddRange(new object[] {
            "Z55.0",
            "Z55.2",
            "Z55.3",
            "Z55.4",
            "Z55.8",
            "Z55.9",
            "Z56.0",
            "Z56.2",
            "Z56.3",
            "Z56.4",
            "Z56.6",
            "Z56.7",
            "Z57.0",
            "Z59.3",
            "Z60.0",
            "Z60.1",
            "Z60.8",
            "Z61.0",
            "Z61.1",
            "Z61.2",
            "Z61.3",
            "Z61.4",
            "Z61.5",
            "Z61.6",
            "Z61.7",
            "Z61.8",
            "Z61.9",
            "Z62.0",
            "Z62.1",
            "Z62.2",
            "Z62.3",
            "Z62.4",
            "Z62.5",
            "Z62.6",
            "Z62.8",
            "Z62.9",
            "Z63.0",
            "Z63.1",
            "Z63.2",
            "Z63.4",
            "Z63.5",
            "Z63.6",
            "Z63.7",
            "Z63.8",
            "Z63.9",
            "Z64.0",
            "Z65.4"});
            this.cmbConsultationsICD10.Location = new System.Drawing.Point(131, 366);
            this.cmbConsultationsICD10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConsultationsICD10.Name = "cmbConsultationsICD10";
            this.cmbConsultationsICD10.Size = new System.Drawing.Size(117, 29);
            this.cmbConsultationsICD10.TabIndex = 33;
            this.cmbConsultationsICD10.UseSelectable = true;
            this.cmbConsultationsICD10.UseStyleColors = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Enabled = false;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(16, 559);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(120, 19);
            this.metroLabel19.TabIndex = 44;
            this.metroLabel19.Text = "Dependant Name:";
            this.metroLabel19.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(41, 366);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "ICD 10 Codes:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtConsultationsDate
            // 
            this.txtConsultationsDate.Enabled = false;
            this.txtConsultationsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtConsultationsDate.Location = new System.Drawing.Point(136, 221);
            this.txtConsultationsDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtConsultationsDate.Name = "txtConsultationsDate";
            this.txtConsultationsDate.Size = new System.Drawing.Size(118, 30);
            this.txtConsultationsDate.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDate.TabIndex = 31;
            this.txtConsultationsDate.UseStyleColors = true;
            // 
            // txtConsultationsDependancy_Code
            // 
            // 
            // 
            // 
            this.txtConsultationsDependancy_Code.CustomButton.Image = null;
            this.txtConsultationsDependancy_Code.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtConsultationsDependancy_Code.CustomButton.Name = "";
            this.txtConsultationsDependancy_Code.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtConsultationsDependancy_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsDependancy_Code.CustomButton.TabIndex = 1;
            this.txtConsultationsDependancy_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsDependancy_Code.CustomButton.UseSelectable = true;
            this.txtConsultationsDependancy_Code.CustomButton.Visible = false;
            this.txtConsultationsDependancy_Code.Enabled = false;
            this.txtConsultationsDependancy_Code.Lines = new string[0];
            this.txtConsultationsDependancy_Code.Location = new System.Drawing.Point(130, 587);
            this.txtConsultationsDependancy_Code.MaxLength = 32767;
            this.txtConsultationsDependancy_Code.Name = "txtConsultationsDependancy_Code";
            this.txtConsultationsDependancy_Code.PasswordChar = '\0';
            this.txtConsultationsDependancy_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultationsDependancy_Code.SelectedText = "";
            this.txtConsultationsDependancy_Code.SelectionLength = 0;
            this.txtConsultationsDependancy_Code.SelectionStart = 0;
            this.txtConsultationsDependancy_Code.Size = new System.Drawing.Size(118, 23);
            this.txtConsultationsDependancy_Code.TabIndex = 42;
            this.txtConsultationsDependancy_Code.UseSelectable = true;
            this.txtConsultationsDependancy_Code.UseStyleColors = true;
            this.txtConsultationsDependancy_Code.WaterMark = "Enter Dependancy Code";
            this.txtConsultationsDependancy_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsDependancy_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(88, 223);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Date:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Enabled = false;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(40, 48);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 19);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Client name :";
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Enabled = false;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(20, 587);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(124, 19);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Dependancy Code:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // txtConsultationsMember_Number
            // 
            // 
            // 
            // 
            this.txtConsultationsMember_Number.CustomButton.Image = null;
            this.txtConsultationsMember_Number.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtConsultationsMember_Number.CustomButton.Name = "";
            this.txtConsultationsMember_Number.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtConsultationsMember_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultationsMember_Number.CustomButton.TabIndex = 1;
            this.txtConsultationsMember_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultationsMember_Number.CustomButton.UseSelectable = true;
            this.txtConsultationsMember_Number.CustomButton.Visible = false;
            this.txtConsultationsMember_Number.Enabled = false;
            this.txtConsultationsMember_Number.Lines = new string[0];
            this.txtConsultationsMember_Number.Location = new System.Drawing.Point(134, 115);
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
            this.txtConsultationsMember_Number.UseStyleColors = true;
            this.txtConsultationsMember_Number.WaterMark = "Enter Number";
            this.txtConsultationsMember_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultationsMember_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Enabled = false;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(40, 153);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Date of birth:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Enabled = false;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(29, 84);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Client Surname:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(64, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Number:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(23, 40);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(28, 22);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 41;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(604, 639);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 42);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(687, 639);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 42);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(770, 639);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 42);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.lblBack.UseStyleColors = true;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // msmConsult
            // 
            this.msmConsult.Owner = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 687);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 124;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(16, 687);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 42);
            this.btnConfirm.TabIndex = 123;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseStyleColors = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(852, 639);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(91, 42);
            this.btnArchive.TabIndex = 122;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseStyleColors = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click_1);
            // 
            // frmConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 721);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(2083, 788);
            this.MinimumSize = new System.Drawing.Size(1023, 590);
            this.Movable = false;
            this.Name = "frmConsultations";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Consultations_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel lblBack;
        private MetroFramework.Components.MetroStyleManager msmConsult;
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
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroButton btnArchive;
    }
}