﻿using System;
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

        /// Properties
        /// <summary>
        /// Gets the Employee ID
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
        }
        /// <summary>
        /// Gets the Employees First Name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be empty or whitespace.");
                }
                _firstName = value;
            }
        }
        /// <summary>
        /// Gets the Employees Middle Name if needed
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value != null)
                {
                    _middleName = value ?? string.Empty;
                }
            }
        }
        /// <summary>
        /// Gets the Employees Last Name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be empty or whitespace.");
                }
                _lastName = value;
            }
        }
        /// <summary>
        /// Gets the Employee salary, if it is greater than 0
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Salary must be a positive value.");
                }
                _salary = value;

            }
        }

        /// <summary>
        /// Initilizes a new instance of an Employee with their ID, full name, and salary.
        /// </summary>
        public Employee (string employeeId, string firstName, string lastName, double salary, string middleName = "")
        {
            _employeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;
        }

        /// <summary>
        /// Will write the employee's full name in the console
        /// </summary>
        public void PrintFullName()
        {
            if (string.IsNullOrWhiteSpace(_middleName))
            {
                Console.WriteLine($"Name: {_firstName} {_lastName}");
            }
            else
            {
                Console.WriteLine($"Name: {_firstName} {_middleName} {_lastName}");
            }
        }

        /// <summary>
        /// Display's the employee's ID, full name using the PrintFullName() method, and their salary
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {_employeeId}");
            PrintFullName();
            Console.WriteLine($"Salary: {_salary:C}");
        }
    }
}
