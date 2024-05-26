namespace DriverCarLicences
{
    partial class frmFindPerson
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
            this.cntrlPersonalInfoWithfilter1 = new DriverCarLicences.cntrlPersonalInfoWithfilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(665, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Person";
            // 
            // cntrlPersonalInfoWithfilter1
            // 
            this.cntrlPersonalInfoWithfilter1.AllowDrop = true;
            this.cntrlPersonalInfoWithfilter1.EnableFilter = false;
            this.cntrlPersonalInfoWithfilter1.Location = new System.Drawing.Point(13, 103);
            this.cntrlPersonalInfoWithfilter1.Name = "cntrlPersonalInfoWithfilter1";
            this.cntrlPersonalInfoWithfilter1.ShowAddPerson = true;
            this.cntrlPersonalInfoWithfilter1.Size = new System.Drawing.Size(1584, 895);
            this.cntrlPersonalInfoWithfilter1.TabIndex = 1;
            // 
            // FindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1609, 1010);
            this.Controls.Add(this.cntrlPersonalInfoWithfilter1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindPerson";
            this.ShowIcon = false;
            this.Text = "FindPerson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindPerson_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private cntrlPersonalInfoWithfilter cntrlPersonalInfoWithfilter1;
    }
}