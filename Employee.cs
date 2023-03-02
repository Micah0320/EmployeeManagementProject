//Micah Arndt
//CISS 201
//Final Project
//2-23-23

//Employee Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox14
{
    class Employee
    {
        //Fields for the employees
        private string name;
        //employee id
        private string eid;
        //Hours Worked not set in constructor
        private double hoursWorked;
        private double payRate;

        //Create Constructor
        public Employee(string id, string name, double payRate, double hours = 0)
        {
            this.name = name;
            this.eid = id;
            this.payRate = payRate;
            //Set hours worked to 0. Updated later.
            this.hoursWorked = hours;
        }

        //Getter and Setter methods.
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        public string EmployeeID
        {
            get { return this.eid; }
            set { this.eid = value; }

        }

        public double PayRate
        {
            get { return this.payRate; }
            set { this.payRate = value; }

        }
        public double HoursWorked
        {
            get { return this.hoursWorked; }
            set { this.hoursWorked = value; }
        }
        //Get the amount paid to the employee
        public double PayAmount()
        { return this.hoursWorked * this.payRate; }

        //Overwritten toString method
        public override string ToString()
        {
            return $"{this.EmployeeID}\n{this.Name}\n{this.PayRate.ToString()}\n{HoursWorked}";
        }
    }
}
