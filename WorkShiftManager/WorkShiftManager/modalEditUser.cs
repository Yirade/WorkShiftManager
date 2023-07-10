using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShiftManager
{
    public partial class modalEditUser : Form
    {
        public int Id { get; set; }
        string selectedImagePath;

        public modalEditUser(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            Worker worker = Globals.DataManager.GetWorkerById(Id);
            txtName.Text = worker.Name;
            txtEmail.Text = worker.Email;
            imgProfile.Image = Image.FromFile(worker.ProfileImagePath);
            selectedImagePath = worker.ProfileImagePath;

            foreach (Department department in Globals.DataManager.Departments)
            {
                comboDep.Items.Add(department.Name);
            }

            comboDep.SelectedItem = worker.Department;

        }

        private void modalEditUser_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string department = comboDep.SelectedItem as string;

            if (ValidateName(name) && ValidateEmail(email) && !string.IsNullOrEmpty(department))
            {
                string newImagePath = CopyProfileImage(selectedImagePath, Id.ToString());

                Globals.DataManager.EditWorker(Id, txtName.Text, txtEmail.Text, newImagePath, comboDep.SelectedItem as string);

                // Rimuovi il lavoratore dal vecchio dipartimento
                Worker worker = Globals.DataManager.GetWorkerById(Id);
                Department oldDepartment = Globals.DataManager.Departments.FirstOrDefault(d => d.Workers.Contains(worker));
                if (oldDepartment != null)
                {
                    oldDepartment.Workers.Remove(worker);
                }

                // Aggiungi il lavoratore al nuovo dipartimento
                Department newDepartment = Globals.DataManager.Departments.FirstOrDefault(d => d.Name == department);
                if (newDepartment != null)
                {
                    newDepartment.Workers.Add(worker);
                }

                // Salva i dati aggiornati
                string filename = "data.xml";
                Globals.DataManager.SaveData(filename);

                txtName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                comboDep.SelectedItem = null;
                selectedImagePath = string.Empty;

                this.Close();

                // Aggiungi qui la logica per aggiornare l'interfaccia grafica o eseguire altre operazioni necessarie dopo la modifica del worker
            }
            else
            {
                if (!ValidateName(name))
                    txtName.BorderColor = Color.Red;
                else
                    txtName.BorderColor = SystemColors.ControlDark;

                if (!ValidateEmail(email))
                    txtEmail.BorderColor = Color.Red;
                else
                    txtEmail.BorderColor = SystemColors.ControlDark;

                if (string.IsNullOrEmpty(department))
                    comboDep.BorderColor = Color.Red;
                else
                    comboDep.BorderColor = SystemColors.ControlDark;

                MessageBox.Show("Inserisci tutti i dati richiesti in un formato valido.");
            }
        }

        private bool ValidateName(string name)
        {
            // Verifica se il nome contiene solo lettere e spazi
            return !string.IsNullOrEmpty(name) && name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool ValidateEmail(string email)
        {
            // Verifica se l'email ha un formato valido
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private string CopyProfileImage(string sourcePath, string workerName)
        {
            if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
            {
                // Gestisci il caso in cui il percorso del file di origine sia nullo o non valido
                return string.Empty;
            }

            string destinationFolder = "Data";
            Directory.CreateDirectory(destinationFolder); // Crea la directory se non esiste

            string destinationFileName = workerName + Path.GetExtension(sourcePath);
            string destinationPath = Path.Combine(destinationFolder, destinationFileName);

            int counter = 1;
            while (File.Exists(destinationPath))
            {
                string newFileName = $"{workerName}-new{counter}{Path.GetExtension(sourcePath)}";
                destinationPath = Path.Combine(destinationFolder, newFileName);
                counter++;
            }

            File.Copy(sourcePath, destinationPath, true);

            return destinationPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void imgProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "File immagine|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Seleziona un'immagine";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                imgProfile.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}
