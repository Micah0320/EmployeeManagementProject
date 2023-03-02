//Micah Arndt
//CISS 201
//Final Project
//2-23-23

//Add employee forn

using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox14
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        //Handles when the close button is clicked
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }

        //Handles when the clear button is clicked
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear text from all text boxes.
            eidTextBox.Clear();
            nameTextBox.Clear();
            payTextBox.Clear();
            //Focus on the employee id text box
            eidTextBox.Focus();
        }

        //Handles when the save button is clicked
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Create a stream writer to append text to employees file
            StreamWriter sw = File.AppendText("employees.txt");

            //if all information contains text
            if (!(string.IsNullOrWhiteSpace(eidTextBox.Text)
                || string.IsNullOrWhiteSpace(nameTextBox.Text)
                || string.IsNullOrWhiteSpace(payTextBox.Text)))
            {
                //If we can parse a double from the pay rate box
                if (Double.TryParse(payTextBox.Text, out double rate))
                {
                    //Create a temp employee
                    Employee temp = new Employee(eidTextBox.Text, nameTextBox.Text, rate);
                    //Write to employees file
                    sw.WriteLine(temp);
                    //Save Changes
                    sw.Flush();
                    //Click the clear button
                    clearButton.PerformClick();
                }
                //When you cant parse doubles
                else
                {
                    //Display an error message
                    MessageBox.Show("Pay must be a Decimal.");
                }
            }
            //If a field is empty or contains whitespace
            else
            {
                //Display error message
                MessageBox.Show("All Fields Required.");
            }
            //Close the stream writer
            sw.Close();
        }
    }
}
