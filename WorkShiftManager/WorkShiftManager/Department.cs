using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class Department
    {
        // Proprietati
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public Schedule Schedule { get; set; }

        private int employeeCount = 0;
        public int EmployeeCount { get { return employeeCount; } }

        private static List<Department> departments = new List<Department>();

        private List<Employee> employees = new List<Employee>();

        // Constructor
        public Department(string name, Schedule schedule)
        {
            Name = name;
            Employees = new List<Employee>();
            this.Schedule = schedule;
        }

        // Metoda de adaugare a unui angajat la departament
        public void AddEmployee(string firstName, string lastName, decimal salary, string employeeID)
        {
            employeeCount++;
            Employee employee = new Employee(firstName, lastName, employeeID, salary, this.Name);
            Employees.Add(employee);
        }

        // Metoda de afisare a informatiilor despre departament
        public string DisplayDepartmentInfo()
        {
            string Buff = $"Departament: {Name}\n\nProgramul de lucru al departamentului: {Schedule.DisplaySchedule()}\n\nAngajati:\n";
            foreach (Employee employee in Employees)
            {
                Buff += employee.DisplayEmployeeInfo();
            }
            return Buff;
        }

        public static Department FindDepartmentByName(string departmentName)
        {
            return departments.FirstOrDefault(d => d.Name == departmentName);
        }

        public Employee FindEmployeeByID(string employeeID)
        {
            return employees.FirstOrDefault(e => e.EmployeeID == employeeID);
        }

        public int GetLastEmployeeID()
        {
            if (Employees.Count > 0)
            {
                int employeeID = int.Parse("EMP" + employeeCount.ToString());
                return employeeID;
            }
            else
            {
                return 0;
            }
        }


    }
}
