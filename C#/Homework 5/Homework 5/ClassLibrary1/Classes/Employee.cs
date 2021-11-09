using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary  { get; set; }
        public RoleEnum Role { get; set; }
        public string LastName1 { get; }

        public string PrintInfo()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
