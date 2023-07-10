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
    public partial class WeekDayElement : UserControl
    {   
        uint count = 0;

        public Label Value
        {
            get { return lblNr; }
            set { lblNr = value; }
        }
        public WeekDayElement()
        {
            InitializeComponent();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblNr.Text = (++count).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblNr.Text = (--count).ToString();
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
