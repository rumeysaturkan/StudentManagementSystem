namespace SMS.Forms
{
    partial class ControlStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlStudentForm));
            this.dgvCoSt = new System.Windows.Forms.DataGridView();
            this.lblCoStName = new System.Windows.Forms.Label();
            this.lblCoStDep = new System.Windows.Forms.Label();
            this.lblCoStGender = new System.Windows.Forms.Label();
            this.txtbxCoStName = new System.Windows.Forms.TextBox();
            this.btnAddSt = new System.Windows.Forms.Button();
            this.btnUptadeSt = new System.Windows.Forms.Button();
            this.btnRemoveSt = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblConAge = new System.Windows.Forms.Label();
            this.lblCoStSurname = new System.Windows.Forms.Label();
            this.txtbxCoStSurname = new System.Windows.Forms.TextBox();
            this.cbxCoStGender = new System.Windows.Forms.ComboBox();
            this.cbxCoStDe = new System.Windows.Forms.ComboBox();
            this.gbxCoTe = new System.Windows.Forms.GroupBox();
            this.txtbxCoStAge = new System.Windows.Forms.DomainUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.menuStripControlStudent = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocumentStudent = new System.Drawing.Printing.PrintDocument();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printPreviewDialogStudent = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoSt)).BeginInit();
            this.gbxCoTe.SuspendLayout();
            this.menuStripControlStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCoSt
            // 
            this.dgvCoSt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCoSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoSt.GridColor = System.Drawing.Color.LightGray;
            this.dgvCoSt.Location = new System.Drawing.Point(551, 94);
            this.dgvCoSt.Name = "dgvCoSt";
            this.dgvCoSt.RowHeadersWidth = 51;
            this.dgvCoSt.RowTemplate.Height = 24;
            this.dgvCoSt.Size = new System.Drawing.Size(947, 562);
            this.dgvCoSt.TabIndex = 0;
            this.dgvCoSt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAddSt_CellClick);
            // 
            // lblCoStName
            // 
            this.lblCoStName.AutoSize = true;
            this.lblCoStName.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoStName.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoStName.Location = new System.Drawing.Point(113, 22);
            this.lblCoStName.Name = "lblCoStName";
            this.lblCoStName.Size = new System.Drawing.Size(80, 28);
            this.lblCoStName.TabIndex = 1;
            this.lblCoStName.Text = "Name";
            // 
            // lblCoStDep
            // 
            this.lblCoStDep.AutoSize = true;
            this.lblCoStDep.Font = new System.Drawing.Font("Lucida Bright", 13F);
            this.lblCoStDep.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoStDep.Location = new System.Drawing.Point(114, 306);
            this.lblCoStDep.Name = "lblCoStDep";
            this.lblCoStDep.Size = new System.Drawing.Size(139, 24);
            this.lblCoStDep.TabIndex = 2;
            this.lblCoStDep.Text = "Department";
            // 
            // lblCoStGender
            // 
            this.lblCoStGender.AutoSize = true;
            this.lblCoStGender.Font = new System.Drawing.Font("Lucida Bright", 13F);
            this.lblCoStGender.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoStGender.Location = new System.Drawing.Point(114, 241);
            this.lblCoStGender.Name = "lblCoStGender";
            this.lblCoStGender.Size = new System.Drawing.Size(88, 24);
            this.lblCoStGender.TabIndex = 3;
            this.lblCoStGender.Text = "Gender";
            // 
            // txtbxCoStName
            // 
            this.txtbxCoStName.Location = new System.Drawing.Point(118, 58);
            this.txtbxCoStName.Name = "txtbxCoStName";
            this.txtbxCoStName.Size = new System.Drawing.Size(197, 22);
            this.txtbxCoStName.TabIndex = 4;
            // 
            // btnAddSt
            // 
            this.btnAddSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnAddSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSt.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSt.Location = new System.Drawing.Point(41, 416);
            this.btnAddSt.Name = "btnAddSt";
            this.btnAddSt.Size = new System.Drawing.Size(161, 61);
            this.btnAddSt.TabIndex = 7;
            this.btnAddSt.Text = "Add";
            this.btnAddSt.UseVisualStyleBackColor = false;
            this.btnAddSt.Click += new System.EventHandler(this.btnAddSt_Click);
            // 
            // btnUptadeSt
            // 
            this.btnUptadeSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnUptadeSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUptadeSt.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUptadeSt.Location = new System.Drawing.Point(231, 416);
            this.btnUptadeSt.Name = "btnUptadeSt";
            this.btnUptadeSt.Size = new System.Drawing.Size(161, 61);
            this.btnUptadeSt.TabIndex = 8;
            this.btnUptadeSt.Text = "Uptade";
            this.btnUptadeSt.UseVisualStyleBackColor = false;
            this.btnUptadeSt.Click += new System.EventHandler(this.btnUptadeSt_Click);
            // 
            // btnRemoveSt
            // 
            this.btnRemoveSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnRemoveSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSt.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSt.Location = new System.Drawing.Point(144, 492);
            this.btnRemoveSt.Name = "btnRemoveSt";
            this.btnRemoveSt.Size = new System.Drawing.Size(161, 61);
            this.btnRemoveSt.TabIndex = 9;
            this.btnRemoveSt.Text = "Remove";
            this.btnRemoveSt.UseVisualStyleBackColor = false;
            this.btnRemoveSt.Click += new System.EventHandler(this.btnRemoveSt_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.LightGray;
            this.lblStudent.Location = new System.Drawing.Point(545, 49);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(133, 32);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "Students";
            // 
            // lblConAge
            // 
            this.lblConAge.AutoSize = true;
            this.lblConAge.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConAge.ForeColor = System.Drawing.Color.LightGray;
            this.lblConAge.Location = new System.Drawing.Point(112, 165);
            this.lblConAge.Name = "lblConAge";
            this.lblConAge.Size = new System.Drawing.Size(66, 32);
            this.lblConAge.TabIndex = 11;
            this.lblConAge.Text = "Age";
            // 
            // lblCoStSurname
            // 
            this.lblCoStSurname.AutoSize = true;
            this.lblCoStSurname.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoStSurname.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoStSurname.Location = new System.Drawing.Point(112, 95);
            this.lblCoStSurname.Name = "lblCoStSurname";
            this.lblCoStSurname.Size = new System.Drawing.Size(134, 32);
            this.lblCoStSurname.TabIndex = 12;
            this.lblCoStSurname.Text = "Surname";
            // 
            // txtbxCoStSurname
            // 
            this.txtbxCoStSurname.Location = new System.Drawing.Point(118, 130);
            this.txtbxCoStSurname.Name = "txtbxCoStSurname";
            this.txtbxCoStSurname.Size = new System.Drawing.Size(197, 22);
            this.txtbxCoStSurname.TabIndex = 13;
            // 
            // cbxCoStGender
            // 
            this.cbxCoStGender.FormattingEnabled = true;
            this.cbxCoStGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbxCoStGender.Location = new System.Drawing.Point(118, 268);
            this.cbxCoStGender.Name = "cbxCoStGender";
            this.cbxCoStGender.Size = new System.Drawing.Size(197, 24);
            this.cbxCoStGender.TabIndex = 14;
            // 
            // cbxCoStDe
            // 
            this.cbxCoStDe.FormattingEnabled = true;
            this.cbxCoStDe.Items.AddRange(new object[] {
            "Architecture",
            "Chemical Engineering",
            "Computer Engineering",
            "Civil Engineering",
            "Environmental Engineering",
            "Electrical Engineering",
            "Civil Engineering",
            "Industrial Design",
            "Philosophy",
            "Physics",
            "Psychology",
            "Nursing",
            "Mathematics",
            "Mechanical Engineering",
            ""});
            this.cbxCoStDe.Location = new System.Drawing.Point(118, 344);
            this.cbxCoStDe.Name = "cbxCoStDe";
            this.cbxCoStDe.Size = new System.Drawing.Size(197, 24);
            this.cbxCoStDe.TabIndex = 15;
            // 
            // gbxCoTe
            // 
            this.gbxCoTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxCoTe.Controls.Add(this.txtbxCoStAge);
            this.gbxCoTe.Controls.Add(this.checkBox1);
            this.gbxCoTe.Controls.Add(this.lblCoStName);
            this.gbxCoTe.Controls.Add(this.cbxCoStDe);
            this.gbxCoTe.Controls.Add(this.btnRemoveSt);
            this.gbxCoTe.Controls.Add(this.btnAddSt);
            this.gbxCoTe.Controls.Add(this.btnUptadeSt);
            this.gbxCoTe.Controls.Add(this.cbxCoStGender);
            this.gbxCoTe.Controls.Add(this.txtbxCoStName);
            this.gbxCoTe.Controls.Add(this.txtbxCoStSurname);
            this.gbxCoTe.Controls.Add(this.lblCoStSurname);
            this.gbxCoTe.Controls.Add(this.lblConAge);
            this.gbxCoTe.Controls.Add(this.lblCoStGender);
            this.gbxCoTe.Controls.Add(this.lblCoStDep);
            this.gbxCoTe.Location = new System.Drawing.Point(107, 83);
            this.gbxCoTe.Name = "gbxCoTe";
            this.gbxCoTe.Size = new System.Drawing.Size(422, 573);
            this.gbxCoTe.TabIndex = 18;
            this.gbxCoTe.TabStop = false;
            // 
            // txtbxCoStAge
            // 
            this.txtbxCoStAge.Items.Add("28");
            this.txtbxCoStAge.Items.Add("27");
            this.txtbxCoStAge.Items.Add("26");
            this.txtbxCoStAge.Items.Add("25");
            this.txtbxCoStAge.Items.Add("24");
            this.txtbxCoStAge.Items.Add("23");
            this.txtbxCoStAge.Items.Add("22");
            this.txtbxCoStAge.Items.Add("21");
            this.txtbxCoStAge.Items.Add("20");
            this.txtbxCoStAge.Items.Add("19");
            this.txtbxCoStAge.Items.Add("18");
            this.txtbxCoStAge.Items.Add("17");
            this.txtbxCoStAge.Location = new System.Drawing.Point(118, 200);
            this.txtbxCoStAge.Name = "txtbxCoStAge";
            this.txtbxCoStAge.Size = new System.Drawing.Size(197, 22);
            this.txtbxCoStAge.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.LightGray;
            this.checkBox1.Location = new System.Drawing.Point(84, 374);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(260, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Please confirm your action";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonMini
            // 
            this.buttonMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.buttonMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMini.Location = new System.Drawing.Point(1482, 12);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(34, 34);
            this.buttonMini.TabIndex = 21;
            this.buttonMini.Text = "_";
            this.buttonMini.UseVisualStyleBackColor = false;
            this.buttonMini.Click += new System.EventHandler(this.buttonMini_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Location = new System.Drawing.Point(1522, 12);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(34, 34);
            this.buttonMax.TabIndex = 20;
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.buttonEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEx.Location = new System.Drawing.Point(1562, 12);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(34, 34);
            this.buttonEx.TabIndex = 19;
            this.buttonEx.Text = "X";
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // menuStripControlStudent
            // 
            this.menuStripControlStudent.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripControlStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripControlStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.homepageToolStripMenuItem});
            this.menuStripControlStudent.Location = new System.Drawing.Point(12, 9);
            this.menuStripControlStudent.Name = "menuStripControlStudent";
            this.menuStripControlStudent.Size = new System.Drawing.Size(266, 51);
            this.menuStripControlStudent.TabIndex = 22;
            this.menuStripControlStudent.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 47);
            this.toolStripMenuItem1.Text = "<";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homepageToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(202, 47);
            this.homepageToolStripMenuItem.Text = "Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click_1);
            // 
            // printDocumentStudent
            // 
            this.printDocumentStudent.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(980, 662);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(132, 41);
            this.buttonPrint.TabIndex = 23;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialogStudent
            // 
            this.printPreviewDialogStudent.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogStudent.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogStudent.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogStudent.Document = this.printDocumentStudent;
            this.printPreviewDialogStudent.Enabled = true;
            this.printPreviewDialogStudent.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogStudent.Icon")));
            this.printPreviewDialogStudent.Name = "printPreviewDialog1";
            this.printPreviewDialogStudent.Visible = false;
            // 
            // ControlStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1616, 706);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonMini);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.gbxCoTe);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dgvCoSt);
            this.Controls.Add(this.menuStripControlStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.ControlStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoSt)).EndInit();
            this.gbxCoTe.ResumeLayout(false);
            this.gbxCoTe.PerformLayout();
            this.menuStripControlStudent.ResumeLayout(false);
            this.menuStripControlStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCoSt;
        private System.Windows.Forms.Label lblCoStName;
        private System.Windows.Forms.Label lblCoStDep;
        private System.Windows.Forms.Label lblCoStGender;
        private System.Windows.Forms.TextBox txtbxCoStName;
        private System.Windows.Forms.Button btnAddSt;
        private System.Windows.Forms.Button btnUptadeSt;
        private System.Windows.Forms.Button btnRemoveSt;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblConAge;
        private System.Windows.Forms.Label lblCoStSurname;
        private System.Windows.Forms.TextBox txtbxCoStSurname;
        private System.Windows.Forms.ComboBox cbxCoStGender;
        private System.Windows.Forms.ComboBox cbxCoStDe;
        private System.Windows.Forms.GroupBox gbxCoTe;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DomainUpDown txtbxCoStAge;
        private System.Windows.Forms.MenuStrip menuStripControlStudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocumentStudent;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogStudent;
    }
}