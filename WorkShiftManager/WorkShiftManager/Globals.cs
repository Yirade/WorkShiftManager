using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShiftManager
{
    public static class Globals
    {
        public static DataManager DataManager { get; set; }

        static Globals()
        {
            DataManager = new DataManager();
        }
    }

}
