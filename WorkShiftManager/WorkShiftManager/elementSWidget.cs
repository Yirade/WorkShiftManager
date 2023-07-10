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
    public partial class SWidgetElement : UserControl
    {
        public Label LblName
        {
            get { return lblName; }
            set { lblName = value; }
        }
        public Guna.UI2.WinForms.Guna2CirclePictureBox ImgElement1
        {
            get { return imgElement3; }
            set { imgElement3 = value; }
        }
        public Guna.UI2.WinForms.Guna2CirclePictureBox ImgElement2
        {
            get { return imgElement2; }
            set { imgElement2 = value; }
        }
        public Guna.UI2.WinForms.Guna2CirclePictureBox ImgElement3
        {
            get { return imgElement1; }
            set { imgElement1 = value; }
        }
        public SWidgetElement()
        {
            InitializeComponent();
        }

        private void elementSWidget_Load(object sender, EventArgs e)
        {

        }

        private void elemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgElement3_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form modalEdit = new Form();
            using (modalScheduleDetail modal = new modalScheduleDetail())
            {
                modalEdit.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    Globals.DataManager.SaveData("data.xml"); // Salva i dati
                    Globals.DataManager.LoadData("data.xml"); // Ricarica i dati
                }
            }
        }

        private void imgElement2_Click(object sender, EventArgs e)
        {

        }

        private void imgElement1_Click(object sender, EventArgs e)
        {

        }

    }
}
