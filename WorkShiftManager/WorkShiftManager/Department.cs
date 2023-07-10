using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public class Department
    {
        public string Name { get; set; }
        public List<Worker> Workers { get; set; }

        public Department()
        {
            Workers = new List<Worker>();
        }
    }
}
