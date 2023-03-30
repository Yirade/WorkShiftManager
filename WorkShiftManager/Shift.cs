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

        // Metoda de afisare a informatiilor despre tura
        public string DisplayShiftInfo()
        {
            return $"Data: {ShiftDate.ToShortDateString()}\nOra de inceput: {EndTime}\nAngajat: {ShiftEmployee.FirstName} {ShiftEmployee.LastName}";
        }
    }
}
