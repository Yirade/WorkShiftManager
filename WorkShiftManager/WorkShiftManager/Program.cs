using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WorkShiftManager
{
    public class Program
    {
        // Alte metode existente

        // Funcție de căutare a unui angajat după nume
        public static Employee FindEmployeeByName(List<Employee> employees, string firstName, string lastName)
        {
            foreach (Employee employee in employees)
            {
                if (employee.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && employee.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return employee;
                }
            }
            return null; // Returnăm null dacă angajatul nu este găsit
        }

        // Funcție de căutare a unui departament după nume
        public static Department FindDepartmentByName(List<Department> departments, string departmentName)
        {
            foreach (Department department in departments)
            {
                if (department.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase))
                {
                    return department;
                }
            }
            return null; // Returnăm null dacă departamentul nu este găsit
        }

        public static List<Employee> SearchEmployees(List<Department> departments, string searchCriteria)
        {
            List<Employee> searchResults = new List<Employee>();

            foreach (Department department in departments)
            {
                foreach (Employee employee in department.Employees)
                {
                    if (employee.FirstName.Contains(searchCriteria) ||
                        employee.LastName.Contains(searchCriteria) ||
                        employee.EmployeeID.ToString().Contains(searchCriteria) ||
                        employee.Department.Contains(searchCriteria))
                    {
                        searchResults.Add(employee);
                    }
                }
            }

            return searchResults;
        }

        public static List<Department> SearchDepartments(List<Department> departments, string searchCriteria)
        {
            List<Department> searchResults = new List<Department>();

            foreach (Department department in departments)
            {
                if (department.Name.Contains(searchCriteria))
                {
                    searchResults.Add(department);
                }
            }

            return searchResults;
        }

        static void Main(string[] args)
        {
            Application.Run(new Form1());
        }
    }
}
