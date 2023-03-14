using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class Shift
    {
        // Proprietăți
        public DateTime ShiftDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Employee ShiftEmployee { get; set; }

        // Constructor
        public Shift(DateTime shiftDate, TimeSpan startTime, TimeSpan endTime, Employee shiftEmployee)
        {
            ShiftDate = shiftDate;
            StartTime = startTime;
            EndTime = endTime;
            ShiftEmployee = shiftEmployee;
        }

        // Metodă de afișare a informațiilor despre tură
        public void DisplayShiftInfo()
        {
            Console.WriteLine("Data: {0}", ShiftDate.ToShortDateString());
            Console.WriteLine("Ora de început: {0}", StartTime);
            Console.WriteLine("Ora de sfârșit: {0}", EndTime);
            Console.WriteLine("Angajat: {0} {1}", ShiftEmployee.FirstName, ShiftEmployee.LastName);
        }
    }
}
