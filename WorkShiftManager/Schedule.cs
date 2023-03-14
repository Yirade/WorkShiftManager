using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class Schedule
    {
        // Proprietati
        public string ScheduleName { get; set; }
        public List<Workday> Workdays { get; set; }

        // Constructor
        public Schedule(string scheduleName)
        {
            ScheduleName = scheduleName;
            Workdays = new List<Workday>();
        }

        // Metode
        public void AddWorkday(string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            Workdays.Add(new Workday(dayOfWeek, startTime, endTime));
        }

        public TimeSpan GetTotalWorkHours()
        {
            TimeSpan totalWorkHours = TimeSpan.Zero;

            foreach (Workday workday in Workdays)
            {
                totalWorkHours += workday.GetWorkHours();
            }

            return totalWorkHours;
        }

        public void DisplaySchedule()
        {
            Console.WriteLine("Program: {0}", ScheduleName);
            foreach (Workday workday in Workdays)
            {
                Console.WriteLine("{0}:\t\t{1,5} - {2}", workday.DayOfWeek, workday.StartTime, workday.EndTime);
            }
            Console.WriteLine("Totalul orelor de lucru: {0}", GetTotalWorkHours());
        }
    }
}
