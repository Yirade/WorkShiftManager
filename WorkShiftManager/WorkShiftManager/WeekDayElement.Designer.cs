namespace WorkShiftManager
{
    partial class WeekDayElement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBg = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPlus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnMinus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblNr = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.AutoRoundedCorners = true;
            this.panelBg.BorderRadius = 24;
            this.panelBg.Controls.Add(this.lblNr);
            this.panelBg.Controls.Add(this.btnMinus);
            this.panelBg.Controls.Add(this.btnPlus);
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(200, 50);
            this.panelBg.TabIndex = 0;
            this.panelBg.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBg_Paint);
            // 
            // btnPlus
            // 
            this.btnPlus.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlus.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlus.Image = global::WorkShiftManager.Properties.Resources.plus1;
            this.btnPlus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlus.ImageRotate = 0F;
            this.btnPlus.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlus.Location = new System.Drawing.Point(148, 10);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlus.Size = new System.Drawing.Size(30, 30);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinus.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinus.Image = global::WorkShiftManager.Properties.Resources.minus;
            this.btnMinus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinus.ImageRotate = 0F;
            this.btnMinus.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinus.Location = new System.Drawing.Point(19, 10);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNr.Location = new System.Drawing.Point(68, 13);
            this.lblNr.MaximumSize = new System.Drawing.Size(61, 25);
            this.lblNr.MinimumSize = new System.Drawing.Size(61, 25);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(61, 25);
            this.lblNr.TabIndex = 2;
            this.lblNr.Text = "12";
            this.lblNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeekDayElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelBg);
            this.Name = "WeekDayElement";
            this.Size = new System.Drawing.Size(200, 50);
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBg;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlus;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinus;
        private System.Windows.Forms.Label lblNr;
    }
}
