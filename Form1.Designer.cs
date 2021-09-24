
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblAgeFactor = new System.Windows.Forms.Label();
            this.lblDonationFactor = new System.Windows.Forms.Label();
            this.lblConsentFactor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRecalculate = new System.Windows.Forms.Button();
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
            this.txtAgeFactor.Location = new System.Drawing.Point(274, 465);
            this.txtAgeFactor.Name = "txtAgeFactor";
            this.txtAgeFactor.Size = new System.Drawing.Size(125, 27);
            this.txtAgeFactor.TabIndex = 7;
            this.txtAgeFactor.Text = "1";
            this.txtAgeFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDonationFactor
            // 
            this.txtDonationFactor.Location = new System.Drawing.Point(274, 510);
            this.txtDonationFactor.Name = "txtDonationFactor";
            this.txtDonationFactor.Size = new System.Drawing.Size(125, 27);
            this.txtDonationFactor.TabIndex = 8;
            this.txtDonationFactor.Text = "1";
            this.txtDonationFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConsentFactor
            // 
            this.txtConsentFactor.Location = new System.Drawing.Point(513, 465);
            this.txtConsentFactor.Name = "txtConsentFactor";
            this.txtConsentFactor.Size = new System.Drawing.Size(125, 27);
            this.txtConsentFactor.TabIndex = 9;
            this.txtConsentFactor.Text = "100";
            this.txtConsentFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(513, 510);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 10;
            // 
            // lblAgeFactor
            // 
            this.lblAgeFactor.AutoSize = true;
            this.lblAgeFactor.Location = new System.Drawing.Point(174, 465);
            this.lblAgeFactor.Name = "lblAgeFactor";
            this.lblAgeFactor.Size = new System.Drawing.Size(80, 20);
            this.lblAgeFactor.TabIndex = 11;
            this.lblAgeFactor.Text = "Age Factor";
            // 
            // lblDonationFactor
            // 
            this.lblDonationFactor.AutoSize = true;
            this.lblDonationFactor.Location = new System.Drawing.Point(142, 510);
            this.lblDonationFactor.Name = "lblDonationFactor";
            this.lblDonationFactor.Size = new System.Drawing.Size(115, 20);
            this.lblDonationFactor.TabIndex = 12;
            this.lblDonationFactor.Text = "Donation Factor";
            // 
            // lblConsentFactor
            // 
            this.lblConsentFactor.AutoSize = true;
            this.lblConsentFactor.Location = new System.Drawing.Point(405, 468);
            this.lblConsentFactor.Name = "lblConsentFactor";
            this.lblConsentFactor.Size = new System.Drawing.Size(106, 20);
            this.lblConsentFactor.TabIndex = 13;
            this.lblConsentFactor.Text = "Consent Factor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 678);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblConsentFactor);
            this.Controls.Add(this.lblDonationFactor);
            this.Controls.Add(this.lblAgeFactor);
            this.Controls.Add(this.textBox4);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblAgeFactor;
        private System.Windows.Forms.Label lblDonationFactor;
        private System.Windows.Forms.Label lblConsentFactor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRecalculate;
    }
}

