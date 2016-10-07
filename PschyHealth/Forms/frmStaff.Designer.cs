namespace PschyHealth
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.cmbStaffCrit = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.btnStaffDelete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnStaffUpdate = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox17 = new MetroFramework.Controls.MetroTextBox();
            this.btnStaffAdd = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.dgvStaff = new MetroFramework.Controls.MetroGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStaffPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtStaffUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.msmStaff = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnConfirm = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnArchive = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStaffCrit
            // 
            this.cmbStaffCrit.FormattingEnabled = true;
            this.cmbStaffCrit.ItemHeight = 23;
            this.cmbStaffCrit.Items.AddRange(new object[] {
            "ID",
            "First Name",
            "Surname",
            "Position",
            "Staff Number"});
            this.cmbStaffCrit.Location = new System.Drawing.Point(55, 23);
            this.cmbStaffCrit.Name = "cmbStaffCrit";
            this.cmbStaffCrit.Size = new System.Drawing.Size(141, 29);
            this.cmbStaffCrit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbStaffCrit.TabIndex = 3;
            this.cmbStaffCrit.UseSelectable = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(288, 27);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(76, 19);
            this.metroLabel18.TabIndex = 1;
            this.metroLabel18.Text = "Search For:";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "African",
            "Asian",
            "Colloured",
            "White",
            "Indian",
            "Other"});
            this.metroComboBox3.Location = new System.Drawing.Point(127, 240);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox3.TabIndex = 47;
            this.metroComboBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.UseStyleColors = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.metroComboBox2.Location = new System.Drawing.Point(127, 205);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox2.TabIndex = 46;
            this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.UseStyleColors = true;
            // 
            // metroTextBox9
            // 
            // 
            // 
            // 
            this.metroTextBox9.CustomButton.Image = null;
            this.metroTextBox9.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox9.CustomButton.Name = "";
            this.metroTextBox9.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.metroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox9.CustomButton.TabIndex = 1;
            this.metroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox9.CustomButton.UseSelectable = true;
            this.metroTextBox9.CustomButton.Visible = false;
            this.metroTextBox9.Lines = new string[0];
            this.metroTextBox9.Location = new System.Drawing.Point(127, 276);
            this.metroTextBox9.MaxLength = 32767;
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.PasswordChar = '\0';
            this.metroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox9.SelectedText = "";
            this.metroTextBox9.SelectionLength = 0;
            this.metroTextBox9.SelectionStart = 0;
            this.metroTextBox9.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox9.TabIndex = 17;
            this.metroTextBox9.UseSelectable = true;
            this.metroTextBox9.WaterMark = "Enter Staff Number";
            this.metroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(127, 176);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.TabIndex = 14;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMark = "Enter Date of birth";
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(127, 147);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.TabIndex = 13;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMark = "Enter Position";
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(127, 118);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.TabIndex = 12;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMark = "Enter Practice Location";
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(127, 89);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.TabIndex = 11;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "Enter Surname";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(7, 27);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(55, 19);
            this.metroLabel17.TabIndex = 0;
            this.metroLabel17.Text = "Criteria:";
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Image = null;
            this.btnStaffDelete.Location = new System.Drawing.Point(850, 643);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(155, 23);
            this.btnStaffDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStaffDelete.TabIndex = 41;
            this.btnStaffDelete.Text = "Delete Staff";
            this.btnStaffDelete.UseSelectable = true;
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.Image = null;
            this.btnStaffUpdate.Location = new System.Drawing.Point(680, 643);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(155, 23);
            this.btnStaffUpdate.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStaffUpdate.TabIndex = 40;
            this.btnStaffUpdate.Text = "Update Staff";
            this.btnStaffUpdate.UseSelectable = true;
            this.btnStaffUpdate.UseVisualStyleBackColor = true;
            this.btnStaffUpdate.Click += new System.EventHandler(this.btnStaffUpdate_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(127, 60);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.TabIndex = 10;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Enter First Name";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(127, 31);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Enter ID";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(30, 276);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(92, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Staff Number:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(66, 205);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Gender:";
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
            this.metroTextBox17.Location = new System.Drawing.Point(353, 23);
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
            this.metroTextBox17.Click += new System.EventHandler(this.metroTextBox17_Click);
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Image = null;
            this.btnStaffAdd.Location = new System.Drawing.Point(510, 643);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(155, 23);
            this.btnStaffAdd.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStaffAdd.TabIndex = 38;
            this.btnStaffAdd.Text = "Add Staff";
            this.btnStaffAdd.UseSelectable = true;
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(34, 234);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(87, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Ethnic Group:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 176);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Date of birth:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(63, 147);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Position:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Practice Location:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(57, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Surname:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "First Name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(97, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(340, 643);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(155, 23);
            this.metroTextButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton2.TabIndex = 37;
            this.metroTextButton2.Text = "Search";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvStaff.Location = new System.Drawing.Point(340, 152);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(665, 470);
            this.dgvStaff.Style = MetroFramework.MetroColorStyle.Blue;
            this.dgvStaff.TabIndex = 36;
            this.dgvStaff.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvStaff.SelectionChanged += new System.EventHandler(this.dgvStaff_SelectionChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.cmbStaffCrit);
            this.groupBox3.Controls.Add(this.metroTextBox17);
            this.groupBox3.Controls.Add(this.metroLabel18);
            this.groupBox3.Controls.Add(this.metroLabel17);
            this.groupBox3.Location = new System.Drawing.Point(386, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 71);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Staff";
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
            this.metroComboBox1.Location = new System.Drawing.Point(214, 23);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(54, 29);
            this.metroComboBox1.TabIndex = 62;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStaffPassword);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.txtStaffUsername);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroComboBox3);
            this.groupBox1.Controls.Add(this.metroComboBox2);
            this.groupBox1.Controls.Add(this.metroTextBox9);
            this.groupBox1.Controls.Add(this.metroTextBox6);
            this.groupBox1.Controls.Add(this.metroTextBox5);
            this.groupBox1.Controls.Add(this.metroTextBox4);
            this.groupBox1.Controls.Add(this.metroTextBox3);
            this.groupBox1.Controls.Add(this.metroTextBox2);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 526);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // txtStaffPassword
            // 
            // 
            // 
            // 
            this.txtStaffPassword.CustomButton.Image = null;
            this.txtStaffPassword.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtStaffPassword.CustomButton.Name = "";
            this.txtStaffPassword.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtStaffPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffPassword.CustomButton.TabIndex = 1;
            this.txtStaffPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffPassword.CustomButton.UseSelectable = true;
            this.txtStaffPassword.CustomButton.Visible = false;
            this.txtStaffPassword.Lines = new string[0];
            this.txtStaffPassword.Location = new System.Drawing.Point(127, 380);
            this.txtStaffPassword.MaxLength = 32767;
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.PasswordChar = '\0';
            this.txtStaffPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffPassword.SelectedText = "";
            this.txtStaffPassword.SelectionLength = 0;
            this.txtStaffPassword.SelectionStart = 0;
            this.txtStaffPassword.Size = new System.Drawing.Size(148, 23);
            this.txtStaffPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffPassword.TabIndex = 51;
            this.txtStaffPassword.UseSelectable = true;
            this.txtStaffPassword.WaterMark = "Enter Staff password";
            this.txtStaffPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(30, 380);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(66, 19);
            this.metroLabel11.TabIndex = 50;
            this.metroLabel11.Text = "Password:";
            // 
            // txtStaffUsername
            // 
            // 
            // 
            // 
            this.txtStaffUsername.CustomButton.Image = null;
            this.txtStaffUsername.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtStaffUsername.CustomButton.Name = "";
            this.txtStaffUsername.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtStaffUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffUsername.CustomButton.TabIndex = 1;
            this.txtStaffUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffUsername.CustomButton.UseSelectable = true;
            this.txtStaffUsername.CustomButton.Visible = false;
            this.txtStaffUsername.Lines = new string[0];
            this.txtStaffUsername.Location = new System.Drawing.Point(127, 327);
            this.txtStaffUsername.MaxLength = 32767;
            this.txtStaffUsername.Name = "txtStaffUsername";
            this.txtStaffUsername.PasswordChar = '\0';
            this.txtStaffUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffUsername.SelectedText = "";
            this.txtStaffUsername.SelectionLength = 0;
            this.txtStaffUsername.SelectionStart = 0;
            this.txtStaffUsername.Size = new System.Drawing.Size(148, 23);
            this.txtStaffUsername.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffUsername.TabIndex = 49;
            this.txtStaffUsername.UseSelectable = true;
            this.txtStaffUsername.WaterMark = "Enter Staff username";
            this.txtStaffUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(30, 327);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(71, 19);
            this.metroLabel10.TabIndex = 48;
            this.metroLabel10.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(959, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(23, 45);
            this.pbBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 22);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 44;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click_1);
            // 
            // msmStaff
            // 
            this.msmStaff.Owner = this;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = null;
            this.btnConfirm.Location = new System.Drawing.Point(510, 672);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(155, 23);
            this.btnConfirm.Style = MetroFramework.MetroColorStyle.Red;
            this.btnConfirm.TabIndex = 45;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(680, 672);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(155, 23);
            this.btnArchive.TabIndex = 64;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2083, 708);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btnStaffDelete);
            this.Controls.Add(this.btnStaffUpdate);
            this.Controls.Add(this.btnStaffAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTextButton2);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(2083, 788);
            this.Movable = false;
            this.Name = "frmStaff";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbStaffCrit;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnStaffDelete;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnStaffUpdate;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox17;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnStaffAdd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        private MetroFramework.Controls.MetroGrid dgvStaff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pbBack;
        private MetroFramework.Controls.MetroTextBox txtStaffPassword;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtStaffUsername;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Components.MetroStyleManager msmStaff;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConfirm;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnArchive;
    }
}