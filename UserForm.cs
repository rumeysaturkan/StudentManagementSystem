
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
    public partial class UserForm : Form 
    {
        public UserForm()
        {
            InitializeComponent();
        }
        UserDal _userDal = new UserDal();

       

        private void btnUsAdd_Click(object sender, EventArgs e)
        {
            var result = _userDal.GetUserName(txtbxUsName.Text);
            
            try {    
                if(result.Count == 0) { 
                 if(txtbxUsPass.Text == textBoxTekrarpassUs.Text) {
                  _userDal.Add(new User
                 {
                Name = txtbxUsName.Text,
                password = txtbxUsPass.Text
                
                  }); 
                 LoadUsers();
                 MessageBox.Show("Added");
                   txtbxUsName.Text="";
                        txtbxUsPass.Text = "";
                        textBoxTekrarpassUs.Text = "";
                        labelpass.Text = " ";
                    }
               else if(txtbxUsPass.Text != textBoxTekrarpassUs.Text)
            {
                MessageBox.Show("Passwords are not the same.");
            }     
                }
                else { MessageBox.Show("This username has been taken."); }
            } catch(Exception ex)
            {

            }
        }
        private void LoadUsers()
        {
            dgvUser.DataSource = _userDal.GetAll();
            this.dgvUser.Columns["password"].Visible = false;
            labelnumberofuser.Text = "Number of Users : " + _userDal.GetAll().Count;
        }
        private void btnUsUp_Click(object sender, EventArgs e)
        {
            try {
                if (checkBoxcont.Checked == true)
                {
                    if (txtbxNewPasUpDelUs.Text == txtbxPassUpDeUs.Text)
                    {
                        _userDal.Uptade(new User
                        {
                            Id = Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value),
                            Name = txtbxNameUpDeUs.Text,
                            password = txtbxPassUpDeUs.Text,


                        });
                        LoadUsers();
                        MessageBox.Show("Uptaded");
                        txtbxNameUpDeUs.Text = "";
                        txtbxPassUpDeUs.Text = "";
                       
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else {
                    MessageBox.Show("Please control the checkbox");
                        }
            }catch(Exception ex) { }
        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            if (tabControl1.SelectedTab == tabPageUptade) {
            txtbxNameUpDeUs.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            txtbxPassUpDeUs.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
             }
            else if (tabControl1.SelectedTab == tabPageDelete){

                txtbxDelName.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
                txtbxDelPass.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
                    }
            }catch(Exception ex)
            {

            }
        }
        private void btnUsDe_Click(object sender, EventArgs e)
        {
            try {
                if (checkBoxcontdelete.Checked == true)
                {
                    if (txtbxDelPass.Text == txtbxDelContPass.Text)
                    {
                        _userDal.Delete(new User
                        {
                            Id = Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value)
                        });
                        LoadUsers();
                        MessageBox.Show("Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else {
                    MessageBox.Show("Please control the checkbox");
                        }
            }
            catch(Exception ex) { }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           
         LoadUsers();
        }
 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { 
                if(textBoxId.Text == "")
                {
                    LoadUsers();
                }
            var result = _userDal.GetId(Convert.ToInt32(textBoxId.Text));
            dgvUser.DataSource = result; 
            }
            catch (Exception ex)
            {
                 
            }
            
        }

     
        private void txtbxUsPass_TextChanged(object sender, EventArgs e)
        {
           
                int numberrof = txtbxUsPass.Text.Length;
                if (numberrof > 0 && numberrof < 6)
                {
                    progressBar1.Value = 1;
                    progressBar1.ForeColor = Color.Red;
                    labelpass.Text = "Weak";
                }
                else if (numberrof >= 6 && numberrof < 8)
                {
                    progressBar1.Value = 2;
                    progressBar1.ForeColor = Color.Yellow;
                    labelpass.Text = "Strong";
                }
                else if (numberrof >= 8)
                {
                    progressBar1.Value = 3;
                    progressBar1.ForeColor = Color.Green;
                    labelpass.Text = "Very Strong";
                }
                else
                {
                    progressBar1.Value = 0;
                }

            
        }
        
    
    }
    }

