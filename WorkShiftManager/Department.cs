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
        public string DisplayDepartmentInfo()
        {
            string Buff = $"Departament: {Name}\nProgramul de lucru al departamentului: {Schedule.DisplaySchedule()}\nAngajati:";
            foreach (Employee employee in Employees)
            {
                Buff += employee.DisplayEmployeeInfo();
            }
            return Buff;
        }
    }
}
