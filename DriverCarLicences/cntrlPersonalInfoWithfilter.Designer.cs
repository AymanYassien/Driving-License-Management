namespace DriverCarLicences
{
    partial class cntrlPersonalInfoWithfilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.ctrlPersonInfo_1 = new DriverCarLicences.ctrlPersonInfo_();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.btnAdd);
            this.gbFilter.Controls.Add(this.txtbFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(23, 32);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1510, 157);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::DriverCarLicences.Properties.Resources.SearchPerson_1_;
            this.btnSearch.Location = new System.Drawing.Point(877, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 66);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::DriverCarLicences.Properties.Resources.Add_Person_40_1_;
            this.btnAdd.Location = new System.Drawing.Point(1019, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 66);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbFilter
            // 
            this.txtbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbFilter.Location = new System.Drawing.Point(579, 78);
            this.txtbFilter.Name = "txtbFilter";
            this.txtbFilter.Size = new System.Drawing.Size(267, 38);
            this.txtbFilter.TabIndex = 6;
            this.txtbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilter_KeyPress);
            this.txtbFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtbFilter_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "National Number"});
            this.cbFilterBy.Location = new System.Drawing.Point(264, 78);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(286, 39);
            this.cbFilterBy.TabIndex = 2;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // ctrlPersonInfo_1
            // 
            this.ctrlPersonInfo_1.AllowDrop = true;
            this.ctrlPersonInfo_1.Location = new System.Drawing.Point(3, 195);
            this.ctrlPersonInfo_1.Name = "ctrlPersonInfo_1";
            this.ctrlPersonInfo_1.Size = new System.Drawing.Size(1580, 680);
            this.ctrlPersonInfo_1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cntrlPersonalInfoWithfilter
            // 
            this.AllowDrop = true;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonInfo_1);
            this.Name = "cntrlPersonalInfoWithfilter";
            this.Size = new System.Drawing.Size(1584, 895);
            this.Load += new System.EventHandler(this.cntrlPersonalInfoWithfilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private DriverCarLicences.cntrlPersonInfo_ cntrlPersonInfo1;
        private DriverCarLicences.ctrlPersonInfo_ ctrlPersonInfo_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFilterBY;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ctrlPersonInfo_ ctrlPersonInfo_1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
