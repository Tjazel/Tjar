namespace PschyHealth.Forms
{
    partial class frmPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.dgvPayments = new MetroFramework.Controls.MetroGrid();
            this.txtPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPayments_Method_Of_Payments = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayments_Amount = new MetroFramework.Controls.MetroTextBox();
            this.txtPaymentsDiscount = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAfbetaal = new MetroFramework.Controls.MetroButton();
            this.btnAfgeskryf = new MetroFramework.Controls.MetroButton();
            this.btnKortingAfbetaal = new MetroFramework.Controls.MetroButton();
            this.cmbPaymentsClient = new MetroFramework.Controls.MetroComboBox();
            this.dgvConsultations = new MetroFramework.Controls.MetroGrid();
            this.txtPaymentsConsultation = new System.Windows.Forms.TextBox();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPaymentsClient_Account_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPaymentsDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPaymentsClient_Surname = new MetroFramework.Controls.MetroTextBox();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(3, 34);
            this.pbBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(37, 27);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 45;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPayments.Location = new System.Drawing.Point(923, 98);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(447, 464);
            this.dgvPayments.TabIndex = 46;
            this.dgvPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.AutoSize = true;
            this.txtPaymentMethod.Location = new System.Drawing.Point(47, 271);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(137, 17);
            this.txtPaymentMethod.TabIndex = 47;
            this.txtPaymentMethod.Text = "Method of payment :";
            // 
            // cmbPayments_Method_Of_Payments
            // 
            this.cmbPayments_Method_Of_Payments.FormattingEnabled = true;
            this.cmbPayments_Method_Of_Payments.ItemHeight = 24;
            this.cmbPayments_Method_Of_Payments.Items.AddRange(new object[] {
            "Member",
            "Medical Aid"});
            this.cmbPayments_Method_Of_Payments.Location = new System.Drawing.Point(200, 258);
            this.cmbPayments_Method_Of_Payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPayments_Method_Of_Payments.Name = "cmbPayments_Method_Of_Payments";
            this.cmbPayments_Method_Of_Payments.Size = new System.Drawing.Size(158, 30);
            this.cmbPayments_Method_Of_Payments.TabIndex = 48;
            this.cmbPayments_Method_Of_Payments.UseSelectable = true;
            this.cmbPayments_Method_Of_Payments.SelectedIndexChanged += new System.EventHandler(this.cmbPayments_Method_Of_Payments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Amount :";
            // 
            // txtPayments_Amount
            // 
            // 
            // 
            // 
            this.txtPayments_Amount.CustomButton.Image = null;
            this.txtPayments_Amount.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtPayments_Amount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayments_Amount.CustomButton.Name = "";
            this.txtPayments_Amount.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPayments_Amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayments_Amount.CustomButton.TabIndex = 1;
            this.txtPayments_Amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayments_Amount.CustomButton.UseSelectable = true;
            this.txtPayments_Amount.CustomButton.Visible = false;
            this.txtPayments_Amount.ForeColor = System.Drawing.Color.Snow;
            this.txtPayments_Amount.Lines = new string[0];
            this.txtPayments_Amount.Location = new System.Drawing.Point(200, 329);
            this.txtPayments_Amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayments_Amount.MaxLength = 32767;
            this.txtPayments_Amount.Name = "txtPayments_Amount";
            this.txtPayments_Amount.PasswordChar = '\0';
            this.txtPayments_Amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPayments_Amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayments_Amount.SelectedText = "";
            this.txtPayments_Amount.SelectionLength = 0;
            this.txtPayments_Amount.SelectionStart = 0;
            this.txtPayments_Amount.Size = new System.Drawing.Size(160, 25);
            this.txtPayments_Amount.TabIndex = 50;
            this.txtPayments_Amount.UseSelectable = true;
            this.txtPayments_Amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayments_Amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPaymentsDiscount
            // 
            // 
            // 
            // 
            this.txtPaymentsDiscount.CustomButton.Image = null;
            this.txtPaymentsDiscount.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtPaymentsDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentsDiscount.CustomButton.Name = "";
            this.txtPaymentsDiscount.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPaymentsDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsDiscount.CustomButton.TabIndex = 1;
            this.txtPaymentsDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsDiscount.CustomButton.UseSelectable = true;
            this.txtPaymentsDiscount.CustomButton.Visible = false;
            this.txtPaymentsDiscount.Lines = new string[0];
            this.txtPaymentsDiscount.Location = new System.Drawing.Point(200, 386);
            this.txtPaymentsDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentsDiscount.MaxLength = 32767;
            this.txtPaymentsDiscount.Name = "txtPaymentsDiscount";
            this.txtPaymentsDiscount.PasswordChar = '\0';
            this.txtPaymentsDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsDiscount.SelectedText = "";
            this.txtPaymentsDiscount.SelectionLength = 0;
            this.txtPaymentsDiscount.SelectionStart = 0;
            this.txtPaymentsDiscount.Size = new System.Drawing.Size(160, 25);
            this.txtPaymentsDiscount.TabIndex = 52;
            this.txtPaymentsDiscount.UseSelectable = true;
            this.txtPaymentsDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Discount :";
            // 
            // btnAfbetaal
            // 
            this.btnAfbetaal.Location = new System.Drawing.Point(162, 551);
            this.btnAfbetaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfbetaal.Name = "btnAfbetaal";
            this.btnAfbetaal.Size = new System.Drawing.Size(96, 44);
            this.btnAfbetaal.TabIndex = 53;
            this.btnAfbetaal.Text = "Down paid";
            this.btnAfbetaal.UseSelectable = true;
            // 
            // btnAfgeskryf
            // 
            this.btnAfgeskryf.Location = new System.Drawing.Point(264, 551);
            this.btnAfgeskryf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfgeskryf.Name = "btnAfgeskryf";
            this.btnAfgeskryf.Size = new System.Drawing.Size(96, 44);
            this.btnAfgeskryf.TabIndex = 55;
            this.btnAfgeskryf.Text = "Written off";
            this.btnAfgeskryf.UseSelectable = true;
            // 
            // btnKortingAfbetaal
            // 
            this.btnKortingAfbetaal.Location = new System.Drawing.Point(162, 599);
            this.btnKortingAfbetaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKortingAfbetaal.Name = "btnKortingAfbetaal";
            this.btnKortingAfbetaal.Size = new System.Drawing.Size(198, 44);
            this.btnKortingAfbetaal.TabIndex = 56;
            this.btnKortingAfbetaal.Text = "Bereken korting afbetaal";
            this.btnKortingAfbetaal.UseSelectable = true;
            // 
            // cmbPaymentsClient
            // 
            this.cmbPaymentsClient.FormattingEnabled = true;
            this.cmbPaymentsClient.ItemHeight = 24;
            this.cmbPaymentsClient.Location = new System.Drawing.Point(200, 98);
            this.cmbPaymentsClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentsClient.Name = "cmbPaymentsClient";
            this.cmbPaymentsClient.Size = new System.Drawing.Size(160, 30);
            this.cmbPaymentsClient.TabIndex = 57;
            this.cmbPaymentsClient.UseSelectable = true;
            this.cmbPaymentsClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
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
            this.dgvConsultations.Location = new System.Drawing.Point(420, 98);
            this.dgvConsultations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dgvConsultations.RowTemplate.Height = 24;
            this.dgvConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultations.Size = new System.Drawing.Size(472, 464);
            this.dgvConsultations.TabIndex = 58;
            this.dgvConsultations.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConsultations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultations_CellContentClick);
            // 
            // txtPaymentsConsultation
            // 
            this.txtPaymentsConsultation.Location = new System.Drawing.Point(226, 491);
            this.txtPaymentsConsultation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaymentsConsultation.Name = "txtPaymentsConsultation";
            this.txtPaymentsConsultation.Size = new System.Drawing.Size(132, 22);
            this.txtPaymentsConsultation.TabIndex = 59;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(420, 599);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 44);
            this.btnConfirm.TabIndex = 60;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 491);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 20);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Consultation number :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 217);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(154, 20);
            this.metroLabel2.TabIndex = 63;
            this.metroLabel2.Text = "Client account number:";
            // 
            // txtPaymentsClient_Account_Number
            // 
            // 
            // 
            // 
            this.txtPaymentsClient_Account_Number.CustomButton.Image = null;
            this.txtPaymentsClient_Account_Number.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtPaymentsClient_Account_Number.CustomButton.Name = "";
            this.txtPaymentsClient_Account_Number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaymentsClient_Account_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsClient_Account_Number.CustomButton.TabIndex = 1;
            this.txtPaymentsClient_Account_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsClient_Account_Number.CustomButton.UseSelectable = true;
            this.txtPaymentsClient_Account_Number.CustomButton.Visible = false;
            this.txtPaymentsClient_Account_Number.Lines = new string[0];
            this.txtPaymentsClient_Account_Number.Location = new System.Drawing.Point(200, 217);
            this.txtPaymentsClient_Account_Number.MaxLength = 32767;
            this.txtPaymentsClient_Account_Number.Name = "txtPaymentsClient_Account_Number";
            this.txtPaymentsClient_Account_Number.PasswordChar = '\0';
            this.txtPaymentsClient_Account_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsClient_Account_Number.SelectedText = "";
            this.txtPaymentsClient_Account_Number.SelectionLength = 0;
            this.txtPaymentsClient_Account_Number.SelectionStart = 0;
            this.txtPaymentsClient_Account_Number.Size = new System.Drawing.Size(158, 23);
            this.txtPaymentsClient_Account_Number.TabIndex = 64;
            this.txtPaymentsClient_Account_Number.UseSelectable = true;
            this.txtPaymentsClient_Account_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsClient_Account_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(149, 434);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 20);
            this.metroLabel3.TabIndex = 65;
            this.metroLabel3.Text = "Date :";
            // 
            // txtPaymentsDate
            // 
            this.txtPaymentsDate.Location = new System.Drawing.Point(200, 424);
            this.txtPaymentsDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPaymentsDate.Name = "txtPaymentsDate";
            this.txtPaymentsDate.Size = new System.Drawing.Size(160, 30);
            this.txtPaymentsDate.TabIndex = 66;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(99, 98);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 20);
            this.metroLabel4.TabIndex = 67;
            this.metroLabel4.Text = "Client name:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(76, 153);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 20);
            this.metroLabel5.TabIndex = 68;
            this.metroLabel5.Text = "Client surname :";
            // 
            // txtPaymentsClient_Surname
            // 
            // 
            // 
            // 
            this.txtPaymentsClient_Surname.CustomButton.Image = null;
            this.txtPaymentsClient_Surname.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtPaymentsClient_Surname.CustomButton.Name = "";
            this.txtPaymentsClient_Surname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaymentsClient_Surname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsClient_Surname.CustomButton.TabIndex = 1;
            this.txtPaymentsClient_Surname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsClient_Surname.CustomButton.UseSelectable = true;
            this.txtPaymentsClient_Surname.CustomButton.Visible = false;
            this.txtPaymentsClient_Surname.Lines = new string[0];
            this.txtPaymentsClient_Surname.Location = new System.Drawing.Point(200, 153);
            this.txtPaymentsClient_Surname.MaxLength = 32767;
            this.txtPaymentsClient_Surname.Name = "txtPaymentsClient_Surname";
            this.txtPaymentsClient_Surname.PasswordChar = '\0';
            this.txtPaymentsClient_Surname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsClient_Surname.SelectedText = "";
            this.txtPaymentsClient_Surname.SelectionLength = 0;
            this.txtPaymentsClient_Surname.SelectionStart = 0;
            this.txtPaymentsClient_Surname.Size = new System.Drawing.Size(160, 23);
            this.txtPaymentsClient_Surname.TabIndex = 69;
            this.txtPaymentsClient_Surname.UseSelectable = true;
            this.txtPaymentsClient_Surname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsClient_Surname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBack.Location = new System.Drawing.Point(46, 36);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(51, 25);
            this.lblBack.TabIndex = 70;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(866, 51);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 25);
            this.metroLabel6.TabIndex = 71;
            this.metroLabel6.Text = "Payments";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 780);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.txtPaymentsClient_Surname);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPaymentsDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPaymentsClient_Account_Number);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtPaymentsConsultation);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.cmbPaymentsClient);
            this.Controls.Add(this.btnKortingAfbetaal);
            this.Controls.Add(this.btnAfgeskryf);
            this.Controls.Add(this.btnAfbetaal);
            this.Controls.Add(this.txtPaymentsDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayments_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPayments_Method_Of_Payments);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.pbBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayments";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBack;
        private MetroFramework.Controls.MetroGrid dgvPayments;
        private System.Windows.Forms.Label txtPaymentMethod;
        private MetroFramework.Controls.MetroComboBox cmbPayments_Method_Of_Payments;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtPayments_Amount;
        private MetroFramework.Controls.MetroTextBox txtPaymentsDiscount;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnAfbetaal;
        private MetroFramework.Controls.MetroButton btnAfgeskryf;
        private MetroFramework.Controls.MetroButton btnKortingAfbetaal;
        private MetroFramework.Controls.MetroComboBox cmbPaymentsClient;
        private MetroFramework.Controls.MetroGrid dgvConsultations;
        private System.Windows.Forms.TextBox txtPaymentsConsultation;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPaymentsClient_Account_Number;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime txtPaymentsDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPaymentsClient_Surname;
        private MetroFramework.Controls.MetroLabel lblBack;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}