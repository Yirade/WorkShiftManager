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
    public partial class modalEditDepartment : Form
    {
        string departmentName;
        public modalEditDepartment(string departmentName)
        {
            InitializeComponent();
            this.departmentName = departmentName;
            txtName.Text = departmentName;
        }

        private void modalEditDepartment_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Globals.DataManager.ModifyDepartmentName(departmentName, txtName.Text);
            this.Close();
        }
    }
}
