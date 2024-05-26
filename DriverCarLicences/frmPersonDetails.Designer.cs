namespace DriverCarLicences
{
    partial class frmPersonDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonInfo_1 = new DriverCarLicences.ctrlPersonInfo_();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(611, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // ctrlPersonInfo_1
            // 
            this.ctrlPersonInfo_1.AllowDrop = true;
            this.ctrlPersonInfo_1.Location = new System.Drawing.Point(12, 139);
            this.ctrlPersonInfo_1.Name = "ctrlPersonInfo_1";
            this.ctrlPersonInfo_1.Size = new System.Drawing.Size(1553, 576);
            this.ctrlPersonInfo_1.TabIndex = 0;
            this.ctrlPersonInfo_1.Load += new System.EventHandler(this.ctrlPersonInfo_1_Load);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox12.Image = global::DriverCarLicences.Properties.Resources.Close_32_1_;
            this.pictureBox12.Location = new System.Drawing.Point(1377, 763);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 115;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1364, 750);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 56);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = " Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1613, 868);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonInfo_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonDetails";
            this.ShowIcon = false;
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.PersonDetails1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonInfo_ ctrlPersonInfo_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button btnClose;
    }
}