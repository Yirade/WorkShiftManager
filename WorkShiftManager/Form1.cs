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
    public partial class Form1 : Form
    {
        formDashboard dashboard;
        formWorkers workers;
        formSchedule schedule;
        formSettings settings;
        formAbout about;
        public Form1()
        {
            InitializeComponent();
            mdiProp();
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboars_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }

            string filename = "data.xml";
            Globals.DataManager.LoadData(filename);
            //Globals.DataManager.AddData("data1.xml");
            //Globals.DataManager.SaveData("data.xml");
            //Globals.DataManager.LoadData("data.xml");


        }

        public static bool SideBarExpand { get; set; } = true;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(240, 240, 240);
        }

        private void timeSideBar_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand)
            {
                SideBar.Width -= 10;

                if (SideBar.Width <= 60)
                {
                    sideSeparator.Width = 38;

                    SideBarExpand = false;
                    timeSideBar.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                sideSeparator.Width = 170;

                if (SideBar.Width >= 200)
                {
                    SideBarExpand = true;
                    timeSideBar.Stop();
                }
            }
            AnimateButtonWidth(btnDashboard);
            AnimateButtonWidth(btnWorkers);
            AnimateButtonWidth(btnSchedule);
            AnimateButtonWidth(btnSettings);
            AnimateButtonWidth(btnAbout);
        }
        private void AnimateButtonWidth(Guna.UI2.WinForms.Guna2Button button)
        {
            int step = 10;

            if (button.Width >= 45 && SideBarExpand)
            {
                button.Width -= step;
                if (button.Width <= 65) { button.Width = 65; }
            }else
            {
                button.Width += step;
                if (button.Width >= 200) { button.Width = 200; }
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            timeSideBar.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Globals.DataManager.SaveData("data.xml");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboars_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }else
            {
                dashboard.Activate();
            }
        }

        private void Dashboars_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new formSettings();
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            if (workers == null)
            {
                workers = new formWorkers(SideBarExpand);
                workers.FormClosed += Workers_FormClosed;
                workers.MdiParent = this;
                workers.Dock = DockStyle.Fill;
                workers.Show();
            }
            else
            {
                workers.Activate();
            }
        }

        private void Workers_FormClosed(object sender, FormClosedEventArgs e)
        {
            workers = null;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (schedule == null)
            {
                schedule = new formSchedule();
                schedule.FormClosed += Schedule_FormClosed;
                schedule.MdiParent = this;
                schedule.Dock = DockStyle.Fill;
                schedule.Show();
            }
            else
            {
                schedule.Activate();
            }
        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            schedule = null;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new formAbout();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }
    }
}
