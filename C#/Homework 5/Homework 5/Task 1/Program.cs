using ClassLibrary1.Classes;
using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager[] managers = new Manager[]
            {
                new Manager("Viktor", "Stojkov"),
                new Manager("Tamara", "Maksimovska")
            };

            Contractor[] contractors = new Contractor[]
            {
                new Contractor("Marija", "Mladenovska", 8, 50, managers[0]),
                new Contractor("Danilo", "Borozan", 10, 30, managers[1]),
            };

            SalesPerson[] salesPerson = new SalesPerson[]
            {
                new SalesPerson("Mila", "Velkovska")
            };

            Employee[] company = new Employee[]
            {
                managers[0],
                managers[1],
                contractors[0],
                contractors[1],
                salesPerson[0]
            };

            CEO firstCEO = new CEO("Elena", "Ivanovska", 20, company);

            Console.WriteLine("CEO:");
            Console.WriteLine(firstCEO.PrintInfo());
            Console.WriteLine($"Salary of CEO is: {firstCEO.GetSalary()}");
            Console.WriteLine("Employees: ");
            firstCEO.PrintEmployees(company);


            Console.ReadLine();
        }
    }
}
