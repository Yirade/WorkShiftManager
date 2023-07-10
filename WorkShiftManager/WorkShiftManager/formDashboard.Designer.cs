using System.Drawing;

namespace WorkShiftManager
{
    partial class formDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chartDep = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelPie = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNr = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblNrTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDep = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTxtNote = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDep)).BeginInit();
            this.panelPie.SuspendLayout();
            this.panelNr.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.panelTxtNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartDep
            // 
            this.chartDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.chartDep.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.chartDep.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            chartArea5.Name = "ChartArea1";
            this.chartDep.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartDep.Legends.Add(legend5);
            this.chartDep.Location = new System.Drawing.Point(0, 0);
            this.chartDep.Name = "chartDep";
            this.chartDep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartDep.Series.Add(series5);
            this.chartDep.Size = new System.Drawing.Size(253, 335);
            this.chartDep.TabIndex = 2;
            this.chartDep.Click += new System.EventHandler(this.chartDep_Click_1);
            // 
            // panelPie
            // 
            this.panelPie.BorderRadius = 22;
            this.panelPie.Controls.Add(this.chartDep);
            this.panelPie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panelPie.Location = new System.Drawing.Point(19, 66);
            this.panelPie.Name = "panelPie";
            this.panelPie.Size = new System.Drawing.Size(252, 338);
            this.panelPie.TabIndex = 3;
            // 
            // panelNr
            // 
            this.panelNr.BorderRadius = 22;
            this.panelNr.Controls.Add(this.lblNr);
            this.panelNr.Controls.Add(this.lblNrTitle);
            this.panelNr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panelNr.Location = new System.Drawing.Point(284, 66);
            this.panelNr.Name = "panelNr";
            this.panelNr.Size = new System.Drawing.Size(234, 160);
            this.panelNr.TabIndex = 4;
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.BackColor = System.Drawing.Color.Transparent;
            this.lblNr.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblNr.Location = new System.Drawing.Point(0, 54);
            this.lblNr.MinimumSize = new System.Drawing.Size(234, 0);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(234, 86);
            this.lblNr.TabIndex = 7;
            this.lblNr.Text = "14";
            this.lblNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNrTitle
            // 
            this.lblNrTitle.AutoSize = true;
            this.lblNrTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.lblNrTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrTitle.Location = new System.Drawing.Point(12, 17);
            this.lblNrTitle.Name = "lblNrTitle";
            this.lblNrTitle.Size = new System.Drawing.Size(119, 37);
            this.lblNrTitle.TabIndex = 0;
            this.lblNrTitle.Text = "Workers:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 22;
            this.guna2Panel1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel1.Controls.Add(this.date1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(531, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(234, 100);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderRadius = 17;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CustomFormat = "HH:mm";
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(54, 54);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShowUpDown = true;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(160, 36);
            this.guna2DateTimePicker1.TabIndex = 10;
            this.guna2DateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 7, 9, 8, 0, 0, 0);
            // 
            // date1
            // 
            this.date1.Animated = true;
            this.date1.AutoRoundedCorners = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.BorderRadius = 17;
            this.date1.Checked = true;
            this.date1.CustomFormat = "HH:mm";
            this.date1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.date1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date1.Location = new System.Drawing.Point(54, 9);
            this.date1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.ShowUpDown = true;
            this.date1.Size = new System.Drawing.Size(160, 36);
            this.date1.TabIndex = 9;
            this.date1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date1.UseTransparentBackground = true;
            this.date1.Value = new System.DateTime(2023, 7, 9, 8, 0, 0, 0);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 22;
            this.guna2Panel2.Controls.Add(this.lblDep);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Location = new System.Drawing.Point(284, 244);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(234, 160);
            this.guna2Panel2.TabIndex = 7;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.BackColor = System.Drawing.Color.Transparent;
            this.lblDep.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblDep.Location = new System.Drawing.Point(0, 54);
            this.lblDep.MinimumSize = new System.Drawing.Size(234, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(234, 86);
            this.lblDep.TabIndex = 7;
            this.lblDep.Text = "3642";
            this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departments:";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 22;
            this.guna2Panel3.Controls.Add(this.panelTxtNote);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Location = new System.Drawing.Point(19, 422);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(499, 160);
            this.guna2Panel3.TabIndex = 8;
            // 
            // panelTxtNote
            // 
            this.panelTxtNote.BackColor = System.Drawing.Color.Transparent;
            this.panelTxtNote.Controls.Add(this.txtNote);
            this.panelTxtNote.Location = new System.Drawing.Point(18, 46);
            this.panelTxtNote.Name = "panelTxtNote";
            this.panelTxtNote.Size = new System.Drawing.Size(460, 94);
            this.panelTxtNote.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txtNote.BorderRadius = 22;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(0, 0);
            this.txtNote.Margin = new System.Windows.Forms.Padding(5);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtNote.PlaceholderText = "🖊 Your note ...";
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(460, 94);
            this.txtNote.TabIndex = 0;
            this.txtNote.TextOffset = new System.Drawing.Point(5, 5);
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note:";
            // 
            // flowSearch
            // 
            this.flowSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowSearch.Location = new System.Drawing.Point(768, 244);
            this.flowSearch.Name = "flowSearch";
            this.flowSearch.Size = new System.Drawing.Size(200, 170);
            this.flowSearch.TabIndex = 9;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Animated = true;
            this.SearchBox.AutoRoundedCorners = true;
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SearchBox.BorderRadius = 17;
            this.SearchBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.SearchBox.Location = new System.Drawing.Point(768, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search...";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(200, 36);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TextOffset = new System.Drawing.Point(10, 0);
            this.SearchBox.WordWrap = false;
            this.SearchBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.ControlBox = false;
            this.Controls.Add(this.flowSearch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelNr);
            this.Controls.Add(this.panelPie);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "formDashboard";
            this.Activated += new System.EventHandler(this.formDashboard_Activated);
            this.Load += new System.EventHandler(this.formDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDep)).EndInit();
            this.panelPie.ResumeLayout(false);
            this.panelNr.ResumeLayout(false);
            this.panelNr.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.panelTxtNote.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDep;
        private Guna.UI2.WinForms.Guna2Panel panelPie;
        private Guna.UI2.WinForms.Guna2Panel panelNr;
        private System.Windows.Forms.Label lblNrTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblNr;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI2.WinForms.Guna2Panel panelTxtNote;
        private Guna.UI2.WinForms.Guna2DateTimePicker date1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowSearch;
    }
}