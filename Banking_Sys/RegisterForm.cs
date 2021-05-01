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

namespace Banking_Sys
{
    public partial class RegisterForm : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        Banking_dbEntities bse;
        MemoryStream ms;
        //private readonly object accnotext;

        public RegisterForm()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loaddate()
        {
            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void loadaccount()
        {
            //throw new NotImplementedException();
            bse = new Banking_dbEntities();
            var item = bse.userAccounts.ToArray();
            no = item.LastOrDefault().Account_no + 1;
            textBox1.Text = Convert.ToString(no);
        }

        private void loadstate()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Dhaka");
            comboBox1.Items.Add("Chittagong");
            comboBox1.Items.Add("Rajshahi");
            comboBox1.Items.Add("Khulna");
            comboBox1.Items.Add("Barisal");
            comboBox1.Items.Add("Dinajpur");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    gender = "Female";
                }
                else if (radioButton5.Checked)
                {
                    gender = "Other";
                }
                if (radioButton4.Checked)
                {
                    m_status = "Married";
                }
                else if (radioButton3.Checked)
                {
                    m_status = "Unmarried";
                }
                bse = new Banking_dbEntities();
                userAccount acc = new userAccount();
                acc.Account_no = Convert.ToDecimal(textBox1.Text);
                acc.Name = textBox2.Text;
                acc.DOB = dateTimePicker1.Value.ToString();
                acc.PhoneNo = textBox3.Text;
                acc.Address = textBox4.Text;
                acc.District = textBox8.Text;
                acc.State = comboBox1.SelectedItem.ToString();
                acc.Gender = gender;
                acc.Martial_status = m_status;
                acc.Mother_Name = textBox6.Text;
                acc.Father_Name = textBox5.Text;
                acc.Balance = Convert.ToDecimal(textBox7.Text);
                acc.Date = label3.Text;
                acc.Picture = ms.ToArray();
                bse.userAccounts.Add(acc);
                bse.SaveChanges();
                MessageBox.Show("File saved");
            }
            else
            {
                MessageBox.Show("Please Fill up");
            }
            
        }

        private void btn_upld_Click(object sender, EventArgs e)
        {
            OpenFileDialog opndblg = new OpenFileDialog();
            if (opndblg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opndblg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
