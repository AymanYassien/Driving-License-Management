namespace DriverCarLicences
{
    partial class frm_Add_UpdateUser
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
            this.TablInfo = new System.Windows.Forms.TabControl();
            this.Personal = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.cntrlPersonalInfoWithfilter1 = new DriverCarLicences.cntrlPersonalInfoWithfilter();
            this.Login = new System.Windows.Forms.TabPage();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.lblPesonID_Txt = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbConfirmPwd = new System.Windows.Forms.TextBox();
            this.tbPWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.TablInfo.SuspendLayout();
            this.Personal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // TablInfo
            // 
            this.TablInfo.Controls.Add(this.Personal);
            this.TablInfo.Controls.Add(this.Login);
            this.TablInfo.Location = new System.Drawing.Point(23, 130);
            this.TablInfo.Name = "TablInfo";
            this.TablInfo.SelectedIndex = 0;
            this.TablInfo.Size = new System.Drawing.Size(1581, 894);
            this.TablInfo.TabIndex = 0;
            this.TablInfo.SelectedIndexChanged += new System.EventHandler(this.TablInfo_SelectedIndexChanged);
            // 
            // Personal
            // 
            this.Personal.Controls.Add(this.pictureBox1);
            this.Personal.Controls.Add(this.btnNext);
            this.Personal.Controls.Add(this.cntrlPersonalInfoWithfilter1);
            this.Personal.Location = new System.Drawing.Point(8, 39);
            this.Personal.Name = "Personal";
            this.Personal.Padding = new System.Windows.Forms.Padding(3);
            this.Personal.Size = new System.Drawing.Size(1565, 847);
            this.Personal.TabIndex = 0;
            this.Personal.Text = "Personal Info";
            this.Personal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DriverCarLicences.Properties.Resources.Next_32_1_;
            this.pictureBox1.Location = new System.Drawing.Point(1449, 774);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(1295, 763);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(200, 56);
            this.btnNext.TabIndex = 117;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cntrlPersonalInfoWithfilter1
            // 
            this.cntrlPersonalInfoWithfilter1.AllowDrop = true;
            this.cntrlPersonalInfoWithfilter1.EnableFilter = true;
            this.cntrlPersonalInfoWithfilter1.Location = new System.Drawing.Point(6, 3);
            this.cntrlPersonalInfoWithfilter1.Name = "cntrlPersonalInfoWithfilter1";
            this.cntrlPersonalInfoWithfilter1.ShowAddPerson = true;
            this.cntrlPersonalInfoWithfilter1.Size = new System.Drawing.Size(1541, 754);
            this.cntrlPersonalInfoWithfilter1.TabIndex = 0;
            this.cntrlPersonalInfoWithfilter1.onPersonSelected += new System.Action<int>(this.cntrlPersonalInfoWithfilter1_onPersonSelected);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.isActive);
            this.Login.Controls.Add(this.pictureBox2);
            this.Login.Controls.Add(this.pictureBox10);
            this.Login.Controls.Add(this.lblPersonIDValue);
            this.Login.Controls.Add(this.lblPesonID_Txt);
            this.Login.Controls.Add(this.pictureBox3);
            this.Login.Controls.Add(this.tbConfirmPwd);
            this.Login.Controls.Add(this.tbPWD);
            this.Login.Controls.Add(this.label1);
            this.Login.Controls.Add(this.label3);
            this.Login.Controls.Add(this.pictureBox6);
            this.Login.Controls.Add(this.tbUserName);
            this.Login.Controls.Add(this.label2);
            this.Login.Location = new System.Drawing.Point(8, 39);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(1565, 847);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login Info";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActive.Location = new System.Drawing.Point(419, 427);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(154, 35);
            this.isActive.TabIndex = 114;
            this.isActive.Text = "Is Active";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DriverCarLicences.Properties.Resources.Number_32_1_;
            this.pictureBox2.Location = new System.Drawing.Point(348, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 449;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Image = global::DriverCarLicences.Properties.Resources.Person_32_1_;
            this.pictureBox10.Location = new System.Drawing.Point(348, 196);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 447;
            this.pictureBox10.TabStop = false;
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIDValue.ForeColor = System.Drawing.Color.Red;
            this.lblPersonIDValue.Location = new System.Drawing.Point(412, 126);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(102, 39);
            this.lblPersonIDValue.TabIndex = 448;
            this.lblPersonIDValue.Text = "N/A";
            // 
            // lblPesonID_Txt
            // 
            this.lblPesonID_Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesonID_Txt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPesonID_Txt.Location = new System.Drawing.Point(144, 131);
            this.lblPesonID_Txt.Name = "lblPesonID_Txt";
            this.lblPesonID_Txt.Size = new System.Drawing.Size(175, 39);
            this.lblPesonID_Txt.TabIndex = 446;
            this.lblPesonID_Txt.Text = "User ID:";
            this.lblPesonID_Txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DriverCarLicences.Properties.Resources.Number_32_1_;
            this.pictureBox3.Location = new System.Drawing.Point(348, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 118;
            this.pictureBox3.TabStop = false;
            // 
            // tbConfirmPwd
            // 
            this.tbConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPwd.Location = new System.Drawing.Point(419, 347);
            this.tbConfirmPwd.MaxLength = 20;
            this.tbConfirmPwd.Name = "tbConfirmPwd";
            this.tbConfirmPwd.PasswordChar = '*';
            this.tbConfirmPwd.Size = new System.Drawing.Size(251, 31);
            this.tbConfirmPwd.TabIndex = 113;
            this.tbConfirmPwd.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPwd_Validating);
            // 
            // tbPWD
            // 
            this.tbPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPWD.Location = new System.Drawing.Point(419, 272);
            this.tbPWD.MaxLength = 20;
            this.tbPWD.Name = "tbPWD";
            this.tbPWD.PasswordChar = '*';
            this.tbPWD.Size = new System.Drawing.Size(251, 31);
            this.tbPWD.TabIndex = 112;
            this.tbPWD.Validating += new System.ComponentModel.CancelEventHandler(this.tbPWD_Validating);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(138, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 115;
            this.label1.Text = "Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(26, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 39);
            this.label3.TabIndex = 116;
            this.label3.Text = "Confirm Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::DriverCarLicences.Properties.Resources.Number_32_1_;
            this.pictureBox6.Location = new System.Drawing.Point(348, 138);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 112;
            this.pictureBox6.TabStop = false;
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Location = new System.Drawing.Point(419, 189);
            this.tbUserName.MaxLength = 20;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(251, 31);
            this.tbUserName.TabIndex = 111;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(122, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 39);
            this.label2.TabIndex = 110;
            this.label2.Text = "User Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(585, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(398, 54);
            this.lblTitle.TabIndex = 112;
            this.lblTitle.Text = "Add New User";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1427, 1055);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 13, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 56);
            this.btnSave.TabIndex = 113;
            this.btnSave.Text = "  Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox11.Image = global::DriverCarLicences.Properties.Resources.Save_32_1_;
            this.pictureBox11.Location = new System.Drawing.Point(1444, 1068);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 115;
            this.pictureBox11.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox12.Image = global::DriverCarLicences.Properties.Resources.Close_32_1_;
            this.pictureBox12.Location = new System.Drawing.Point(1217, 1068);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 118;
            this.pictureBox12.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1202, 1055);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 56);
            this.btnClose.TabIndex = 117;
            this.btnClose.Text = " Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frm_Add_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1635, 1143);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.TablInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_UpdateUser";
            this.ShowIcon = false;
            this.Text = "Add/UpdateUser";
            this.Load += new System.EventHandler(this.frm_Add_UpdateUser_Load);
            this.TablInfo.ResumeLayout(false);
            this.Personal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TablInfo;
        private System.Windows.Forms.TabPage Personal;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbConfirmPwd;
        private System.Windows.Forms.TextBox tbPWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblPersonIDValue;
        private System.Windows.Forms.Label lblPesonID_Txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox isActive;
        private cntrlPersonalInfoWithfilter cntrlPersonalInfoWithfilter1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button btnClose;
    }
}