/*
 Andrew Larkins
CIS3309-001
01/22/20
Lab 2
Murach C# Text Exercise 4-2
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
	{
        // Variables to count number of invoices, the running total amount of invoices in money,
        // and the average of the invoices.
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        // Set min invoice to something super big so it is not defaulted to 0.
        decimal minInvoice = decimal.MaxValue;
        // max
        decimal maxInvoice;

        // Constructor 
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtEnterSubtotal.Focus();

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name");
            }
        }

        // Method for the calculate button.
        private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
			decimal discountPercent = .25m;
			decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
			decimal invoiceTotal = subtotal - discountAmount;

            // Try catch to make sure a valid number is entered.
            try
            {
                txtSubtotal.Text = subtotal.ToString("c");
                txtDiscountPercent.Text = discountPercent.ToString("p1");
                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtTotal.Text = invoiceTotal.ToString("c");
                numberOfInvoices++;
                totalOfInvoices += invoiceTotal;
                invoiceAverage = totalOfInvoices / numberOfInvoices;

                txtNumberOfInvoices.Text = numberOfInvoices.ToString();
                txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
                txtInvoiceAverage.Text = invoiceAverage.ToString("c");

                // Find min and maX invoices.
                minInvoice = Math.Min(minInvoice, invoiceTotal);
                maxInvoice = Math.Max(maxInvoice, invoiceTotal);


                // Convert decimal to currency format
                txtSmallestInvoice.Text = minInvoice.ToString("c");
                txtLargestInvoice.Text = maxInvoice.ToString("c");

                txtEnterSubtotal.Text = "";
                txtEnterSubtotal.Focus();
            }
            catch
            {
                MessageBox.Show("Please enter a subtotal");
            }

		}

        // Handles click event for the Clear Total button.
        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            //Set the text boxes back to 0.
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            // Clears text boxes.
            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtSmallestInvoice.Text = "";
            txtLargestInvoice.Text = "";

            txtEnterSubtotal.Focus();
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        

    }
}
