//Micah Arndt
//CISS 201
//Final Project
//2-23-23

//Main Form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Handles the exit button clicks
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }
        //Handles an add employee button click
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            //Initializes and shows an add employee form
            AddEmployeeForm addForm = new AddEmployeeForm();
            addForm.ShowDialog();
        }

        //handles display button click
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //initialize and show a display all form
            DisplayAllForm displayForm = new DisplayAllForm();
            displayForm.ShowDialog();
        }

        //Handles add hours button click
        private void AddHoursButton_Click(object sender, EventArgs e)
        {
            //Initialize and show an add hours form
            AddHoursForm addHoursForm = new AddHoursForm();
            addHoursForm.ShowDialog();
        }
    }
}
