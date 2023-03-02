//Micah Arndt
//CISS 201
//Final Project
//2-23-23

//Display Form Class
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
    public partial class DisplayAllForm : Form
    {
        public DisplayAllForm()
        {
            InitializeComponent();
        }

        //Handles when the close button is clicked
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }

        //Handles the initial load
        private void DisplayAllForm_Load(object sender, EventArgs e)
        {
            //If employees.txt exists
            if (File.Exists("employees.txt"))
            {
                //Create a stream reader
                StreamReader sr = new StreamReader("employees.txt");
                string eid;
                //While an eid is available, read the next 4 lines
                while ((eid = sr.ReadLine()) != null)
                {
                    //Get the name
                    string name = sr.ReadLine();
                    //Get pay rate
                    double payRate = Double.Parse(sr.ReadLine());
                    //Get hours worked
                    double hours = Double.Parse(sr.ReadLine());
                    //Create an employee object
                    Employee employee = new Employee(eid, name, payRate, hours);
                    //Add the object to the list box
                    employeeListBox.Items.Add($"Employee ID: {employee.EmployeeID}    Name: {employee.Name}    Pay Rate: {employee.PayRate}    Total Paid: ${employee.PayAmount()}\n");
                }
                //sr.Close();
            }
            //If we are missing the employees file
            else
            {
                //Display an error message
                MessageBox.Show("Missing employees.txt");
            }
        }

        //Handles Printing
        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Print the document
            printDocument1.Print();
        }

        //Sets up the document to be printed
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Employee Payroll Report",
                                    new Font("Courier New", 24, FontStyle.Bold),
                                    Brushes.Black, 300, 100);
            e.Graphics.DrawString(DateTime.Now.ToString(),
                                    new Font("Courier New", 12, FontStyle.Italic),
                                    Brushes.Black, 320, 150);

            int x = 100, y = 200;
            foreach (var row in employeeListBox.Items)
            {
                e.Graphics.DrawString(row.ToString(),
                                        new Font("Courier New", 12, FontStyle.Regular),
                                        Brushes.Black, x, y);
                y += 16;
            }
        }
    }
}
