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
            this.txtConsultationNr = new System.Windows.Forms.TextBox();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.txtConsultation = new MetroFramework.Controls.MetroTextBox();
            this.msmPayments = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmPayments)).BeginInit();
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
            this.txtPaymentMethod.Location = new System.Drawing.Point(12, 111);
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
            this.cmbPayments_Method_Of_Payments.Location = new System.Drawing.Point(155, 98);
            this.cmbPayments_Method_Of_Payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPayments_Method_Of_Payments.Name = "cmbPayments_Method_Of_Payments";
            this.cmbPayments_Method_Of_Payments.Size = new System.Drawing.Size(121, 30);
            this.cmbPayments_Method_Of_Payments.TabIndex = 48;
            this.cmbPayments_Method_Of_Payments.UseSelectable = true;
            this.cmbPayments_Method_Of_Payments.SelectedIndexChanged += new System.EventHandler(this.cmbPayments_Method_Of_Payments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 175);
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
            this.txtPayments_Amount.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtPayments_Amount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayments_Amount.CustomButton.Name = "";
            this.txtPayments_Amount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPayments_Amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayments_Amount.CustomButton.TabIndex = 1;
            this.txtPayments_Amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayments_Amount.CustomButton.UseSelectable = true;
            this.txtPayments_Amount.CustomButton.Visible = false;
            this.txtPayments_Amount.ForeColor = System.Drawing.Color.Snow;
            this.txtPayments_Amount.Lines = new string[0];
            this.txtPayments_Amount.Location = new System.Drawing.Point(155, 169);
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
            this.txtPaymentsDiscount.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtPaymentsDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentsDiscount.CustomButton.Name = "";
            this.txtPaymentsDiscount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPaymentsDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentsDiscount.CustomButton.TabIndex = 1;
            this.txtPaymentsDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentsDiscount.CustomButton.UseSelectable = true;
            this.txtPaymentsDiscount.CustomButton.Visible = false;
            this.txtPaymentsDiscount.Lines = new string[0];
            this.txtPaymentsDiscount.Location = new System.Drawing.Point(155, 226);
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
            this.label2.Location = new System.Drawing.Point(67, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Discount :";
            // 
            // btnAfbetaal
            // 
            this.btnAfbetaal.Location = new System.Drawing.Point(52, 370);
            this.btnAfbetaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfbetaal.Name = "btnAfbetaal";
            this.btnAfbetaal.Size = new System.Drawing.Size(75, 44);
            this.btnAfbetaal.TabIndex = 53;
            this.btnAfbetaal.Text = "Down paid";
            this.btnAfbetaal.UseSelectable = true;
            // 
            // btnAfgeskryf
            // 
            this.btnAfgeskryf.Location = new System.Drawing.Point(155, 370);
            this.btnAfgeskryf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfgeskryf.Name = "btnAfgeskryf";
            this.btnAfgeskryf.Size = new System.Drawing.Size(75, 44);
            this.btnAfgeskryf.TabIndex = 55;
            this.btnAfgeskryf.Text = "Written off";
            this.btnAfgeskryf.UseSelectable = true;
            // 
            // btnKortingAfbetaal
            // 
            this.btnKortingAfbetaal.Location = new System.Drawing.Point(256, 370);
            this.btnKortingAfbetaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKortingAfbetaal.Name = "btnKortingAfbetaal";
            this.btnKortingAfbetaal.Size = new System.Drawing.Size(75, 44);
            this.btnKortingAfbetaal.TabIndex = 56;
            this.btnKortingAfbetaal.Text = "Bereken korting afbetaal";
            this.btnKortingAfbetaal.UseSelectable = true;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ItemHeight = 24;
            this.cmbClient.Location = new System.Drawing.Point(155, 53);
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
            // txtConsultationNr
            // 
            this.txtConsultationNr.Location = new System.Drawing.Point(143, 283);
            this.txtConsultationNr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsultationNr.Name = "txtConsultationNr";
            this.txtConsultationNr.Size = new System.Drawing.Size(132, 22);
            this.txtConsultationNr.TabIndex = 59;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(420, 588);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 28);
            this.btnConfirm.TabIndex = 60;
            this.btnConfirm.Text = "metroButton1";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtConsultation
            // 
            // 
            // 
            // 
            this.txtConsultation.CustomButton.Image = null;
            this.txtConsultation.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtConsultation.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsultation.CustomButton.Name = "";
            this.txtConsultation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsultation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultation.CustomButton.TabIndex = 1;
            this.txtConsultation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultation.CustomButton.UseSelectable = true;
            this.txtConsultation.CustomButton.Visible = false;
            this.txtConsultation.Lines = new string[] {
        "metroTextBox1"};
            this.txtConsultation.Location = new System.Drawing.Point(52, 506);
            this.txtConsultation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConsultation.MaxLength = 32767;
            this.txtConsultation.Name = "txtConsultation";
            this.txtConsultation.PasswordChar = '\0';
            this.txtConsultation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultation.SelectedText = "";
            this.txtConsultation.SelectionLength = 0;
            this.txtConsultation.SelectionStart = 0;
            this.txtConsultation.Size = new System.Drawing.Size(100, 28);
            this.txtConsultation.TabIndex = 61;
            this.txtConsultation.Text = "metroTextBox1";
            this.txtConsultation.UseSelectable = true;
            this.txtConsultation.Visible = false;
            this.txtConsultation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // msmPayments
            // 
            this.msmPayments.Owner = this;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 780);
            this.Controls.Add(this.txtConsultation);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtConsultationNr);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.cmbClient);
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
            ((System.ComponentModel.ISupportInitialize)(this.msmPayments)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox cmbClient;
        private MetroFramework.Controls.MetroGrid dgvConsultations;
        private System.Windows.Forms.TextBox txtConsultationNr;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroTextBox txtConsultation;
        private MetroFramework.Components.MetroStyleManager msmPayments;
    }
}