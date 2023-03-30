using System;

namespace WorkShiftManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Cream un program de lucru cu cateva zile de lucru
            Schedule schedule = new Schedule("Program normal de lucru");
            schedule.AddWorkday("Luni", new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0));
            schedule.AddWorkday("Marti", new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0));
            schedule.AddWorkday("Miercuri", new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0));
            schedule.AddWorkday("Joi", new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0));
            schedule.AddWorkday("Vineri", new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0));

            // Cream un departament si adaugam cativa angajati
            Department department = new Department("Vanzari", schedule);
            department.AddEmployee(new Employee("Ion", "Popescu", 1001, 3000, "Vanzari"));
            department.AddEmployee(new Employee("Maria", "Ionescu", 1002, 3500, "Vanzari"));
            department.AddEmployee(new Employee("Andrei", "Popa", 1003, 3200, "Vanzari"));

            Console.WriteLine("Prenume: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Nume: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Salariu: ");
            string what_we_want = Console.ReadLine();
            Console.WriteLine("Departament: ");
            string dep = Console.ReadLine();

            department.AddEmployee(new Employee(firstName, lastName, Convert.ToInt32(id), Convert.ToInt32(what_we_want), dep));


            // Afisam informatiile despre departament
            Console.WriteLine(department.DisplayDepartmentInfo());

            // Programul a fost finalizat, asteptam ca utilizatorul sa apese o tasta
            Console.ReadKey();
        }
    }
}