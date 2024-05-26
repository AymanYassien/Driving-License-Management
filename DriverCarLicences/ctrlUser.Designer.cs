namespace DriverCarLicences
{
    partial class ctrlUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlPersonInfo_1 = new DriverCarLicences.ctrlPersonInfo_();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 591);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1514, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // lblIsActive
            // 
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIsActive.Location = new System.Drawing.Point(1279, 56);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(136, 37);
            this.lblIsActive.TabIndex = 130;
            this.lblIsActive.Text = "???";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(1083, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 35);
            this.label4.TabIndex = 129;
            this.label4.Text = "Is Active:";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserName.Location = new System.Drawing.Point(795, 62);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(196, 37);
            this.lblUserName.TabIndex = 128;
            this.lblUserName.Text = "???";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(502, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 35);
            this.label2.TabIndex = 127;
            this.label2.Text = "User Name:";
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserID.Location = new System.Drawing.Point(289, 60);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(136, 37);
            this.lblUserID.TabIndex = 126;
            this.lblUserID.Text = "???";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(97, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 35);
            this.label5.TabIndex = 124;
            this.label5.Text = "User ID:";
            // 
            // ctrlPersonInfo_1
            // 
            this.ctrlPersonInfo_1.AllowDrop = true;
            this.ctrlPersonInfo_1.Location = new System.Drawing.Point(12, 16);
            this.ctrlPersonInfo_1.Name = "ctrlPersonInfo_1";
            this.ctrlPersonInfo_1.Size = new System.Drawing.Size(1580, 569);
            this.ctrlPersonInfo_1.TabIndex = 0;
            // 
            // ctrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersonInfo_1);
            this.Name = "ctrlUser";
            this.Size = new System.Drawing.Size(1579, 773);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo_ ctrlPersonInfo_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label4;
    }
}
