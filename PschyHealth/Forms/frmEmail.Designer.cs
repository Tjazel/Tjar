namespace PschyHealth
{
    partial class frmEmail
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
            this.msmEmail = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblBack = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTo = new MetroFramework.Controls.MetroTextBox();
            this.txtCC = new MetroFramework.Controls.MetroTextBox();
            this.txtSubject = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btnSendEmail = new MetroFramework.Controls.MetroButton();
            this.cmb1 = new MetroFramework.Controls.MetroComboBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.btnReadMail = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // msmEmail
            // 
            this.msmEmail.Owner = this;
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::PschyHealth.Properties.Resources.Circled_Chevron_Right_48px_111;
            this.pbBack.Location = new System.Drawing.Point(8, 69);
            this.pbBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(37, 27);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 46;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBack.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBack.Location = new System.Drawing.Point(51, 71);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(51, 25);
            this.lblBack.TabIndex = 47;
            this.lblBack.Text = "Back";
            this.lblBack.UseStyleColors = true;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(276, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 25);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "E-mail";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 20);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "To :";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 224);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 20);
            this.metroLabel3.TabIndex = 50;
            this.metroLabel3.Text = "CC :";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 283);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 20);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Subject :";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 331);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 20);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = "Message :";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtTo.CustomButton.Image = null;
            this.txtTo.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.txtTo.CustomButton.Name = "";
            this.txtTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTo.CustomButton.TabIndex = 1;
            this.txtTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTo.CustomButton.UseSelectable = true;
            this.txtTo.CustomButton.Visible = false;
            this.txtTo.Lines = new string[0];
            this.txtTo.Location = new System.Drawing.Point(106, 168);
            this.txtTo.MaxLength = 32767;
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTo.SelectedText = "";
            this.txtTo.SelectionLength = 0;
            this.txtTo.SelectionStart = 0;
            this.txtTo.Size = new System.Drawing.Size(466, 23);
            this.txtTo.TabIndex = 53;
            this.txtTo.UseSelectable = true;
            this.txtTo.UseStyleColors = true;
            this.txtTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCC
            // 
            this.txtCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtCC.CustomButton.Image = null;
            this.txtCC.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.txtCC.CustomButton.Name = "";
            this.txtCC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCC.CustomButton.TabIndex = 1;
            this.txtCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCC.CustomButton.UseSelectable = true;
            this.txtCC.CustomButton.Visible = false;
            this.txtCC.Lines = new string[0];
            this.txtCC.Location = new System.Drawing.Point(106, 221);
            this.txtCC.MaxLength = 32767;
            this.txtCC.Name = "txtCC";
            this.txtCC.PasswordChar = '\0';
            this.txtCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCC.SelectedText = "";
            this.txtCC.SelectionLength = 0;
            this.txtCC.SelectionStart = 0;
            this.txtCC.Size = new System.Drawing.Size(466, 23);
            this.txtCC.TabIndex = 54;
            this.txtCC.UseSelectable = true;
            this.txtCC.UseStyleColors = true;
            this.txtCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtSubject.CustomButton.Image = null;
            this.txtSubject.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.txtSubject.CustomButton.Name = "";
            this.txtSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubject.CustomButton.TabIndex = 1;
            this.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubject.CustomButton.UseSelectable = true;
            this.txtSubject.CustomButton.Visible = false;
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(106, 283);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.Size = new System.Drawing.Size(466, 23);
            this.txtSubject.TabIndex = 55;
            this.txtSubject.UseSelectable = true;
            this.txtSubject.UseStyleColors = true;
            this.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(106, 134);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(86, 17);
            this.metroCheckBox1.TabIndex = 58;
            this.metroCheckBox1.Text = "Send to all";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseStyleColors = true;
            this.metroCheckBox1.Visible = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendEmail.Location = new System.Drawing.Point(627, 641);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(0, 46);
            this.btnSendEmail.TabIndex = 59;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseSelectable = true;
            this.btnSendEmail.UseStyleColors = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.ItemHeight = 24;
            this.cmb1.Location = new System.Drawing.Point(192, 132);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(191, 30);
            this.cmb1.TabIndex = 60;
            this.cmb1.UseSelectable = true;
            this.cmb1.UseStyleColors = true;
            this.cmb1.Visible = false;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(403, 134);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(173, 17);
            this.metroCheckBox2.TabIndex = 61;
            this.metroCheckBox2.Text = "Send from existing clients";
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.UseStyleColors = true;
            this.metroCheckBox2.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(106, 574);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(466, 70);
            this.btnSend.TabIndex = 62;
            this.btnSend.Text = "Send";
            this.btnSend.UseSelectable = true;
            this.btnSend.UseStyleColors = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::PschyHealth.Properties.Resources.Minimize_Window_48px;
            this.pbMinimize.Location = new System.Drawing.Point(618, 10);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(31, 28);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 64;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::PschyHealth.Properties.Resources.Close_Window_48px;
            this.pbExit.Location = new System.Drawing.Point(657, 10);
            this.pbExit.Margin = new System.Windows.Forms.Padding(4);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(29, 28);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 63;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // txtMessage
            // 
            // 
            // 
            // 
            this.txtMessage.CustomButton.Image = null;
            this.txtMessage.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtMessage.CustomButton.Name = "";
            this.txtMessage.CustomButton.Size = new System.Drawing.Size(235, 235);
            this.txtMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMessage.CustomButton.TabIndex = 1;
            this.txtMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMessage.CustomButton.UseSelectable = true;
            this.txtMessage.CustomButton.Visible = false;
            this.txtMessage.Lines = new string[0];
            this.txtMessage.Location = new System.Drawing.Point(106, 331);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.Size = new System.Drawing.Size(466, 237);
            this.txtMessage.TabIndex = 65;
            this.txtMessage.UseSelectable = true;
            this.txtMessage.UseStyleColors = true;
            this.txtMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnReadMail
            // 
            this.btnReadMail.Location = new System.Drawing.Point(106, 689);
            this.btnReadMail.Name = "btnReadMail";
            this.btnReadMail.Size = new System.Drawing.Size(147, 65);
            this.btnReadMail.TabIndex = 66;
            this.btnReadMail.Text = "Read my e-mails";
            this.btnReadMail.UseSelectable = true;
            this.btnReadMail.UseStyleColors = true;
            this.btnReadMail.Click += new System.EventHandler(this.btnReadMail_Click);
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 1084);
            this.Controls.Add(this.btnReadMail);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.pbBack);
            this.Name = "frmEmail";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.Shown += new System.EventHandler(this.frmEmail_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.msmEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmEmail;
        private System.Windows.Forms.PictureBox pbBack;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox txtSubject;
        private MetroFramework.Controls.MetroTextBox txtCC;
        private MetroFramework.Controls.MetroTextBox txtTo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblBack;
        private MetroFramework.Controls.MetroButton btnSendEmail;
        private MetroFramework.Controls.MetroComboBox cmb1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroButton btnSend;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbExit;
        private MetroFramework.Controls.MetroButton btnReadMail;
        private MetroFramework.Controls.MetroTextBox txtMessage;
    }
}