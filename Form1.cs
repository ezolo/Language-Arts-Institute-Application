//Programmer: Eva Zolotarev
//Project: Zolotarev_2
//Due Date: 3/11/2020
//Description: Assignment #2- Orders are taken from students who want to learn a language at the LAI.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zolotarev_2
{
    public partial class Form1 : Form
    {
        //Declare class-level constants for later use in the programs
        private const decimal IN_STATE_COST = 49m;
        private const decimal OUT_OF_STATE_COST = 99m;
        private int checkCounter;
        decimal totalPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //*** The following 7 comments stay true for each checkBox event (I.e: germanCheckBox, italianCheckBox, russianCheckBox, spanishCheckBox)
            //(1) Increases check counter to count amount of checked boxes
            //(2) These checks are then recorded in totalCoursesOutput for user to see
            if (frenchCheckBox.Checked)
                {
                    ++checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                //(3a) If statement shows that if In-State or Out-of-State, different price applies
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                //(3b) If statement shows that if In-State or Out-of-State, different price applies
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }
            //(4) Decreases check counter to count amount of checked boxes
                else
                {
                    --checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                //(5a) If statement shows that if In-State or Out-of-State, different price applies
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                //(5b) If statement shows that if In-State or Out-of-State, different price applies
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }
            //(6) This large if statement, with several smaller if statements inside, prevents a user to check more than three courses (grays them out)
            if (checkCounter >= 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = false;
                }
               if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = false;
                }
               if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = false;
                }
               if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = false;
                }
               if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = false;
                }
            }
            //(7) On the flip side, this if statement allows user to continue to select more check boxes as long as the user has selected so far less than 3
            if (checkCounter < 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = true;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = true;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = true;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = true;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = true;
                }
            }

        }

        private void italianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (italianCheckBox.Checked)
            {
                ++checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }
            else
            {
                --checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }

            if (checkCounter >= 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = false;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = false;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = false;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = false;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = false;
                }
            }
            if (checkCounter < 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = true;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = true;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = true;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = true;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = true;
                }
            }
        }

        private void russianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (russianCheckBox.Checked)
            {
                ++checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }
            else
            {
                --checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }

            if (checkCounter >= 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = false;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = false;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = false;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = false;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = false;
                }
            }
            if (checkCounter < 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = true;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = true;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = true;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = true;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = true;
                }
            }
        }

        private void spanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (spanishCheckBox.Checked)
            {
                ++checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }
            else
            {
                --checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }

            if (checkCounter >= 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = false;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = false;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = false;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = false;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = false;
                }
            }
            if (checkCounter < 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = true;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = true;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = true;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = true;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = true;
                }
            }
        }

        private void germanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (germanCheckBox.Checked)
            {
                ++checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }

            }
            else
            {
                --checkCounter;
                totalCoursesOutput.Text = checkCounter.ToString();
                if (inStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * IN_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
                if (outStateRadioButton.Checked)
                {
                    totalPrice = checkCounter * OUT_OF_STATE_COST;
                    costLabel.Text = totalPrice.ToString("c");
                }
            }

            if (checkCounter >= 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = false;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = false;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = false;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = false;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = false;
                }
            }
            if (checkCounter < 3)
            {
                if (!frenchCheckBox.Checked)
                {
                    frenchCheckBox.Enabled = true;
                }
                if (!italianCheckBox.Checked)
                {
                    italianCheckBox.Enabled = true;
                }
                if (!russianCheckBox.Checked)
                {
                    russianCheckBox.Enabled = true;
                }
                if (!germanCheckBox.Checked)
                {
                    germanCheckBox.Enabled = true;
                }
                if (!spanishCheckBox.Checked)
                {
                    spanishCheckBox.Enabled = true;
                }
            }
        }

        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //(8) The following if statement shows that if the inStateRadioButton is chosen, the In-State tuition for each course will appear
            if (inStateRadioButton.Checked)
            {
                germanPrice.Text = IN_STATE_COST.ToString("c");
                spanishPrice.Text = IN_STATE_COST.ToString("c");
                italianPrice.Text = IN_STATE_COST.ToString("c");
                russianPrice.Text = IN_STATE_COST.ToString("c");
                frenchPrice.Text = IN_STATE_COST.ToString("c");
            }

        }

        private void outStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //(9) The following if statement shows that if the outStateRadioButton is chosen, the Out-of-State tuition for each course will appear
            if (outStateRadioButton.Checked)
            {
                germanPrice.Text = OUT_OF_STATE_COST.ToString("c");
                spanishPrice.Text = OUT_OF_STATE_COST.ToString("c");
                italianPrice.Text = OUT_OF_STATE_COST.ToString("c");
                russianPrice.Text = OUT_OF_STATE_COST.ToString("c");
                frenchPrice.Text = OUT_OF_STATE_COST.ToString("c");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //(10) The first if statement shows that if no course is chosen, a message box appear to tell the user to select more courses
            totalCoursesOutput.Text = checkCounter.ToString();
            if (checkCounter < 1)
            {
                MessageBox.Show("Please choose at least one, but no more than three, course(s)", "Well this is embarassing...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //(11) The if statements in the else relate to what message will be displayed if certain radiobuttons will be selected
            else
            {
                if (fallRadioButton.Checked && inStateRadioButton.Checked && mastercardRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + fallRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + inStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + mastercardRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (fallRadioButton.Checked && outStateRadioButton.Checked && mastercardRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + fallRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + outStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + mastercardRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (fallRadioButton.Checked && inStateRadioButton.Checked && visaRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + fallRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + inStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + visaRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (fallRadioButton.Checked && outStateRadioButton.Checked && visaRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + fallRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + outStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + visaRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (springRadioButton.Checked && inStateRadioButton.Checked && mastercardRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + springRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + inStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + mastercardRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (springRadioButton.Checked && inStateRadioButton.Checked && visaRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + springRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + inStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + visaRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (springRadioButton.Checked && outStateRadioButton.Checked && mastercardRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + springRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + outStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + mastercardRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (springRadioButton.Checked && outStateRadioButton.Checked && visaRadioButton.Checked)
                {
                    MessageBox.Show(("Registration Term: " + springRadioButton.Text + " " + yearComboBox.Text + System.Environment.NewLine + "Student ID: " + idTextBox.Text + System.Environment.NewLine + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + System.Environment.NewLine + "Email Address: " + emailTextBox.Text + System.Environment.NewLine + "Residence Status: " + outStateRadioButton.Text + System.Environment.NewLine + "Total Courses Purchased: " + totalCoursesOutput.Text + System.Environment.NewLine + "Price Per Course: " + germanPrice.Text + System.Environment.NewLine + "Total Order Price: " + costLabel.Text + System.Environment.NewLine + "Credit Card Type: " + visaRadioButton.Text + System.Environment.NewLine + "Card Number: " + cardNumberTextBox.Text + System.Environment.NewLine + "Card Expiration Date: " + expirationTextBox.Text), "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //(12)The following button clears the contents inputted by the user
        private void clearButton_Click(object sender, EventArgs e)
        {
            springRadioButton.Checked = false;
            yearComboBox.Text = "";
            idTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            outStateRadioButton.Checked = false;
            germanCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            frenchCheckBox.Checked = false;
            germanPrice.Text = "";
            italianPrice.Text = "";
            frenchPrice.Text = "";
            spanishPrice.Text = "";
            russianPrice.Text = "";
            visaRadioButton.Checked = false;
            cardNumberTextBox.Text = "";
            expirationTextBox.Text = "";

        //(13) The following, after clearing, brings focus to the first data entry/selection: the fall or spring term
            fallRadioButton.Focus();
        }

        //(14) The following is the exit button. It displays a message whether the user wants to exit the program and if "yes" is selected, the user will exit successfully. If "no" is selected, the user will remain on the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
