using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }
        public double AddBonus(double bonus)
        {
            return _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }

        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 2000;
            Role = RoleEnum.Manager;
        }
    }
}
