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
    public partial class SearchElement : UserControl
    {
        public Label LblName
        {
            get { return lblName; }
            set { lblName = value; }
        }
        public Label LblDepartment
        {
            get { return lblDep; }
            set { lblDep = value; }
        }
        public Guna.UI2.WinForms.Guna2CirclePictureBox ImgProfile
        {
            get { return imgProfile; }
            set { imgProfile = value; }
        }
        public SearchElement()
        {
            InitializeComponent();
        }

        private void SearchElement_Load(object sender, EventArgs e)
        {

        }
    }
}
