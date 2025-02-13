// Author: [Zaid Rojas]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

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

                Console.Write("Enter Employee ID: ");
                employId = Console.ReadLine();
                Console.Write("Enter First Name: ");
                first_n = Console.ReadLine();
                Console.Write("Enter Middle Name: ");
                mid_n = Console.ReadLine();

            }
            //Employee newEmployee = new Employee("8347261", "Zaid", "Rojas",500.00, "Nemesis");
            //newEmployee.DisplayEmployeeInfo();
        }
    }
}
