using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue { get; set; }
        public void AddSuccessRevenue(int revenue)
        {
            _successSaleRevenue = revenue;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                return Salary += 500;
            }
            else if(_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
            {
                return Salary += 1000;
            }
            else if(_successSaleRevenue > 5000)
            {
                return Salary += 1500;
            }
            else
            {
                return Salary;
            }
        }

        public SalesPerson(string firstName, string lastName) : base (firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            Role = RoleEnum.Sales;
        }
    }
}
