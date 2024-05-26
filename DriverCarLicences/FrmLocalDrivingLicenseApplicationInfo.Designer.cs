namespace DriverCarLicences
{
    partial class FrmLocalDrivingLicenseApplicationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalDrivingLicenseApplicationInfo));
            this.cntrlLocalDrivingLicenseApplicationInfo1 = new DriverCarLicences.cntrlLocalDrivingLicenseApplicationInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntrlLocalDrivingLicenseApplicationInfo1
            // 
            this.cntrlLocalDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.cntrlLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.cntrlLocalDrivingLicenseApplicationInfo1.Name = "cntrlLocalDrivingLicenseApplicationInfo1";
            this.cntrlLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(1532, 759);
            this.cntrlLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DriverCarLicences.Properties.Resources.Close_32_1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1338, 809);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 3, 13, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 64);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1552, 902);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cntrlLocalDrivingLicenseApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocalDrivingLicenseApplicationInfo";
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.FrmLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private cntrlLocalDrivingLicenseApplicationInfo cntrlLocalDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}