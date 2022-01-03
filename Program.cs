using System;
using System.Collections.Generic;

// this sets the namespace to CatWorx.BadgeMaker
namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will store the resposnse from the user as list of Employee class objects
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }
        // This is the method that will get the employees data from the user
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter a name: ");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }
                Console.WriteLine("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Photo URL: ");
                string photoURL = Console.ReadLine();

                Employee currentEmployee = new Employee(firstName, lastName, id, photoURL);
                employees.Add(currentEmployee);
            }
            return employees;
        }
        
    }
}