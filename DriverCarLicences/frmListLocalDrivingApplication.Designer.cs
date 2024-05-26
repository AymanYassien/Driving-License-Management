namespace DriverCarLicences
{
    partial class frmListLocalDrivingApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLocalDrivingApplication));
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.Records = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NotSetTitle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Updagte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleStrretTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Issue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.LicensesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.NotSetTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilter.Location = new System.Drawing.Point(546, 392);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(262, 31);
            this.tbFilter.TabIndex = 29;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCounter.Location = new System.Drawing.Point(193, 878);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(46, 31);
            this.lblCounter.TabIndex = 28;
            this.lblCounter.Text = "??";
            // 
            // Records
            // 
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.ForeColor = System.Drawing.Color.Black;
            this.Records.Location = new System.Drawing.Point(15, 872);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(152, 31);
            this.Records.TabIndex = 24;
            this.Records.Text = "#Records:    ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 21;
            this.dataGridView1.ContextMenuStrip = this.NotSetTitle;
            this.dataGridView1.Location = new System.Drawing.Point(21, 477);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1764, 361);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // NotSetTitle
            // 
            this.NotSetTitle.DropShadowEnabled = false;
            this.NotSetTitle.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.NotSetTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetail,
            this.toolStripSeparator1,
            this.Updagte,
            this.toolStripSeparator5,
            this.Delete,
            this.toolStripSeparator2,
            this.ScheduleTest,
            this.toolStripSeparator3,
            this.Issue,
            this.toolStripSeparator4,
            this.ShowLicense,
            this.toolStripSeparator6,
            this.LicensesHistory});
            this.NotSetTitle.Name = "contextMenuStrip1";
            this.NotSetTitle.Size = new System.Drawing.Size(533, 320);
            this.NotSetTitle.Text = "Show Details";
            // 
            // showDetail
            // 
            this.showDetail.Image = global::DriverCarLicences.Properties.Resources.PersonDetails_32_1_;
            this.showDetail.Name = "showDetail";
            this.showDetail.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.showDetail.Size = new System.Drawing.Size(532, 40);
            this.showDetail.Text = "Show Appplication Details";
            this.showDetail.Click += new System.EventHandler(this.showDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(529, 6);
            // 
            // Updagte
            // 
            this.Updagte.Image = global::DriverCarLicences.Properties.Resources.edit_32_1_;
            this.Updagte.Name = "Updagte";
            this.Updagte.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.Updagte.Size = new System.Drawing.Size(532, 40);
            this.Updagte.Text = "Edit Application";
            this.Updagte.Click += new System.EventHandler(this.Updagte_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(529, 6);
            // 
            // Delete
            // 
            this.Delete.Image = global::DriverCarLicences.Properties.Resources.Delete_32_1_;
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.Delete.Size = new System.Drawing.Size(532, 40);
            this.Delete.Text = "Cancel Application";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(529, 6);
            // 
            // ScheduleTest
            // 
            this.ScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScheduleVisionTest,
            this.ScheduleWrittenTest,
            this.ScheduleStrretTest});
            this.ScheduleTest.Image = global::DriverCarLicences.Properties.Resources.Schedule_Test_32;
            this.ScheduleTest.Name = "ScheduleTest";
            this.ScheduleTest.Size = new System.Drawing.Size(532, 40);
            this.ScheduleTest.Text = "Schedule Test";
            // 
            // ScheduleVisionTest
            // 
            this.ScheduleVisionTest.Image = global::DriverCarLicences.Properties.Resources.Vision_Test_32;
            this.ScheduleVisionTest.Name = "ScheduleVisionTest";
            this.ScheduleVisionTest.Size = new System.Drawing.Size(380, 44);
            this.ScheduleVisionTest.Text = "Schedule Vision Test";
            // 
            // ScheduleWrittenTest
            // 
            this.ScheduleWrittenTest.Enabled = false;
            this.ScheduleWrittenTest.Image = global::DriverCarLicences.Properties.Resources.Written_Test_32;
            this.ScheduleWrittenTest.Name = "ScheduleWrittenTest";
            this.ScheduleWrittenTest.Size = new System.Drawing.Size(380, 44);
            this.ScheduleWrittenTest.Text = "Schedule Written Test";
            // 
            // ScheduleStrretTest
            // 
            this.ScheduleStrretTest.Enabled = false;
            this.ScheduleStrretTest.Image = global::DriverCarLicences.Properties.Resources.Street_Test_32;
            this.ScheduleStrretTest.Name = "ScheduleStrretTest";
            this.ScheduleStrretTest.Size = new System.Drawing.Size(380, 44);
            this.ScheduleStrretTest.Text = "Schedule Street Test";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(529, 6);
            // 
            // Issue
            // 
            this.Issue.Enabled = false;
            this.Issue.Image = global::DriverCarLicences.Properties.Resources.IssueDrivingLicense_32;
            this.Issue.Name = "Issue";
            this.Issue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.Issue.Size = new System.Drawing.Size(532, 40);
            this.Issue.Text = "Issue Driving License (First Time)";
            this.Issue.Click += new System.EventHandler(this.Issue_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(529, 6);
            // 
            // ShowLicense
            // 
            this.ShowLicense.Enabled = false;
            this.ShowLicense.Image = global::DriverCarLicences.Properties.Resources.License_View_32;
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.ShowLicense.Size = new System.Drawing.Size(532, 40);
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(529, 6);
            // 
            // LicensesHistory
            // 
            this.LicensesHistory.Image = global::DriverCarLicences.Properties.Resources.PersonLicenseHistory_32;
            this.LicensesHistory.Name = "LicensesHistory";
            this.LicensesHistory.Size = new System.Drawing.Size(532, 40);
            this.LicensesHistory.Text = "Show Person License History";
            this.LicensesHistory.Click += new System.EventHandler(this.LicensesHistory_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 555;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 300;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National Number",
            "Full Name",
            "Status"});
            this.comboBox1.Location = new System.Drawing.Point(164, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 37);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(590, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 57);
            this.label1.TabIndex = 20;
            this.label1.Text = "Local Driving License Application";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DriverCarLicences.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(1008, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverCarLicences.Properties.Resources.Manage_Applications_641;
            this.pictureBox1.Location = new System.Drawing.Point(709, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::DriverCarLicences.Properties.Resources.New_Driving_License_32;
            this.btnAdd.Location = new System.Drawing.Point(1665, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 117);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DriverCarLicences.Properties.Resources.Close_32_1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1593, 858);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 3, 13, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 64);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1819, 954);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListLocalDrivingApplication";
            this.Text = "List Local Driving Application";
            this.Load += new System.EventHandler(this.frmListLocalDrivingApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.NotSetTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip NotSetTitle;
        private System.Windows.Forms.ToolStripMenuItem showDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Updagte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleStrretTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Issue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem LicensesHistory;
    }
}