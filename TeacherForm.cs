
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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        TeacherDal _teacherDal = new TeacherDal();
        private void AddtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlTeacherForm controlTeacherForm = new ControlTeacherForm();
            controlTeacherForm.Show();
            this.Close();
            
        }
        private void LoadTeachers()
        {
            labelnumberofTeacher.Text = "Number of Teachers : " + _teacherDal.GetAll().Count;

            dgvTeacher.DataSource = _teacherDal.GetAll();
        }
        private void SearchTeacher(string key)
        {
            var result = _teacherDal.GetAll().Where(p => p.Name.Contains(key)).ToList();
            dgvTeacher.DataSource = result;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

       
        private void UptadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlTeacherForm controlTeacherForm = new ControlTeacherForm();
            controlTeacherForm.Show();
            this.Close();
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlTeacherForm controlTeacherForm = new ControlTeacherForm();
            controlTeacherForm.Show();
            this.Close();
        }

        private void BacktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomepageForm homepageForm = new HomepageForm();
            homepageForm.Show();
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

      

        private void cmbxSearchByAca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxSearchByAca.Text != "Not Selected")
            { 
                var result = _teacherDal.GetAcademicTitle(cmbxSearchByAca.Text);
            dgvTeacher.DataSource = result;
            }
            else
            {
               dgvTeacher.DataSource = _teacherDal.GetAll(); 
            }

          

        }
    }
}
