using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShiftManager
{
    public partial class formWorkers : Form
    {
        bool SideBarExpand;
        public formWorkers(bool SideBarExpand)
        {
            InitializeComponent();
            this.SideBarExpand = SideBarExpand;
        }

        private void formWorkers_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            UpdateWorkers(); // Aggiornamento iniziale del flowLayoutPanel
        }

        public void UpdateWorkers()
        {
            // Rimuovi gli elementi esistenti dal flowLayoutPanel
            flowWorker.Controls.Clear();

            List<Worker> allWorkers = Globals.DataManager.Departments.SelectMany(d => d.Workers).ToList();

            // Ordina i worker per ID in ordine crescente
            List<Worker> sortedWorkers = allWorkers.OrderBy(w => w.Id).ToList();

            foreach (Worker worker in sortedWorkers)
            {
                // Creazione di un nuovo elemento Element
                Element workerElement = new Element(this);

                // Impostazione delle proprietà dell'elemento
                try { workerElement.ImgElement.Image = Image.FromFile(worker.ProfileImagePath); }
                catch (Exception ex)
                {
                    workerElement.ImgElement.Image = Properties.Resources.user;
                }
                workerElement.LblName.Text = worker.Name;
                workerElement.LblEmail.Text = worker.Email;
                workerElement.LblDepartment.Text = worker.Department;
                workerElement.LblId.Text = "#" + worker.Id.ToString();

                workerElement.Id = worker.Id;

                workerElement.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                // Aggiungi l'elemento al flowLayoutPanel
                flowWorker.Controls.Add(workerElement);
            }
        }




        public void UpdateDepartments()
        {
            // Rimuovi gli elementi esistenti dal flowLayoutPanel
            flowWorker.Controls.Clear();

            foreach (Department department in Globals.DataManager.Departments)
            {
                // Creazione di un nuovo elemento Element per il dipartimento
                DepElement departmentElement = new DepElement(this);

                // Impostazione delle proprietà dell'elemento dipartimento
                departmentElement.LblDepartment.Text = department.Name;
                departmentElement.LblWorkers.Text = "Workers: " + department.Workers.Count.ToString();

                // Impostazione delle dimensioni dell'elemento dipartimento
                departmentElement.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                // Aggiungi l'elemento dipartimento al flowLayoutPanel
                flowWorker.Controls.Add(departmentElement);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateDepartments();
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowWorker_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnWAdd_Click(object sender, EventArgs e)
        {
            Form modalAdd = new Form();
            if (btnWWorkers.Checked)
            {
                using (modalAddUser modal = new modalAddUser())
                {
                    modalAdd.StartPosition = FormStartPosition.CenterScreen;
                    
                    if (modal.ShowDialog() == DialogResult.OK)
                    {
                        UpdateWorkers(); // Aggiornamento dopo la creazione di un nuovo worker
                        Globals.DataManager.SaveData("data.xml"); // Salva i dati
                        Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                    }
                    UpdateWorkers();
                }
            }else if (btnWDepartment.Checked)
            {
                using (modalAddDepartment modal = new modalAddDepartment())
                {
                    modalAdd.StartPosition = FormStartPosition.CenterScreen;
                    
                    if (modal.ShowDialog() == DialogResult.OK)
                    {
                        UpdateDepartments();
                        // Aggiungi qui il codice per aggiornare i dipartimenti, se necessario
                    }
                    UpdateDepartments();
                }
            }
            
        }

        private void btnWWorkers_Click(object sender, EventArgs e)
        {
            UpdateWorkers();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
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

        private void ShowSearchResults(List<Worker> workers)
        {
            // Rimuovi gli elementi esistenti dal flowLayoutPanel
            flowWorker.Controls.Clear();

            foreach (Worker worker in workers)
            {
                // Creazione di un nuovo elemento Element
                Element workerElement = new Element(this);

                // Impostazione delle proprietà dell'elemento
                try { workerElement.ImgElement.Image = Image.FromFile(worker.ProfileImagePath); }
                catch (Exception ex)
                {
                    workerElement.ImgElement.Image = Properties.Resources.user;
                    //MessageBox.Show("Errore durante il caricamento dell'immagine del profilo: " + ex.Message);
                }
                workerElement.LblName.Text = worker.Name;
                workerElement.LblEmail.Text = worker.Email;
                workerElement.LblDepartment.Text = worker.Department;
                workerElement.LblId.Text = "#" + worker.Id.ToString();

                workerElement.Id = worker.Id;

                workerElement.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                // Aggiungi l'elemento al flowLayoutPanel
                flowWorker.Controls.Add(workerElement);
            }
        }
    }
}
