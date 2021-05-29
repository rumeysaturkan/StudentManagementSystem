
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        UserDal _userDal = new UserDal();
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtbxLogName.Text == "" || txtbxLogPass.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Users where Name=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtbxLogName.Text);
                cmd.Parameters.AddWithValue("@password", txtbxLogPass.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    HomepageForm fm = new HomepageForm();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void lblLogClose_Click_1(object sender, EventArgs e)
        {
         this.Close();
        }


        private void buttonEx_Click(object sender, EventArgs e)
        { this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) { 
            this.WindowState = FormWindowState.Maximized;}
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }

    }
    
            


