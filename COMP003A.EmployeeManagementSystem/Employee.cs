using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    internal class Employee
    {
        // Fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        public string EmployeeId
        {
            get { return _employeeId; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Cannot contain Null or Whitespace");
                }
                _firstName = value;
            }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Cannot be null.");
                }
                _middleName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Cannot contain Null or Whitespace");
                }
                _lastName = value;
            }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be less than 0");
                }
                _salary = value;
            }
        }

        public Employee (string employeeId, string firstName, string lastName, double salary, string middleName = "")
        {
            _employeeId = employeeId;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _salary = salary;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Name: {_firstName} {_middleName} {_lastName}");
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {_employeeId}");
            PrintFullName();
            Console.WriteLine($"Salary: {_salary:C}");
        }
    }
}
