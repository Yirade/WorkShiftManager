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
    public partial class Element : UserControl
    {
        public Guna.UI2.WinForms.Guna2CirclePictureBox ImgElement
        {
            get { return imgElement; }
            set { imgElement = value; }
        }

        public Label LblName
        {
            get { return lblName; }
            set { lblName = value; }
        }

        public Label LblDepartment
        {
            get { return lblDepartment; }
            set { lblDepartment = value; }
        }

        public Label LblEmail
        {
            get { return lblEmail; }
            set { lblEmail = value; }
        }

        public Label LblId
        {
            get { return lblId; }
            set { lblId = value; }
        }

        public int Id { get; set; }
        private formWorkers parentForm;

        public Element(formWorkers parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void Element_Load(object sender, EventArgs e)
        {

        }

        public void detail(string name, string email, string department, int id)
        {
            lblName.Text = name;
            lblEmail.Text = email;
            lblDepartment.Text = department;
            lblId.Text = id.ToString();
        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void imgEdit_Click(object sender, EventArgs e)
        {

        }

        private void imgDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Globals.DataManager.RemoveWorker(Id);
            Globals.DataManager.SaveData("data.xml");
            parentForm.UpdateWorkers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalEditUser modal = new modalEditUser(Id))
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    parentForm.UpdateWorkers(); // Aggiornamento dopo la creazione di un nuovo worker
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
                parentForm.UpdateWorkers();
            }
        }

        private void imgElement_Click(object sender, EventArgs e)
        {

        }
    }
}
