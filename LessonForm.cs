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
    public partial class LessonForm : Form
    {
        public LessonForm()
        {
            InitializeComponent();
        }
        LessonDal lessonDal = new LessonDal();

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

        private void toolmenustripback_Click(object sender, EventArgs e)
        {
            this.Close();
            HomepageForm homepageForm = new HomepageForm();
            homepageForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
             comboBoxDepartment.SelectedIndex == -1
             || comboBoxNmae.SelectedIndex == -1 )
            {
                MessageBox.Show("Don't enter a blank or incorrect value. ");
            }
            else
            {
                try
                {
                    lessonDal.Add(new Lesson
                    {
                        Name = comboBoxNmae.SelectedItem.ToString(),
                        Department = comboBoxDepartment.SelectedItem.ToString()

                    }); // if (checkBoxTe.Checked == false)
                    //{
                       // MessageBox.Show("Please tick the box.");
                   // }
                   // else
                   // {
                        LoadLessons();
                        MessageBox.Show("Added");
                   // }
                }
                catch (Exception ex)
                {

                }
            }
        }

       
        private void LoadLessons()
        {
            dgvLessons.DataSource = lessonDal.GetAll();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {
            LoadLessons();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           if(comboBoxDepartment.SelectedIndex == -1
          || comboBoxNmae.SelectedIndex == -1 )
            {
                MessageBox.Show("Don't enter a blank or incorrect value. ");
            }
            else
            {
                try
                {
                    lessonDal.Delete(new Lesson
                    {
                        Id = Convert.ToInt32(dgvLessons.CurrentRow.Cells[0].Value)
                    }); if (checkBox1.Checked == false)
                    {
                        MessageBox.Show("Please tick the box.");
                    }
                    else
                    {
                        LoadLessons();
                        MessageBox.Show("Deleted");
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void dgvLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                comboBoxNmae.Text = dgvLessons.CurrentRow.Cells[1].Value.ToString();
                comboBoxDepartment.Text = dgvLessons.CurrentRow.Cells[2].Value.ToString();
                ;
            
        }
    }
}
