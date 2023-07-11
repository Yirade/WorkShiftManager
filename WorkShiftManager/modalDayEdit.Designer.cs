namespace WorkShiftManager
{
    partial class modalDayEdit
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timeEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblName.Size = new System.Drawing.Size(300, 42);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Saturday";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Controls.Add(this.timeEnd);
            this.guna2Panel1.Controls.Add(this.timeStart);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(20, 50);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(260, 180);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // timeStart
            // 
            this.timeStart.AutoRoundedCorners = true;
            this.timeStart.BackColor = System.Drawing.Color.Transparent;
            this.timeStart.BorderRadius = 17;
            this.timeStart.Checked = true;
            this.timeStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeStart.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.ForeColor = System.Drawing.Color.White;
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timeStart.Location = new System.Drawing.Point(99, 21);
            this.timeStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(140, 36);
            this.timeStart.TabIndex = 2;
            this.timeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeStart.Value = new System.DateTime(2023, 7, 11, 9, 0, 0, 0);
            // 
            // timeEnd
            // 
            this.timeEnd.AutoRoundedCorners = true;
            this.timeEnd.BackColor = System.Drawing.Color.Transparent;
            this.timeEnd.BorderRadius = 17;
            this.timeEnd.Checked = true;
            this.timeEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.ForeColor = System.Drawing.Color.White;
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timeEnd.Location = new System.Drawing.Point(99, 74);
            this.timeEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(140, 36);
            this.timeEnd.TabIndex = 3;
            this.timeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeEnd.Value = new System.DateTime(2023, 7, 11, 18, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.btnCancel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnCancel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.btnCancel.Location = new System.Drawing.Point(155, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 45);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 21;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(20, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 45);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 21;
            this.btnDelete.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.btnDelete.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.btnDelete.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
            this.btnDelete.Location = new System.Drawing.Point(67, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // modalDayEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modalDayEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Day Edit";
            this.Load += new System.EventHandler(this.modalDayEdit_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeEnd;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}