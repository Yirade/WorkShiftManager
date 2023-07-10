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
    public partial class DepElement : UserControl
    {
        private formWorkers parentForm;
        public DepElement(formWorkers parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public Label LblDepartment
        {
            get { return lblDepartment; }
            set { lblDepartment = value; }
        }

        public Label LblWorkers
        {
            get { return lblWorkers; }
            set { lblWorkers = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Globals.DataManager.Departments.RemoveAt(Globals.DataManager.Departments.FindIndex(x => x.Name == lblDepartment.Text));
            Globals.DataManager.SaveData("data.xml");
            parentForm.UpdateDepartments();
        }

        private void DepElement_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalEditDepartment modal = new modalEditDepartment(lblDepartment.Text))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    parentForm.UpdateDepartments(); // Aggiornamento dopo la creazione di un nuovo worker
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
                parentForm.UpdateDepartments();
            }
        }
    }
}
