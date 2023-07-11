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
    public partial class formSchedule : Form
    {
        public formSchedule()
        {
            InitializeComponent();
        }

        private void formSchedule_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            UpdateSchedule();
        }

        private void flowSchedule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateSchedule()
        {
            // Rimuovi gli elementi esistenti dal flowSchedule
            flowSchedule.Controls.Clear();

            // Crea e aggiungi gli elementi SWidgetElement per i dipartimenti
            foreach (Department department in Globals.DataManager.Departments)
            {
                // Crea un nuovo elemento SWidgetElement per il dipartimento
                SWidgetElement departmentElement = new SWidgetElement();

                // Imposta il nome del dipartimento
                departmentElement.LblName.Text = department.Name;
                departmentElement.isDepartment = true;

                // Aggiungi l'elemento del dipartimento al flowSchedule
                flowSchedule.Controls.Add(departmentElement);

                // Aggiungi le immagini di profilo dei primi tre lavoratori
                int workerCount = Math.Min(department.Workers.Count, 3);
                for (int i = 0; i < workerCount; i++)
                {
                    string profileImagePath = department.Workers[i].ProfileImagePath;

                    // Imposta le nuove immagini di profilo
                    if (i == 0)
                    {
                        try { departmentElement.ImgElement3.Image = Image.FromFile(profileImagePath); }
                        catch (Exception ex)
                        {
                            departmentElement.ImgElement3.Image = Properties.Resources.user;
                        }
                        //departmentElement.ImgElement3.Image = Image.FromFile(profileImagePath);
                    }
                    else if (i == 1)
                    {
                        try { departmentElement.ImgElement2.Image = Image.FromFile(profileImagePath); }
                        catch (Exception ex)
                        {
                            departmentElement.ImgElement2.Image = Properties.Resources.user;
                        }
                    }
                    else if (i == 2)
                    {
                        try { departmentElement.ImgElement1.Image = Image.FromFile(profileImagePath); }
                        catch (Exception ex)
                        {
                            departmentElement.ImgElement1.Image = Properties.Resources.user;
                        }
                    }
                }
            }

            // Crea e aggiungi gli elementi SWidgetElement per i worker
            foreach (Department department in Globals.DataManager.Departments)
            {
                foreach (Worker worker in department.Workers)
                {
                    // Crea un nuovo elemento SWidgetElement per il worker
                    SWidgetElement workerElement = new SWidgetElement();

                    // Imposta l'immagine di profilo solo per l'elemento ImgElement1
                    if (workerElement.ImgElement3.Image == null)
                    {
                        string profileImagePath = worker.ProfileImagePath;
                        try { workerElement.ImgElement3.Image = Image.FromFile(profileImagePath); }
                        catch (Exception ex)
                        {
                            workerElement.ImgElement3.Image = Properties.Resources.user;
                        }
                        //workerElement.ImgElement3.Image = Image.FromFile(profileImagePath);
                        workerElement.LblName.Text = worker.Name;
                        
                    }
                    workerElement.workerId = worker.Id;
                    workerElement.isDepartment = false;
                    // Aggiungi l'elemento del worker al flowSchedule
                    flowSchedule.Controls.Add(workerElement);
                }
            }
        }



        private void formSchedule_Activated(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBox.Text)) 
            {
                UpdateSchedule();
            }else
            {
                string searchQuery = SearchBox.Text.ToLower();

                List<Worker> workers = new List<Worker>();

                foreach (Department department in Globals.DataManager.Departments)
                {
                    foreach (Worker worker in department.Workers)
                    {
                        if (worker.Name.ToLower().Contains(searchQuery) || worker.Email.ToLower().Contains(searchQuery))
                        {
                            workers.Add(worker);
                        }
                    }
                }

                ShowSearchResults(workers);
            }
        }

        private void ShowSearchResults(List<Worker> workers)
        {
            // Rimuovi gli elementi esistenti dal flowSchedule
            flowSchedule.Controls.Clear();

            // Crea e aggiungi gli elementi SWidgetElement per i worker
            foreach (Worker worker in workers)
            {
                // Crea un nuovo elemento SWidgetElement per il worker
                SWidgetElement workerElement = new SWidgetElement();

                // Imposta l'immagine di profilo solo per l'elemento ImgElement1
                if (workerElement.ImgElement3.Image == null)
                {
                    string profileImagePath = worker.ProfileImagePath;
                    try { workerElement.ImgElement3.Image = Image.FromFile(profileImagePath); }
                    catch (Exception ex)
                    {
                        workerElement.ImgElement3.Image = Properties.Resources.user;
                    }
                    workerElement.LblName.Text = worker.Name;
                }

                // Aggiungi l'elemento del worker al flowSchedule
                flowSchedule.Controls.Add(workerElement);
            }
        }

    }
}
