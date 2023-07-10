using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkShiftManager
{
    public partial class modalAddUser : Form
    {
        public modalAddUser()
        {
            InitializeComponent();
            foreach (Department department in Globals.DataManager.Departments)
            {
                comboDep.Items.Add(department.Name);
            }
        }

        string selectedImagePath;

        private void contrlolClose_Click(object sender, EventArgs e)
        {

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string department = comboDep.SelectedItem as string;

            if (ValidateName(name) && ValidateEmail(email) && !string.IsNullOrEmpty(department))
            {
                Worker newWorker = new Worker
                {
                    Name = name,
                    Email = email,
                    Department = department,
                };

                // Imposta l'immagine di default se non viene selezionata alcuna immagine del profilo
                if (string.IsNullOrEmpty(selectedImagePath))
                    newWorker.ProfileImagePath = "Data\\user.png";
                else
                {
                    string newImagePath = CopyProfileImage(selectedImagePath, newWorker.Id.ToString());
                    newWorker.ProfileImagePath = newImagePath;
                }

                Department selectedDepartment = Globals.DataManager.Departments.FirstOrDefault(d => d.Name == department);
                selectedDepartment?.Workers.Add(newWorker);
                string filename = "data.xml";
                Globals.DataManager.SaveData(filename);

                txtName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                comboDep.SelectedItem = null;
                selectedImagePath = string.Empty;

                this.Close();
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

            File.Copy(sourcePath, destinationPath, true);

            return destinationPath;
        }

        private void comboDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void modalAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
