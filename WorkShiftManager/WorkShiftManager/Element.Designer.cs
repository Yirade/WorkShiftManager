namespace WorkShiftManager
{
    partial class Element
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMore = new Guna.UI2.WinForms.Guna2Button();
            this.imgElement = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgElement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(123, 7);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(371, 20);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(181, 25);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "user@exemple.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(125, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(122, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "user@exemple.com";
            this.lblEmail.Click += new System.EventHandler(this.lblId_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 25);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "#000";
            this.lblId.Click += new System.EventHandler(this.lblDepartment_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 14;
            this.btnDelete.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.remove_hover;
            this.btnDelete.CustomImages.Image = global::WorkShiftManager.Properties.Resources.remove;
            this.btnDelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnDelete.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(740, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 14;
            this.btnEdit.CustomImages.CheckedImage = global::WorkShiftManager.Properties.Resources.pen_click;
            this.btnEdit.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.pen_click;
            this.btnEdit.CustomImages.Image = global::WorkShiftManager.Properties.Resources.pen;
            this.btnEdit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnEdit.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(693, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.Animated = true;
            this.btnMore.AutoRoundedCorners = true;
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.BorderRadius = 14;
            this.btnMore.CustomImages.HoveredImage = global::WorkShiftManager.Properties.Resources.ellipsis_hover;
            this.btnMore.CustomImages.Image = global::WorkShiftManager.Properties.Resources.ellipsis;
            this.btnMore.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMore.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnMore.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMore.ForeColor = System.Drawing.Color.White;
            this.btnMore.Location = new System.Drawing.Point(787, 15);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(30, 30);
            this.btnMore.TabIndex = 11;
            this.btnMore.UseTransparentBackground = true;
            // 
            // imgElement
            // 
            this.imgElement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgElement.BackColor = System.Drawing.Color.Transparent;
            this.imgElement.Image = global::WorkShiftManager.Properties.Resources.user;
            this.imgElement.ImageRotate = 0F;
            this.imgElement.Location = new System.Drawing.Point(65, 7);
            this.imgElement.Name = "imgElement";
            this.imgElement.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgElement.Size = new System.Drawing.Size(50, 50);
            this.imgElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgElement.TabIndex = 0;
            this.imgElement.TabStop = false;
            this.imgElement.UseTransparentBackground = true;
            this.imgElement.Click += new System.EventHandler(this.imgElement_Click);
            // 
            // Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgElement);
            this.Name = "Element";
            this.Size = new System.Drawing.Size(833, 64);
            this.Load += new System.EventHandler(this.Element_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox imgElement;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnMore;
    }
}
