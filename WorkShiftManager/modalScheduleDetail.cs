using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShiftManager
{
    public partial class modalScheduleDetail : Form
    {
        private int workerId;
        public modalScheduleDetail(int workerId)
        {
            InitializeComponent();

            this.workerId = workerId;

            UpdateSchedule();
        }

        public modalScheduleDetail()
        {
            InitializeComponent();
        }

        public void UpdateSchedule()
        {
            // Trova il lavoratore in base all'ID
            Worker worker = Globals.DataManager.GetWorkerById(workerId);

            // Verifica se il lavoratore esiste
            if (worker != null)
            {
                // Crea un array di DayOfWeek nell'ordine desiderato (da Lunedì a Domenica)
                DayOfWeek[] orderedDaysOfWeek = new DayOfWeek[]
                {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
            DayOfWeek.Sunday
                };

                // Itera attraverso i giorni della settimana nell'ordine desiderato
                for (int i = 0; i < 7; i++)
                {
                    DayOfWeek dayOfWeek = orderedDaysOfWeek[i];

                    // Ottieni l'orario di lavoro per il giorno corrente
                    if (worker.Schedule.TryGetValue(dayOfWeek, out WorkSchedule workSchedule))
                    {
                        // L'orario di lavoro per il giorno corrente è presente
                        Label label = Controls.Find("label" + (i + 1), true).FirstOrDefault() as Label;
                        if (label != null)
                        {
                            if (workSchedule != null)
                            {
                                // Se l'orario di lavoro esiste, imposta il testo nel formato "orainizio - orafine"
                                string startTime = workSchedule.StartTime.ToString(@"hh\:mm");
                                string endTime = workSchedule.EndTime.ToString(@"hh\:mm");
                                label.Text = startTime + " - " + endTime;
                            }
                            else
                            {
                                // Se l'orario di lavoro non esiste, imposta il testo che indica che è libero
                                label.Text = "Free";
                            }
                        }
                    }
                    else
                    {
                        // L'orario di lavoro per il giorno corrente non è presente
                        Label label = Controls.Find("label" + (i + 1), true).FirstOrDefault() as Label;
                        if (label != null)
                        {
                            // Se l'orario di lavoro non esiste, imposta il testo che indica che è libero
                            label.Text = "Free";
                        }
                    }
                }
            }
            else
            {
                // Lavoratore non trovato, gestisci l'errore o mostra un messaggio di avviso
                MessageBox.Show("Worker not found.");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modalScheduleDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalDayEdit modal = new modalDayEdit("Monday", workerId))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalDayEdit modal = new modalDayEdit("Tuesday", workerId))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalDayEdit modal = new modalDayEdit("Wednesday", workerId))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalDayEdit modal = new modalDayEdit("Thursday", workerId))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalDayEdit modal = new modalDayEdit("Friday", workerId))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalDayEdit modal = new modalDayEdit("Saturday", workerId))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalDayEdit modal = new modalDayEdit("Sunday", workerId))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void modalScheduleDetail_Activated(object sender, EventArgs e)
        {
            UpdateSchedule();
        }
    }
}
