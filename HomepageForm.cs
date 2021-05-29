
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Forms
{
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
        }

      

        private void btnHpUser_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
            this.Hide();
        }

        private void btnHpStudent_Click(object sender, EventArgs e)
        {
            StudentForm student = new StudentForm();
            student.Show();
            this.Hide();
        }

        private void btnHpTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            teacher.Show();
            this.Hide();
        }

        private void btnHpLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HomepageForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            this.Close();
            LessonForm lessonForm = new LessonForm();
            lessonForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = "Date : " + DateTime.Now.ToLongDateString();
            labelTime.Text = "Time : " + DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            CalculateForm calculate = new CalculateForm();
            calculate.Show();
            this.Hide();
        }
    }
}
