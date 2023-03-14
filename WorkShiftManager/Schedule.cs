using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class Schedule
    {
        // Proprietăți
        public List<Shift> Shifts { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Constructor
        public Schedule(DateTime startDate, DateTime endDate)
        {
            Shifts = new List<Shift>();
            StartDate = startDate;
            EndDate = endDate;
        }

        // Metodă de adăugare a unei ture la programul de lucru
        public void AddShift(Shift shift)
        {
            Shifts.Add(shift);
        }

        // Metodă de afișare a informațiilor despre programul de lucru
        public void DisplaySchedule()
        {
            Console.WriteLine("Programul de lucru:");
            Console.WriteLine("Data de început: {0}", StartDate.ToShortDateString());
            Console.WriteLine("Data de sfârșit: {0}", EndDate.ToShortDateString());
            Console.WriteLine();
            foreach (Shift shift in Shifts)
            {
                shift.DisplayShiftInfo();
                Console.WriteLine();
            }
        }
    }
}
