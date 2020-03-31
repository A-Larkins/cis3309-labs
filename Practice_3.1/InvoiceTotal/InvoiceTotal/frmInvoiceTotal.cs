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
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        // Exit button click event handler to exit program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Calculate button click event handler.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input and convert into a decimal.
                decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
                decimal discountPercentage = Convert.ToDecimal(txtDiscountPercent.Text);
                // Turn percentage into decimal form.
                discountPercentage = discountPercentage / 100;
                // calculate discount
                decimal discountAmount = subtotal * discountPercentage;
                decimal total = subtotal - discountAmount;

                // Show the results of the calculations.
                txtDiscountAmount.Text = discountAmount.ToString();
                txtTotal.Text = total.ToString();
            }
            // Handle exceptions that can occer.
            catch (Exception ex)
            {
                txtSubtotal.Text = "";
                txtDiscountPercent.Text = "";
                MessageBox.Show("Enter in both subtotal and discount.");
                txtSubtotal.Focus();

            }
        }
    }
}
