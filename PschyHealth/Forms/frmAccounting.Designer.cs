﻿namespace PschyHealth
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
            this.txtAccCredit_Balance = new MetroFramework.Controls.MetroTextBox();
            this.txtAccDebit_Balance = new MetroFramework.Controls.MetroTextBox();
            this.txtAccType = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccVAT = new MetroFramework.Controls.MetroTextBox();
            this.txtAccDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtAccNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtAccTransaction = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblAccNum = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDeleteAccount = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnUpdateAccount = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmbAccCriteria = new MetroFramework.Controls.MetroComboBox();
            this.txtAccSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnAddAcount = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.dgvAccount.Location = new System.Drawing.Point(329, 156);
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
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(904, 104);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 29);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.UseCustomForeColor = true;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtAccCredit_Balance
            // 
            // 
            // 
            // 
            this.txtAccCredit_Balance.CustomButton.Image = null;
            this.txtAccCredit_Balance.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtAccCredit_Balance.CustomButton.Name = "";
            this.txtAccCredit_Balance.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAccCredit_Balance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccCredit_Balance.CustomButton.TabIndex = 1;
            this.txtAccCredit_Balance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccCredit_Balance.CustomButton.UseSelectable = true;
            this.txtAccCredit_Balance.CustomButton.Visible = false;
            this.txtAccCredit_Balance.Lines = new string[0];
            this.txtAccCredit_Balance.Location = new System.Drawing.Point(123, 206);
            this.txtAccCredit_Balance.MaxLength = 32767;
            this.txtAccCredit_Balance.Name = "txtAccCredit_Balance";
            this.txtAccCredit_Balance.PasswordChar = '\0';
            this.txtAccCredit_Balance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccCredit_Balance.SelectedText = "";
            this.txtAccCredit_Balance.SelectionLength = 0;
            this.txtAccCredit_Balance.SelectionStart = 0;
            this.txtAccCredit_Balance.Size = new System.Drawing.Size(125, 23);
            this.txtAccCredit_Balance.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccCredit_Balance.TabIndex = 13;
            this.txtAccCredit_Balance.UseSelectable = true;
            this.txtAccCredit_Balance.WaterMark = "Enter Credit Balance";
            this.txtAccCredit_Balance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccCredit_Balance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccDebit_Balance
            // 
            // 
            // 
            // 
            this.txtAccDebit_Balance.CustomButton.Image = null;
            this.txtAccDebit_Balance.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtAccDebit_Balance.CustomButton.Name = "";
            this.txtAccDebit_Balance.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAccDebit_Balance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDebit_Balance.CustomButton.TabIndex = 1;
            this.txtAccDebit_Balance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccDebit_Balance.CustomButton.UseSelectable = true;
            this.txtAccDebit_Balance.CustomButton.Visible = false;
            this.txtAccDebit_Balance.Lines = new string[0];
            this.txtAccDebit_Balance.Location = new System.Drawing.Point(123, 177);
            this.txtAccDebit_Balance.MaxLength = 32767;
            this.txtAccDebit_Balance.Name = "txtAccDebit_Balance";
            this.txtAccDebit_Balance.PasswordChar = '\0';
            this.txtAccDebit_Balance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccDebit_Balance.SelectedText = "";
            this.txtAccDebit_Balance.SelectionLength = 0;
            this.txtAccDebit_Balance.SelectionStart = 0;
            this.txtAccDebit_Balance.Size = new System.Drawing.Size(125, 23);
            this.txtAccDebit_Balance.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDebit_Balance.TabIndex = 12;
            this.txtAccDebit_Balance.UseSelectable = true;
            this.txtAccDebit_Balance.WaterMark = "Enter Debit Balance";
            this.txtAccDebit_Balance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccDebit_Balance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccType
            // 
            // 
            // 
            // 
            this.txtAccType.CustomButton.Image = null;
            this.txtAccType.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtAccType.CustomButton.Name = "";
            this.txtAccType.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAccType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccType.CustomButton.TabIndex = 1;
            this.txtAccType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccType.CustomButton.UseSelectable = true;
            this.txtAccType.CustomButton.Visible = false;
            this.txtAccType.Lines = new string[0];
            this.txtAccType.Location = new System.Drawing.Point(123, 148);
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
            this.groupBox1.Controls.Add(this.txtAccCredit_Balance);
            this.groupBox1.Controls.Add(this.txtAccDebit_Balance);
            this.groupBox1.Controls.Add(this.txtAccType);
            this.groupBox1.Controls.Add(this.txtAccVAT);
            this.groupBox1.Controls.Add(this.txtAccDescription);
            this.groupBox1.Controls.Add(this.txtAccNumber);
            this.groupBox1.Controls.Add(this.txtAccTransaction);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.lblAccNum);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 250);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // txtAccVAT
            // 
            // 
            // 
            // 
            this.txtAccVAT.CustomButton.Image = null;
            this.txtAccVAT.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtAccVAT.CustomButton.Name = "";
            this.txtAccVAT.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAccVAT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccVAT.CustomButton.TabIndex = 1;
            this.txtAccVAT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccVAT.CustomButton.UseSelectable = true;
            this.txtAccVAT.CustomButton.Visible = false;
            this.txtAccVAT.Lines = new string[0];
            this.txtAccVAT.Location = new System.Drawing.Point(123, 119);
            this.txtAccVAT.MaxLength = 32767;
            this.txtAccVAT.Name = "txtAccVAT";
            this.txtAccVAT.PasswordChar = '\0';
            this.txtAccVAT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccVAT.SelectedText = "";
            this.txtAccVAT.SelectionLength = 0;
            this.txtAccVAT.SelectionStart = 0;
            this.txtAccVAT.Size = new System.Drawing.Size(125, 23);
            this.txtAccVAT.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccVAT.TabIndex = 10;
            this.txtAccVAT.UseSelectable = true;
            this.txtAccVAT.WaterMark = "Enter VAT";
            this.txtAccVAT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccVAT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccDescription
            // 
            // 
            // 
            // 
            this.txtAccDescription.CustomButton.Image = null;
            this.txtAccDescription.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtAccDescription.CustomButton.Name = "";
            this.txtAccDescription.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAccDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccDescription.CustomButton.TabIndex = 1;
            this.txtAccDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccDescription.CustomButton.UseSelectable = true;
            this.txtAccDescription.CustomButton.Visible = false;
            this.txtAccDescription.Lines = new string[0];
            this.txtAccDescription.Location = new System.Drawing.Point(123, 93);
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
            // txtAccNumber
            // 
            // 
            // 
            // 
            this.txtAccNumber.CustomButton.Image = null;
            this.txtAccNumber.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtAccNumber.CustomButton.Name = "";
            this.txtAccNumber.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAccNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccNumber.CustomButton.TabIndex = 1;
            this.txtAccNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccNumber.CustomButton.UseSelectable = true;
            this.txtAccNumber.CustomButton.Visible = false;
            this.txtAccNumber.Lines = new string[0];
            this.txtAccNumber.Location = new System.Drawing.Point(123, 64);
            this.txtAccNumber.MaxLength = 32767;
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.PasswordChar = '\0';
            this.txtAccNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccNumber.SelectedText = "";
            this.txtAccNumber.SelectionLength = 0;
            this.txtAccNumber.SelectionStart = 0;
            this.txtAccNumber.Size = new System.Drawing.Size(125, 23);
            this.txtAccNumber.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccNumber.TabIndex = 8;
            this.txtAccNumber.UseSelectable = true;
            this.txtAccNumber.WaterMark = "Enter Number";
            this.txtAccNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccTransaction
            // 
            // 
            // 
            // 
            this.txtAccTransaction.CustomButton.Image = null;
            this.txtAccTransaction.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtAccTransaction.CustomButton.Name = "";
            this.txtAccTransaction.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txtAccTransaction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccTransaction.CustomButton.TabIndex = 1;
            this.txtAccTransaction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccTransaction.CustomButton.UseSelectable = true;
            this.txtAccTransaction.CustomButton.Visible = false;
            this.txtAccTransaction.Lines = new string[0];
            this.txtAccTransaction.Location = new System.Drawing.Point(123, 35);
            this.txtAccTransaction.MaxLength = 32767;
            this.txtAccTransaction.Name = "txtAccTransaction";
            this.txtAccTransaction.PasswordChar = '\0';
            this.txtAccTransaction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccTransaction.SelectedText = "";
            this.txtAccTransaction.SelectionLength = 0;
            this.txtAccTransaction.SelectionStart = 0;
            this.txtAccTransaction.ShowClearButton = true;
            this.txtAccTransaction.Size = new System.Drawing.Size(125, 23);
            this.txtAccTransaction.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccTransaction.TabIndex = 7;
            this.txtAccTransaction.UseSelectable = true;
            this.txtAccTransaction.WaterMark = "Enter Transaction";
            this.txtAccTransaction.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccTransaction.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 206);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Credit Balance:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(25, 177);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Debit Balance:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(77, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Type:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(81, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "VAT:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Description:";
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Location = new System.Drawing.Point(6, 64);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(113, 19);
            this.lblAccNum.TabIndex = 1;
            this.lblAccNum.Text = "Account Number:";
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
            this.btnDeleteAccount.Location = new System.Drawing.Point(731, 621);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteAccount.TabIndex = 58;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseSelectable = true;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAccount.Image")));
            this.btnUpdateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.Location = new System.Drawing.Point(584, 621);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateAccount.TabIndex = 57;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseSelectable = true;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
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
            // 
            // txtAccSearch
            // 
            // 
            // 
            // 
            this.txtAccSearch.CustomButton.Image = null;
            this.txtAccSearch.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtAccSearch.CustomButton.Name = "";
            this.txtAccSearch.CustomButton.Size = new System.Drawing.Size(20, 22);
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
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.BackColor = System.Drawing.Color.Maroon;
            this.btnAddAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcount.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddAcount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAcount.Image")));
            this.btnAddAcount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAcount.Location = new System.Drawing.Point(435, 621);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(97, 23);
            this.btnAddAcount.TabIndex = 56;
            this.btnAddAcount.Text = "Add";
            this.btnAddAcount.UseCustomBackColor = true;
            this.btnAddAcount.UseCustomForeColor = true;
            this.btnAddAcount.UseSelectable = true;
            this.btnAddAcount.UseVisualStyleBackColor = false;
            // 
            // frmAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAddAcount);
            this.Movable = false;
            this.Name = "frmAccounting";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.frmAccounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvAccount;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txtAccCredit_Balance;
        private MetroFramework.Controls.MetroTextBox txtAccDebit_Balance;
        private MetroFramework.Controls.MetroTextBox txtAccType;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtAccVAT;
        private MetroFramework.Controls.MetroTextBox txtAccDescription;
        private MetroFramework.Controls.MetroTextBox txtAccNumber;
        private MetroFramework.Controls.MetroTextBox txtAccTransaction;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblAccNum;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnDeleteAccount;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnUpdateAccount;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSearch;
        private MetroFramework.Controls.MetroComboBox cmbAccCriteria;
        private MetroFramework.Controls.MetroTextBox txtAccSearch;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnAddAcount;
    }
}