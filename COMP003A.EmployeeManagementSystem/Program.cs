// Author: [Zaid Rojas]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

using System.Drawing;
using System.Transactions;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string employId;
                string first_n;
                string mid_n;
                string last_n;
                double salary;

                // Will now recieve values for all the variables regarding the employee
                Console.Write("Enter Employee ID: ");
                employId = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(employId))
                {
                    Console.WriteLine("No nulls or white space.\n");
                    continue;
                }

                Console.Write("Enter First Name: ");
                first_n = Console.ReadLine();
                try
                {
                    if (string.IsNullOrWhiteSpace(first_n))
                    { throw new ArgumentException("First names cannot be empty.\n"); }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    continue;
                }

                Console.Write("Enter Middle Name (Press Enter to skip): ");
                mid_n = Console.ReadLine();
                //if (mid_n == null) { mid_n = ""; }

                Console.Write("Enter Last Name: ");
                last_n = Console.ReadLine();
                try
                {
                    if (string.IsNullOrWhiteSpace(last_n))
                    { throw new ArgumentException("Last names cannot be empty.\n"); }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    continue;
                }

                Console.Write("Enter Salary: ");
                try
                {
                    if (!double.TryParse(Console.ReadLine(), out salary) || salary <= 0)
                    {
                        throw new ArgumentException("Salary must be a positive number.\n");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    continue;
                }

                // Create the employee with newly given inputs and display the information allowed
                Employee newEmployee = new Employee(employId, first_n, last_n, salary, mid_n);
                Console.WriteLine("\nEmployee Created Successfully!");
                newEmployee.DisplayEmployeeInfo();

                // Will now go through the process of going through the different departments
                Department HR = new HRDepartment();
                Department IT = new ITDepartment();

                Console.WriteLine("");
                HR.DisplayDepartmentInfo();
                Console.WriteLine($"Details: {HR.GetDepartmentDetails()}");
                ((IDepartmentOperations)HR).Operate();
                Console.WriteLine("");

                Console.WriteLine("");
                IT.DisplayDepartmentInfo();
                Console.WriteLine($"Details: {IT.GetDepartmentDetails()}");
                ((IDepartmentOperations)IT).Operate();
                Console.WriteLine("");

            }
        }
    }
}
