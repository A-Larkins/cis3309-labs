/*
 * Andrew Larkins
 * Cis 3309-01
 * Lab 4 Exercise 8.1x
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

namespace ScoreCalculator
{ 
    public partial class ScoreCalculator : Form
    {
        
        // Class variables to store score total and score count
        private decimal scoreTotal;

        // Count not needed with List, was used with Array to
        // keep track of how many elements were in the array.
        // Lists are easier because you don't have to worry about
        // the length like in an array.
        //private int scoreCount = 0;

        // Array
        //private int[] myData = new int[20];
        // List
        private static List<int> myData = new List<int>();


        public ScoreCalculator()
        {
            InitializeComponent();
        }

        // Exit event on button click.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for when user clicks on the add button.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get input from score text box.
            int score = int.Parse(txtScore.Text);

            // Add score to array
            //myData[scoreCount] = score;

            // Add score to List.
            myData.Add(score);

            // Add new score to total count.
            scoreTotal = scoreTotal + score;
            // Increment the count of scores.
            //scoreCount++;
            // Calculate average of scores.
            //decimal scoreAverage = scoreTotal / scoreCount;
            decimal scoreAverage = scoreTotal / myData.Count;


            // Display the results.
            txtScoreTotal.Text = scoreTotal.ToString();
            //txtScoreCount.Text = scoreCount.ToString();
            txtScoreCount.Text = myData.Count.ToString();
            txtAverage.Text = scoreAverage.ToString();


            // Go back to the score textbox.
            txtScore.Focus();
        }

        // Event handler for the clear button.
        private void btnClearScores_Click(object sender, EventArgs e)
        {
            // Clear the values.
            scoreTotal = 0;
            //scoreCount = 0;

            // Set all txt boxes to 0.
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            // Clear array.
            //myData = new int[20];

            //Clear List
            myData = new List<int>();

            // Go back to the score textbox.
            txtScore.Focus();
        }



        // Click event handler for the display button which will make
        // the array viewable and print in a textbox. Also sorts the array.
        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            //String displayMyDataArray = "";
            //Array.Sort(myData);

            // Display
            String displayNumbersInList = "";
            // Sort the numbers in the list.
            myData.Sort();

            int count = 0;
            bool isEmpty = !myData.Any();

            if (isEmpty)
            {
                MessageBox.Show("Enter some values before clicking the button.");
            }

            foreach(int i in myData)
            {
                //displayMyDataArray += i.ToString() + "\n";

                displayNumbersInList += i.ToString() + "\n";
                count++;

                if(myData.Count() >= 20)
                {
                    MessageBox.Show("Hey, this only shows a max of 20 scores.");
                    break;

                }
               else if (count == myData.Count)
                {
                    MessageBox.Show(displayNumbersInList, "Number of scores entered: " + myData.Count);
                    break;
                }

            }
            txtScore.Focus();
        }

    }
}
