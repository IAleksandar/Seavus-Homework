using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public double AddSharesPrice(double number)
        {
            return _sharesPrice = number;
        }

        public void PrintEmployees(Employee[] employees)
        {
            foreach(Employee person in employees)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }

        public override double GetSalary()
        {
            double SharesPrice = AddSharesPrice(50);
            return Salary + Shares * SharesPrice;
        }

        public CEO(string firstName, string lastName, int shares, Employee[] employeesArray) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Shares = shares;
            Employees = employeesArray;
            Salary = 1000;
            Role = RoleEnum.CEO;
            _sharesPrice = 200;
        }

    }
}
