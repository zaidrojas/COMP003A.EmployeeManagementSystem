using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP003A.EmployeeManagementSystem
{

    interface IDepartmentOperations
    {
        void Operate();
    }


    class ITDepartment: Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure.";
        }

        public void Operate()
        {
            Console.WriteLine("Performing IT operations...");
        }

        public ITDepartment()
        {
            Name = "IT";
        }

    }

    class HRDepartment: Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }

        public void Operate()
        {
            Console.WriteLine("Performing HR operations...");
        }

        public HRDepartment()
        {
            Name = "HR";
        }
    }

    abstract class Department
    {
        // Fields
        public string DepartmentName { get; set; }

        public abstract string GetDepartmentDetails();

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {Name}");
        }


    }
}
