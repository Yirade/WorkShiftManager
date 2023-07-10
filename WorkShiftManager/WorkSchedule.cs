using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class WorkSchedule
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public WorkSchedule(TimeSpan startTime, TimeSpan endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public WorkSchedule()
        {

        }
    }
}
