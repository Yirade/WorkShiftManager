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

        // Constructor
        public Department(string name, Schedule schedule)
        {
            Name = name;
            Employees = new List<Employee>();
            Schedule = schedule;
        }

        // Metoda de adaugare a unui angajat la departament
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        // Metoda de afisare a informatiilor despre departament
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("Departament: {0}", Name);
            Console.WriteLine();
            Console.WriteLine("Programul de lucru al departamentului:");
            Schedule.DisplaySchedule();
            Console.WriteLine();
            Console.WriteLine("Angajati:");
            foreach (Employee employee in Employees)
            {
                employee.DisplayEmployeeInfo();
            }
        }
    }
}
