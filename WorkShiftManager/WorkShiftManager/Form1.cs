using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WorkShiftManager
{
    partial class Form1 : Form
    {
        private string dataFilePath = "data.txt";
        private List<Department> departments = new List<Department>();
        private int lastEmployeeID;

        private Panel sideMenuPanel;
        private Button employeesButton;
        private Button departmentsButton;
        private Button schedulesButton;
        private Button addButton;
        private MenuStrip menuStrip1;
        private ToolStripTextBox menu;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox4;
        private ToolStripTextBox toolStripTextBox5;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripTextBox toolStripTextBox6;
        private ToolStripTextBox toolStripTextBox7;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox8;
        private Panel panel1;
        private GroupBox _nrAngajati;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private bool isMenuExpanded = false;

        public Form1()
        {
            InitializeComponent();

            InitializeSideMenu();

            departments = new List<Department>();

            if (File.Exists(dataFilePath))
            {
                LoadDataFromFile();
            }
            else
            {
                CreateInitialData();
            }

            DisplayDepartments();
        }

        private void CreateInitialData()
        {
            Schedule schedule = new Schedule("ProgramulMeu");

            Department department1 = new Department("Departament1", schedule);
            department1.AddEmployee("John", "Doe", 1000, "EMP1");
            departments.Add(department1);

            lastEmployeeID = department1.GetLastEmployeeID();
        }

        private void DisplayDepartments()
        {
            ClearForm();

            int top = 20;

            foreach (Department department in departments)
            {
                Label departmentLabel = new Label();
                departmentLabel.Text = $"Departament: {department.Name}";
                departmentLabel.Location = new Point(20, top);
                departmentLabel.AutoSize = true;
                Controls.Add(departmentLabel);

                top += 20;

                foreach (Employee employee in department.Employees)
                {
                    Label employeeLabel = new Label();
                    employeeLabel.Text = $"Nume: {employee.FirstName} {employee.LastName}, Salariu: {employee.Salary}";
                    employeeLabel.Location = new Point(40, top);
                    employeeLabel.AutoSize = true;
                    Controls.Add(employeeLabel);

                    top += 20;
                }

                top += 20;
            }
        }

        private void ClearForm()
        {
            Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToFile();
        }

        private void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(dataFilePath))
            {
                foreach (Department department in departments)
                {
                    writer.WriteLine(department.Name);
                    writer.WriteLine(department.Schedule.Name);
                    writer.WriteLine(department.Employees.Count);

                    foreach (Employee employee in department.Employees)
                    {
                        writer.WriteLine(employee.FirstName);
                        writer.WriteLine(employee.LastName);
                        writer.WriteLine(employee.Salary);
                        writer.WriteLine(employee.EmployeeID);
                    }
                }

                writer.WriteLine(lastEmployeeID);
            }
        }

        private void LoadDataFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(this.dataFilePath))
                {
                    this.departments.Clear();

                    while (!reader.EndOfStream)
                    {
                        string departmentName = reader.ReadLine();
                        string scheduleName = reader.ReadLine();

                        int employeeCount;
                        if (!int.TryParse(reader.ReadLine(), out employeeCount))
                        {
                            throw new Exception("Eroare la citirea numărului de angajați.");
                        }

                        Schedule schedule = new Schedule(scheduleName);
                        Department department = new Department(departmentName, schedule);

                        for (int i = 0; i < employeeCount; i++)
                        {
                            string firstName = reader.ReadLine();
                            string lastName = reader.ReadLine();

                            decimal salary;
                            if (!decimal.TryParse(reader.ReadLine(), out salary))
                            {
                                throw new Exception("Eroare la citirea salariului angajatului.");
                            }

                            int employeeID;
                            if (!int.TryParse(reader.ReadLine(), out employeeID))
                            {
                                throw new Exception("Eroare la citirea ID-ului angajatului.");
                            }

                            department.AddEmployee(firstName, lastName, salary, employeeID.ToString());
                        }

                        this.departments.Add(department);
                    }

                    string lastEmployeeIDString;
                    if (!string.IsNullOrWhiteSpace(lastEmployeeIDString = reader.ReadLine()))
                    {
                        if (!int.TryParse(lastEmployeeIDString, out lastEmployeeID))
                        {
                            throw new Exception("Eroare la citirea ultimului ID de angajat.");
                        }
                    }
                    else
                    {
                        throw new Exception("Eroare la citirea ultimului ID de angajat.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea datelor: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox8 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._nrAngajati = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this._nrAngajati.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(100, 23);
            this.menu.Text = "Menu";
            this.menu.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menu.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "ANGAJATI";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "DEPARTAMENTE";
            this.toolStripTextBox3.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4,
            this.toolStripTextBox5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 23);
            this.toolStripMenuItem1.Text = "ADAUGA";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox4.Text = "ANGAJAT";
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox5.Text = "DEPARTAMENT";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox6,
            this.toolStripTextBox7,
            this.toolStripSeparator1,
            this.toolStripTextBox8});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 23);
            this.toolStripMenuItem2.Text = "ALTELE";
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox6.Text = "SALVEAZA";
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox7.Text = "INCARCA";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripTextBox8
            // 
            this.toolStripTextBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox8.Name = "toolStripTextBox8";
            this.toolStripTextBox8.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox8.Text = "INCHIDE";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 429);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // _nrAngajati
            // 
            this._nrAngajati.Controls.Add(this.label1);
            this._nrAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._nrAngajati.Location = new System.Drawing.Point(0, 30);
            this._nrAngajati.Name = "_nrAngajati";
            this._nrAngajati.Size = new System.Drawing.Size(200, 51);
            this._nrAngajati.TabIndex = 1;
            this._nrAngajati.TabStop = false;
            this._nrAngajati.Text = "Nr. Angajati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "14";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(816, 458);
            this.Controls.Add(this._nrAngajati);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this._nrAngajati.ResumeLayout(false);
            this._nrAngajati.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeSideMenu()
        {
            // Configurarea panelului meniului lateral
            sideMenuPanel = new Panel();
            sideMenuPanel.BackColor = Color.FromArgb(23, 21, 32);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.AutoScroll = true;
            sideMenuPanel.Width = 250;

            // Configurarea butoanelor din meniul lateral
            employeesButton = CreateSideMenuButton("Employees", "employeesButton_Click");
            departmentsButton = CreateSideMenuButton("Departments", "departmentsButton_Click");
            schedulesButton = CreateSideMenuButton("Schedules", "schedulesButton_Click");
            addButton = CreateSideMenuButton("Add", "addButton_Click");

            // Adăugarea butoanelor în panelul meniului lateral
            sideMenuPanel.Controls.Add(employeesButton);
            sideMenuPanel.Controls.Add(departmentsButton);
            sideMenuPanel.Controls.Add(schedulesButton);
            sideMenuPanel.Controls.Add(addButton);

            // Adăugarea panelului meniului lateral în formular
            Controls.Add(sideMenuPanel);
        }

        private Button CreateSideMenuButton(string buttonText, string clickEvent)
        {
            Button button = new Button();
            button.Text = buttonText;
            button.BackColor = Color.FromArgb(35, 32, 39);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.ForeColor = Color.White;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(15, 0, 0, 0);
            button.Width = sideMenuPanel.Width;
            button.Height = 60;
            button.Click += (EventHandler)Delegate.CreateDelegate(typeof(EventHandler), this, clickEvent);

            return button;
        }

        private void ToggleSideMenu()
        {
            if (isMenuExpanded)
            {
                // Retrage meniul lateral
                sideMenuPanel.Width = 70;
                isMenuExpanded = false;
            }
            else
            {
                // Extinde meniul lateral
                sideMenuPanel.Width = 250;
                isMenuExpanded = true;
            }
        }

        // Evenimentul pentru butonul de extindere/retragere a meniului
        private void menuExpandButton_Click(object sender, EventArgs e)
        {
            ToggleSideMenu();
        }

        // Evenimente pentru butoanele meniului
        private void employeesButton_Click(object sender, EventArgs e)
        {
            // Acțiuni pentru vizualizarea angajaților
        }

        private void departmentsButton_Click(object sender, EventArgs e)
        {
            // Acțiuni pentru vizualizarea departamentelor
        }

        private void schedulesButton_Click(object sender, EventArgs e)
        {
            // Acțiuni pentru vizualizarea orarelor de muncă
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Acțiuni pentru secțiunea de adăugare
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
