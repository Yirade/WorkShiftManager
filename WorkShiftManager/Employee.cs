using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class Employee
    {
        // Proprietati
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        // Constructor
        public Employee(string firstName, string lastName, int employeeID, decimal salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeID = employeeID;
            Salary = salary;
            Department = department;
        }

        // Metoda de afisare a informatiilor despre angajat
        public string DisplayEmployeeInfo()
        {
            return $"Nume: {FirstName} {LastName}\nID angajat: {EmployeeID}\nSalariu: {Salary}\nDepartament: {Department}";
            
            //Console.WriteLine("Nume: {0} {1}", FirstName, LastName);
            //Console.WriteLine("ID angajat: {0}", EmployeeID);
            //Console.WriteLine("Salariu: {0}", Salary);
            //Console.WriteLine("Departament: {0}", Department);
        }
    }
}
