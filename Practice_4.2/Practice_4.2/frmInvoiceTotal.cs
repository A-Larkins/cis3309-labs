using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4._2
{
    public partial class frmInvoiceTotal : Form
    {

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        decimal minInvoice = decimal.MaxValue;
        decimal maxInvoice;


        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        // Exit program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ok button click event handler method.
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                lblEnterSubtotal.Enabled = true;
                txtEnterSubtotal.Enabled = true;
                btnCalculate.Enabled = true;
                btnClearTotals.Enabled = true;
                txtEnterSubtotal.Focus();
            }
            else
            {
                MessageBox.Show("Enter a positive name.");
                txtName.Focus();
            }
        }

        // Calculate button click event handler method.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
            bool isANum = subtotal > 0 && subtotal < decimal.MaxValue;
            if (txtEnterSubtotal.Text != "" && isANum)
            {
                enableStuff();
                txtSubtotal.Text = subtotal.ToString();

                decimal discountPercent = .25m;
                txtDiscountPercent.Text = Convert.ToInt32(discountPercent * 100).ToString() + "%";
                decimal discountAmount = (subtotal * discountPercent);
                txtDiscountAmount.Text = discountAmount.ToString();
                decimal total = subtotal - discountAmount;
                txtTotal.Text = total.ToString();
                
                numberOfInvoices++;
                txtNumInvoices.Text = numberOfInvoices.ToString();
                totalOfInvoices += total;
                txtTotalInvoices.Text = totalOfInvoices.ToString();
                invoiceAverage = (totalOfInvoices / numberOfInvoices);
                txtInvoiceAverage.Text = invoiceAverage.ToString();

                if (total < minInvoice)
                {
                    minInvoice = total;
                }
                if (total > maxInvoice)
                {
                    maxInvoice = total;
                }
                txtSmallestValue.Text = minInvoice.ToString();
                txtLargestInvoice.Text = maxInvoice.ToString();
                txtEnterSubtotal.Text = "";
                txtEnterSubtotal.Focus();
            }
            else
            {
                MessageBox.Show("Enter a number.");
                txtEnterSubtotal.Focus();
            }
        }

        // Method to enable all the other lbls and txtboxes.
        private void enableStuff()
        {
            lblSubtotal.Enabled = true;
            lblInvoiceAverage.Enabled = true;
            lblDiscountAmount.Enabled = true;
            lblDiscountPercent.Enabled = true;
            lblLargestInvoice.Enabled = true;
            lblSmallestValue.Enabled = true;
            lblTotal.Enabled = true;
            lblNumInvoices.Enabled = true;
            lblTotalInvoices.Enabled = true;
            txtDiscountAmount.Enabled = true;
            txtDiscountPercent.Enabled = true;
            txtInvoiceAverage.Enabled = true;
            txtLargestInvoice.Enabled = true;
            txtNumInvoices.Enabled = true;
            txtTotal.Enabled = true;
            txtSubtotal.Enabled = true;
            txtSmallestValue.Enabled = true;
            txtTotalInvoices.Enabled = true;
        }

        // Clear total click event handler.
        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "";
            txtDiscountAmount.Text = "";
            txtDiscountPercent.Text = "";
            txtEnterSubtotal.Text = "";
            txtInvoiceAverage.Text = "";
            txtLargestInvoice.Text = "";
            txtNumInvoices.Text = "";
            txtSmallestValue.Text = "";
            txtTotal.Text = "";
            txtTotalInvoices.Text = "";

            numberOfInvoices = 0;
            totalOfInvoices = 0;
            invoiceAverage = 0;
            maxInvoice = 0;
            minInvoice = decimal.MaxValue;


            txtEnterSubtotal.Focus();
        }
    }
}
