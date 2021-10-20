
namespace AlumniEngagementScore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcScore = new System.Windows.Forms.Button();
            this.txtAgeFactor = new System.Windows.Forms.TextBox();
            this.txtDonationFactor = new System.Windows.Forms.TextBox();
            this.txtConsentFactor = new System.Windows.Forms.TextBox();
            this.txtOptOutFactor = new System.Windows.Forms.TextBox();
            this.lblAgeFactor = new System.Windows.Forms.Label();
            this.lblDonationFactor = new System.Windows.Forms.Label();
            this.lblConsentFactor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRecalculate = new System.Windows.Forms.Button();
            this.btnToCSV = new System.Windows.Forms.Button();
            this.lblClickFactor = new System.Windows.Forms.Label();
            this.txtClickFactor = new System.Windows.Forms.TextBox();
            this.txtOpenFactor = new System.Windows.Forms.TextBox();
            this.lblOpenFactor = new System.Windows.Forms.Label();
            this.txtEmailFactor = new System.Windows.Forms.TextBox();
            this.lblEmailFactor = new System.Windows.Forms.Label();
            this.txtMeetingsFactor = new System.Windows.Forms.TextBox();
            this.lblMeetingsFactor = new System.Windows.Forms.Label();
            this.lblPositionFactor = new System.Windows.Forms.Label();
            this.lblOrgFactor = new System.Windows.Forms.Label();
            this.txtPositionFactor = new System.Windows.Forms.TextBox();
            this.txtOrgFactor = new System.Windows.Forms.TextBox();
            this.txtUpdateDetailsFactor = new System.Windows.Forms.TextBox();
            this.lblUpdateDetails = new System.Windows.Forms.Label();
            this.lblEventReg = new System.Windows.Forms.Label();
            this.lblEventsPart = new System.Windows.Forms.Label();
            this.txtEventsRegFactor = new System.Windows.Forms.TextBox();
            this.txtEventsPartFactor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1053, 340);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name:";
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(106, 391);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(151, 28);
            this.cboSheet.TabIndex = 3;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(106, 342);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(928, 27);
            this.txtFilename.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet:";
            // 
            // btnCalcScore
            // 
            this.btnCalcScore.Location = new System.Drawing.Point(646, 391);
            this.btnCalcScore.Name = "btnCalcScore";
            this.btnCalcScore.Size = new System.Drawing.Size(501, 29);
            this.btnCalcScore.TabIndex = 6;
            this.btnCalcScore.Text = "Calculate Score";
            this.btnCalcScore.UseVisualStyleBackColor = true;
            this.btnCalcScore.Click += new System.EventHandler(this.btnCalcScore_Click);
            // 
            // txtAgeFactor
            // 
            this.txtAgeFactor.Enabled = false;
            this.txtAgeFactor.Location = new System.Drawing.Point(145, 465);
            this.txtAgeFactor.Name = "txtAgeFactor";
            this.txtAgeFactor.Size = new System.Drawing.Size(68, 27);
            this.txtAgeFactor.TabIndex = 7;
            this.txtAgeFactor.Text = "0";
            this.txtAgeFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDonationFactor
            // 
            this.txtDonationFactor.Enabled = false;
            this.txtDonationFactor.Location = new System.Drawing.Point(145, 510);
            this.txtDonationFactor.Name = "txtDonationFactor";
            this.txtDonationFactor.Size = new System.Drawing.Size(68, 27);
            this.txtDonationFactor.TabIndex = 8;
            this.txtDonationFactor.Text = "0";
            this.txtDonationFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConsentFactor
            // 
            this.txtConsentFactor.Location = new System.Drawing.Point(372, 465);
            this.txtConsentFactor.Name = "txtConsentFactor";
            this.txtConsentFactor.Size = new System.Drawing.Size(69, 27);
            this.txtConsentFactor.TabIndex = 9;
            this.txtConsentFactor.Text = "100";
            this.txtConsentFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOptOutFactor
            // 
            this.txtOptOutFactor.Location = new System.Drawing.Point(372, 510);
            this.txtOptOutFactor.Name = "txtOptOutFactor";
            this.txtOptOutFactor.Size = new System.Drawing.Size(69, 27);
            this.txtOptOutFactor.TabIndex = 10;
            this.txtOptOutFactor.Text = "-100";
            this.txtOptOutFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAgeFactor
            // 
            this.lblAgeFactor.AutoSize = true;
            this.lblAgeFactor.Location = new System.Drawing.Point(45, 465);
            this.lblAgeFactor.Name = "lblAgeFactor";
            this.lblAgeFactor.Size = new System.Drawing.Size(80, 20);
            this.lblAgeFactor.TabIndex = 11;
            this.lblAgeFactor.Text = "Age Factor";
            // 
            // lblDonationFactor
            // 
            this.lblDonationFactor.AutoSize = true;
            this.lblDonationFactor.Location = new System.Drawing.Point(13, 510);
            this.lblDonationFactor.Name = "lblDonationFactor";
            this.lblDonationFactor.Size = new System.Drawing.Size(115, 20);
            this.lblDonationFactor.TabIndex = 12;
            this.lblDonationFactor.Text = "Donation Factor";
            // 
            // lblConsentFactor
            // 
            this.lblConsentFactor.AutoSize = true;
            this.lblConsentFactor.Location = new System.Drawing.Point(252, 468);
            this.lblConsentFactor.Name = "lblConsentFactor";
            this.lblConsentFactor.Size = new System.Drawing.Size(96, 20);
            this.lblConsentFactor.TabIndex = 13;
            this.lblConsentFactor.Text = "Opt-In Factor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Opt-Out Factor";
            // 
            // btnRecalculate
            // 
            this.btnRecalculate.Location = new System.Drawing.Point(646, 391);
            this.btnRecalculate.Name = "btnRecalculate";
            this.btnRecalculate.Size = new System.Drawing.Size(501, 29);
            this.btnRecalculate.TabIndex = 15;
            this.btnRecalculate.Text = "Recalculate Score";
            this.btnRecalculate.UseVisualStyleBackColor = true;
            this.btnRecalculate.Visible = false;
            this.btnRecalculate.Click += new System.EventHandler(this.btnRecalculate_Click);
            // 
            // btnToCSV
            // 
            this.btnToCSV.Location = new System.Drawing.Point(455, 391);
            this.btnToCSV.Name = "btnToCSV";
            this.btnToCSV.Size = new System.Drawing.Size(163, 29);
            this.btnToCSV.TabIndex = 16;
            this.btnToCSV.Text = "Export CSV";
            this.btnToCSV.UseVisualStyleBackColor = true;
            this.btnToCSV.Click += new System.EventHandler(this.btnToCSV_Click);
            // 
            // lblClickFactor
            // 
            this.lblClickFactor.AutoSize = true;
            this.lblClickFactor.Location = new System.Drawing.Point(252, 554);
            this.lblClickFactor.Name = "lblClickFactor";
            this.lblClickFactor.Size = new System.Drawing.Size(84, 20);
            this.lblClickFactor.TabIndex = 17;
            this.lblClickFactor.Text = "Click Factor";
            // 
            // txtClickFactor
            // 
            this.txtClickFactor.Location = new System.Drawing.Point(372, 551);
            this.txtClickFactor.Name = "txtClickFactor";
            this.txtClickFactor.Size = new System.Drawing.Size(69, 27);
            this.txtClickFactor.TabIndex = 18;
            this.txtClickFactor.Text = "50";
            this.txtClickFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpenFactor
            // 
            this.txtOpenFactor.Location = new System.Drawing.Point(372, 595);
            this.txtOpenFactor.Name = "txtOpenFactor";
            this.txtOpenFactor.Size = new System.Drawing.Size(69, 27);
            this.txtOpenFactor.TabIndex = 20;
            this.txtOpenFactor.Text = "25";
            this.txtOpenFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOpenFactor
            // 
            this.lblOpenFactor.AutoSize = true;
            this.lblOpenFactor.Location = new System.Drawing.Point(252, 598);
            this.lblOpenFactor.Name = "lblOpenFactor";
            this.lblOpenFactor.Size = new System.Drawing.Size(89, 20);
            this.lblOpenFactor.TabIndex = 19;
            this.lblOpenFactor.Text = "Open Factor";
            // 
            // txtEmailFactor
            // 
            this.txtEmailFactor.Location = new System.Drawing.Point(624, 592);
            this.txtEmailFactor.Name = "txtEmailFactor";
            this.txtEmailFactor.Size = new System.Drawing.Size(69, 27);
            this.txtEmailFactor.TabIndex = 28;
            this.txtEmailFactor.Text = "250";
            this.txtEmailFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEmailFactor
            // 
            this.lblEmailFactor.AutoSize = true;
            this.lblEmailFactor.Location = new System.Drawing.Point(504, 595);
            this.lblEmailFactor.Name = "lblEmailFactor";
            this.lblEmailFactor.Size = new System.Drawing.Size(90, 20);
            this.lblEmailFactor.TabIndex = 27;
            this.lblEmailFactor.Text = "Email Factor";
            // 
            // txtMeetingsFactor
            // 
            this.txtMeetingsFactor.Location = new System.Drawing.Point(624, 548);
            this.txtMeetingsFactor.Name = "txtMeetingsFactor";
            this.txtMeetingsFactor.Size = new System.Drawing.Size(69, 27);
            this.txtMeetingsFactor.TabIndex = 26;
            this.txtMeetingsFactor.Text = "20";
            this.txtMeetingsFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMeetingsFactor
            // 
            this.lblMeetingsFactor.AutoSize = true;
            this.lblMeetingsFactor.Location = new System.Drawing.Point(504, 551);
            this.lblMeetingsFactor.Name = "lblMeetingsFactor";
            this.lblMeetingsFactor.Size = new System.Drawing.Size(114, 20);
            this.lblMeetingsFactor.TabIndex = 25;
            this.lblMeetingsFactor.Text = "Meetings Factor";
            // 
            // lblPositionFactor
            // 
            this.lblPositionFactor.AutoSize = true;
            this.lblPositionFactor.Location = new System.Drawing.Point(504, 507);
            this.lblPositionFactor.Name = "lblPositionFactor";
            this.lblPositionFactor.Size = new System.Drawing.Size(105, 20);
            this.lblPositionFactor.TabIndex = 24;
            this.lblPositionFactor.Text = "Position Factor";
            // 
            // lblOrgFactor
            // 
            this.lblOrgFactor.AutoSize = true;
            this.lblOrgFactor.Location = new System.Drawing.Point(504, 465);
            this.lblOrgFactor.Name = "lblOrgFactor";
            this.lblOrgFactor.Size = new System.Drawing.Size(78, 20);
            this.lblOrgFactor.TabIndex = 23;
            this.lblOrgFactor.Text = "Org Factor";
            // 
            // txtPositionFactor
            // 
            this.txtPositionFactor.Location = new System.Drawing.Point(624, 507);
            this.txtPositionFactor.Name = "txtPositionFactor";
            this.txtPositionFactor.Size = new System.Drawing.Size(69, 27);
            this.txtPositionFactor.TabIndex = 22;
            this.txtPositionFactor.Text = "10";
            this.txtPositionFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrgFactor
            // 
            this.txtOrgFactor.Location = new System.Drawing.Point(624, 462);
            this.txtOrgFactor.Name = "txtOrgFactor";
            this.txtOrgFactor.Size = new System.Drawing.Size(69, 27);
            this.txtOrgFactor.TabIndex = 21;
            this.txtOrgFactor.Text = "10";
            this.txtOrgFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUpdateDetailsFactor
            // 
            this.txtUpdateDetailsFactor.Location = new System.Drawing.Point(878, 548);
            this.txtUpdateDetailsFactor.Name = "txtUpdateDetailsFactor";
            this.txtUpdateDetailsFactor.Size = new System.Drawing.Size(69, 27);
            this.txtUpdateDetailsFactor.TabIndex = 34;
            this.txtUpdateDetailsFactor.Text = "4";
            this.txtUpdateDetailsFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUpdateDetails
            // 
            this.lblUpdateDetails.AutoSize = true;
            this.lblUpdateDetails.Location = new System.Drawing.Point(758, 551);
            this.lblUpdateDetails.Name = "lblUpdateDetails";
            this.lblUpdateDetails.Size = new System.Drawing.Size(108, 20);
            this.lblUpdateDetails.TabIndex = 33;
            this.lblUpdateDetails.Text = "Update Details";
            // 
            // lblEventReg
            // 
            this.lblEventReg.AutoSize = true;
            this.lblEventReg.Location = new System.Drawing.Point(728, 507);
            this.lblEventReg.Name = "lblEventReg";
            this.lblEventReg.Size = new System.Drawing.Size(135, 20);
            this.lblEventReg.TabIndex = 32;
            this.lblEventReg.Text = "Events Registration";
            // 
            // lblEventsPart
            // 
            this.lblEventsPart.AutoSize = true;
            this.lblEventsPart.Location = new System.Drawing.Point(725, 462);
            this.lblEventsPart.Name = "lblEventsPart";
            this.lblEventsPart.Size = new System.Drawing.Size(138, 20);
            this.lblEventsPart.TabIndex = 31;
            this.lblEventsPart.Text = "Events Participation";
            // 
            // txtEventsRegFactor
            // 
            this.txtEventsRegFactor.Location = new System.Drawing.Point(878, 507);
            this.txtEventsRegFactor.Name = "txtEventsRegFactor";
            this.txtEventsRegFactor.Size = new System.Drawing.Size(69, 27);
            this.txtEventsRegFactor.TabIndex = 30;
            this.txtEventsRegFactor.Text = "5";
            this.txtEventsRegFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEventsPartFactor
            // 
            this.txtEventsPartFactor.Location = new System.Drawing.Point(878, 462);
            this.txtEventsPartFactor.Name = "txtEventsPartFactor";
            this.txtEventsPartFactor.Size = new System.Drawing.Size(69, 27);
            this.txtEventsPartFactor.TabIndex = 29;
            this.txtEventsPartFactor.Text = "10";
            this.txtEventsPartFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 678);
            this.Controls.Add(this.txtUpdateDetailsFactor);
            this.Controls.Add(this.lblUpdateDetails);
            this.Controls.Add(this.lblEventReg);
            this.Controls.Add(this.lblEventsPart);
            this.Controls.Add(this.txtEventsRegFactor);
            this.Controls.Add(this.txtEventsPartFactor);
            this.Controls.Add(this.txtEmailFactor);
            this.Controls.Add(this.lblEmailFactor);
            this.Controls.Add(this.txtMeetingsFactor);
            this.Controls.Add(this.lblMeetingsFactor);
            this.Controls.Add(this.lblPositionFactor);
            this.Controls.Add(this.lblOrgFactor);
            this.Controls.Add(this.txtPositionFactor);
            this.Controls.Add(this.txtOrgFactor);
            this.Controls.Add(this.txtOpenFactor);
            this.Controls.Add(this.lblOpenFactor);
            this.Controls.Add(this.txtClickFactor);
            this.Controls.Add(this.lblClickFactor);
            this.Controls.Add(this.btnToCSV);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblConsentFactor);
            this.Controls.Add(this.lblDonationFactor);
            this.Controls.Add(this.lblAgeFactor);
            this.Controls.Add(this.txtOptOutFactor);
            this.Controls.Add(this.txtConsentFactor);
            this.Controls.Add(this.txtDonationFactor);
            this.Controls.Add(this.txtAgeFactor);
            this.Controls.Add(this.btnCalcScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumni Engagement Score";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcScore;
        private System.Windows.Forms.TextBox txtAgeFactor;
        private System.Windows.Forms.TextBox txtDonationFactor;
        private System.Windows.Forms.TextBox txtConsentFactor;
        private System.Windows.Forms.TextBox txtOptOutFactor;
        private System.Windows.Forms.Label lblAgeFactor;
        private System.Windows.Forms.Label lblDonationFactor;
        private System.Windows.Forms.Label lblConsentFactor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRecalculate;
        private System.Windows.Forms.Button btnToCSV;
        private System.Windows.Forms.Label lblClickFactor;
        private System.Windows.Forms.TextBox txtClickFactor;
        private System.Windows.Forms.TextBox txtOpenFactor;
        private System.Windows.Forms.Label lblOpenFactor;
        private System.Windows.Forms.TextBox txtEmailFactor;
        private System.Windows.Forms.Label lblEmailFactor;
        private System.Windows.Forms.TextBox txtMeetingsFactor;
        private System.Windows.Forms.Label lblMeetingsFactor;
        private System.Windows.Forms.Label lblPositionFactor;
        private System.Windows.Forms.Label lblOrgFactor;
        private System.Windows.Forms.TextBox txtPositionFactor;
        private System.Windows.Forms.TextBox txtOrgFactor;
        private System.Windows.Forms.TextBox txtUpdateDetailsFactor;
        private System.Windows.Forms.Label lblUpdateDetails;
        private System.Windows.Forms.Label lblEventReg;
        private System.Windows.Forms.Label lblEventsPart;
        private System.Windows.Forms.TextBox txtEventsRegFactor;
        private System.Windows.Forms.TextBox txtEventsPartFactor;
    }
}

