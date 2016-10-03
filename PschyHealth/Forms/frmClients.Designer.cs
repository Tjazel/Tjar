namespace PschyHealth
{
    partial class frmClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddExistingClient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.cmbClientEthnic_Group = new MetroFramework.Controls.MetroComboBox();
            this.cmbClientGender = new MetroFramework.Controls.MetroComboBox();
            this.txtClientMaritial_Status = new MetroFramework.Controls.MetroTextBox();
            this.txtClientOccupation = new MetroFramework.Controls.MetroTextBox();
            this.txtClientMobile_Cellphone_Number = new MetroFramework.Controls.MetroTextBox();
            this.txtClientHome_Telephone_Number = new MetroFramework.Controls.MetroTextBox();
            this.txtClientAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtCleintDate_of_birth = new MetroFramework.Controls.MetroTextBox();
            this.cmbClientCriteria = new MetroFramework.Controls.MetroComboBox();
            this.txtClientsSearch = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbClientSymbol = new MetroFramework.Controls.MetroComboBox();
            this.txtClientSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtCleintFirst_Name = new MetroFramework.Controls.MetroTextBox();
            this.txtClientID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnUpdateClient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDeleteClient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClients = new MetroFramework.Controls.MetroGrid();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewClient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.gbDependants = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddExistingClient
            // 
            this.btnAddExistingClient.Image = null;
            this.btnAddExistingClient.Location = new System.Drawing.Point(801, 783);
            this.btnAddExistingClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddExistingClient.Name = "btnAddExistingClient";
            this.btnAddExistingClient.Size = new System.Drawing.Size(123, 54);
            this.btnAddExistingClient.TabIndex = 36;
            this.btnAddExistingClient.Text = "Add existing client";
            this.btnAddExistingClient.UseSelectable = true;
            this.btnAddExistingClient.UseVisualStyleBackColor = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(22, 32);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(56, 20);
            this.metroLabel17.TabIndex = 0;
            this.metroLabel17.Text = "Criteria:";
            // 
            // cmbClientEthnic_Group
            // 
            this.cmbClientEthnic_Group.FormattingEnabled = true;
            this.cmbClientEthnic_Group.ItemHeight = 24;
            this.cmbClientEthnic_Group.Items.AddRange(new object[] {
            "African",
            "Asian",
            "Colloured",
            "White",
            "Indian",
            "Other"});
            this.cmbClientEthnic_Group.Location = new System.Drawing.Point(201, 218);
            this.cmbClientEthnic_Group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClientEthnic_Group.Name = "cmbClientEthnic_Group";
            this.cmbClientEthnic_Group.Size = new System.Drawing.Size(160, 30);
            this.cmbClientEthnic_Group.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbClientEthnic_Group.TabIndex = 45;
            this.cmbClientEthnic_Group.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbClientEthnic_Group.UseSelectable = true;
            // 
            // cmbClientGender
            // 
            this.cmbClientGender.FormattingEnabled = true;
            this.cmbClientGender.ItemHeight = 24;
            this.cmbClientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbClientGender.Location = new System.Drawing.Point(201, 175);
            this.cmbClientGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClientGender.Name = "cmbClientGender";
            this.cmbClientGender.Size = new System.Drawing.Size(160, 30);
            this.cmbClientGender.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbClientGender.TabIndex = 44;
            this.cmbClientGender.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbClientGender.UseSelectable = true;
            // 
            // txtClientMaritial_Status
            // 
            // 
            // 
            // 
            this.txtClientMaritial_Status.CustomButton.Image = null;
            this.txtClientMaritial_Status.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtClientMaritial_Status.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientMaritial_Status.CustomButton.Name = "";
            this.txtClientMaritial_Status.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtClientMaritial_Status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientMaritial_Status.CustomButton.TabIndex = 1;
            this.txtClientMaritial_Status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientMaritial_Status.CustomButton.UseSelectable = true;
            this.txtClientMaritial_Status.CustomButton.Visible = false;
            this.txtClientMaritial_Status.Lines = new string[0];
            this.txtClientMaritial_Status.Location = new System.Drawing.Point(199, 462);
            this.txtClientMaritial_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientMaritial_Status.MaxLength = 32767;
            this.txtClientMaritial_Status.Name = "txtClientMaritial_Status";
            this.txtClientMaritial_Status.PasswordChar = '\0';
            this.txtClientMaritial_Status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientMaritial_Status.SelectedText = "";
            this.txtClientMaritial_Status.SelectionLength = 0;
            this.txtClientMaritial_Status.SelectionStart = 0;
            this.txtClientMaritial_Status.Size = new System.Drawing.Size(188, 28);
            this.txtClientMaritial_Status.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientMaritial_Status.TabIndex = 43;
            this.txtClientMaritial_Status.UseSelectable = true;
            this.txtClientMaritial_Status.WaterMark = "Enter Maritial Status";
            this.txtClientMaritial_Status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientMaritial_Status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClientOccupation
            // 
            // 
            // 
            // 
            this.txtClientOccupation.CustomButton.Image = null;
            this.txtClientOccupation.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtClientOccupation.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientOccupation.CustomButton.Name = "";
            this.txtClientOccupation.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtClientOccupation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientOccupation.CustomButton.TabIndex = 1;
            this.txtClientOccupation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientOccupation.CustomButton.UseSelectable = true;
            this.txtClientOccupation.CustomButton.Visible = false;
            this.txtClientOccupation.Lines = new string[0];
            this.txtClientOccupation.Location = new System.Drawing.Point(199, 428);
            this.txtClientOccupation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientOccupation.MaxLength = 32767;
            this.txtClientOccupation.Name = "txtClientOccupation";
            this.txtClientOccupation.PasswordChar = '\0';
            this.txtClientOccupation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientOccupation.SelectedText = "";
            this.txtClientOccupation.SelectionLength = 0;
            this.txtClientOccupation.SelectionStart = 0;
            this.txtClientOccupation.Size = new System.Drawing.Size(188, 28);
            this.txtClientOccupation.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientOccupation.TabIndex = 42;
            this.txtClientOccupation.UseSelectable = true;
            this.txtClientOccupation.WaterMark = "Enter Occupation";
            this.txtClientOccupation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientOccupation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClientMobile_Cellphone_Number
            // 
            // 
            // 
            // 
            this.txtClientMobile_Cellphone_Number.CustomButton.Image = null;
            this.txtClientMobile_Cellphone_Number.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.txtClientMobile_Cellphone_Number.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientMobile_Cellphone_Number.CustomButton.Name = "";
            this.txtClientMobile_Cellphone_Number.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtClientMobile_Cellphone_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientMobile_Cellphone_Number.CustomButton.TabIndex = 1;
            this.txtClientMobile_Cellphone_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientMobile_Cellphone_Number.CustomButton.UseSelectable = true;
            this.txtClientMobile_Cellphone_Number.CustomButton.Visible = false;
            this.txtClientMobile_Cellphone_Number.Lines = new string[0];
            this.txtClientMobile_Cellphone_Number.Location = new System.Drawing.Point(199, 391);
            this.txtClientMobile_Cellphone_Number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientMobile_Cellphone_Number.MaxLength = 32767;
            this.txtClientMobile_Cellphone_Number.Name = "txtClientMobile_Cellphone_Number";
            this.txtClientMobile_Cellphone_Number.PasswordChar = '\0';
            this.txtClientMobile_Cellphone_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientMobile_Cellphone_Number.SelectedText = "";
            this.txtClientMobile_Cellphone_Number.SelectionLength = 0;
            this.txtClientMobile_Cellphone_Number.SelectionStart = 0;
            this.txtClientMobile_Cellphone_Number.Size = new System.Drawing.Size(108, 28);
            this.txtClientMobile_Cellphone_Number.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientMobile_Cellphone_Number.TabIndex = 41;
            this.txtClientMobile_Cellphone_Number.UseSelectable = true;
            this.txtClientMobile_Cellphone_Number.WaterMark = "(___) ___-____";
            this.txtClientMobile_Cellphone_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientMobile_Cellphone_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClientHome_Telephone_Number
            // 
            // 
            // 
            // 
            this.txtClientHome_Telephone_Number.CustomButton.Image = null;
            this.txtClientHome_Telephone_Number.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.txtClientHome_Telephone_Number.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientHome_Telephone_Number.CustomButton.Name = "";
            this.txtClientHome_Telephone_Number.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtClientHome_Telephone_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientHome_Telephone_Number.CustomButton.TabIndex = 1;
            this.txtClientHome_Telephone_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientHome_Telephone_Number.CustomButton.UseSelectable = true;
            this.txtClientHome_Telephone_Number.CustomButton.Visible = false;
            this.txtClientHome_Telephone_Number.Lines = new string[0];
            this.txtClientHome_Telephone_Number.Location = new System.Drawing.Point(199, 356);
            this.txtClientHome_Telephone_Number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientHome_Telephone_Number.MaxLength = 32767;
            this.txtClientHome_Telephone_Number.Name = "txtClientHome_Telephone_Number";
            this.txtClientHome_Telephone_Number.PasswordChar = '\0';
            this.txtClientHome_Telephone_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientHome_Telephone_Number.SelectedText = "";
            this.txtClientHome_Telephone_Number.SelectionLength = 0;
            this.txtClientHome_Telephone_Number.SelectionStart = 0;
            this.txtClientHome_Telephone_Number.Size = new System.Drawing.Size(108, 28);
            this.txtClientHome_Telephone_Number.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientHome_Telephone_Number.TabIndex = 40;
            this.txtClientHome_Telephone_Number.UseSelectable = true;
            this.txtClientHome_Telephone_Number.WaterMark = "(___) ___-____";
            this.txtClientHome_Telephone_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientHome_Telephone_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClientAddress
            // 
            // 
            // 
            // 
            this.txtClientAddress.CustomButton.Image = null;
            this.txtClientAddress.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.txtClientAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientAddress.CustomButton.Name = "";
            this.txtClientAddress.CustomButton.Size = new System.Drawing.Size(104, 104);
            this.txtClientAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientAddress.CustomButton.TabIndex = 1;
            this.txtClientAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientAddress.CustomButton.UseSelectable = true;
            this.txtClientAddress.CustomButton.Visible = false;
            this.txtClientAddress.Lines = new string[0];
            this.txtClientAddress.Location = new System.Drawing.Point(199, 261);
            this.txtClientAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientAddress.MaxLength = 32767;
            this.txtClientAddress.Multiline = true;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.PasswordChar = '\0';
            this.txtClientAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientAddress.SelectedText = "";
            this.txtClientAddress.SelectionLength = 0;
            this.txtClientAddress.SelectionStart = 0;
            this.txtClientAddress.Size = new System.Drawing.Size(188, 88);
            this.txtClientAddress.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientAddress.TabIndex = 39;
            this.txtClientAddress.UseSelectable = true;
            this.txtClientAddress.WaterMark = "Enter Address";
            this.txtClientAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCleintDate_of_birth
            // 
            // 
            // 
            // 
            this.txtCleintDate_of_birth.CustomButton.Image = null;
            this.txtCleintDate_of_birth.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtCleintDate_of_birth.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCleintDate_of_birth.CustomButton.Name = "";
            this.txtCleintDate_of_birth.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCleintDate_of_birth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCleintDate_of_birth.CustomButton.TabIndex = 1;
            this.txtCleintDate_of_birth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCleintDate_of_birth.CustomButton.UseSelectable = true;
            this.txtCleintDate_of_birth.CustomButton.Visible = false;
            this.txtCleintDate_of_birth.Lines = new string[0];
            this.txtCleintDate_of_birth.Location = new System.Drawing.Point(199, 139);
            this.txtCleintDate_of_birth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCleintDate_of_birth.MaxLength = 32767;
            this.txtCleintDate_of_birth.Name = "txtCleintDate_of_birth";
            this.txtCleintDate_of_birth.PasswordChar = '\0';
            this.txtCleintDate_of_birth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCleintDate_of_birth.SelectedText = "";
            this.txtCleintDate_of_birth.SelectionLength = 0;
            this.txtCleintDate_of_birth.SelectionStart = 0;
            this.txtCleintDate_of_birth.Size = new System.Drawing.Size(188, 28);
            this.txtCleintDate_of_birth.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCleintDate_of_birth.TabIndex = 36;
            this.txtCleintDate_of_birth.UseSelectable = true;
            this.txtCleintDate_of_birth.WaterMark = "Enter date of birth";
            this.txtCleintDate_of_birth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCleintDate_of_birth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbClientCriteria
            // 
            this.cmbClientCriteria.FormattingEnabled = true;
            this.cmbClientCriteria.ItemHeight = 24;
            this.cmbClientCriteria.Items.AddRange(new object[] {
            "ID Number",
            "First Name",
            "Surname"});
            this.cmbClientCriteria.Location = new System.Drawing.Point(104, 28);
            this.cmbClientCriteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClientCriteria.Name = "cmbClientCriteria";
            this.cmbClientCriteria.Size = new System.Drawing.Size(186, 30);
            this.cmbClientCriteria.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbClientCriteria.TabIndex = 3;
            this.cmbClientCriteria.UseSelectable = true;
            this.cmbClientCriteria.TextChanged += new System.EventHandler(this.cmbClientCriteria_TextChanged);
            // 
            // txtClientsSearch
            // 
            // 
            // 
            // 
            this.txtClientsSearch.CustomButton.Image = null;
            this.txtClientsSearch.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.txtClientsSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientsSearch.CustomButton.Name = "";
            this.txtClientsSearch.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtClientsSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientsSearch.CustomButton.TabIndex = 1;
            this.txtClientsSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientsSearch.CustomButton.UseSelectable = true;
            this.txtClientsSearch.CustomButton.Visible = false;
            this.txtClientsSearch.Lines = new string[0];
            this.txtClientsSearch.Location = new System.Drawing.Point(408, 28);
            this.txtClientsSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientsSearch.MaxLength = 32767;
            this.txtClientsSearch.Name = "txtClientsSearch";
            this.txtClientsSearch.PasswordChar = '\0';
            this.txtClientsSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientsSearch.SelectedText = "";
            this.txtClientsSearch.SelectionLength = 0;
            this.txtClientsSearch.SelectionStart = 0;
            this.txtClientsSearch.Size = new System.Drawing.Size(188, 36);
            this.txtClientsSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientsSearch.TabIndex = 2;
            this.txtClientsSearch.UseSelectable = true;
            this.txtClientsSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientsSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtClientsSearch.TextChanged += new System.EventHandler(this.txtClientsSearch_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbClientSymbol);
            this.groupBox3.Controls.Add(this.cmbClientCriteria);
            this.groupBox3.Controls.Add(this.txtClientsSearch);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(1093, 86);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(640, 88);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Client";
            // 
            // cmbClientSymbol
            // 
            this.cmbClientSymbol.FormattingEnabled = true;
            this.cmbClientSymbol.ItemHeight = 24;
            this.cmbClientSymbol.Items.AddRange(new object[] {
            "ID Number",
            "First Name",
            "Surname"});
            this.cmbClientSymbol.Location = new System.Drawing.Point(312, 28);
            this.cmbClientSymbol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClientSymbol.Name = "cmbClientSymbol";
            this.cmbClientSymbol.Size = new System.Drawing.Size(73, 30);
            this.cmbClientSymbol.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbClientSymbol.TabIndex = 4;
            this.cmbClientSymbol.UseSelectable = true;
            this.cmbClientSymbol.Visible = false;
            this.cmbClientSymbol.SelectedIndexChanged += new System.EventHandler(this.cmbClientSymbol_SelectedIndexChanged_1);
            // 
            // txtClientSurname
            // 
            // 
            // 
            // 
            this.txtClientSurname.CustomButton.Image = null;
            this.txtClientSurname.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtClientSurname.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientSurname.CustomButton.Name = "";
            this.txtClientSurname.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtClientSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientSurname.CustomButton.TabIndex = 1;
            this.txtClientSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientSurname.CustomButton.UseSelectable = true;
            this.txtClientSurname.CustomButton.Visible = false;
            this.txtClientSurname.Lines = new string[0];
            this.txtClientSurname.Location = new System.Drawing.Point(200, 102);
            this.txtClientSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientSurname.MaxLength = 32767;
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.PasswordChar = '\0';
            this.txtClientSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientSurname.SelectedText = "";
            this.txtClientSurname.SelectionLength = 0;
            this.txtClientSurname.SelectionStart = 0;
            this.txtClientSurname.Size = new System.Drawing.Size(188, 28);
            this.txtClientSurname.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientSurname.TabIndex = 35;
            this.txtClientSurname.UseSelectable = true;
            this.txtClientSurname.WaterMark = "Enter Surname";
            this.txtClientSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCleintFirst_Name
            // 
            // 
            // 
            // 
            this.txtCleintFirst_Name.CustomButton.Image = null;
            this.txtCleintFirst_Name.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtCleintFirst_Name.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCleintFirst_Name.CustomButton.Name = "";
            this.txtCleintFirst_Name.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtCleintFirst_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCleintFirst_Name.CustomButton.TabIndex = 1;
            this.txtCleintFirst_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCleintFirst_Name.CustomButton.UseSelectable = true;
            this.txtCleintFirst_Name.CustomButton.Visible = false;
            this.txtCleintFirst_Name.Lines = new string[0];
            this.txtCleintFirst_Name.Location = new System.Drawing.Point(200, 68);
            this.txtCleintFirst_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCleintFirst_Name.MaxLength = 32767;
            this.txtCleintFirst_Name.Name = "txtCleintFirst_Name";
            this.txtCleintFirst_Name.PasswordChar = '\0';
            this.txtCleintFirst_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCleintFirst_Name.SelectedText = "";
            this.txtCleintFirst_Name.SelectionLength = 0;
            this.txtCleintFirst_Name.SelectionStart = 0;
            this.txtCleintFirst_Name.Size = new System.Drawing.Size(188, 28);
            this.txtCleintFirst_Name.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCleintFirst_Name.TabIndex = 34;
            this.txtCleintFirst_Name.UseSelectable = true;
            this.txtCleintFirst_Name.WaterMark = "Enter First Name";
            this.txtCleintFirst_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCleintFirst_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClientID
            // 
            // 
            // 
            // 
            this.txtClientID.CustomButton.Image = null;
            this.txtClientID.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtClientID.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientID.CustomButton.Name = "";
            this.txtClientID.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtClientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientID.CustomButton.TabIndex = 1;
            this.txtClientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientID.CustomButton.UseSelectable = true;
            this.txtClientID.CustomButton.Visible = false;
            this.txtClientID.Lines = new string[0];
            this.txtClientID.Location = new System.Drawing.Point(200, 32);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClientID.MaxLength = 32767;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.PasswordChar = '\0';
            this.txtClientID.ReadOnly = true;
            this.txtClientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientID.SelectedText = "";
            this.txtClientID.SelectionLength = 0;
            this.txtClientID.SelectionStart = 0;
            this.txtClientID.Size = new System.Drawing.Size(188, 28);
            this.txtClientID.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientID.TabIndex = 33;
            this.txtClientID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientID.UseSelectable = true;
            this.txtClientID.WaterMark = "Enter ID Number";
            this.txtClientID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.Color.White;
            this.metroLabel9.Location = new System.Drawing.Point(32, 396);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(126, 20);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.TabIndex = 32;
            this.metroLabel9.Text = "Phone No (Mob) :";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.ForeColor = System.Drawing.Color.White;
            this.metroLabel11.Location = new System.Drawing.Point(58, 462);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(107, 20);
            this.metroLabel11.TabIndex = 31;
            this.metroLabel11.Text = "Maritial Status:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.ForeColor = System.Drawing.Color.White;
            this.metroLabel12.Location = new System.Drawing.Point(81, 428);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(88, 20);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel12.TabIndex = 30;
            this.metroLabel12.Text = "Occupation:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(22, 361);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 20);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Phone No (Home) :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(109, 261);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 20);
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Address:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(71, 218);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 20);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Ethnic Group:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(118, 175);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 20);
            this.metroLabel8.TabIndex = 26;
            this.metroLabel8.Text = "Gender:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(71, 139);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 20);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Date of birth:";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Image = null;
            this.btnUpdateClient.Location = new System.Drawing.Point(1066, 783);
            this.btnUpdateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(123, 54);
            this.btnUpdateClient.TabIndex = 37;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseSelectable = true;
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(104, 102);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 20);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Surname:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(88, 68);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 20);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "First Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(85, 32);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "ID Number:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.WrapToLine = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteClient.Image = null;
            this.btnDeleteClient.Location = new System.Drawing.Point(801, 854);
            this.btnDeleteClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(123, 54);
            this.btnDeleteClient.TabIndex = 38;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseCustomForeColor = true;
            this.btnDeleteClient.UseSelectable = true;
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbClientEthnic_Group);
            this.groupBox1.Controls.Add(this.cmbClientGender);
            this.groupBox1.Controls.Add(this.txtClientMaritial_Status);
            this.groupBox1.Controls.Add(this.txtClientOccupation);
            this.groupBox1.Controls.Add(this.txtClientMobile_Cellphone_Number);
            this.groupBox1.Controls.Add(this.txtClientHome_Telephone_Number);
            this.groupBox1.Controls.Add(this.txtClientAddress);
            this.groupBox1.Controls.Add(this.txtCleintDate_of_birth);
            this.groupBox1.Controls.Add(this.txtClientSurname);
            this.groupBox1.Controls.Add(this.txtCleintFirst_Name);
            this.groupBox1.Controls.Add(this.txtClientID);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(425, 516);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClients.Location = new System.Drawing.Point(801, 187);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(932, 588);
            this.dgvClients.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvClients.TabIndex = 34;
            this.dgvClients.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged_1);
            // 
            // pbMic
            // 
            this.pbMic.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbMic.Location = new System.Drawing.Point(6, 45);
            this.pbMic.Margin = new System.Windows.Forms.Padding(2);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(38, 28);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 40;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1741, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Image = null;
            this.btnAddNewClient.Location = new System.Drawing.Point(932, 783);
            this.btnAddNewClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(123, 54);
            this.btnAddNewClient.TabIndex = 42;
            this.btnAddNewClient.Text = "Add new client";
            this.btnAddNewClient.UseSelectable = true;
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            // 
            // gbDependants
            // 
            this.gbDependants.Location = new System.Drawing.Point(6, 614);
            this.gbDependants.Name = "gbDependants";
            this.gbDependants.Size = new System.Drawing.Size(425, 197);
            this.gbDependants.TabIndex = 43;
            this.gbDependants.TabStop = false;
            this.gbDependants.Text = "Dependants";
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2067, 970);
            this.Controls.Add(this.gbDependants);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.pbMic);
            this.Controls.Add(this.btnAddExistingClient);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClients);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(2777, 970);
            this.MinimumSize = new System.Drawing.Size(1918, 970);
            this.Movable = false;
            this.Name = "frmClients";
            this.Padding = new System.Windows.Forms.Padding(28, 75, 28, 25);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnAddExistingClient;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroComboBox cmbClientEthnic_Group;
        private MetroFramework.Controls.MetroComboBox cmbClientGender;
        private MetroFramework.Controls.MetroTextBox txtClientMaritial_Status;
        private MetroFramework.Controls.MetroTextBox txtClientOccupation;
        private MetroFramework.Controls.MetroTextBox txtClientMobile_Cellphone_Number;
        private MetroFramework.Controls.MetroTextBox txtClientHome_Telephone_Number;
        private MetroFramework.Controls.MetroTextBox txtClientAddress;
        private MetroFramework.Controls.MetroTextBox txtCleintDate_of_birth;
        private MetroFramework.Controls.MetroComboBox cmbClientCriteria;
        private MetroFramework.Controls.MetroTextBox txtClientsSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtClientSurname;
        private MetroFramework.Controls.MetroTextBox txtCleintFirst_Name;
        private MetroFramework.Controls.MetroTextBox txtClientID;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnUpdateClient;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnDeleteClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dgvClients;
        private MetroFramework.Controls.MetroComboBox cmbClientSymbol;
        private System.Windows.Forms.PictureBox pbMic;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnAddNewClient;
        private System.Windows.Forms.GroupBox gbDependants;
    }
}