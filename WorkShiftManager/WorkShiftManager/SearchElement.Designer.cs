namespace WorkShiftManager
{
    partial class SearchElement
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
            this.imgProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProfile
            // 
            this.imgProfile.Image = global::WorkShiftManager.Properties.Resources.user;
            this.imgProfile.ImageRotate = 0F;
            this.imgProfile.InitialImage = global::WorkShiftManager.Properties.Resources.user;
            this.imgProfile.Location = new System.Drawing.Point(7, 3);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgProfile.Size = new System.Drawing.Size(36, 36);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 0;
            this.imgProfile.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(49, 24);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(68, 13);
            this.lblDep.TabIndex = 2;
            this.lblDep.Text = "Department";
            // 
            // SearchElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgProfile);
            this.Name = "SearchElement";
            this.Size = new System.Drawing.Size(200, 40);
            this.Load += new System.EventHandler(this.SearchElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox imgProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDep;
    }
}
