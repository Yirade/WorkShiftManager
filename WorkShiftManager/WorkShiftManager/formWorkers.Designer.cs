namespace WorkShiftManager
{
    partial class formWorkers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelWOption = new Guna.UI2.WinForms.Guna2Panel();
            this.btnWDepartment = new Guna.UI2.WinForms.Guna2Button();
            this.btnWWorkers = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flowWorker = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelWOption.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWOption
            // 
            this.panelWOption.Controls.Add(this.btnWDepartment);
            this.panelWOption.Controls.Add(this.btnWWorkers);
            this.panelWOption.Location = new System.Drawing.Point(12, 12);
            this.panelWOption.Name = "panelWOption";
            this.panelWOption.Size = new System.Drawing.Size(211, 36);
            this.panelWOption.TabIndex = 3;
            // 
            // btnWDepartment
            // 
            this.btnWDepartment.Animated = true;
            this.btnWDepartment.AutoRoundedCorners = true;
            this.btnWDepartment.BorderRadius = 17;
            this.btnWDepartment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWDepartment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnWDepartment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWDepartment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWDepartment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnWDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWDepartment.ForeColor = System.Drawing.Color.White;
            this.btnWDepartment.Location = new System.Drawing.Point(107, 0);
            this.btnWDepartment.Name = "btnWDepartment";
            this.btnWDepartment.Size = new System.Drawing.Size(101, 36);
            this.btnWDepartment.TabIndex = 2;
            this.btnWDepartment.Text = "Departments";
            this.btnWDepartment.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnWWorkers
            // 
            this.btnWWorkers.Animated = true;
            this.btnWWorkers.AutoRoundedCorners = true;
            this.btnWWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnWWorkers.BorderRadius = 17;
            this.btnWWorkers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWWorkers.Checked = true;
            this.btnWWorkers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnWWorkers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWWorkers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWWorkers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWWorkers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWWorkers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.btnWWorkers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWWorkers.ForeColor = System.Drawing.Color.White;
            this.btnWWorkers.Location = new System.Drawing.Point(0, 0);
            this.btnWWorkers.Name = "btnWWorkers";
            this.btnWWorkers.Size = new System.Drawing.Size(101, 36);
            this.btnWWorkers.TabIndex = 1;
            this.btnWWorkers.Text = "Workers";
            this.btnWWorkers.Click += new System.EventHandler(this.btnWWorkers_Click);
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.flowWorker;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(770, 67);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 317);
            this.guna2VScrollBar1.TabIndex = 4;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.White;
            this.guna2VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2VScrollBar1_Scroll);
            // 
            // flowWorker
            // 
            this.flowWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowWorker.AutoScroll = true;
            this.flowWorker.Location = new System.Drawing.Point(12, 67);
            this.flowWorker.Name = "flowWorker";
            this.flowWorker.Size = new System.Drawing.Size(776, 317);
            this.flowWorker.TabIndex = 6;
            this.flowWorker.Paint += new System.Windows.Forms.PaintEventHandler(this.flowWorker_Paint);
            // 
            // btnWAdd
            // 
            this.btnWAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWAdd.Animated = true;
            this.btnWAdd.AutoRoundedCorners = true;
            this.btnWAdd.BorderRadius = 23;
            this.btnWAdd.CustomImages.Image = global::WorkShiftManager.Properties.Resources.plus;
            this.btnWAdd.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWAdd.CustomImages.ImageOffset = new System.Drawing.Point(0, 1);
            this.btnWAdd.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.btnWAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWAdd.ForeColor = System.Drawing.Color.White;
            this.btnWAdd.Location = new System.Drawing.Point(704, 7);
            this.btnWAdd.Name = "btnWAdd";
            this.btnWAdd.Size = new System.Drawing.Size(84, 48);
            this.btnWAdd.TabIndex = 5;
            this.btnWAdd.Text = "Add";
            this.btnWAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnWAdd.Click += new System.EventHandler(this.btnWAdd_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnWAdd);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 383);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 67);
            this.panelBottom.TabIndex = 7;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Animated = true;
            this.SearchBox.AutoRoundedCorners = true;
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SearchBox.BorderRadius = 17;
            this.SearchBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.IconLeft = global::WorkShiftManager.Properties.Resources.search;
            this.SearchBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.SearchBox.Location = new System.Drawing.Point(588, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search...";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(200, 36);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextOffset = new System.Drawing.Point(10, 0);
            this.SearchBox.UseWaitCursor = true;
            this.SearchBox.WordWrap = false;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // formWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.flowWorker);
            this.Controls.Add(this.panelWOption);
            this.Controls.Add(this.SearchBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formWorkers";
            this.Text = "formWorkers";
            this.Load += new System.EventHandler(this.formWorkers_Load);
            this.panelWOption.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Panel panelWOption;
        private Guna.UI2.WinForms.Guna2Button btnWDepartment;
        private Guna.UI2.WinForms.Guna2Button btnWWorkers;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Button btnWAdd;
        private System.Windows.Forms.FlowLayoutPanel flowWorker;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
    }
}