using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP003A.EmployeeManagementSystem
{

    /// <summary>
    /// Defines constract for departments to explain their duties
    /// </summary>
    interface IDepartmentOperations
    {
        /// <summary>
        /// Display's the department's duties
        /// </summary>
        void Operate();
    }


    /// <summary>
    /// Represents the IT Department derived from Department and IDepartmentOperations
    /// </summary>
    class ITDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// Explaining the duty of the IT's department
        /// </summary>
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure.";
        }

        /// <summary>
        /// Lets user know that the IT department is performing their operations on the employee
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing IT operations...");
        }

        /// <summary>
        /// Constructor for Department, saying IT's name
        /// </summary>
        public ITDepartment()
        {
            DepartmentName = "IT";
        }

    }

    /// <summary>
    /// Represents the HR Department derived from Department and IDepartmentOperations
    /// </summary>
    class HRDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// Explaining the duty of the HR department
        /// </summary>
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }

        /// <summary>
        /// Lets user know that the HR department is performing their operations on the employee
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing HR operations...");
        }

        /// <summary>
        /// Constructor for Department, specifying HR's name
        /// </summary>
        public HRDepartment()
        {
            DepartmentName = "Human Resources";
        }
    }

    /// <summary>
    /// Representing the general branches of the company's departments
    /// </summary>

    abstract class Department
    {
        // Auto-implemented property
        public string DepartmentName { get; set; }

        /// <summary>
        /// Abstract method that will give details to the department's functions
        /// </summary>
        public abstract string GetDepartmentDetails();

        /// <summary>
        /// Has the deprartment name displayed in full
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }


    }
}
