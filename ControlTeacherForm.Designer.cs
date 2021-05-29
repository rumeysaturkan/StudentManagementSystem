namespace SMS.Forms
{
    partial class ControlTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTeacherForm));
            this.btnCoTeAdd = new System.Windows.Forms.Button();
            this.btnCoTeRe = new System.Windows.Forms.Button();
            this.btnCoTeUp = new System.Windows.Forms.Button();
            this.dgvCoTeachers = new System.Windows.Forms.DataGridView();
            this.lblCoTeName = new System.Windows.Forms.Label();
            this.lblCoTeSurname = new System.Windows.Forms.Label();
            this.lblCoTeGender = new System.Windows.Forms.Label();
            this.lblCoTeRoom = new System.Windows.Forms.Label();
            this.lblCoTeDep = new System.Windows.Forms.Label();
            this.lblCoTeAcad = new System.Windows.Forms.Label();
            this.txtbxCoTeName = new System.Windows.Forms.TextBox();
            this.txtbxCoTeSurna = new System.Windows.Forms.TextBox();
            this.cbxCoTeGen = new System.Windows.Forms.ComboBox();
            this.txtbxCoTeRN = new System.Windows.Forms.TextBox();
            this.cbxCoTeAcT = new System.Windows.Forms.ComboBox();
            this.cbxCoTeDe = new System.Windows.Forms.ComboBox();
            this.gbxCoTe = new System.Windows.Forms.GroupBox();
            this.checkBoxTe = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BacktoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.printPreviewDialogTeacher = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentTeacher = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoTeachers)).BeginInit();
            this.gbxCoTe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCoTeAdd
            // 
            this.btnCoTeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.btnCoTeAdd, "btnCoTeAdd");
            this.btnCoTeAdd.Name = "btnCoTeAdd";
            this.btnCoTeAdd.UseVisualStyleBackColor = false;
            this.btnCoTeAdd.Click += new System.EventHandler(this.btnCoTeAdd_Click);
            // 
            // btnCoTeRe
            // 
            this.btnCoTeRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.btnCoTeRe, "btnCoTeRe");
            this.btnCoTeRe.Name = "btnCoTeRe";
            this.btnCoTeRe.UseVisualStyleBackColor = false;
            this.btnCoTeRe.Click += new System.EventHandler(this.btnCoTeRe_Click);
            // 
            // btnCoTeUp
            // 
            this.btnCoTeUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.btnCoTeUp, "btnCoTeUp");
            this.btnCoTeUp.ForeColor = System.Drawing.Color.Black;
            this.btnCoTeUp.Name = "btnCoTeUp";
            this.btnCoTeUp.UseVisualStyleBackColor = false;
            this.btnCoTeUp.Click += new System.EventHandler(this.btnCoTeUp_Click);
            // 
            // dgvCoTeachers
            // 
            resources.ApplyResources(this.dgvCoTeachers, "dgvCoTeachers");
            this.dgvCoTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoTeachers.Name = "dgvCoTeachers";
            this.dgvCoTeachers.RowTemplate.Height = 24;
            this.dgvCoTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoTeachers_CellClick);
          
            // 
            // lblCoTeName
            // 
            resources.ApplyResources(this.lblCoTeName, "lblCoTeName");
            this.lblCoTeName.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoTeName.Name = "lblCoTeName";
            // 
            // lblCoTeSurname
            // 
            resources.ApplyResources(this.lblCoTeSurname, "lblCoTeSurname");
            this.lblCoTeSurname.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoTeSurname.Name = "lblCoTeSurname";
            // 
            // lblCoTeGender
            // 
            resources.ApplyResources(this.lblCoTeGender, "lblCoTeGender");
            this.lblCoTeGender.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoTeGender.Name = "lblCoTeGender";
            // 
            // lblCoTeRoom
            // 
            resources.ApplyResources(this.lblCoTeRoom, "lblCoTeRoom");
            this.lblCoTeRoom.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoTeRoom.Name = "lblCoTeRoom";
            // 
            // lblCoTeDep
            // 
            resources.ApplyResources(this.lblCoTeDep, "lblCoTeDep");
            this.lblCoTeDep.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoTeDep.Name = "lblCoTeDep";
            // 
            // lblCoTeAcad
            // 
            resources.ApplyResources(this.lblCoTeAcad, "lblCoTeAcad");
            this.lblCoTeAcad.ForeColor = System.Drawing.Color.LightGray;
            this.lblCoTeAcad.Name = "lblCoTeAcad";
            // 
            // txtbxCoTeName
            // 
            resources.ApplyResources(this.txtbxCoTeName, "txtbxCoTeName");
            this.txtbxCoTeName.Name = "txtbxCoTeName";
            // 
            // txtbxCoTeSurna
            // 
            resources.ApplyResources(this.txtbxCoTeSurna, "txtbxCoTeSurna");
            this.txtbxCoTeSurna.Name = "txtbxCoTeSurna";
            // 
            // cbxCoTeGen
            // 
            resources.ApplyResources(this.cbxCoTeGen, "cbxCoTeGen");
            this.cbxCoTeGen.FormattingEnabled = true;
            this.cbxCoTeGen.Items.AddRange(new object[] {
            resources.GetString("cbxCoTeGen.Items"),
            resources.GetString("cbxCoTeGen.Items1")});
            this.cbxCoTeGen.Name = "cbxCoTeGen";
            // 
            // txtbxCoTeRN
            // 
            resources.ApplyResources(this.txtbxCoTeRN, "txtbxCoTeRN");
            this.txtbxCoTeRN.Name = "txtbxCoTeRN";
            // 
            // cbxCoTeAcT
            // 
            resources.ApplyResources(this.cbxCoTeAcT, "cbxCoTeAcT");
            this.cbxCoTeAcT.FormattingEnabled = true;
            this.cbxCoTeAcT.Items.AddRange(new object[] {
            resources.GetString("cbxCoTeAcT.Items"),
            resources.GetString("cbxCoTeAcT.Items1"),
            resources.GetString("cbxCoTeAcT.Items2"),
            resources.GetString("cbxCoTeAcT.Items3"),
            resources.GetString("cbxCoTeAcT.Items4"),
            resources.GetString("cbxCoTeAcT.Items5")});
            this.cbxCoTeAcT.Name = "cbxCoTeAcT";
            // 
            // cbxCoTeDe
            // 
            resources.ApplyResources(this.cbxCoTeDe, "cbxCoTeDe");
            this.cbxCoTeDe.FormattingEnabled = true;
            this.cbxCoTeDe.Items.AddRange(new object[] {
            resources.GetString("cbxCoTeDe.Items"),
            resources.GetString("cbxCoTeDe.Items1"),
            resources.GetString("cbxCoTeDe.Items2"),
            resources.GetString("cbxCoTeDe.Items3"),
            resources.GetString("cbxCoTeDe.Items4"),
            resources.GetString("cbxCoTeDe.Items5"),
            resources.GetString("cbxCoTeDe.Items6"),
            resources.GetString("cbxCoTeDe.Items7"),
            resources.GetString("cbxCoTeDe.Items8"),
            resources.GetString("cbxCoTeDe.Items9"),
            resources.GetString("cbxCoTeDe.Items10"),
            resources.GetString("cbxCoTeDe.Items11"),
            resources.GetString("cbxCoTeDe.Items12"),
            resources.GetString("cbxCoTeDe.Items13")});
            this.cbxCoTeDe.Name = "cbxCoTeDe";
            // 
            // gbxCoTe
            // 
            resources.ApplyResources(this.gbxCoTe, "gbxCoTe");
            this.gbxCoTe.Controls.Add(this.checkBoxTe);
            this.gbxCoTe.Controls.Add(this.btnCoTeUp);
            this.gbxCoTe.Controls.Add(this.cbxCoTeAcT);
            this.gbxCoTe.Controls.Add(this.cbxCoTeDe);
            this.gbxCoTe.Controls.Add(this.txtbxCoTeRN);
            this.gbxCoTe.Controls.Add(this.btnCoTeRe);
            this.gbxCoTe.Controls.Add(this.cbxCoTeGen);
            this.gbxCoTe.Controls.Add(this.btnCoTeAdd);
            this.gbxCoTe.Controls.Add(this.txtbxCoTeSurna);
            this.gbxCoTe.Controls.Add(this.lblCoTeDep);
            this.gbxCoTe.Controls.Add(this.txtbxCoTeName);
            this.gbxCoTe.Controls.Add(this.lblCoTeAcad);
            this.gbxCoTe.Controls.Add(this.lblCoTeName);
            this.gbxCoTe.Controls.Add(this.lblCoTeSurname);
            this.gbxCoTe.Controls.Add(this.lblCoTeGender);
            this.gbxCoTe.Controls.Add(this.lblCoTeRoom);
            this.gbxCoTe.Name = "gbxCoTe";
            this.gbxCoTe.TabStop = false;
            // 
            // checkBoxTe
            // 
            resources.ApplyResources(this.checkBoxTe, "checkBoxTe");
            this.checkBoxTe.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxTe.Name = "checkBoxTe";
            this.checkBoxTe.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BacktoolStripMenuItem,
            this.homepageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // BacktoolStripMenuItem
            // 
            this.BacktoolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.BacktoolStripMenuItem, "BacktoolStripMenuItem");
            this.BacktoolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.BacktoolStripMenuItem.Name = "BacktoolStripMenuItem";
            this.BacktoolStripMenuItem.Click += new System.EventHandler(this.BacktoolStripMenuItem_Click);
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.homepageToolStripMenuItem, "homepageToolStripMenuItem");
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click_1);
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
            // printPreviewDialogTeacher
            // 
            resources.ApplyResources(this.printPreviewDialogTeacher, "printPreviewDialogTeacher");
            this.printPreviewDialogTeacher.Document = this.printDocumentTeacher;
            this.printPreviewDialogTeacher.Name = "printPreviewDialogTeacher";
            // 
            // printDocumentTeacher
            // 
            this.printDocumentTeacher.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTeacher_PrintPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlTeacherForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMini);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.gbxCoTe);
            this.Controls.Add(this.dgvCoTeachers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlTeacherForm";
            this.Load += new System.EventHandler(this.ControlTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoTeachers)).EndInit();
            this.gbxCoTe.ResumeLayout(false);
            this.gbxCoTe.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCoTeAdd;
        private System.Windows.Forms.Button btnCoTeRe;
        private System.Windows.Forms.Button btnCoTeUp;
        private System.Windows.Forms.DataGridView dgvCoTeachers;
        private System.Windows.Forms.Label lblCoTeName;
        private System.Windows.Forms.Label lblCoTeSurname;
        private System.Windows.Forms.Label lblCoTeGender;
        private System.Windows.Forms.Label lblCoTeRoom;
        private System.Windows.Forms.Label lblCoTeDep;
        private System.Windows.Forms.Label lblCoTeAcad;
        private System.Windows.Forms.TextBox txtbxCoTeName;
        private System.Windows.Forms.TextBox txtbxCoTeSurna;
        private System.Windows.Forms.ComboBox cbxCoTeGen;
        private System.Windows.Forms.TextBox txtbxCoTeRN;
        private System.Windows.Forms.ComboBox cbxCoTeAcT;
        private System.Windows.Forms.ComboBox cbxCoTeDe;
        private System.Windows.Forms.GroupBox gbxCoTe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BacktoolStripMenuItem;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.CheckBox checkBoxTe;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogTeacher;
        private System.Drawing.Printing.PrintDocument printDocumentTeacher;
        private System.Windows.Forms.Button button1;
    }
}