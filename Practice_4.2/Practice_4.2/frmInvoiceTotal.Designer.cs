namespace Practice_4._2
{
    partial class frmInvoiceTotal
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
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumInvoices = new System.Windows.Forms.Label();
            this.lblTotalInvoices = new System.Windows.Forms.Label();
            this.lblInvoiceAverage = new System.Windows.Forms.Label();
            this.lblLargestInvoice = new System.Windows.Forms.Label();
            this.lblSmallestValue = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNumInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.txtSmallestValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(62, 66);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(66, 13);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.AutoSize = true;
            this.lblEnterSubtotal.Enabled = false;
            this.lblEnterSubtotal.Location = new System.Drawing.Point(62, 122);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(77, 13);
            this.lblEnterSubtotal.TabIndex = 1;
            this.lblEnterSubtotal.Text = "Enter Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Enabled = false;
            this.lblSubtotal.Location = new System.Drawing.Point(62, 170);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "&Subtotal:";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Enabled = false;
            this.lblDiscountPercent.Location = new System.Drawing.Point(62, 221);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(92, 13);
            this.lblDiscountPercent.TabIndex = 3;
            this.lblDiscountPercent.Text = "Discount Percent:";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Enabled = false;
            this.lblDiscountAmount.Location = new System.Drawing.Point(62, 264);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountAmount.TabIndex = 4;
            this.lblDiscountAmount.Text = "Discount Amount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(62, 312);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblNumInvoices
            // 
            this.lblNumInvoices.AutoSize = true;
            this.lblNumInvoices.Enabled = false;
            this.lblNumInvoices.Location = new System.Drawing.Point(329, 122);
            this.lblNumInvoices.Name = "lblNumInvoices";
            this.lblNumInvoices.Size = new System.Drawing.Size(102, 13);
            this.lblNumInvoices.TabIndex = 6;
            this.lblNumInvoices.Text = "Number of Invoices:";
            // 
            // lblTotalInvoices
            // 
            this.lblTotalInvoices.AutoSize = true;
            this.lblTotalInvoices.Enabled = false;
            this.lblTotalInvoices.Location = new System.Drawing.Point(340, 170);
            this.lblTotalInvoices.Name = "lblTotalInvoices";
            this.lblTotalInvoices.Size = new System.Drawing.Size(86, 13);
            this.lblTotalInvoices.TabIndex = 7;
            this.lblTotalInvoices.Text = "Total of Invoices";
            // 
            // lblInvoiceAverage
            // 
            this.lblInvoiceAverage.AutoSize = true;
            this.lblInvoiceAverage.Enabled = false;
            this.lblInvoiceAverage.Location = new System.Drawing.Point(340, 221);
            this.lblInvoiceAverage.Name = "lblInvoiceAverage";
            this.lblInvoiceAverage.Size = new System.Drawing.Size(88, 13);
            this.lblInvoiceAverage.TabIndex = 8;
            this.lblInvoiceAverage.Text = "Invoice Average:";
            // 
            // lblLargestInvoice
            // 
            this.lblLargestInvoice.AutoSize = true;
            this.lblLargestInvoice.Enabled = false;
            this.lblLargestInvoice.Location = new System.Drawing.Point(340, 261);
            this.lblLargestInvoice.Name = "lblLargestInvoice";
            this.lblLargestInvoice.Size = new System.Drawing.Size(83, 13);
            this.lblLargestInvoice.TabIndex = 9;
            this.lblLargestInvoice.Text = "Largest Invoice:";
            // 
            // lblSmallestValue
            // 
            this.lblSmallestValue.AutoSize = true;
            this.lblSmallestValue.Enabled = false;
            this.lblSmallestValue.Location = new System.Drawing.Point(340, 309);
            this.lblSmallestValue.Name = "lblSmallestValue";
            this.lblSmallestValue.Size = new System.Drawing.Size(79, 13);
            this.lblSmallestValue.TabIndex = 10;
            this.lblSmallestValue.Text = "Smallest Value:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Enabled = false;
            this.txtEnterSubtotal.Location = new System.Drawing.Point(164, 122);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSubtotal.TabIndex = 2;
            this.txtEnterSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(164, 170);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 13;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Enabled = false;
            this.txtDiscountPercent.Location = new System.Drawing.Point(164, 214);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercent.TabIndex = 14;
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Enabled = false;
            this.txtDiscountAmount.Location = new System.Drawing.Point(164, 261);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountAmount.TabIndex = 15;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(164, 309);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumInvoices
            // 
            this.txtNumInvoices.Enabled = false;
            this.txtNumInvoices.Location = new System.Drawing.Point(474, 119);
            this.txtNumInvoices.Name = "txtNumInvoices";
            this.txtNumInvoices.ReadOnly = true;
            this.txtNumInvoices.Size = new System.Drawing.Size(100, 20);
            this.txtNumInvoices.TabIndex = 17;
            this.txtNumInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalInvoices
            // 
            this.txtTotalInvoices.Enabled = false;
            this.txtTotalInvoices.Location = new System.Drawing.Point(474, 170);
            this.txtTotalInvoices.Name = "txtTotalInvoices";
            this.txtTotalInvoices.ReadOnly = true;
            this.txtTotalInvoices.Size = new System.Drawing.Size(100, 20);
            this.txtTotalInvoices.TabIndex = 18;
            this.txtTotalInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Enabled = false;
            this.txtInvoiceAverage.Location = new System.Drawing.Point(474, 221);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceAverage.TabIndex = 19;
            this.txtInvoiceAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Enabled = false;
            this.txtLargestInvoice.Location = new System.Drawing.Point(474, 261);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtLargestInvoice.TabIndex = 20;
            this.txtLargestInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSmallestValue
            // 
            this.txtSmallestValue.Enabled = false;
            this.txtSmallestValue.Location = new System.Drawing.Point(474, 305);
            this.txtSmallestValue.Name = "txtSmallestValue";
            this.txtSmallestValue.ReadOnly = true;
            this.txtSmallestValue.Size = new System.Drawing.Size(100, 20);
            this.txtSmallestValue.TabIndex = 21;
            this.txtSmallestValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(474, 61);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(300, 356);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Enabled = false;
            this.btnClearTotals.Location = new System.Drawing.Point(404, 356);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(75, 23);
            this.btnClearTotals.TabIndex = 24;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(499, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSmallestValue);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalInvoices);
            this.Controls.Add(this.txtNumInvoices);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSmallestValue);
            this.Controls.Add(this.lblLargestInvoice);
            this.Controls.Add(this.lblInvoiceAverage);
            this.Controls.Add(this.lblTotalInvoices);
            this.Controls.Add(this.lblNumInvoices);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblEnterSubtotal);
            this.Controls.Add(this.lblEnterName);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumInvoices;
        private System.Windows.Forms.Label lblTotalInvoices;
        private System.Windows.Forms.Label lblInvoiceAverage;
        private System.Windows.Forms.Label lblLargestInvoice;
        private System.Windows.Forms.Label lblSmallestValue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNumInvoices;
        private System.Windows.Forms.TextBox txtTotalInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.TextBox txtSmallestValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Button btnExit;
    }
}

