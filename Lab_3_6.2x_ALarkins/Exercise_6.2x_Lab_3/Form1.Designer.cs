/*
 * Andrew Larkins
 * 1/30/20
 * Cis-3309-01
 * Lab 3
 * Exercise 6.2
 */


namespace Exercise_6._2x_Lab_3
{
    partial class frmIncomeTax
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
            this.lblTaxableIncome = new System.Windows.Forms.Label();
            this.lblIncomeTaxOwed = new System.Windows.Forms.Label();
            this.txtTaxableIncome = new System.Windows.Forms.TextBox();
            this.txtIncomeTaxOwed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxableIncome
            // 
            this.lblTaxableIncome.AutoSize = true;
            this.lblTaxableIncome.Location = new System.Drawing.Point(13, 74);
            this.lblTaxableIncome.Name = "lblTaxableIncome";
            this.lblTaxableIncome.Size = new System.Drawing.Size(86, 13);
            this.lblTaxableIncome.TabIndex = 0;
            this.lblTaxableIncome.Text = "Taxable Income:";
            // 
            // lblIncomeTaxOwed
            // 
            this.lblIncomeTaxOwed.AutoSize = true;
            this.lblIncomeTaxOwed.Location = new System.Drawing.Point(13, 123);
            this.lblIncomeTaxOwed.Name = "lblIncomeTaxOwed";
            this.lblIncomeTaxOwed.Size = new System.Drawing.Size(97, 13);
            this.lblIncomeTaxOwed.TabIndex = 1;
            this.lblIncomeTaxOwed.Text = "Income Tax Owed:";
            // 
            // txtTaxableIncome
            // 
            this.txtTaxableIncome.Enabled = false;
            this.txtTaxableIncome.Location = new System.Drawing.Point(138, 74);
            this.txtTaxableIncome.Name = "txtTaxableIncome";
            this.txtTaxableIncome.Size = new System.Drawing.Size(100, 20);
            this.txtTaxableIncome.TabIndex = 3;
            // 
            // txtIncomeTaxOwed
            // 
            this.txtIncomeTaxOwed.Enabled = false;
            this.txtIncomeTaxOwed.Location = new System.Drawing.Point(138, 116);
            this.txtIncomeTaxOwed.Name = "txtIncomeTaxOwed";
            this.txtIncomeTaxOwed.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeTaxOwed.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(35, 166);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(171, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(13, 32);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(66, 13);
            this.lblEnterName.TabIndex = 6;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(265, 27);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmIncomeTax
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(363, 212);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIncomeTaxOwed);
            this.Controls.Add(this.txtTaxableIncome);
            this.Controls.Add(this.lblIncomeTaxOwed);
            this.Controls.Add(this.lblTaxableIncome);
            this.Name = "frmIncomeTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxableIncome;
        private System.Windows.Forms.Label lblIncomeTaxOwed;
        private System.Windows.Forms.TextBox txtTaxableIncome;
        private System.Windows.Forms.TextBox txtIncomeTaxOwed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
    }
}

