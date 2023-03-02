//Micah Arndt
//CISS 201
//Final Project
//2-23-23

//The Add Hours Form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox14
{
    public partial class AddHoursForm : Form
    {
        //List for all employees, creates an empty list upon creation
        private List<Employee> allEmployees = new List<Employee>();
        //Variable for keeping track of what employee we are entering hours for.
        private int currentEmp = 0;
        public AddHoursForm()
        {
            InitializeComponent();
        }

        //Handles what happens when the clear button is clicked.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear the hours text box. Don't want to lose eid or employee name
            hoursTextBox.Clear();
            //Select the hours box as the input
            hoursTextBox.Focus();
        }


        //Method does not do anything, was an accidental add.
        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        //Upon loading the form itself
        private void AddHoursForm_Load(object sender, EventArgs e)
        {
            this.currentEmp = 0;
            //Need to load every Employee into a List
            if (File.Exists("employees.txt"))
            {
                StreamReader sr = new StreamReader("employees.txt");
                string eid;
                //While there is an eid present, read the next 3 lines as well
                while ((eid = sr.ReadLine()) != null)
                {
                    //Get employee name
                    string name = sr.ReadLine();
                    //Get employee pay rate
                    double payRate = Double.Parse(sr.ReadLine());
                    //Get hours worked. Is discarded.
                    //Just need to get it as it is in the document.
                    double hoursWorked = Double.Parse(sr.ReadLine());
                    //Create a new employee and add it to our list
                    Employee employee = new Employee(eid, name, payRate);
                    allEmployees.Add(employee);
                }
                //Close our reader
                sr.Close();
                //Make the text boxes contain information regarding our first employee
                eidTextBox.Text = allEmployees[0].EmployeeID;
                nameTextBox.Text = allEmployees[0].Name;
            }
            //Error message if we are missing employees.txt
            else
            {
                MessageBox.Show("Missing employees.txt");
            }

            
        }

        //Handle what happens if we click next
        private void NextButton_Click(object sender, EventArgs e)
        {
            //As long as the hours text box has test in it
            if (!(String.IsNullOrWhiteSpace(hoursTextBox.Text)))
            {
                //Check to see if we can parse a double from the hours worked.
                if (Double.TryParse(hoursTextBox.Text, out double hours))
                {
                    //Set the hours worked for the current employee to hours
                    allEmployees[this.currentEmp].HoursWorked = hours;
                    //move to the next employee
                    currentEmp++;
                    //If there are no employees left
                    if (currentEmp >= allEmployees.Count)
                    {
                        //enable the save button
                        saveButton.Enabled = true;
                        //Disable the next button
                        nextButton.Enabled = false;
                        //Disable the text box field
                        hoursTextBox.Enabled = false;
                        //Show a message that there are no more employees
                        MessageBox.Show("No more employees.");
                        //Clear all text fields
                        eidTextBox.Clear();
                        nameTextBox.Clear();
                        hoursTextBox.Clear();
                    }
                    //If there are still employees
                    else
                    {
                        //Set the text boxes to contain information regarding the next employee
                        eidTextBox.Text = allEmployees[currentEmp].EmployeeID;
                        nameTextBox.Text = allEmployees[currentEmp].Name;
                        //Clear the hour text box
                        hoursTextBox.Clear();
                        //Have the hour text box as the active input box
                        hoursTextBox.Focus();
                    }
                }
                //If a double can't be parsed from hours text box
                else
                {
                    //Display an error message
                    MessageBox.Show("Hours must be a decimal value");
                }
            }
            //If we are missing employees.txt
            else
            {
                MessageBox.Show("Missing employees.txt");
            }
        }

        //Handles the saving of employee info
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Erase all previous data on employees.txt
            File.WriteAllText("employees.txt", "");
            //Now we add a stream writer to append text to employees file
            StreamWriter sr = File.AppendText("employees.txt");

            //For each employee, append info to file
            foreach (Employee employee in allEmployees)
            {
                sr.WriteLine(employee);
                //Save changes
                sr.Flush();

            }
            //Close our reader
            sr.Close();
            //Close the form
            Close();
        }
    }
}
