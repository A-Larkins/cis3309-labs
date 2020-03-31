/*  
 *  Andrew Larkins
 *  Cis-3309-01
 *  Lab 2
 *  1/26/20
 *  
 *  Enhanced 5-2 Exercise
 *  
 *  5-2 #7) List three possible advantages of your new form design
 *  over the original form as specified in the text.
 *  
 *  The updated form has alot better user functionality. The
 *  enter data button can be used with the enter button, so the user
 *  does not have to use a mouse. The textboxes then come up whereas
 *  before they were already loaded and the user could easily enter
 *  things incorrectly. This way, the user cannot begin the program
 *  without the program first checking if the user has entered in
 *  the textbox inputs in the right order.
 *  
 *  - Added user funtionality
 *  - Added an error checking system
 *  - Added a clear problem and rerun system
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

namespace FutureValue
{
    public partial class FutureValue : Form
    {
        public FutureValue()
        {
            InitializeComponent();
        }

        // Set up load events.
        private void FutureValue_Load(object sender, EventArgs e)
        {

        }

        // Clears data and enables the text boxes for user input
        // after the button is clicked on.
        private void btnEnterData_Click(object sender, EventArgs e)
        {
           
            // Clears text boxes.
            txtMonthlyInvestment.Text = "";
            txtInterestRate.Text = "";
            txtYears.Text = "";
            txtFutureValue.Text = "";

            txtMonthlyInvestment.Enabled = true;
            txtInterestRate.Enabled = true;
            txtYears.Enabled = true;
            txtFutureValue.Enabled = true;

            txtMonthlyInvestment.Focus();

        }

        // Calculate method when the button is clicked.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            // Create vars to store user input from text boxes.
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            decimal numYears = Convert.ToInt32(txtYears.Text);

           
            decimal months = numYears * 12;
           
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
            // Comes up when the calculation is done. Asks user.
            MessageBox.Show("If you want another calculation press Enter Data button.", "Re-run!");
            btnEnterData.Focus();

        }

        // Method for exit button to close program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtMonthlyInvestment_TextChanged(object sender, EventArgs e)
        {

        }

        // After the years are entered, enable the calculate button.
        // User can just hit enter.
        private void txtYears_TextChanged(object sender, EventArgs e)
        {

            btnCalculate.Enabled = true;
            btnCalculate.Focus();

        }

        
    }
}
