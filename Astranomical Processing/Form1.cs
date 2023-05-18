using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astranomical_Processing
{
    // Andrew Millett, Evan Waters, Starlight Inc., Sprint 1
    // Date: 11/05/2023
    // Version: 1
    // Astranomical Processing
    // The program will hold data about observed neutrino activity that has been input in an array.
    // The program will feature 1 text box to input the data, 3 buttons 1 enter button to enter the input into the array, 1 button to search the array for specific entry,
    // and 1 button to sort the array. It will also feature a list box to display the array.
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] neutrinosArray = new int[24];

        #region Methods

        public void display()
        {
            lstArrayDisplay.Items.Clear();
            for (int count = 0; count < neutrinosArray.Length; count++)// For each item in Array
            {
                lstArrayDisplay.Items.Add(neutrinosArray[count]);// Display items in list box
            }
        }// Used to display the list in the listbox

        public void edit(int editSelected)
        {
            string input = txtInput.Text;
            int searchTerm = 0;
            bool parsed = false;

            try// Try to parse string from textbox to an int
            {
                searchTerm = Int32.Parse(input);
                parsed = true;
            }
            catch (FormatException)// If parse is unsuccessful
            {
                MessageBox.Show("Unable to parse " + input, "Error");
            }
            
            if (parsed == true)// If parsed is true then begin edit method
            {
                neutrinosArray[editSelected] = searchTerm;
                sortBubble();                
            }
        }// Edit method

        public void error()
        {
            MessageBox.Show("Error!", "Error");
        }// General error message, can be edited for more specific use

        public void success()
        {
            MessageBox.Show("Success!", "Success");
        }// General success message, can be edited for more specific use

        public void searchBinary()
        {
            int first = 0;
            int last = neutrinosArray.Length - 1;
            int position = -1;
            bool found = false;
            int compCount = 0;
            string input = txtInput.Text;
            int searchTerm = 0;
            bool parsed = false;

            if (txtInput.Text.Equals(""))// if textbox blank then throw up error
            {
                MessageBox.Show("Nothing entered", "Error");                
            }

            try// Try to parse string from textbox to an int
            {
                searchTerm = Int32.Parse(input);
                parsed = true;
            }
            catch (FormatException)// If parse is unsuccessful
            {
                MessageBox.Show("Unable to parse " + input, "Error");
            }

            while (found != true && first <= last && parsed == true)// If parsed is true, search item not found, and first is less or equal to last then begin while loop
            {
                int middle = (first + last) / 2;

                if (neutrinosArray[middle] == searchTerm)
                {
                    found = true;
                    position = middle;
                    compCount++;

                    MessageBox.Show("Your search has been found after " + compCount + " attempts.", "Success!");
                    return;
                }

                else if (neutrinosArray[middle] >= searchTerm)
                {
                    last = middle -1;
                    compCount++;
                }

                else
                {
                    first = middle +1;
                    compCount++;
                }
            }

            MessageBox.Show("Search was not found", "Error");
        }// Binary search method to be called later

        public void sortBubble()
        {
            var n = neutrinosArray.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (neutrinosArray[j] > neutrinosArray[j + 1])
                    {
                        var tempVar = neutrinosArray[j];
                        neutrinosArray[j] = neutrinosArray[j + 1];
                        neutrinosArray[j + 1] = tempVar;
                    }
            display();
        }// Bubble sort method to be called later

        public void generateNumbers()
        {
            Random randomNumbers = new Random();
            for(int i = 0; i < neutrinosArray.Length; i++)
            {
                neutrinosArray[i] = randomNumbers.Next(10, 99);
            }
        }// Used to add random numbers within 10 - 99 into neutrinos array

        #endregion


        private void btnEnterData_Click(object sender, EventArgs e)
        {
            generateNumbers();
            display();
        }// When the "enter" button is pressed, call these two methods

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchBinary();
        }// When "search" button is pressed, call the binary search method

        private void btnSort_Click(object sender, EventArgs e)
        {
            sortBubble();
        }// when the "sort" button is pressed, call the bubble sort method

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // If enter key is pressed
            {
                if (lstArrayDisplay.SelectedIndex >= 0)// and something is selected in the list box, then begin edit method
                {
                    edit(lstArrayDisplay.SelectedIndex);
                    txtInput.Clear();// clear textbox
                }// End if statement

            }// End if statement
        }// When a valid integer is entered into the textbox and the enter key is pressed, call the edit method
    }
}
