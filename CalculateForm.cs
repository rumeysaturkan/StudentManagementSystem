using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Forms
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string secilendosyayolu;

           string FileName = openFileDialog1.FileName;
           // OpenFileDialog file = new OpenFileDialog1();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(FileName);
                    if (fi.Exists)
                    {
                        secilendosyayolu = FileName;
                        labelPath.Text = secilendosyayolu;
                    }
                    else
                    {
                        MessageBox.Show("Not File");

                    }
                }
            }
            catch (Exception ex)
            {

            }


        }






        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelPath.Text == " ")
                {
                    MessageBox.Show("Please Choose File");
                }
                else
                {
                    string line = "";
                    StreamReader sr = new StreamReader(labelPath.Text);
                    while (true)
                    {
                        line = sr.ReadLine();

                        if (line == null)
                        {
                            break;
                        }
                        listBox1.Items.Add(line);
                        string[] notlar = line.Split(' ');
                        double ort = (Convert.ToInt32(txtbxMidterm.Text) * Convert.ToDouble(notlar[1])) / 100 + (Convert.ToInt32(txtbxFinal.Text) * Convert.ToDouble(notlar[2])) / 100;
                        listBox2.Items.Add(notlar[0] + " : " + ort);
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
            }
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomepageForm homepage = new HomepageForm();
            homepage.Show();
            this.Close();
        }

      
        }
    }

