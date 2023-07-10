namespace WorkShiftManager
{
    partial class SWidgetElement
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
            this.elemPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOpen = new Guna.UI2.WinForms.Guna2CircleButton();
            this.imgElement1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.imgElement2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.imgElement3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.elemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgElement1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgElement2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgElement3)).BeginInit();
            this.SuspendLayout();
            // 
            // elemPanel
            // 
            this.elemPanel.BorderRadius = 22;
            this.elemPanel.Controls.Add(this.btnOpen);
            this.elemPanel.Controls.Add(this.imgElement1);
            this.elemPanel.Controls.Add(this.imgElement2);
            this.elemPanel.Controls.Add(this.imgElement3);
            this.elemPanel.Controls.Add(this.lblName);
            this.elemPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.elemPanel.Location = new System.Drawing.Point(0, 0);
            this.elemPanel.Margin = new System.Windows.Forms.Padding(0);
            this.elemPanel.MaximumSize = new System.Drawing.Size(187, 150);
            this.elemPanel.MinimumSize = new System.Drawing.Size(187, 150);
            this.elemPanel.Name = "elemPanel";
            this.elemPanel.Size = new System.Drawing.Size(187, 150);
            this.elemPanel.TabIndex = 0;
            this.elemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.elemPanel_Paint);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.Animated = true;
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.CustomImages.CheckedImage = global::WorkShiftManager.Properties.Resources.routine_hovered;
            this.btnOpen.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.routine_hovered;
            this.btnOpen.CustomImages.Image = global::WorkShiftManager.Properties.Resources.routine;
            this.btnOpen.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOpen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(10, 92);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnOpen.Size = new System.Drawing.Size(50, 50);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imgElement1
            // 
            this.imgElement1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgElement1.BackColor = System.Drawing.Color.Transparent;
            this.imgElement1.FillColor = System.Drawing.Color.Transparent;
            this.imgElement1.ImageRotate = 0F;
            this.imgElement1.Location = new System.Drawing.Point(146, 110);
            this.imgElement1.Name = "imgElement1";
            this.imgElement1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgElement1.Size = new System.Drawing.Size(32, 32);
            this.imgElement1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgElement1.TabIndex = 10;
            this.imgElement1.TabStop = false;
            this.imgElement1.UseTransparentBackground = true;
            this.imgElement1.Click += new System.EventHandler(this.imgElement3_Click);
            // 
            // imgElement2
            // 
            this.imgElement2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgElement2.BackColor = System.Drawing.Color.Transparent;
            this.imgElement2.FillColor = System.Drawing.Color.Transparent;
            this.imgElement2.ImageRotate = 0F;
            this.imgElement2.Location = new System.Drawing.Point(129, 110);
            this.imgElement2.Name = "imgElement2";
            this.imgElement2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgElement2.Size = new System.Drawing.Size(32, 32);
            this.imgElement2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgElement2.TabIndex = 9;
            this.imgElement2.TabStop = false;
            this.imgElement2.UseTransparentBackground = true;
            this.imgElement2.Click += new System.EventHandler(this.imgElement2_Click);
            // 
            // imgElement3
            // 
            this.imgElement3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgElement3.BackColor = System.Drawing.Color.Transparent;
            this.imgElement3.FillColor = System.Drawing.Color.Transparent;
            this.imgElement3.ImageRotate = 0F;
            this.imgElement3.Location = new System.Drawing.Point(112, 110);
            this.imgElement3.Name = "imgElement3";
            this.imgElement3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgElement3.Size = new System.Drawing.Size(32, 32);
            this.imgElement3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgElement3.TabIndex = 8;
            this.imgElement3.TabStop = false;
            this.imgElement3.UseTransparentBackground = true;
            this.imgElement3.Click += new System.EventHandler(this.imgElement1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.MaximumSize = new System.Drawing.Size(187, 0);
            this.lblName.MinimumSize = new System.Drawing.Size(187, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblName.Size = new System.Drawing.Size(187, 74);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Human Resources";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // SWidgetElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elemPanel);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "SWidgetElement";
            this.Size = new System.Drawing.Size(187, 150);
            this.Load += new System.EventHandler(this.elementSWidget_Load);
            this.elemPanel.ResumeLayout(false);
            this.elemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgElement1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgElement2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgElement3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel elemPanel;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgElement1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgElement2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgElement3;
        private Guna.UI2.WinForms.Guna2CircleButton btnOpen;
    }
}
