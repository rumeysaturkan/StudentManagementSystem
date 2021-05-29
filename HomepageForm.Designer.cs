namespace SMS.Forms

{
    partial class HomepageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHpLogout = new System.Windows.Forms.Button();
            this.lblHpStudent = new System.Windows.Forms.Label();
            this.lblHpTeacher = new System.Windows.Forms.Label();
            this.lblHpUser = new System.Windows.Forms.Label();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.labelLesson = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnLessonForm = new System.Windows.Forms.Button();
            this.btnHpStudent = new System.Windows.Forms.Button();
            this.btnHpUser = new System.Windows.Forms.Button();
            this.btnHpTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "student.png");
            this.ımageList1.Images.SetKeyName(1, "teacher.png");
            this.ımageList1.Images.SetKeyName(2, "user.png");
            this.ımageList1.Images.SetKeyName(3, "Lessons.png");
            // 
            // btnHpLogout
            // 
            resources.ApplyResources(this.btnHpLogout, "btnHpLogout");
            this.btnHpLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(163)))), ((int)(((byte)(146)))));
            this.btnHpLogout.Name = "btnHpLogout";
            this.btnHpLogout.UseVisualStyleBackColor = false;
            this.btnHpLogout.Click += new System.EventHandler(this.btnHpLogout_Click);
            // 
            // lblHpStudent
            // 
            resources.ApplyResources(this.lblHpStudent, "lblHpStudent");
            this.lblHpStudent.ForeColor = System.Drawing.Color.LightGray;
            this.lblHpStudent.Name = "lblHpStudent";
            // 
            // lblHpTeacher
            // 
            resources.ApplyResources(this.lblHpTeacher, "lblHpTeacher");
            this.lblHpTeacher.ForeColor = System.Drawing.Color.LightGray;
            this.lblHpTeacher.Name = "lblHpTeacher";
            // 
            // lblHpUser
            // 
            resources.ApplyResources(this.lblHpUser, "lblHpUser");
            this.lblHpUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblHpUser.Name = "lblHpUser";
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
            // labelLesson
            // 
            resources.ApplyResources(this.labelLesson, "labelLesson");
            this.labelLesson.ForeColor = System.Drawing.Color.LightGray;
            this.labelLesson.Name = "labelLesson";
            // 
            // labelDate
            // 
            resources.ApplyResources(this.labelDate, "labelDate");
            this.labelDate.ForeColor = System.Drawing.Color.LightGray;
            this.labelDate.Name = "labelDate";
            // 
            // labelTime
            // 
            resources.ApplyResources(this.labelTime, "labelTime");
            this.labelTime.ForeColor = System.Drawing.Color.LightGray;
            this.labelTime.Name = "labelTime";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLessonForm
            // 
            resources.ApplyResources(this.btnLessonForm, "btnLessonForm");
            this.btnLessonForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLessonForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLessonForm.ImageList = this.ımageList1;
            this.btnLessonForm.Name = "btnLessonForm";
            this.btnLessonForm.UseVisualStyleBackColor = false;
            this.btnLessonForm.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // btnHpStudent
            // 
            resources.ApplyResources(this.btnHpStudent, "btnHpStudent");
            this.btnHpStudent.BackColor = System.Drawing.Color.Snow;
            this.btnHpStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHpStudent.ImageList = this.ımageList1;
            this.btnHpStudent.Name = "btnHpStudent";
            this.btnHpStudent.UseVisualStyleBackColor = false;
            this.btnHpStudent.Click += new System.EventHandler(this.btnHpStudent_Click);
            // 
            // btnHpUser
            // 
            resources.ApplyResources(this.btnHpUser, "btnHpUser");
            this.btnHpUser.BackColor = System.Drawing.Color.Snow;
            this.btnHpUser.ForeColor = System.Drawing.Color.White;
            this.btnHpUser.ImageList = this.ımageList1;
            this.btnHpUser.Name = "btnHpUser";
            this.btnHpUser.UseVisualStyleBackColor = false;
            this.btnHpUser.Click += new System.EventHandler(this.btnHpUser_Click);
            // 
            // btnHpTeacher
            // 
            resources.ApplyResources(this.btnHpTeacher, "btnHpTeacher");
            this.btnHpTeacher.BackColor = System.Drawing.Color.Snow;
            this.btnHpTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHpTeacher.ImageList = this.ımageList1;
            this.btnHpTeacher.Name = "btnHpTeacher";
            this.btnHpTeacher.UseVisualStyleBackColor = false;
            this.btnHpTeacher.Click += new System.EventHandler(this.btnHpTeacher_Click);
            // 
            // HomepageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelLesson);
            this.Controls.Add(this.btnLessonForm);
            this.Controls.Add(this.buttonMini);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.lblHpStudent);
            this.Controls.Add(this.btnHpStudent);
            this.Controls.Add(this.lblHpUser);
            this.Controls.Add(this.lblHpTeacher);
            this.Controls.Add(this.btnHpUser);
            this.Controls.Add(this.btnHpLogout);
            this.Controls.Add(this.btnHpTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomepageForm";
            this.Load += new System.EventHandler(this.HomepageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHpStudent;
        private System.Windows.Forms.Button btnHpTeacher;
        private System.Windows.Forms.Button btnHpLogout;
        private System.Windows.Forms.Button btnHpUser;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblHpStudent;
        private System.Windows.Forms.Label lblHpTeacher;
        private System.Windows.Forms.Label lblHpUser;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Button btnLessonForm;
        private System.Windows.Forms.Label labelLesson;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}