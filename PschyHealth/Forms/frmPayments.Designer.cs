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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
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
            this.cmbClient = new MetroFramework.Controls.MetroComboBox();
            this.dgvConsultations = new MetroFramework.Controls.MetroGrid();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.msmPayments = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaymentsConsultation = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaymentsDate = new MetroFramework.Controls.MetroDateTime();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaymentsClient_Surname = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClient_Account_Number = new MetroFramework.Controls.MetroTextBox();
            this.btnArchive = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmPayments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBack
            // 
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(3, 36);
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
            this.txtPaymentMethod.Location = new System.Drawing.Point(0, 203);
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
            this.cmbPayments_Method_Of_Payments.Location = new System.Drawing.Point(177, 203);
            this.cmbPayments_Method_Of_Payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPayments_Method_Of_Payments.Name = "cmbPayments_Method_Of_Payments";
            this.cmbPayments_Method_Of_Payments.Size = new System.Drawing.Size(160, 30);
            this.cmbPayments_Method_Of_Payments.TabIndex = 48;
            this.cmbPayments_Method_Of_Payments.UseSelectable = true;
            this.cmbPayments_Method_Of_Payments.SelectedIndexChanged += new System.EventHandler(this.cmbPayments_Method_Of_Payments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 286);
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
            this.txtPayments_Amount.Location = new System.Drawing.Point(177, 286);
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
            this.txtPaymentsDiscount.Location = new System.Drawing.Point(177, 324);
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
            this.label2.Location = new System.Drawing.Point(55, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Discount :";
            // 
            // btnAfbetaal
            // 
            this.btnAfbetaal.Location = new System.Drawing.Point(40, 425);
            this.btnAfbetaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfbetaal.Name = "btnAfbetaal";
            this.btnAfbetaal.Size = new System.Drawing.Size(75, 44);
            this.btnAfbetaal.TabIndex = 53;
            this.btnAfbetaal.Text = "Down paid";
            this.btnAfbetaal.UseSelectable = true;
            // 
            // btnAfgeskryf
            // 
            this.btnAfgeskryf.Location = new System.Drawing.Point(143, 425);
            this.btnAfgeskryf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfgeskryf.Name = "btnAfgeskryf";
            this.btnAfgeskryf.Size = new System.Drawing.Size(75, 44);
            this.btnAfgeskryf.TabIndex = 55;
            this.btnAfgeskryf.Text = "Written off";
            this.btnAfgeskryf.UseSelectable = true;
            // 
            // btnKortingAfbetaal
            // 
            this.btnKortingAfbetaal.Location = new System.Drawing.Point(224, 425);
            this.btnKortingAfbetaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKortingAfbetaal.Name = "btnKortingAfbetaal";
            this.btnKortingAfbetaal.Size = new System.Drawing.Size(179, 44);
            this.btnKortingAfbetaal.TabIndex = 56;
            this.btnKortingAfbetaal.Text = "Bereken korting afbetaal";
            this.btnKortingAfbetaal.UseSelectable = true;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ItemHeight = 24;
            this.cmbClient.Location = new System.Drawing.Point(177, 27);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(160, 30);
            this.cmbClient.TabIndex = 57;
            this.cmbClient.UseSelectable = true;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(420, 588);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 28);
            this.btnConfirm.TabIndex = 60;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // msmPayments
            // 
            this.msmPayments.Owner = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Client name :";
            // 
            // txtPaymentsConsultation
            // 
            // 
            // 
            // 
            this.txtPaymentsConsultation.CustomButton.Image = null;
            this.txtPaymentsConsultation.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtPaymentsConsultation.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentsConsultation.CustomButton.Name = "";
            this.txtPaymentsConsultation.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtPaymentsConsultation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsConsultation.CustomButton.TabIndex = 1;
            this.txtPaymentsConsultation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsConsultation.CustomButton.UseSelectable = true;
            this.txtPaymentsConsultation.CustomButton.Visible = false;
            this.txtPaymentsConsultation.ForeColor = System.Drawing.Color.Snow;
            this.txtPaymentsConsultation.Lines = new string[0];
            this.txtPaymentsConsultation.Location = new System.Drawing.Point(177, 246);
            this.txtPaymentsConsultation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentsConsultation.MaxLength = 32767;
            this.txtPaymentsConsultation.Name = "txtPaymentsConsultation";
            this.txtPaymentsConsultation.PasswordChar = '\0';
            this.txtPaymentsConsultation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPaymentsConsultation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsConsultation.SelectedText = "";
            this.txtPaymentsConsultation.SelectionLength = 0;
            this.txtPaymentsConsultation.SelectionStart = 0;
            this.txtPaymentsConsultation.Size = new System.Drawing.Size(160, 25);
            this.txtPaymentsConsultation.TabIndex = 64;
            this.txtPaymentsConsultation.UseSelectable = true;
            this.txtPaymentsConsultation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsConsultation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Consultation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Date :";
            // 
            // txtPaymentsDate
            // 
            this.txtPaymentsDate.Location = new System.Drawing.Point(177, 370);
            this.txtPaymentsDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentsDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPaymentsDate.Name = "txtPaymentsDate";
            this.txtPaymentsDate.Size = new System.Drawing.Size(160, 30);
            this.txtPaymentsDate.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Client surname :";
            // 
            // txtPaymentsClient_Surname
            // 
            this.txtPaymentsClient_Surname.FormattingEnabled = true;
            this.txtPaymentsClient_Surname.ItemHeight = 24;
            this.txtPaymentsClient_Surname.Location = new System.Drawing.Point(177, 81);
            this.txtPaymentsClient_Surname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaymentsClient_Surname.Name = "txtPaymentsClient_Surname";
            this.txtPaymentsClient_Surname.Size = new System.Drawing.Size(160, 30);
            this.txtPaymentsClient_Surname.TabIndex = 67;
            this.txtPaymentsClient_Surname.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Client account number  :";
            // 
            // txtClient_Account_Number
            // 
            // 
            // 
            // 
            this.txtClient_Account_Number.CustomButton.Image = null;
            this.txtClient_Account_Number.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtClient_Account_Number.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClient_Account_Number.CustomButton.Name = "";
            this.txtClient_Account_Number.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtClient_Account_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClient_Account_Number.CustomButton.TabIndex = 1;
            this.txtClient_Account_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClient_Account_Number.CustomButton.UseSelectable = true;
            this.txtClient_Account_Number.CustomButton.Visible = false;
            this.txtClient_Account_Number.ForeColor = System.Drawing.Color.Snow;
            this.txtClient_Account_Number.Lines = new string[0];
            this.txtClient_Account_Number.Location = new System.Drawing.Point(177, 139);
            this.txtClient_Account_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClient_Account_Number.MaxLength = 32767;
            this.txtClient_Account_Number.Name = "txtClient_Account_Number";
            this.txtClient_Account_Number.PasswordChar = '\0';
            this.txtClient_Account_Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClient_Account_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClient_Account_Number.SelectedText = "";
            this.txtClient_Account_Number.SelectionLength = 0;
            this.txtClient_Account_Number.SelectionStart = 0;
            this.txtClient_Account_Number.Size = new System.Drawing.Size(160, 25);
            this.txtClient_Account_Number.TabIndex = 71;
            this.txtClient_Account_Number.UseSelectable = true;
            this.txtClient_Account_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClient_Account_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnArchive
            // 
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(128, 588);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(139, 28);
            this.btnArchive.TabIndex = 72;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseSelectable = true;
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbClient);
            this.groupBox1.Controls.Add(this.txtPaymentMethod);
            this.groupBox1.Controls.Add(this.txtClient_Account_Number);
            this.groupBox1.Controls.Add(this.cmbPayments_Method_Of_Payments);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPayments_Amount);
            this.groupBox1.Controls.Add(this.txtPaymentsClient_Surname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPaymentsDate);
            this.groupBox1.Controls.Add(this.txtPaymentsDiscount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAfbetaal);
            this.groupBox1.Controls.Add(this.txtPaymentsConsultation);
            this.groupBox1.Controls.Add(this.btnAfgeskryf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnKortingAfbetaal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(411, 485);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 780);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.pbBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayments";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmPayments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private MetroFramework.Controls.MetroComboBox cmbClient;
        private MetroFramework.Controls.MetroGrid dgvConsultations;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Components.MetroStyleManager msmPayments;
        private MetroFramework.Controls.MetroTextBox txtClient_Account_Number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox txtPaymentsClient_Surname;
        private MetroFramework.Controls.MetroDateTime txtPaymentsDate;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtPaymentsConsultation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnArchive;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}