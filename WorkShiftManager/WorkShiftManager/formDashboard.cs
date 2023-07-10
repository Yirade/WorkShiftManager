using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Integration;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;

namespace WorkShiftManager
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            populateChartDep();
            UpdateWorkerCountLabel();
            UpdateDepartmentsLabel();
            LoadNoteFromFile();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
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
            flowSearch.Controls.Clear();

            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                return;
            }
            flowSearch.SizeChanged += FlowSearch_SizeChanged;
            foreach (Worker worker in workers)
            {

                SearchElement searchElement = new SearchElement();
                searchElement.LblName.Text = worker.Name;
                searchElement.LblDepartment.Text = worker.Department;
                //searchElement.ImgProfile.Image = worker.ProfilePicture;
                //searchElement.ImgProfile.Image = Image.FromFile(worker.ProfileImagePath);
                searchElement.ImgProfile.Image = System.Drawing.Image.FromFile(worker.ProfileImagePath);
                searchElement.Tag = worker;
                searchElement.Size = new Size(flowSearch.ClientSize.Width, 20);
                searchElement.AutoSize = true;
                searchElement.Dock = DockStyle.Top;
                //searchElement.Click += new EventHandler(OpenWorkerProfile);
                flowSearch.Controls.Add(searchElement);

            }
        }

        private void FlowSearch_SizeChanged(object sender, EventArgs e)
        {
            // Ricalcola la dimensione degli elementi SearchElement in base alle dimensioni attuali del flowSearch
            foreach (Control control in flowSearch.Controls)
            {
                if (control is SearchElement searchElement)
                {
                    searchElement.Size = new Size(flowSearch.ClientSize.Width, 40);
                }
            }
        }

        private void populateChartDep()
        {
            // Cancella i dati esistenti nel controllo Chart
            chartDep.Series.Clear();

            // Crea una nuova serie per i dati
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series("Workers per Department");

            // Imposta il tipo di grafico su "Pie"
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Aggiungi i punti dati alla serie
            foreach (Department department in Globals.DataManager.Departments)
            {
                series1.Points.AddXY(department.Name, department.Workers.Count);
            }

            // Personalizza l'aspetto del grafico
            chartDep.BackColor = Color.Transparent;
            chartDep.Legends[0].BackColor = Color.Transparent;
            chartDep.Legends[0].ForeColor = Color.White;
            chartDep.ChartAreas[0].BackColor = Color.Transparent;
            series1.LabelForeColor = Color.Transparent;
            series1.IsValueShownAsLabel = false;
            chartDep.Legends[0].Alignment = StringAlignment.Center;
            chartDep.Legends[0].Docking = Docking.Bottom;



            chartDep.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartDep.ChartAreas[0].Area3DStyle.PointDepth = 200;
            chartDep.ChartAreas[0].Area3DStyle.Rotation = 0;
            chartDep.ChartAreas[0].Area3DStyle.Inclination = 0;
            chartDep.ChartAreas[0].Area3DStyle.WallWidth = 0;

            // Imposta il buco nel grafico
            chartDep.ChartAreas[0].InnerPlotPosition.Width = 70; // Imposta la larghezza desiderata del buco (percentuale)
            chartDep.ChartAreas[0].InnerPlotPosition.Height = 70; // Imposta l'altezza desiderata del buco (percentuale)

            // Imposta il tipo di grafico su "Doughnut"
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            chartDep.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartDep.ChartAreas[0].Area3DStyle.PointDepth = 200;
            chartDep.ChartAreas[0].Area3DStyle.Rotation = 0;
            chartDep.ChartAreas[0].Area3DStyle.Inclination = 0;
            chartDep.ChartAreas[0].Area3DStyle.WallWidth = 0;

            // Imposta il ridimensionamento del grafico
            chartDep.ChartAreas[0].Position.Width = 100; // Imposta la larghezza desiderata del grafico (percentuale)
            chartDep.ChartAreas[0].Position.Height = 100; // Imposta l'altezza desiderata del grafico (percentuale)
            chartDep.ChartAreas[0].Position.X = 0; // Imposta la posizione X del grafico (percentuale)
            chartDep.ChartAreas[0].Position.Y = 0; // Imposta la posizione Y del grafico (percentuale)

            // Imposta il buco nel grafico
            chartDep.ChartAreas[0].InnerPlotPosition.Width = 70; // Imposta la larghezza desiderata del buco (percentuale)
            chartDep.ChartAreas[0].InnerPlotPosition.Height = 70; // Imposta l'altezza desiderata del buco (percentuale)
            chartDep.ChartAreas[0].InnerPlotPosition.X = 15; // Imposta la posizione X del buco (percentuale)
            chartDep.ChartAreas[0].InnerPlotPosition.Y = 0; // Imposta la posizione Y del buco (percentuale)

            chartDep.ChartAreas[0].Position.X = 0; // Imposta la posizione X del grafico (percentuale)

            // Aggiungi la serie al controllo Chart
            chartDep.Series.Add(series1);
        }

        private void chartDep_Click(object sender, EventArgs e)
        {

        }

        private void chartDep_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateWorkerCountLabel()
        {
            int totalWorkers = 0;

            // Calcola il numero totale di worker
            foreach (Department department in Globals.DataManager.Departments)
            {
                totalWorkers += department.Workers.Count;
            }

            // Imposta il testo della label al numero totale di worker
            lblNr.Text = totalWorkers.ToString();
        }

        private void UpdateDepartmentsLabel()
        {
            int totalDepartments = Globals.DataManager.Departments.Count;

            // Imposta il testo della label al numero totale di dipartimenti
            lblDep.Text = totalDepartments.ToString();
        }


        private void formDashboard_Activated(object sender, EventArgs e)
        {
            populateChartDep();
            UpdateWorkerCountLabel();
            UpdateDepartmentsLabel();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            string filePath = "Data\\note.txt";  // Percorso predefinito per il file di testo

            // Verifica se il contenuto del TextBox è vuoto
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                // Verifica se il file esiste
                if (File.Exists(filePath))
                {
                    try
                    {
                        // Cancella il file di testo
                        File.Delete(filePath);
                        //MessageBox.Show("Il file è stato cancellato.");
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Si è verificato un errore durante la cancellazione del file: " + ex.Message);
                    }
                }
                else
                {
                    //MessageBox.Show("Il file non esiste.");
                }
            }
            else
            {
                try
                {
                    // Salva il contenuto del TextBox nel file di testo
                    File.WriteAllText(filePath, txtNote.Text);
                    //MessageBox.Show("Il file è stato salvato correttamente.");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Si è verificato un errore durante il salvataggio del file: " + ex.Message);
                }
            }
        }

        private void LoadNoteFromFile()
        {
            string filePath = "Data\\note.txt";  // Percorso predefinito per il file di testo

            // Verifica se il file esiste
            if (File.Exists(filePath))
            {
                try
                {
                    // Leggi il contenuto del file di testo
                    string fileContent = File.ReadAllText(filePath);

                    // Verifica se il contenuto del file non è vuoto
                    if (!string.IsNullOrWhiteSpace(fileContent))
                    {
                        // Assegna il contenuto del file al controllo TextBox
                        txtNote.Text = fileContent;
                        //MessageBox.Show("Il file è stato caricato correttamente.");
                    }
                    else
                    {
                        // Il file è vuoto, lascia il controllo TextBox vuoto
                        txtNote.Text = string.Empty;
                        //MessageBox.Show("Il file è vuoto.");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Si è verificato un errore durante il caricamento del file: " + ex.Message);
                }
            }
            else
            {
                // Il file non esiste, lascia il controllo TextBox vuoto
                txtNote.Text = string.Empty;
                //MessageBox.Show("Il file non esiste.");
            }
        }
    }
}
