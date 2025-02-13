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
                Console.Write("Enter First Name: ");
                first_n = Console.ReadLine();
                Console.Write("Enter Middle Name (Press Enter to skip): ");
                mid_n = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                last_n = Console.ReadLine();
                Console.Write("Enter Salary: ");
                try
                {
                    salary = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please enter a valid non-string value.\n\n");
                    continue;
                }
                // Create the employee with newly given inputs and display the information allowed
                Employee newEmployee = new Employee(employId, first_n, last_n, salary, mid_n);
                Console.WriteLine("\nEmployee Created Successfully!");
                newEmployee.DisplayEmployeeInfo();

                // Will now go through the process of going through the different departments
                Department HR = new HRDepartment();
                Department IT = new ITDepartment();

                HR.DisplayDepartmentInfo();
                Console.WriteLine($"Details: {HR.GetDepartmentDetails}");
                ((IDepartmentOperations)HR).Operate();



            }
            //newEmployee.DisplayEmployeeInfo();
        }
    }
}
