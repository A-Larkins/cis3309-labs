/*
 * Andrew Larkins
 * 1/30/20
 * Cis-3309-01
 * Lab 3
 * Exercise 6.2
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

namespace Exercise_6._2x_Lab_3
{
    public partial class frmIncomeTax : Form
    {
        public frmIncomeTax()
        {
            InitializeComponent();
        }

        // Close event for the exit button.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ok button will check if name is entered, if not then
        // the user will have to enter a name.
        // Once a valid name is entered then the other txt
        // boxes become avaliable for user input.
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("No name was entered. Try again.", "Missing Name");
                txtName.Focus();
            }
            else
            {
                txtIncomeTaxOwed.Enabled = true;
                txtTaxableIncome.Enabled = true;
            }
        }

        // Set focus to name textbox.
        private void txtName_TextChanged(object sender, EventArgs e)
        {

            this.ActiveControl = txtName;
        }

        // Calculate button click event handler.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Turn the input into a decimal.
            decimal taxableIncome = decimal.Parse(txtTaxableIncome.Text);
            // Call the validate method to see if input is > 0.
            taxIncomeValidation(taxableIncome);

            // Call the method to do the calculation.
            decimal tax = taxTableLookup(taxableIncome);
            // Display in read only text box.
            txtIncomeTaxOwed.Text = tax.ToString();
        }

        // Method to validate the user input from the income text box.
        private void taxIncomeValidation (decimal input)
        {
            if (input < 0)
            {
                MessageBox.Show("Please enter a positive value.");
            }
        }

        // Method to figure out the correct tax range for the input.
        // Calculates and returns the tax amount owed.
        private decimal taxTableLookup (decimal input)
        {
            decimal amountOwed = 0;

            if (input <= 9_225)
            {
                amountOwed = (.10m * input);
            }
            else if (input >= 9_225 && input <= 37_450)
            {
                amountOwed = (922.50m + (.15m * input));
            }
            else if (input >= 37_450 && input <= 90_750)
            {
                amountOwed = (5_156.25m + (.25m * input));
            }
            else if (input >= 90_750 && input <= 189_300)
            {
                amountOwed = (18_481.25m + (.28m * input));
            }
            else if (input >= 189_300 && input <= 411_500)
            {
                amountOwed =  (46_075.25m + (.33m *input));
            }
            else if (input >= 411_500 && input <= 413_200)
            {
                amountOwed = (119_401.25m + (.35m * input));
            }
            else
            {
                amountOwed = (119_996.25m + (.396m * input));
            }
            return amountOwed;
        }


    }
}
