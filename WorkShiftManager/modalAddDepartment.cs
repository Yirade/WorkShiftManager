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
    public partial class modalAddDepartment : Form
    {
        public modalAddDepartment()
        {
            InitializeComponent();
        }

        private void modalAddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string departmentName = txtName.Text;

            if (!string.IsNullOrEmpty(departmentName))
            {
                Department newDepartment = new Department
                {
                    Name = departmentName
                };

                Globals.DataManager.Departments.Add(newDepartment);

                // Aggiungi qui la logica per aggiornare l'interfaccia grafica o eseguire altre operazioni necessarie dopo la creazione del dipartimento

                // Pulisci il campo di testo per il nome del dipartimento
                txtName.Text = string.Empty;
                this.Close();
            }
            else
            {
                MessageBox.Show("Inserisci un nome valido per il dipartimento.");
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
