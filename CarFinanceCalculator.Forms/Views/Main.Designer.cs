namespace CarFinanceCalculator.Forms.Views
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsrp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgSummary = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMaturityDate = new System.Windows.Forms.Label();
            this.lblEquityDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(12, 29);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.Text = "2009";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(12, 77);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 3;
            this.txtMake.Text = "Infiniti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make";
            // 
            // txtMsrp
            // 
            this.txtMsrp.Location = new System.Drawing.Point(12, 181);
            this.txtMsrp.Name = "txtMsrp";
            this.txtMsrp.Size = new System.Drawing.Size(100, 20);
            this.txtMsrp.TabIndex = 5;
            this.txtMsrp.Text = "38700";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MSRP";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 129);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 7;
            this.txtModel.Text = "G37";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(130, 77);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 20);
            this.txtLoanAmount.TabIndex = 9;
            this.txtLoanAmount.Text = "39203.27";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loan Amount";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(130, 129);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 20);
            this.txtTerm.TabIndex = 11;
            this.txtTerm.Text = "72";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Term (months)";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(130, 181);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 13;
            this.txtRate.Text = ".0659";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rate";
            // 
            // dpStartDate
            // 
            this.dpStartDate.Location = new System.Drawing.Point(12, 239);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(218, 20);
            this.dpStartDate.TabIndex = 14;
            this.dpStartDate.Value = new System.DateTime(2012, 12, 3, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "StartDate";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(130, 29);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 20);
            this.txtPayment.TabIndex = 17;
            this.txtPayment.Text = "660.69";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Monthly Payment";
            // 
            // dgSummary
            // 
            this.dgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummary.Location = new System.Drawing.Point(265, 29);
            this.dgSummary.Name = "dgSummary";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgSummary.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSummary.Size = new System.Drawing.Size(773, 478);
            this.dgSummary.TabIndex = 18;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(218, 23);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMaturityDate
            // 
            this.lblMaturityDate.AutoSize = true;
            this.lblMaturityDate.Location = new System.Drawing.Point(86, 322);
            this.lblMaturityDate.Name = "lblMaturityDate";
            this.lblMaturityDate.Size = new System.Drawing.Size(13, 13);
            this.lblMaturityDate.TabIndex = 20;
            this.lblMaturityDate.Text = "[]";
            // 
            // lblEquityDate
            // 
            this.lblEquityDate.AutoSize = true;
            this.lblEquityDate.Location = new System.Drawing.Point(86, 335);
            this.lblEquityDate.Name = "lblEquityDate";
            this.lblEquityDate.Size = new System.Drawing.Size(13, 13);
            this.lblEquityDate.TabIndex = 21;
            this.lblEquityDate.Text = "[]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Maturity Date: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Equity Date: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 531);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblEquityDate);
            this.Controls.Add(this.lblMaturityDate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dgSummary);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMsrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgSummary;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMaturityDate;
        private System.Windows.Forms.Label lblEquityDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}