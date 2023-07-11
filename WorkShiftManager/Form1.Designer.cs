namespace WorkShiftManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.controlMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.contrlolClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogo = new Guna.UI2.WinForms.Guna2Button();
            this.sideSeparator = new Guna.UI2.WinForms.Guna2Separator();
            this.btnSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.btnWorkers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timeSideBar = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.controlMinimize);
            this.guna2Panel1.Controls.Add(this.controlMaximize);
            this.guna2Panel1.Controls.Add(this.contrlolClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1180, 25);
            this.guna2Panel1.TabIndex = 0;
            // 
            // controlMinimize
            // 
            this.controlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.controlMinimize.IconColor = System.Drawing.Color.White;
            this.controlMinimize.Location = new System.Drawing.Point(1045, 0);
            this.controlMinimize.Name = "controlMinimize";
            this.controlMinimize.Size = new System.Drawing.Size(45, 25);
            this.controlMinimize.TabIndex = 4;
            // 
            // controlMaximize
            // 
            this.controlMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.controlMaximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.controlMaximize.IconColor = System.Drawing.Color.White;
            this.controlMaximize.Location = new System.Drawing.Point(1090, 0);
            this.controlMaximize.Name = "controlMaximize";
            this.controlMaximize.Size = new System.Drawing.Size(45, 25);
            this.controlMaximize.TabIndex = 3;
            // 
            // contrlolClose
            // 
            this.contrlolClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contrlolClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.contrlolClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.contrlolClose.IconColor = System.Drawing.Color.White;
            this.contrlolClose.Location = new System.Drawing.Point(1135, 0);
            this.contrlolClose.Name = "contrlolClose";
            this.contrlolClose.Size = new System.Drawing.Size(45, 25);
            this.contrlolClose.TabIndex = 2;
            this.contrlolClose.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // SideBar
            // 
            this.SideBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.SideBar.Controls.Add(this.btnLogo);
            this.SideBar.Controls.Add(this.sideSeparator);
            this.SideBar.Controls.Add(this.btnSchedule);
            this.SideBar.Controls.Add(this.lblVersion);
            this.SideBar.Controls.Add(this.btnSettings);
            this.SideBar.Controls.Add(this.btnAbout);
            this.SideBar.Controls.Add(this.btnWorkers);
            this.SideBar.Controls.Add(this.btnDashboard);
            this.SideBar.Controls.Add(this.lblLogo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 25);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 595);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            // 
            // btnLogo
            // 
            this.btnLogo.AutoRoundedCorners = true;
            this.btnLogo.BorderRadius = 21;
            this.btnLogo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnLogo.FocusedColor = System.Drawing.Color.Transparent;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogo.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLogo.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogo.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogo.Image = global::WorkShiftManager.Properties.Resources.logo;
            this.btnLogo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogo.Location = new System.Drawing.Point(6, 6);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(48, 45);
            this.btnLogo.TabIndex = 2;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // sideSeparator
            // 
            this.sideSeparator.Location = new System.Drawing.Point(12, 239);
            this.sideSeparator.Name = "sideSeparator";
            this.sideSeparator.Size = new System.Drawing.Size(170, 10);
            this.sideSeparator.TabIndex = 8;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Animated = true;
            this.btnSchedule.AnimatedGIF = true;
            this.btnSchedule.AutoRoundedCorners = true;
            this.btnSchedule.BorderRadius = 21;
            this.btnSchedule.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSchedule.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnSchedule.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnSchedule.CustomImages.CheckedImage = global::WorkShiftManager.Properties.Resources.schedule_color1;
            this.btnSchedule.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.schedule_color1;
            this.btnSchedule.CustomImages.Image = global::WorkShiftManager.Properties.Resources.schedule1;
            this.btnSchedule.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSchedule.CustomImages.ImageOffset = new System.Drawing.Point(30, 0);
            this.btnSchedule.CustomizableEdges.BottomLeft = false;
            this.btnSchedule.CustomizableEdges.TopLeft = false;
            this.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSchedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnSchedule.Location = new System.Drawing.Point(-20, 188);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(200, 45);
            this.btnSchedule.TabIndex = 7;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSchedule.TextOffset = new System.Drawing.Point(70, 0);
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVersion.Location = new System.Drawing.Point(1, 573);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "V 0.2 Beta";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.Animated = true;
            this.btnSettings.AnimatedGIF = true;
            this.btnSettings.AutoRoundedCorners = true;
            this.btnSettings.BorderRadius = 21;
            this.btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnSettings.CustomImages.CheckedImage = global::WorkShiftManager.Properties.Resources.settings_color;
            this.btnSettings.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.settings_color;
            this.btnSettings.CustomImages.Image = global::WorkShiftManager.Properties.Resources.settings;
            this.btnSettings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.CustomImages.ImageOffset = new System.Drawing.Point(30, 0);
            this.btnSettings.CustomizableEdges.BottomLeft = false;
            this.btnSettings.CustomizableEdges.TopLeft = false;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnSettings.Location = new System.Drawing.Point(-20, 472);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 45);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.TextOffset = new System.Drawing.Point(70, 0);
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Animated = true;
            this.btnAbout.AutoRoundedCorners = true;
            this.btnAbout.BorderRadius = 21;
            this.btnAbout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnAbout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnAbout.CustomImages.CheckedImage = global::WorkShiftManager.Properties.Resources.about_color2;
            this.btnAbout.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.about_color2;
            this.btnAbout.CustomImages.Image = global::WorkShiftManager.Properties.Resources.about;
            this.btnAbout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.CustomImages.ImageOffset = new System.Drawing.Point(30, 0);
            this.btnAbout.CustomizableEdges.BottomLeft = false;
            this.btnAbout.CustomizableEdges.TopLeft = false;
            this.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnAbout.Location = new System.Drawing.Point(-20, 523);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 45);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.TextOffset = new System.Drawing.Point(70, 0);
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Animated = true;
            this.btnWorkers.AutoRoundedCorners = true;
            this.btnWorkers.BorderRadius = 21;
            this.btnWorkers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWorkers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnWorkers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnWorkers.CustomImages.CheckedImage = global::WorkShiftManager.Properties.Resources.workers_color;
            this.btnWorkers.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.workers_color;
            this.btnWorkers.CustomImages.Image = global::WorkShiftManager.Properties.Resources.workers;
            this.btnWorkers.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWorkers.CustomImages.ImageOffset = new System.Drawing.Point(30, 4);
            this.btnWorkers.CustomizableEdges.BottomLeft = false;
            this.btnWorkers.CustomizableEdges.TopLeft = false;
            this.btnWorkers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWorkers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWorkers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWorkers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWorkers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnWorkers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkers.ForeColor = System.Drawing.Color.White;
            this.btnWorkers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnWorkers.Location = new System.Drawing.Point(-20, 137);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(200, 45);
            this.btnWorkers.TabIndex = 3;
            this.btnWorkers.Text = "Workers";
            this.btnWorkers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWorkers.TextOffset = new System.Drawing.Point(70, 0);
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.AnimatedGIF = true;
            this.btnDashboard.AutoRoundedCorners = true;
            this.btnDashboard.BorderRadius = 21;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnDashboard.CustomImages.CheckedImage = global::WorkShiftManager.Properties.Resources.dashboard_color;
            this.btnDashboard.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.dashboard_color;
            this.btnDashboard.CustomImages.Image = global::WorkShiftManager.Properties.Resources.dashboard_1_;
            this.btnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.CustomImages.ImageOffset = new System.Drawing.Point(30, 0);
            this.btnDashboard.CustomizableEdges.BottomLeft = false;
            this.btnDashboard.CustomizableEdges.TopLeft = false;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnDashboard.Location = new System.Drawing.Point(-20, 86);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(70, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(60, 4);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(101, 45);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "WSM";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // timeSideBar
            // 
            this.timeSideBar.Interval = 5;
            this.timeSideBar.Tick += new System.EventHandler(this.timeSideBar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1180, 620);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WSM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel SideBar;
        private Guna.UI2.WinForms.Guna2ControlBox contrlolClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox controlMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox controlMaximize;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnWorkers;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private System.Windows.Forms.Label lblVersion;
        private Guna.UI2.WinForms.Guna2Button btnSchedule;
        private Guna.UI2.WinForms.Guna2Separator sideSeparator;
        private Guna.UI2.WinForms.Guna2Button btnLogo;
        private System.Windows.Forms.Timer timeSideBar;
    }
}

