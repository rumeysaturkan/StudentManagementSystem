
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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
           InitializeComponent();
        }
    private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }    
        StudentDal _studentDal = new StudentDal();
        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            ControlStudentForm controlStudentForm = new ControlStudentForm();
            controlStudentForm.Show();
            this.Close();
        }

        private void btnStudentUptade_Click(object sender, EventArgs e)
        {
            ControlStudentForm controlStudentForm = new ControlStudentForm();
            controlStudentForm.Show();
            this.Close();
        }
        private void LoadStudents()
        {
            labelnumberofStudent.Text = "Number of Students : " + _studentDal.GetAll().Count;
            dgvStudents.DataSource = _studentDal.GetAll();
        }
       

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnStudentRemove_Click(object sender, EventArgs e)
        {
           _studentDal.Delete(new Student
            {
              Id = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value)
            });
        
            LoadStudents();
            MessageBox.Show("Deleted");
        }
        private void SearchStudent(string key)
        {
            var result = _studentDal.GetAll().Where(p => p.Name.Contains(key)).ToList();
            dgvStudents.DataSource = result;
           
        }
        private void txtbxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            try { 
                if(txtbxSearchStudent.Text == "")
                {
                    LoadStudents();
                }
            var result = _studentDal.GetId(Convert.ToInt32(txtbxSearchStudent.Text));
            dgvStudents.DataSource = result;
            }
            catch (Exception ex)
            {
                 
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomepageForm homepageForm = new HomepageForm();
            homepageForm.Show();
            this.Close();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlStudentForm controlStudentForm = new ControlStudentForm();
            controlStudentForm.Show();
            this.Close();
        }

        private void uptadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlStudentForm controlStudentForm = new ControlStudentForm();
            controlStudentForm.Show();
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

        private void comboBoxSearchByDepSt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxSearchByDepSt.Text == "Not Selected" )
            {
                LoadStudents();
            }
            else
            { 
             var students = _studentDal.GetDepartment(comboBoxSearchByDepSt.Text);
            dgvStudents.DataSource = students;
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
