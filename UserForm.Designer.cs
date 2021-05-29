namespace SMS.Forms
{
    partial class UserForm
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
            this.btnUsAdd = new System.Windows.Forms.Button();
            this.btnUsUp = new System.Windows.Forms.Button();
            this.btnUsDe = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lblUsName = new System.Windows.Forms.Label();
            this.lblUsPass = new System.Windows.Forms.Label();
            this.txtbxUsName = new System.Windows.Forms.TextBox();
            this.txtbxUsPass = new System.Windows.Forms.TextBox();
            this.gbxUser = new System.Windows.Forms.GroupBox();
            this.lblUsList = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpageAdd = new System.Windows.Forms.TabPage();
            this.labelpass = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxTekrarpassUs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageUptade = new System.Windows.Forms.TabPage();
            this.checkBoxcont = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxNewPasUpDelUs = new System.Windows.Forms.TextBox();
            this.txtbxPassUpDeUs = new System.Windows.Forms.TextBox();
            this.txtbxNameUpDeUs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.checkBoxcontdelete = new System.Windows.Forms.CheckBox();
            this.txtbxDelContPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxDelPass = new System.Windows.Forms.TextBox();
            this.txtbxDelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelnumberofuser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.gbxUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpageAdd.SuspendLayout();
            this.tabPageUptade.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsAdd
            // 
            this.btnUsAdd.AutoEllipsis = true;
            this.btnUsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnUsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsAdd.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsAdd.ForeColor = System.Drawing.Color.Black;
            this.btnUsAdd.Location = new System.Drawing.Point(106, 300);
            this.btnUsAdd.Name = "btnUsAdd";
            this.btnUsAdd.Size = new System.Drawing.Size(159, 73);
            this.btnUsAdd.TabIndex = 0;
            this.btnUsAdd.Text = "Add";
            this.btnUsAdd.UseVisualStyleBackColor = false;
            this.btnUsAdd.Click += new System.EventHandler(this.btnUsAdd_Click);
            // 
            // btnUsUp
            // 
            this.btnUsUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnUsUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsUp.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsUp.Location = new System.Drawing.Point(165, 299);
            this.btnUsUp.Name = "btnUsUp";
            this.btnUsUp.Size = new System.Drawing.Size(161, 73);
            this.btnUsUp.TabIndex = 1;
            this.btnUsUp.Text = "Uptade";
            this.btnUsUp.UseVisualStyleBackColor = false;
            this.btnUsUp.Click += new System.EventHandler(this.btnUsUp_Click);
            // 
            // btnUsDe
            // 
            this.btnUsDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnUsDe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsDe.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsDe.Location = new System.Drawing.Point(155, 288);
            this.btnUsDe.Name = "btnUsDe";
            this.btnUsDe.Size = new System.Drawing.Size(159, 75);
            this.btnUsDe.TabIndex = 2;
            this.btnUsDe.Text = "Delete";
            this.btnUsDe.UseVisualStyleBackColor = false;
            this.btnUsDe.Click += new System.EventHandler(this.btnUsDe_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(6, 10);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(456, 400);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // lblUsName
            // 
            this.lblUsName.AutoSize = true;
            this.lblUsName.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsName.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsName.Location = new System.Drawing.Point(67, 91);
            this.lblUsName.Name = "lblUsName";
            this.lblUsName.Size = new System.Drawing.Size(92, 32);
            this.lblUsName.TabIndex = 4;
            this.lblUsName.Text = "Name";
            // 
            // lblUsPass
            // 
            this.lblUsPass.AutoSize = true;
            this.lblUsPass.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsPass.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsPass.Location = new System.Drawing.Point(42, 141);
            this.lblUsPass.Name = "lblUsPass";
            this.lblUsPass.Size = new System.Drawing.Size(142, 32);
            this.lblUsPass.TabIndex = 5;
            this.lblUsPass.Text = "Password";
            // 
            // txtbxUsName
            // 
            this.txtbxUsName.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxUsName.Location = new System.Drawing.Point(237, 91);
            this.txtbxUsName.MaxLength = 15;
            this.txtbxUsName.Name = "txtbxUsName";
            this.txtbxUsName.Size = new System.Drawing.Size(159, 31);
            this.txtbxUsName.TabIndex = 6;
            // 
            // txtbxUsPass
            // 
            this.txtbxUsPass.Location = new System.Drawing.Point(237, 145);
            this.txtbxUsPass.MaxLength = 10;
            this.txtbxUsPass.Name = "txtbxUsPass";
            this.txtbxUsPass.PasswordChar = '*';
            this.txtbxUsPass.Size = new System.Drawing.Size(159, 31);
            this.txtbxUsPass.TabIndex = 7;
            this.txtbxUsPass.TextChanged += new System.EventHandler(this.txtbxUsPass_TextChanged);
            // 
            // gbxUser
            // 
            this.gbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxUser.Controls.Add(this.dgvUser);
            this.gbxUser.Location = new System.Drawing.Point(533, 200);
            this.gbxUser.Name = "gbxUser";
            this.gbxUser.Size = new System.Drawing.Size(468, 416);
            this.gbxUser.TabIndex = 8;
            this.gbxUser.TabStop = false;
            // 
            // lblUsList
            // 
            this.lblUsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsList.AutoSize = true;
            this.lblUsList.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsList.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsList.Location = new System.Drawing.Point(716, 155);
            this.lblUsList.Name = "lblUsList";
            this.lblUsList.Size = new System.Drawing.Size(135, 32);
            this.lblUsList.TabIndex = 9;
            this.lblUsList.Text = "User List";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(56, 40);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 36);
            this.toolStripMenuItem1.Text = "<";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // buttonMini
            // 
            this.buttonMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(78)))));
            this.buttonMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMini.Location = new System.Drawing.Point(967, 6);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(34, 34);
            this.buttonMini.TabIndex = 17;
            this.buttonMini.Text = "_";
            this.buttonMini.UseVisualStyleBackColor = false;
            this.buttonMini.Click += new System.EventHandler(this.buttonMini_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Location = new System.Drawing.Point(1007, 6);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(34, 34);
            this.buttonMax.TabIndex = 16;
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.buttonEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEx.Location = new System.Drawing.Point(1047, 6);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(34, 34);
            this.buttonEx.TabIndex = 15;
            this.buttonEx.Text = "X";
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(49, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 70);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(165, 27);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(161, 31);
            this.textBoxId.TabIndex = 20;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabpageAdd);
            this.tabControl1.Controls.Add(this.tabPageUptade);
            this.tabControl1.Controls.Add(this.tabPageDelete);
            this.tabControl1.Location = new System.Drawing.Point(45, 185);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 434);
            this.tabControl1.TabIndex = 19;
            // 
            // tabpageAdd
            // 
            this.tabpageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabpageAdd.Controls.Add(this.labelpass);
            this.tabpageAdd.Controls.Add(this.progressBar1);
            this.tabpageAdd.Controls.Add(this.textBoxTekrarpassUs);
            this.tabpageAdd.Controls.Add(this.label2);
            this.tabpageAdd.Controls.Add(this.txtbxUsPass);
            this.tabpageAdd.Controls.Add(this.lblUsName);
            this.tabpageAdd.Controls.Add(this.lblUsPass);
            this.tabpageAdd.Controls.Add(this.btnUsAdd);
            this.tabpageAdd.Controls.Add(this.txtbxUsName);
            this.tabpageAdd.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabpageAdd.Name = "tabpageAdd";
            this.tabpageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAdd.Size = new System.Drawing.Size(471, 405);
            this.tabpageAdd.TabIndex = 0;
            this.tabpageAdd.Text = "Add";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.labelpass.Location = new System.Drawing.Point(44, 197);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(0, 23);
            this.labelpass.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(237, 192);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // textBoxTekrarpassUs
            // 
            this.textBoxTekrarpassUs.Location = new System.Drawing.Point(235, 240);
            this.textBoxTekrarpassUs.MaxLength = 10;
            this.textBoxTekrarpassUs.Name = "textBoxTekrarpassUs";
            this.textBoxTekrarpassUs.PasswordChar = '*';
            this.textBoxTekrarpassUs.Size = new System.Drawing.Size(161, 31);
            this.textBoxTekrarpassUs.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(42, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // tabPageUptade
            // 
            this.tabPageUptade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPageUptade.Controls.Add(this.checkBoxcont);
            this.tabPageUptade.Controls.Add(this.label5);
            this.tabPageUptade.Controls.Add(this.txtbxNewPasUpDelUs);
            this.tabPageUptade.Controls.Add(this.txtbxPassUpDeUs);
            this.tabPageUptade.Controls.Add(this.txtbxNameUpDeUs);
            this.tabPageUptade.Controls.Add(this.label3);
            this.tabPageUptade.Controls.Add(this.btnUsUp);
            this.tabPageUptade.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUptade.Location = new System.Drawing.Point(4, 25);
            this.tabPageUptade.Name = "tabPageUptade";
            this.tabPageUptade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUptade.Size = new System.Drawing.Size(471, 405);
            this.tabPageUptade.TabIndex = 1;
            this.tabPageUptade.Text = "Uptade Username";
            // 
            // checkBoxcont
            // 
            this.checkBoxcont.AutoSize = true;
            this.checkBoxcont.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxcont.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxcont.Location = new System.Drawing.Point(66, 29);
            this.checkBoxcont.Name = "checkBoxcont";
            this.checkBoxcont.Size = new System.Drawing.Size(322, 48);
            this.checkBoxcont.TabIndex = 12;
            this.checkBoxcont.Text = "Please select the user to update\r\nusername from the user list.";
            this.checkBoxcont.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(60, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // txtbxNewPasUpDelUs
            // 
            this.txtbxNewPasUpDelUs.Location = new System.Drawing.Point(240, 236);
            this.txtbxNewPasUpDelUs.MaxLength = 10;
            this.txtbxNewPasUpDelUs.Name = "txtbxNewPasUpDelUs";
            this.txtbxNewPasUpDelUs.PasswordChar = '*';
            this.txtbxNewPasUpDelUs.Size = new System.Drawing.Size(159, 31);
            this.txtbxNewPasUpDelUs.TabIndex = 9;
            // 
            // txtbxPassUpDeUs
            // 
            this.txtbxPassUpDeUs.Location = new System.Drawing.Point(140, 171);
            this.txtbxPassUpDeUs.MaxLength = 10;
            this.txtbxPassUpDeUs.Name = "txtbxPassUpDeUs";
            this.txtbxPassUpDeUs.Size = new System.Drawing.Size(159, 31);
            this.txtbxPassUpDeUs.TabIndex = 9;
            this.txtbxPassUpDeUs.Visible = false;
            // 
            // txtbxNameUpDeUs
            // 
            this.txtbxNameUpDeUs.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxNameUpDeUs.Location = new System.Drawing.Point(240, 111);
            this.txtbxNameUpDeUs.Name = "txtbxNameUpDeUs";
            this.txtbxNameUpDeUs.Size = new System.Drawing.Size(159, 31);
            this.txtbxNameUpDeUs.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(91, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPageDelete.Controls.Add(this.checkBoxcontdelete);
            this.tabPageDelete.Controls.Add(this.txtbxDelContPass);
            this.tabPageDelete.Controls.Add(this.label8);
            this.tabPageDelete.Controls.Add(this.txtbxDelPass);
            this.tabPageDelete.Controls.Add(this.txtbxDelName);
            this.tabPageDelete.Controls.Add(this.label6);
            this.tabPageDelete.Controls.Add(this.btnUsDe);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(471, 405);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Delete";
            // 
            // checkBoxcontdelete
            // 
            this.checkBoxcontdelete.AutoSize = true;
            this.checkBoxcontdelete.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxcontdelete.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxcontdelete.Location = new System.Drawing.Point(117, 31);
            this.checkBoxcontdelete.Name = "checkBoxcontdelete";
            this.checkBoxcontdelete.Size = new System.Drawing.Size(259, 48);
            this.checkBoxcontdelete.TabIndex = 13;
            this.checkBoxcontdelete.Text = "Please select the user to\r\ndelete from the user list.";
            this.checkBoxcontdelete.UseVisualStyleBackColor = true;
            // 
            // txtbxDelContPass
            // 
            this.txtbxDelContPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxDelContPass.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDelContPass.Location = new System.Drawing.Point(248, 224);
            this.txtbxDelContPass.Name = "txtbxDelContPass";
            this.txtbxDelContPass.Size = new System.Drawing.Size(159, 35);
            this.txtbxDelContPass.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(68, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Password";
            // 
            // txtbxDelPass
            // 
            this.txtbxDelPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxDelPass.Location = new System.Drawing.Point(155, 172);
            this.txtbxDelPass.Name = "txtbxDelPass";
            this.txtbxDelPass.Size = new System.Drawing.Size(159, 22);
            this.txtbxDelPass.TabIndex = 10;
            this.txtbxDelPass.Visible = false;
            // 
            // txtbxDelName
            // 
            this.txtbxDelName.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxDelName.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDelName.Location = new System.Drawing.Point(248, 103);
            this.txtbxDelName.Name = "txtbxDelName";
            this.txtbxDelName.Size = new System.Drawing.Size(159, 35);
            this.txtbxDelName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(89, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // labelnumberofuser
            // 
            this.labelnumberofuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnumberofuser.AutoSize = true;
            this.labelnumberofuser.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumberofuser.ForeColor = System.Drawing.Color.LightGray;
            this.labelnumberofuser.Location = new System.Drawing.Point(425, 84);
            this.labelnumberofuser.Name = "labelnumberofuser";
            this.labelnumberofuser.Size = new System.Drawing.Size(0, 28);
            this.labelnumberofuser.TabIndex = 20;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1088, 649);
            this.Controls.Add(this.labelnumberofuser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblUsList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMini);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.gbxUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.gbxUser.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabpageAdd.ResumeLayout(false);
            this.tabpageAdd.PerformLayout();
            this.tabPageUptade.ResumeLayout(false);
            this.tabPageUptade.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsAdd;
        private System.Windows.Forms.Button btnUsUp;
        private System.Windows.Forms.Button btnUsDe;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblUsName;
        private System.Windows.Forms.Label lblUsPass;
        private System.Windows.Forms.TextBox txtbxUsName;
        private System.Windows.Forms.TextBox txtbxUsPass;
        private System.Windows.Forms.GroupBox gbxUser;
        private System.Windows.Forms.Label lblUsList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpageAdd;
        private System.Windows.Forms.TextBox textBoxTekrarpassUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageUptade;
        private System.Windows.Forms.TextBox txtbxPassUpDeUs;
        private System.Windows.Forms.TextBox txtbxNameUpDeUs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxNewPasUpDelUs;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.TextBox txtbxDelContPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxDelPass;
        private System.Windows.Forms.TextBox txtbxDelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labelnumberofuser;
        private System.Windows.Forms.CheckBox checkBoxcont;
        private System.Windows.Forms.CheckBox checkBoxcontdelete;
    }
}