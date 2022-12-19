using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Department
    {
        string name;
        List<Employee> employees;
        Employee headDepartment;

        // department members 
        int nMaxEmployees;
        int nEmployees = 0;

        public Department(string name, int nMaxEmployees, Employee headDepartment)
        {
            this.name = name;

            // creating array to manage employee association (1-n)
            employees = new List<Employee>();
            this.nMaxEmployees = nMaxEmployees;
            nEmployees++;
            this.headDepartment = headDepartment;
        }

        /// <summary>
        /// Adding an employee to a department
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>false with an error</returns>
        public bool AddEmployee(Employee employee) 
        {
            if (nEmployees < nMaxEmployees) 
            { 
                employees.Add(employee);
                nEmployees++;
            }
            else
                return false;

            return true;
        }

        /// <summary>
        /// Get a list of employees of the department
        /// </summary>
        /// <returns></returns>
        public string GetEmployees()
        {
            string res = "";

            foreach (Employee employee in employees)
            {
                if (res.Length > 0) res += ",";

                res += $"{employee.Description()}";
            }
            return res;
        }

        public string Name { get { return name; } }

        public Employee HeadDepartment { get { return headDepartment; } }   
    }
}
