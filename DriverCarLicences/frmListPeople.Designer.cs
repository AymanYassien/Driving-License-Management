namespace DriverCarLicences
{
    partial class frmListPeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NotSetTitle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Updagte = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.email = new System.Windows.Forms.ToolStripMenuItem();
            this.phone = new System.Windows.Forms.ToolStripMenuItem();
            this.Records = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.NotSetTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(967, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter By:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 555;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 300;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(171, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 37);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2104, 361);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // NotSetTitle
            // 
            this.NotSetTitle.DropShadowEnabled = false;
            this.NotSetTitle.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.NotSetTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetail,
            this.toolStripSeparator1,
            this.Add,
            this.Updagte,
            this.Delete,
            this.toolStripSeparator2,
            this.email,
            this.phone});
            this.NotSetTitle.Name = "contextMenuStrip1";
            this.NotSetTitle.Size = new System.Drawing.Size(329, 256);
            this.NotSetTitle.Text = "Show Details";
            // 
            // showDetail
            // 
            this.showDetail.Image = global::DriverCarLicences.Properties.Resources.PersonDetails_32_1_;
            this.showDetail.Name = "showDetail";
            this.showDetail.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.showDetail.Size = new System.Drawing.Size(328, 40);
            this.showDetail.Text = "Show Details";
            this.showDetail.Click += new System.EventHandler(this.showDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(325, 6);
            // 
            // Add
            // 
            this.Add.Image = global::DriverCarLicences.Properties.Resources.AddPerson_32_1_;
            this.Add.Name = "Add";
            this.Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.Add.Size = new System.Drawing.Size(328, 40);
            this.Add.Text = "Add Person";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Updagte
            // 
            this.Updagte.Image = global::DriverCarLicences.Properties.Resources.edit_32_1_;
            this.Updagte.Name = "Updagte";
            this.Updagte.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.Updagte.Size = new System.Drawing.Size(328, 40);
            this.Updagte.Text = "Edit ";
            this.Updagte.Click += new System.EventHandler(this.Updagte_Click);
            // 
            // Delete
            // 
            this.Delete.Image = global::DriverCarLicences.Properties.Resources.Delete_32_1_;
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.Delete.Size = new System.Drawing.Size(328, 40);
            this.Delete.Text = "Delete Person";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(325, 6);
            // 
            // email
            // 
            this.email.Image = global::DriverCarLicences.Properties.Resources.send_email_32_1_;
            this.email.Name = "email";
            this.email.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.email.Size = new System.Drawing.Size(328, 40);
            this.email.Text = "Send Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // phone
            // 
            this.phone.Image = global::DriverCarLicences.Properties.Resources.call_32_1_;
            this.phone.Name = "phone";
            this.phone.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.phone.Size = new System.Drawing.Size(328, 40);
            this.phone.Text = "Phone Call";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // Records
            // 
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Records.ForeColor = System.Drawing.Color.Black;
            this.Records.Location = new System.Drawing.Point(22, 851);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(152, 31);
            this.Records.TabIndex = 4;
            this.Records.Text = "#Records:    ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriverCarLicences.Properties.Resources.People_64_1_;
            this.pictureBox1.Location = new System.Drawing.Point(977, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::DriverCarLicences.Properties.Resources.Add_Person_40_1_;
            this.btnAdd.Location = new System.Drawing.Point(1983, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 115);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DriverCarLicences.Properties.Resources.Close_32_1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1940, 837);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 64);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCounter.Location = new System.Drawing.Point(200, 857);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(46, 31);
            this.lblCounter.TabIndex = 8;
            this.lblCounter.Text = "??";
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2144, 935);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListPeople";
            this.ShowIcon = false;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.NotSetTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip NotSetTitle;
        private System.Windows.Forms.ToolStripMenuItem showDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private System.Windows.Forms.ToolStripMenuItem Updagte;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem email;
        private System.Windows.Forms.ToolStripMenuItem phone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCounter;
    }
}

