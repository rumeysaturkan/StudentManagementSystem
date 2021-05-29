namespace SMS.Forms
{
    partial class TeacherForm
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BacktoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UptadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxteacherform = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelnumberofTeacher = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxSearchByAca = new System.Windows.Forms.ComboBox();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxteacherform.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.GridColor = System.Drawing.Color.LightGray;
            this.dgvTeacher.Location = new System.Drawing.Point(26, 192);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.RowTemplate.Height = 24;
            this.dgvTeacher.Size = new System.Drawing.Size(1063, 407);
            this.dgvTeacher.TabIndex = 3;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.ForeColor = System.Drawing.Color.LightGray;
            this.lblTeacher.Location = new System.Drawing.Point(46, 157);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(178, 32);
            this.lblTeacher.TabIndex = 4;
            this.lblTeacher.Text = "Teacher List";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BacktoolStripMenuItem,
            this.AddtoolStripMenuItem,
            this.UptadeToolStripMenuItem,
            this.RemoveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 36);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BacktoolStripMenuItem
            // 
            this.BacktoolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.BacktoolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoolStripMenuItem.Name = "BacktoolStripMenuItem";
            this.BacktoolStripMenuItem.ShowShortcutKeys = false;
            this.BacktoolStripMenuItem.Size = new System.Drawing.Size(41, 32);
            this.BacktoolStripMenuItem.Text = "<";
            this.BacktoolStripMenuItem.Click += new System.EventHandler(this.BacktoolStripMenuItem_Click);
            // 
            // AddtoolStripMenuItem
            // 
            this.AddtoolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddtoolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoolStripMenuItem.Name = "AddtoolStripMenuItem";
            this.AddtoolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.AddtoolStripMenuItem.Text = "Add";
            this.AddtoolStripMenuItem.Click += new System.EventHandler(this.AddtoolStripMenuItem_Click);
            // 
            // UptadeToolStripMenuItem
            // 
            this.UptadeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.UptadeToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UptadeToolStripMenuItem.Name = "UptadeToolStripMenuItem";
            this.UptadeToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.UptadeToolStripMenuItem.Text = "Uptade";
            this.UptadeToolStripMenuItem.Click += new System.EventHandler(this.UptadeToolStripMenuItem_Click);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(118, 32);
            this.RemoveToolStripMenuItem.Text = "Remove";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // groupBoxteacherform
            // 
            this.groupBoxteacherform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxteacherform.Controls.Add(this.label2);
            this.groupBoxteacherform.Controls.Add(this.labelnumberofTeacher);
            this.groupBoxteacherform.Controls.Add(this.groupBox1);
            this.groupBoxteacherform.Controls.Add(this.dgvTeacher);
            this.groupBoxteacherform.Controls.Add(this.lblTeacher);
            this.groupBoxteacherform.Location = new System.Drawing.Point(47, 51);
            this.groupBoxteacherform.Name = "groupBoxteacherform";
            this.groupBoxteacherform.Size = new System.Drawing.Size(1129, 623);
            this.groupBoxteacherform.TabIndex = 8;
            this.groupBoxteacherform.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            // 
            // labelnumberofTeacher
            // 
            this.labelnumberofTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnumberofTeacher.AutoSize = true;
            this.labelnumberofTeacher.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumberofTeacher.ForeColor = System.Drawing.Color.LightGray;
            this.labelnumberofTeacher.Location = new System.Drawing.Point(477, 44);
            this.labelnumberofTeacher.Name = "labelnumberofTeacher";
            this.labelnumberofTeacher.Size = new System.Drawing.Size(0, 28);
            this.labelnumberofTeacher.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbxSearchByAca);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Academic Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Academic Title";
            // 
            // cmbxSearchByAca
            // 
            this.cmbxSearchByAca.FormattingEnabled = true;
            this.cmbxSearchByAca.Items.AddRange(new object[] {
            "Not Selected",
            "Academic",
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Research Assistant",
            "Teaching Assistant",
            "Lecturer"});
            this.cmbxSearchByAca.Location = new System.Drawing.Point(179, 51);
            this.cmbxSearchByAca.Name = "cmbxSearchByAca";
            this.cmbxSearchByAca.Size = new System.Drawing.Size(222, 31);
            this.cmbxSearchByAca.TabIndex = 0;
            this.cmbxSearchByAca.Text = "Not Selected";
            this.cmbxSearchByAca.SelectedIndexChanged += new System.EventHandler(this.cmbxSearchByAca_SelectedIndexChanged);
            // 
            // buttonMini
            // 
            this.buttonMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.buttonMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMini.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMini.Location = new System.Drawing.Point(1102, 2);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(34, 34);
            this.buttonMini.TabIndex = 30;
            this.buttonMini.Text = "_";
            this.buttonMini.UseVisualStyleBackColor = false;
            this.buttonMini.Click += new System.EventHandler(this.buttonMini_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMax.Location = new System.Drawing.Point(1142, 2);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(34, 34);
            this.buttonMax.TabIndex = 29;
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.buttonEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEx.Location = new System.Drawing.Point(1182, 2);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(34, 34);
            this.buttonEx.TabIndex = 28;
            this.buttonEx.Text = "X";
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1228, 686);
            this.Controls.Add(this.buttonMini);
            this.Controls.Add(this.groupBoxteacherform);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxteacherform.ResumeLayout(false);
            this.groupBoxteacherform.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ToolStripMenuItem AddtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UptadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BacktoolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxteacherform;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonEx;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxSearchByAca;
        private System.Windows.Forms.Label labelnumberofTeacher;
        private System.Windows.Forms.Label label2;
    }
}