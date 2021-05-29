
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
    public partial class ControlStudentForm : Form
    {
        public ControlStudentForm()
        {
            InitializeComponent();
        }
        StudentDal _studentDal = new StudentDal();
        private void LoadStudents()
        {
            dgvCoSt.DataSource = _studentDal.GetAll();
        }
        private void dgwAddSt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxCoStName.Text = dgvCoSt.CurrentRow.Cells[1].Value.ToString();
            txtbxCoStSurname.Text = dgvCoSt.CurrentRow.Cells[2].Value.ToString();
            txtbxCoStAge.Text = dgvCoSt.CurrentRow.Cells[3].Value.ToString();
            cbxCoStGender.Text = dgvCoSt.CurrentRow.Cells[4].Value.ToString();
            cbxCoStDe.Text = dgvCoSt.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnUptadeSt_Click(object sender, EventArgs e)
        {
            if (txtbxCoStName.Text == "" ||
               txtbxCoStSurname.Text == "" || txtbxCoStAge.Text == ""
              || cbxCoStGender.SelectedIndex == -1 || cbxCoStDe.SelectedIndex == -1)
            {
                MessageBox.Show("Don't enter a blank or incorrect value. ");
            }
            else
            {
                try
                {
                    _studentDal.Uptade(new Student
                    {
                        Id = Convert.ToInt32(dgvCoSt.CurrentRow.Cells[0].Value),
                        Name = txtbxCoStName.Text,
                        Surname = txtbxCoStSurname.Text,
                        Age = Convert.ToInt32(txtbxCoStAge.Text),
                        Gender = cbxCoStGender.SelectedItem.ToString(),
                        Department = cbxCoStDe.SelectedItem.ToString(),

                    }); if (checkBox1.Checked == false)
                    {
                        MessageBox.Show("Please tick the box.");
                    }
                    else
                    {
                        LoadStudents();
                        MessageBox.Show("Uptaded");
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnAddSt_Click(object sender, EventArgs e)
        {
            if(txtbxCoStName.Text==""||
               txtbxCoStSurname.Text==""|| txtbxCoStAge.Text == ""
              || cbxCoStGender.SelectedIndex == -1 || cbxCoStDe.SelectedIndex==-1)
            {
                MessageBox.Show("Don't enter a blank or incorrect value. ");
            }
            else { 
            try { 
                
            _studentDal.Add(new Student
            {
                Name = txtbxCoStName.Text,
                Surname = txtbxCoStSurname.Text,
                Age = Convert.ToInt32(txtbxCoStAge.Text),
                Gender = cbxCoStGender.SelectedItem.ToString(),
                Department = cbxCoStDe.SelectedItem.ToString(),

            });;
                if (checkBox1.Checked == false) {
                    MessageBox.Show("Please tick the box.");
                        }
                else { 
                LoadStudents();
            MessageBox.Show("Added");}
            }
            catch(Exception ex)
            {

            }
            }
        }

        private void btnRemoveSt_Click(object sender, EventArgs e)
        {
            try
            {
                _studentDal.Delete(new Student
                {
                    Id = Convert.ToInt32(dgvCoSt.CurrentRow.Cells[0].Value)
                });
                if (checkBox1.Checked == false)
                {
                    MessageBox.Show("Please tick the box.");
                }
                else
                {
                    LoadStudents();
                    MessageBox.Show("Deleted");
                }
            }
            catch (Exception ex)
            {

            }
}

        private void ControlStudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
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

      

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }

        private void homepageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HomepageForm homepageForm = new HomepageForm();
            homepageForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(printPreviewDialogStudent.ShowDialog() == DialogResult.OK)
            {
                printDocumentStudent.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvCoSt.Width, this.dgvCoSt.Height);
            dgvCoSt.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvCoSt.Width, this.dgvCoSt.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

       
    }
    }

