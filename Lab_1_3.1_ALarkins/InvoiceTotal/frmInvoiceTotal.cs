/*
 Andrew Larkins
CIS3309-001
01/20/20
Murach C# Text Exercise 3-1
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
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }
        
        /* 
        Coded this method from the book and did the other stuff.
        Method contains the logic for when the user clicks on
        the calculate button in the form. Takes text and change to
        decimal and the rate is according to the total amount
        entered by the user. Then does the math and sends back
        answer in text in the read only text boxes.
        */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;
            if (invoiceSubtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
            {
                discountPercent = .1m;
            }
            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal invoiceTotal = invoiceSubtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();
        }

        /* 
        This method closes the program when the exit button
        is clicked on by the user.
        */
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
