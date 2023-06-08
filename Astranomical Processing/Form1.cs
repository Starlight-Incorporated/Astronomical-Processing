using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Astranomical_Processing
{
    // Andrew Millett, Evan Waters, Starlight Inc., Sprint 2
    // Date: 22/05/2023
    // Version: 2
    // Astranomical Processing
    // The program will hold data about observed neutrino activity that has been input in an array.
    // The program will now feature 4 new text boxes to display mathmatical functions, 4 new buttons each for a specific mathmatical function,
    // and 1 new button adding a linear search function.
    
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

                    MessageBox.Show("Your search has been found at position " + (position + 1) + " in the array.", "Success!");
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

        public void searchLinear()
        {
            bool found = false;
            string input = txtInput.Text;
            int searchTerm = 0;
            
            if (txtInput.Text.Equals(""))
            {
                MessageBox.Show("Nothing entered", "Error");                
            }

            try// Try to parse string from textbox to an int
            {
                searchTerm = Int32.Parse(input);                
            }
            catch (FormatException)// If parse is unsuccessful
            {
                MessageBox.Show("Unable to parse " + input, "Error");
            }

            foreach (int item in neutrinosArray)
            {
                for (int i = 0; i < neutrinosArray.Length; i++)
                {
                    if (item == searchTerm)
                    {
                        found = true;                        
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Your search has not been found", "Error");
            }
            else
            {
                MessageBox.Show("Your search has been found in the array.", "Success!");
            }
        }// Linear search method to be called later

        #region Calculations

        public void calculateMidRange()
        {
            int min = neutrinosArray[0], max = neutrinosArray[0];

            for (int index = 1; index < neutrinosArray.Length - 1; index++)
            {
                if (neutrinosArray[index] > max)
                {
                    max = neutrinosArray[index];
                }
                if (neutrinosArray[index] < min)
                {
                    min = neutrinosArray[index];
                }
            }

            double answer = (max + min) / 2;
            txtMidRangeOutput.Text = answer.ToString();
        }// Method to calculate the Mid-Range of the array

        public void calculateMode()
        {
            int[] myCount = new int[100];

            int maxCount = 0;
            

            for (int countOuter = 0; countOuter < neutrinosArray.Length - 1; countOuter++)
            {
                int temp = neutrinosArray[countOuter];
                myCount[temp] = myCount[temp]+1;
            }

            for (int countInner = 0; countInner < myCount.Length - 1; countInner++)
            {
                if (myCount[countInner] > maxCount)
                {
                    maxCount = myCount[countInner];
                    int mode = countInner;
                }
            }

            string modeString = null;

            for (int countInner = 1; countInner < myCount.Length; countInner++)
            {
                if (myCount[countInner] == maxCount)
                {
                    
                    modeString = modeString + " " + countInner;
                }
            }
           
            txtModeOutput.Text = modeString;

        }// Method to calculate the Mode of the array

        public void calculateAverage()
        {
            int sum = 0;

            for (int i = 0; i < neutrinosArray.Length; i++)
            {
                sum += neutrinosArray[i];
            }

            float average = (float)sum / neutrinosArray.Length;
            txtAverageOutput.Text = average.ToString();
        }// Method to calculate the Average of the array

        public void calculateRange()
        {
            int min = neutrinosArray[0], max = neutrinosArray[0];

            for (int index = 1; index < neutrinosArray.Length; index++)
            {
                if (neutrinosArray[index] > max)
                {
                    max = neutrinosArray[index];
                }
                if (neutrinosArray[index] < min)
                {
                    min = neutrinosArray[index];
                }
            }

            double answer = max - min;
            txtRangeOutput.Text = answer.ToString();
        }// Method to calculate the Range of the array

        #endregion    
        // Region containing calculation methods

        #endregion
        // Region containing all methods used in program

        #region Button Actions

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

        

        private void btnMidRange_Click(object sender, EventArgs e)
        {
            calculateMidRange();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            calculateMode();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            calculateAverage();
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            calculateRange();
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            searchLinear();
        }

        #endregion
        // Region of Button Actions

        #region Tooltips

        private void btnEnterData_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipEnter = new ToolTip();

            tipEnter.Active = true;
            tipEnter.InitialDelay = 400;
            tipEnter.IsBalloon = true;
            tipEnter.ToolTipIcon = ToolTipIcon.Info;
            tipEnter.ToolTipTitle = "Enter Button";
            tipEnter.SetToolTip(this.btnEnterData, "Press to enter random number into List");
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipSearch = new ToolTip();

            tipSearch.Active = true;
            tipSearch.InitialDelay = 400;
            tipSearch.IsBalloon = true;
            tipSearch.ToolTipIcon = ToolTipIcon.Info;
            tipSearch.ToolTipTitle = "Search Button";
            tipSearch.SetToolTip(this.btnSearch, "Press to search current list for entered number");
        }

        private void btnSort_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipSort = new ToolTip();

            tipSort.Active = true;
            tipSort.InitialDelay = 400;
            tipSort.IsBalloon = true;
            tipSort.ToolTipIcon = ToolTipIcon.Info;
            tipSort.ToolTipTitle = "Sort Button";
            tipSort.SetToolTip(this.btnSort, "Press to sort the current list");
        }

        private void btnLinearSearch_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipLinearSearch = new ToolTip();

            tipLinearSearch.Active = true;
            tipLinearSearch.InitialDelay = 400;
            tipLinearSearch.IsBalloon = true;
            tipLinearSearch.ToolTipIcon = ToolTipIcon.Info;
            tipLinearSearch.ToolTipTitle = "Sequential Search Button";
            tipLinearSearch.SetToolTip(this.btnLinearSearch, "Press to perform a sequential search of current list for entered number");
        }

        private void btnMidRange_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipMidRange = new ToolTip();

            tipMidRange.Active = true;
            tipMidRange.InitialDelay = 400;
            tipMidRange.IsBalloon = true;
            tipMidRange.ToolTipIcon = ToolTipIcon.Info;
            tipMidRange.ToolTipTitle = "Mid-Range Button";
            tipMidRange.SetToolTip(this.btnMidRange, "Press to calculate the Mid-Range of the current list");
        }

        private void btnMode_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipMode = new ToolTip();

            tipMode.Active = true;
            tipMode.InitialDelay = 400;
            tipMode.IsBalloon = true;
            tipMode.ToolTipIcon = ToolTipIcon.Info;
            tipMode.ToolTipTitle = "Mode Button";
            tipMode.SetToolTip(this.btnMode, "Press to calculate the Mode of the current list");
        }

        private void btnAverage_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipAverage = new ToolTip();

            tipAverage.Active = true;
            tipAverage.InitialDelay = 400;
            tipAverage.IsBalloon = true;
            tipAverage.ToolTipIcon = ToolTipIcon.Info;
            tipAverage.ToolTipTitle = "Average Button";
            tipAverage.SetToolTip(this.btnAverage, "Press to calculate the Average of the current list");
        }

        private void btnRange_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipRange = new ToolTip();

            tipRange.Active = true;
            tipRange.InitialDelay = 400;
            tipRange.IsBalloon = true;
            tipRange.ToolTipIcon = ToolTipIcon.Info;
            tipRange.ToolTipTitle = "Range Button";
            tipRange.SetToolTip(this.btnRange, "Press to calculate the Range of the current list");
        }

        private void txtInput_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipInput = new ToolTip();

            tipInput.Active = true;
            tipInput.InitialDelay = 400;
            tipInput.IsBalloon = true;
            tipInput.ToolTipIcon = ToolTipIcon.Info;
            tipInput.ToolTipTitle = "Number Input";
            tipInput.SetToolTip(this.txtInput, "Enter a number to search for");
        }

        private void lstArrayDisplay_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipDisplay = new ToolTip();

            tipDisplay.Active = true;
            tipDisplay.InitialDelay = 400;
            tipDisplay.IsBalloon = true;
            tipDisplay.ToolTipIcon = ToolTipIcon.Info;
            tipDisplay.ToolTipTitle = "Display";
            tipDisplay.SetToolTip(this.lstArrayDisplay, "This is the current list");
        }

        #endregion  
        // Region of tooltips
    }
}
