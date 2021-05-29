namespace SMS.Forms
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.btnStudentRemove = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblStudentSearch = new System.Windows.Forms.Label();
            this.txtbxSearchStudent = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uptadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxstudentform = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchByIdS = new System.Windows.Forms.GroupBox();
            this.groupBoxSearchByDepSt = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchByDepSt = new System.Windows.Forms.ComboBox();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.labelnumberofStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxstudentform.SuspendLayout();
            this.groupBoxSearchByIdS.SuspendLayout();
            this.groupBoxSearchByDepSt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudentRemove
            // 
            this.btnStudentRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnStudentRemove, "btnStudentRemove");
            this.btnStudentRemove.Name = "btnStudentRemove";
            this.btnStudentRemove.UseVisualStyleBackColor = false;
            this.btnStudentRemove.Click += new System.EventHandler(this.btnStudentRemove_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.GridColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.dgvStudents, "dgvStudents");
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // lblStudent
            // 
            resources.ApplyResources(this.lblStudent, "lblStudent");
            this.lblStudent.ForeColor = System.Drawing.Color.LightGray;
            this.lblStudent.Name = "lblStudent";
            // 
            // lblStudentSearch
            // 
            resources.ApplyResources(this.lblStudentSearch, "lblStudentSearch");
            this.lblStudentSearch.ForeColor = System.Drawing.Color.LightGray;
            this.lblStudentSearch.Name = "lblStudentSearch";
            // 
            // txtbxSearchStudent
            // 
            resources.ApplyResources(this.txtbxSearchStudent, "txtbxSearchStudent");
            this.txtbxSearchStudent.Name = "txtbxSearchStudent";
            this.txtbxSearchStudent.TextChanged += new System.EventHandler(this.txtbxSearchStudent_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.addToolStripMenuItem,
            this.uptadeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // uptadeToolStripMenuItem
            // 
            this.uptadeToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.uptadeToolStripMenuItem, "uptadeToolStripMenuItem");
            this.uptadeToolStripMenuItem.Name = "uptadeToolStripMenuItem";
            this.uptadeToolStripMenuItem.Click += new System.EventHandler(this.uptadeToolStripMenuItem_Click);
            // 
            // groupBoxstudentform
            // 
            resources.ApplyResources(this.groupBoxstudentform, "groupBoxstudentform");
            this.groupBoxstudentform.Controls.Add(this.labelnumberofStudent);
            this.groupBoxstudentform.Controls.Add(this.groupBoxSearchByIdS);
            this.groupBoxstudentform.Controls.Add(this.groupBoxSearchByDepSt);
            this.groupBoxstudentform.Controls.Add(this.btnStudentRemove);
            this.groupBoxstudentform.Controls.Add(this.lblStudent);
            this.groupBoxstudentform.Controls.Add(this.dgvStudents);
            this.groupBoxstudentform.Name = "groupBoxstudentform";
            this.groupBoxstudentform.TabStop = false;
            // 
            // groupBoxSearchByIdS
            // 
            this.groupBoxSearchByIdS.Controls.Add(this.lblStudentSearch);
            this.groupBoxSearchByIdS.Controls.Add(this.txtbxSearchStudent);
            resources.ApplyResources(this.groupBoxSearchByIdS, "groupBoxSearchByIdS");
            this.groupBoxSearchByIdS.ForeColor = System.Drawing.Color.LightGray;
            this.groupBoxSearchByIdS.Name = "groupBoxSearchByIdS";
            this.groupBoxSearchByIdS.TabStop = false;
            // 
            // groupBoxSearchByDepSt
            // 
            this.groupBoxSearchByDepSt.Controls.Add(this.label2);
            this.groupBoxSearchByDepSt.Controls.Add(this.comboBoxSearchByDepSt);
            resources.ApplyResources(this.groupBoxSearchByDepSt, "groupBoxSearchByDepSt");
            this.groupBoxSearchByDepSt.ForeColor = System.Drawing.Color.LightGray;
            this.groupBoxSearchByDepSt.Name = "groupBoxSearchByDepSt";
            this.groupBoxSearchByDepSt.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Name = "label2";
            // 
            // comboBoxSearchByDepSt
            // 
            this.comboBoxSearchByDepSt.FormattingEnabled = true;
            this.comboBoxSearchByDepSt.Items.AddRange(new object[] {
            resources.GetString("comboBoxSearchByDepSt.Items"),
            resources.GetString("comboBoxSearchByDepSt.Items1"),
            resources.GetString("comboBoxSearchByDepSt.Items2"),
            resources.GetString("comboBoxSearchByDepSt.Items3"),
            resources.GetString("comboBoxSearchByDepSt.Items4"),
            resources.GetString("comboBoxSearchByDepSt.Items5"),
            resources.GetString("comboBoxSearchByDepSt.Items6"),
            resources.GetString("comboBoxSearchByDepSt.Items7"),
            resources.GetString("comboBoxSearchByDepSt.Items8"),
            resources.GetString("comboBoxSearchByDepSt.Items9"),
            resources.GetString("comboBoxSearchByDepSt.Items10"),
            resources.GetString("comboBoxSearchByDepSt.Items11"),
            resources.GetString("comboBoxSearchByDepSt.Items12"),
            resources.GetString("comboBoxSearchByDepSt.Items13"),
            resources.GetString("comboBoxSearchByDepSt.Items14")});
            resources.ApplyResources(this.comboBoxSearchByDepSt, "comboBoxSearchByDepSt");
            this.comboBoxSearchByDepSt.Name = "comboBoxSearchByDepSt";
            this.comboBoxSearchByDepSt.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchByDepSt_SelectedIndexChanged);
            // 
            // buttonMini
            // 
            resources.ApplyResources(this.buttonMini, "buttonMini");
            this.buttonMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.UseVisualStyleBackColor = false;
            this.buttonMini.Click += new System.EventHandler(this.buttonMini_Click);
            // 
            // buttonMax
            // 
            resources.ApplyResources(this.buttonMax, "buttonMax");
            this.buttonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonEx
            // 
            resources.ApplyResources(this.buttonEx, "buttonEx");
            this.buttonEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // labelnumberofStudent
            // 
            resources.ApplyResources(this.labelnumberofStudent, "labelnumberofStudent");
            this.labelnumberofStudent.ForeColor = System.Drawing.Color.LightGray;
            this.labelnumberofStudent.Name = "labelnumberofStudent";
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.buttonMini);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.groupBoxstudentform);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxstudentform.ResumeLayout(false);
            this.groupBoxstudentform.PerformLayout();
            this.groupBoxSearchByIdS.ResumeLayout(false);
            this.groupBoxSearchByIdS.PerformLayout();
            this.groupBoxSearchByDepSt.ResumeLayout(false);
            this.groupBoxSearchByDepSt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStudentRemove;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblStudentSearch;
        private System.Windows.Forms.TextBox txtbxSearchStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uptadeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxstudentform;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.GroupBox groupBoxSearchByDepSt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchByDepSt;
        private System.Windows.Forms.GroupBox groupBoxSearchByIdS;
        private System.Windows.Forms.Label labelnumberofStudent;
    }
}