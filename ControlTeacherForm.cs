
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
    public partial class ControlTeacherForm : Form
    {
        public ControlTeacherForm()
        {
            InitializeComponent();
        }
        TeacherDal _teacherDal = new TeacherDal();
        private void LoadTeachers()
        {
            dgvCoTeachers.DataSource = _teacherDal.GetAll();
        }
        private void btnCoTeAdd_Click(object sender, EventArgs e)
        {
            if (txtbxCoTeName.Text == "" ||
               txtbxCoTeSurna.Text == "" || txtbxCoTeRN.Text == "" || cbxCoTeGen.SelectedIndex == -1
              || cbxCoTeAcT.SelectedIndex == -1 || cbxCoTeDe.SelectedIndex == -1)
            {
                MessageBox.Show("Don't enter a blank or incorrect value. ");
            }
            else
            {
                try
                {
                    _teacherDal.Add(new Teacher
                    {
                        Name = txtbxCoTeName.Text,
                        Surname = txtbxCoTeSurna.Text,
                        Gender = cbxCoTeGen.SelectedItem.ToString(),
                        RoomNumber = txtbxCoTeRN.Text,
                        AcademicTitle = cbxCoTeAcT.SelectedItem.ToString(),
                        Department = cbxCoTeDe.SelectedItem.ToString(),

                    }); if (checkBoxTe.Checked == false)
                    {
                        MessageBox.Show("Please tick the box.");
                    }
                    else
                    {
                        LoadTeachers();
                        MessageBox.Show("Added");
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnCoTeUp_Click(object sender, EventArgs e)
        {
            if (txtbxCoTeName.Text == "" ||
              txtbxCoTeSurna.Text == "" || txtbxCoTeRN.Text == "" || cbxCoTeGen.SelectedIndex == -1
             || cbxCoTeAcT.SelectedIndex == -1 || cbxCoTeDe.SelectedIndex == -1)
            {
                MessageBox.Show("Don't enter a blank or incorrect value. ");
            }
            else
            {
                try
                {
                    _teacherDal.Uptade(new Teacher
                    {
                        Id = Convert.ToInt32(dgvCoTeachers.CurrentRow.Cells[0].Value),
                        Name = txtbxCoTeName.Text,
                        Surname = txtbxCoTeSurna.Text,
                        Gender = cbxCoTeGen.SelectedItem.ToString(),
                        RoomNumber = txtbxCoTeRN.Text,
                        AcademicTitle = cbxCoTeAcT.SelectedItem.ToString(),
                        Department = cbxCoTeDe.SelectedItem.ToString(),

                    }); if (checkBoxTe.Checked == false)
                    {
                        MessageBox.Show("Please tick the box.");
                    }
                    else
                    {
                        LoadTeachers();
                        MessageBox.Show("Uptaded");
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void btnCoTeRe_Click(object sender, EventArgs e)
        {
            if (txtbxCoTeName.Text == "" ||
            txtbxCoTeSurna.Text == "" || txtbxCoTeRN.Text == "" || cbxCoTeGen.SelectedIndex == -1
           || cbxCoTeAcT.SelectedIndex == -1 || cbxCoTeDe.SelectedIndex == -1)
            {
                MessageBox.Show("Don't enter a blank or incorrect value. ");
            }
            else
            {
                try
                {
                    _teacherDal.Delete(new Teacher
                    {
                        Id = Convert.ToInt32(dgvCoTeachers.CurrentRow.Cells[0].Value)
                    }); if (checkBoxTe.Checked == false)
                    {
                        MessageBox.Show("Please tick the box.");
                    }
                    else
                    {
                        LoadTeachers();
                        MessageBox.Show("Deleted");
                    }
                }
                catch (Exception ex) { }
            }
        }
        private void ControlTeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void dgvCoTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxCoTeName.Text = dgvCoTeachers.CurrentRow.Cells[1].Value.ToString();
            txtbxCoTeSurna.Text = dgvCoTeachers.CurrentRow.Cells[2].Value.ToString();
            cbxCoTeGen.Text = dgvCoTeachers.CurrentRow.Cells[3].Value.ToString();
            txtbxCoTeRN.Text = dgvCoTeachers.CurrentRow.Cells[4].Value.ToString();
            cbxCoTeAcT.Text = dgvCoTeachers.CurrentRow.Cells[5].Value.ToString();
            cbxCoTeDe.Text = dgvCoTeachers.CurrentRow.Cells[6].Value.ToString();
        }

        

        private void BacktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.Show();
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

      

        private void homepageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HomepageForm homepageForm = new HomepageForm();
            homepageForm.Show();
            this.Close();
        }

        private void printDocumentTeacher_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvCoTeachers.Width, this.dgvCoTeachers.Height);
            dgvCoTeachers.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvCoTeachers.Width, this.dgvCoTeachers.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialogTeacher.ShowDialog() == DialogResult.OK)
            {
                printDocumentTeacher.Print();
            }
        }

       
    }
}
