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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pbBack.Location = new System.Drawing.Point(2, 29);
            this.pbBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(28, 22);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPayments.Location = new System.Drawing.Point(692, 80);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(335, 377);
            this.dgvPayments.TabIndex = 46;
            this.dgvPayments.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.AutoSize = true;
            this.txtPaymentMethod.Location = new System.Drawing.Point(0, 165);
            this.txtPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(104, 13);
            this.txtPaymentMethod.TabIndex = 47;
            this.txtPaymentMethod.Text = "Method of payment :";
            // 
            // cmbPayments_Method_Of_Payments
            // 
            this.cmbPayments_Method_Of_Payments.FormattingEnabled = true;
            this.cmbPayments_Method_Of_Payments.ItemHeight = 23;
            this.cmbPayments_Method_Of_Payments.Items.AddRange(new object[] {
            "Member",
            "Medical Aid"});
            this.cmbPayments_Method_Of_Payments.Location = new System.Drawing.Point(133, 165);
            this.cmbPayments_Method_Of_Payments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPayments_Method_Of_Payments.Name = "cmbPayments_Method_Of_Payments";
            this.cmbPayments_Method_Of_Payments.Size = new System.Drawing.Size(121, 29);
            this.cmbPayments_Method_Of_Payments.TabIndex = 48;
            this.cmbPayments_Method_Of_Payments.UseSelectable = true;
            this.cmbPayments_Method_Of_Payments.SelectedIndexChanged += new System.EventHandler(this.cmbPayments_Method_Of_Payments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Amount :";
            // 
            // txtPayments_Amount
            // 
            // 
            // 
            // 
            this.txtPayments_Amount.CustomButton.Image = null;
            this.txtPayments_Amount.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.txtPayments_Amount.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPayments_Amount.CustomButton.Name = "";
            this.txtPayments_Amount.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtPayments_Amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayments_Amount.CustomButton.TabIndex = 1;
            this.txtPayments_Amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayments_Amount.CustomButton.UseSelectable = true;
            this.txtPayments_Amount.CustomButton.Visible = false;
            this.txtPayments_Amount.ForeColor = System.Drawing.Color.Snow;
            this.txtPayments_Amount.Lines = new string[0];
            this.txtPayments_Amount.Location = new System.Drawing.Point(133, 232);
            this.txtPayments_Amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPayments_Amount.MaxLength = 32767;
            this.txtPayments_Amount.Name = "txtPayments_Amount";
            this.txtPayments_Amount.PasswordChar = '\0';
            this.txtPayments_Amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPayments_Amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayments_Amount.SelectedText = "";
            this.txtPayments_Amount.SelectionLength = 0;
            this.txtPayments_Amount.SelectionStart = 0;
            this.txtPayments_Amount.Size = new System.Drawing.Size(120, 20);
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
            this.txtPaymentsDiscount.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.txtPaymentsDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsDiscount.CustomButton.Name = "";
            this.txtPaymentsDiscount.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtPaymentsDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsDiscount.CustomButton.TabIndex = 1;
            this.txtPaymentsDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsDiscount.CustomButton.UseSelectable = true;
            this.txtPaymentsDiscount.CustomButton.Visible = false;
            this.txtPaymentsDiscount.Lines = new string[0];
            this.txtPaymentsDiscount.Location = new System.Drawing.Point(133, 263);
            this.txtPaymentsDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsDiscount.MaxLength = 32767;
            this.txtPaymentsDiscount.Name = "txtPaymentsDiscount";
            this.txtPaymentsDiscount.PasswordChar = '\0';
            this.txtPaymentsDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsDiscount.SelectedText = "";
            this.txtPaymentsDiscount.SelectionLength = 0;
            this.txtPaymentsDiscount.SelectionStart = 0;
            this.txtPaymentsDiscount.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentsDiscount.TabIndex = 52;
            this.txtPaymentsDiscount.UseSelectable = true;
            this.txtPaymentsDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Discount :";
            // 
            // btnAfbetaal
            // 
            this.btnAfbetaal.Location = new System.Drawing.Point(30, 345);
            this.btnAfbetaal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfbetaal.Name = "btnAfbetaal";
            this.btnAfbetaal.Size = new System.Drawing.Size(56, 36);
            this.btnAfbetaal.TabIndex = 53;
            this.btnAfbetaal.Text = "Down paid";
            this.btnAfbetaal.UseSelectable = true;
            // 
            // btnAfgeskryf
            // 
            this.btnAfgeskryf.Location = new System.Drawing.Point(107, 345);
            this.btnAfgeskryf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfgeskryf.Name = "btnAfgeskryf";
            this.btnAfgeskryf.Size = new System.Drawing.Size(56, 36);
            this.btnAfgeskryf.TabIndex = 55;
            this.btnAfgeskryf.Text = "Written off";
            this.btnAfgeskryf.UseSelectable = true;
            // 
            // btnKortingAfbetaal
            // 
            this.btnKortingAfbetaal.Location = new System.Drawing.Point(168, 345);
            this.btnKortingAfbetaal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKortingAfbetaal.Name = "btnKortingAfbetaal";
            this.btnKortingAfbetaal.Size = new System.Drawing.Size(134, 36);
            this.btnKortingAfbetaal.TabIndex = 56;
            this.btnKortingAfbetaal.Text = "Bereken korting afbetaal";
            this.btnKortingAfbetaal.UseSelectable = true;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ItemHeight = 23;
            this.cmbClient.Location = new System.Drawing.Point(133, 22);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 29);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultations.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvConsultations.EnableHeadersVisualStyles = false;
            this.dgvConsultations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConsultations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConsultations.Location = new System.Drawing.Point(315, 80);
            this.dgvConsultations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultations.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvConsultations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultations.RowTemplate.Height = 24;
            this.dgvConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultations.Size = new System.Drawing.Size(354, 377);
            this.dgvConsultations.TabIndex = 58;
            this.dgvConsultations.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConsultations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultations_CellContentClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(315, 478);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
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
            this.label3.Location = new System.Drawing.Point(25, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Client name :";
            // 
            // txtPaymentsConsultation
            // 
            // 
            // 
            // 
            this.txtPaymentsConsultation.CustomButton.Image = null;
            this.txtPaymentsConsultation.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.txtPaymentsConsultation.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsConsultation.CustomButton.Name = "";
            this.txtPaymentsConsultation.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtPaymentsConsultation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsConsultation.CustomButton.TabIndex = 1;
            this.txtPaymentsConsultation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsConsultation.CustomButton.UseSelectable = true;
            this.txtPaymentsConsultation.CustomButton.Visible = false;
            this.txtPaymentsConsultation.ForeColor = System.Drawing.Color.Snow;
            this.txtPaymentsConsultation.Lines = new string[0];
            this.txtPaymentsConsultation.Location = new System.Drawing.Point(133, 200);
            this.txtPaymentsConsultation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsConsultation.MaxLength = 32767;
            this.txtPaymentsConsultation.Name = "txtPaymentsConsultation";
            this.txtPaymentsConsultation.PasswordChar = '\0';
            this.txtPaymentsConsultation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPaymentsConsultation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentsConsultation.SelectedText = "";
            this.txtPaymentsConsultation.SelectionLength = 0;
            this.txtPaymentsConsultation.SelectionStart = 0;
            this.txtPaymentsConsultation.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentsConsultation.TabIndex = 64;
            this.txtPaymentsConsultation.UseSelectable = true;
            this.txtPaymentsConsultation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentsConsultation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Consultation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Date :";
            // 
            // txtPaymentsDate
            // 
            this.txtPaymentsDate.Location = new System.Drawing.Point(133, 301);
            this.txtPaymentsDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentsDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtPaymentsDate.Name = "txtPaymentsDate";
            this.txtPaymentsDate.Size = new System.Drawing.Size(121, 29);
            this.txtPaymentsDate.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Client surname :";
            // 
            // txtPaymentsClient_Surname
            // 
            this.txtPaymentsClient_Surname.FormattingEnabled = true;
            this.txtPaymentsClient_Surname.ItemHeight = 23;
            this.txtPaymentsClient_Surname.Location = new System.Drawing.Point(133, 66);
            this.txtPaymentsClient_Surname.Name = "txtPaymentsClient_Surname";
            this.txtPaymentsClient_Surname.Size = new System.Drawing.Size(121, 29);
            this.txtPaymentsClient_Surname.TabIndex = 67;
            this.txtPaymentsClient_Surname.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Client account number  :";
            // 
            // txtClient_Account_Number
            // 
            // 
            // 
            // 
            this.txtClient_Account_Number.CustomButton.Image = null;
            this.txtClient_Account_Number.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.txtClient_Account_Number.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClient_Account_Number.CustomButton.Name = "";
            this.txtClient_Account_Number.CustomButton.Size = new System.Drawing.Size(11, 12);
            this.txtClient_Account_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClient_Account_Number.CustomButton.TabIndex = 1;
            this.txtClient_Account_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClient_Account_Number.CustomButton.UseSelectable = true;
            this.txtClient_Account_Number.CustomButton.Visible = false;
            this.txtClient_Account_Number.ForeColor = System.Drawing.Color.Snow;
            this.txtClient_Account_Number.Lines = new string[0];
            this.txtClient_Account_Number.Location = new System.Drawing.Point(133, 113);
            this.txtClient_Account_Number.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClient_Account_Number.MaxLength = 32767;
            this.txtClient_Account_Number.Name = "txtClient_Account_Number";
            this.txtClient_Account_Number.PasswordChar = '\0';
            this.txtClient_Account_Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClient_Account_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClient_Account_Number.SelectedText = "";
            this.txtClient_Account_Number.SelectionLength = 0;
            this.txtClient_Account_Number.SelectionStart = 0;
            this.txtClient_Account_Number.Size = new System.Drawing.Size(120, 20);
            this.txtClient_Account_Number.TabIndex = 71;
            this.txtClient_Account_Number.UseSelectable = true;
            this.txtClient_Account_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClient_Account_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnArchive
            // 
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(96, 478);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(104, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(2, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 394);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.pbBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPayments";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
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