/*
 * Andrew Larkins
 * Cis 3309-01
 * Lab 4 Exercise 9.1
 * 2/10/2020
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

namespace DateHandling
{
    public partial class frmDateHandling : Form
    {
        public frmDateHandling()
        {
            InitializeComponent();
        }

        // Method to calculate the days until a certain date from today.
        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            // Get todays date
            DateTime currentDate = DateTime.Today;
            // Check if valid using TryParse method.
            // Pass in in text from the textbox and compare to a real date.
            DateTime check;
            if(DateTime.TryParse(txtFutureDate.Text, out check))
            {
                // Future time from text box.
                DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
                // Use type TimeSpan which can call subtract method and get
                // time in between dates.
                TimeSpan timeB = futureDate.Subtract(currentDate);
                int timeBetween = timeB.Days;

                MessageBox.Show("Current date: " + currentDate.ToShortDateString()
                    + "\nFuture date: " + futureDate.ToShortDateString()
                    + "\nDays until due: " + timeBetween,
                                                   "Due Days Calculation");
            } else // Ask to enter valid date.
            {
                MessageBox.Show("Please enter a date in the form dd/mm/yyyy.");
            }
        }

        // Method to calculate age.
        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // Take current date and subtract from inputed date.
            DateTime currentDate = DateTime.Today;

            // Check if valid using TryParse method.
            // Pass in in text from the textbox and compare to a real date.
            DateTime check;
            if (DateTime.TryParse(txtBirthDate.Text, out check))
            {
                // Get birthday
                DateTime birthDay = DateTime.Parse(txtBirthDate.Text);
                int age = currentDate.Year - birthDay.Year;

                // Assume for the year that birthday has passed, but then
                // check if the birthday hasn't come yet. Thus, age would
                // get decremented by 1 until someone's birthday.
                if (birthDay.Month > currentDate.Month)
                {
                    age = age - 1;
                }

                // Display result in Message box.
                MessageBox.Show("Current date: " + currentDate.ToShortDateString()
                    + "\nBirth date: " + birthDay.ToShortDateString()
                    + "\nAge: " + age,
                                                   "Age Calculation");
            }
            else
            {
                MessageBox.Show("Please enter a date in the form dd/mm/yyyy.");
            }
        }

        // Exit button
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        
    }
}
