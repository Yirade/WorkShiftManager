using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShiftManager
{
    public partial class modalDayEdit : Form
    {
        private int workerId;
        public modalDayEdit(string dayName, int workerId)
        {
            InitializeComponent();

            lblName.Text = dayName;

            this.workerId = workerId;

            timeStart.Format = DateTimePickerFormat.Custom;
            timeStart.CustomFormat = "HH:mm";
            timeStart.ShowUpDown = true;

            timeEnd.Format = DateTimePickerFormat.Custom;
            timeEnd.CustomFormat = "HH:mm"; // Only use hours and minutes
            timeEnd.ShowUpDown = true;

        }

        private void modalDayEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TimeSpan startTime = timeStart.Value.TimeOfDay;
            TimeSpan endTime = timeEnd.Value.TimeOfDay;

            Globals.DataManager.SetWorkerSchedule(workerId, lblName.Text, startTime, endTime);

            Globals.DataManager.SaveData("data.xml");

            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Globals.DataManager.SetWorkerSchedule(workerId, lblName.Text, TimeSpan.Zero, TimeSpan.Zero);

            Globals.DataManager.SaveData("data.xml");

            this.Close();
        }
    }
}
