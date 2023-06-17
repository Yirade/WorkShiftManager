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
        public string Name { get; set; }

        // Constructor
        public Schedule(string scheduleName)
        {
            this.ScheduleName = scheduleName;
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

        public string DisplaySchedule()
        {
            string Buff = $"\nProgram: {ScheduleName}";

            foreach (Workday workday in Workdays)
            {
                Buff += $"\n{workday.DayOfWeek}:\t\t{workday.StartTime,5} - {workday.EndTime}";
            }
            Buff += $"\nTotalul orelor de lucru: {GetTotalWorkHours()}";

            return Buff;
        }
    }
}
