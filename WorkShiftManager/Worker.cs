using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class Worker
    {
        private static int lastId = 0;

        public Dictionary<DayOfWeek, WorkSchedule> Schedule { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string ProfileImagePath { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Worker()
        {
            Id = GetNextAvailableId();
            Schedule = new Dictionary<DayOfWeek, WorkSchedule>();
        }

        private int GetNextAvailableId()
        {
            int nextId = 0;
            bool isIdAvailable = false;

            // Verifica gli ID esistenti
            HashSet<int> usedIds = new HashSet<int>();
            foreach (Department department in Globals.DataManager.Departments)
            {
                foreach (Worker worker in department.Workers)
                {
                    usedIds.Add(worker.Id);
                }
            }

            // Trova il primo ID disponibile
            while (usedIds.Contains(nextId))
            {
                nextId++;
            }

            return nextId;
        }
    }
}
