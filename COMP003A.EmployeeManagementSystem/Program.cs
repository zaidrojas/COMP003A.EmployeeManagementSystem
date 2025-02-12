// Author: [Zaid Rojas]
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee("8347261", "Zaid", "Rojas",500.00, "Nemesis");
            newEmployee.DisplayEmployeeInfo();
        }
    }
}
