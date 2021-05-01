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
    public partial class Update_Form : Form
    {
        Banking_dbEntities dba = new Banking_dbEntities();
        MemoryStream ms;
        BindingList<userAccount> ba;
        public Update_Form()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dba = new Banking_dbEntities();
            decimal accno = Convert.ToDecimal(acctxt.Text);
            userAccount userAccount = dba.userAccounts.First(s=>s.Account_no.Equals(accno));
            userAccount.Account_no = Convert.ToDecimal(acctxt.Text);
            userAccount.Name = nametxt.Text;
            userAccount.DOB = dateTimePicker2.Value.ToString();
            userAccount.Mother_Name = mothertxt.Text;
            userAccount.Father_Name = fathertxt.Text;
            if (radioButton1.Checked == true)
            {
                userAccount.Gender = "Male";
            }
            else
            {
                if (radioButton2.Checked == true)
                    userAccount.Gender = "Female";
            }
            if (radioButton4.Checked == true)
            {
                userAccount.Martial_status = "Married";
            }
            else
            {
                if (radioButton5.Checked == true)
                    userAccount.Martial_status = "Unmarried";
            }
            Image img = pictureBox1.Image;
            if (img.RawFormat != null)
            {
                if (ms != null)
                {
                    img.Save(ms,img.RawFormat);
                    userAccount.Picture = ms.ToArray();
                }
            }
            userAccount.Address = addresstext.Text;
            userAccount.District = districttext.Text;
            userAccount.State = statetext.Text;
            dba.SaveChanges();
            MessageBox.Show("Record Updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ba = new BindingList<userAccount>();
            dba = new Banking_dbEntities();
            var item = dba.userAccounts.Where(a => a.Name == nametxt.Text);
            foreach (var item1 in item)
            {
                ba.Add(item1);
            }
            dataGridView1.DataSource = ba;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dba = new Banking_dbEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dba.userAccounts.Where(a => a.Account_no == accno).FirstOrDefault();
            acctxt.Text = item.Account_no.ToString();
            nametxt.Text = item.Name;
            nametxt.Text = item.Mother_Name;
            fathertxt.Text = item.Father_Name;
            phnnotxt.Text = item.PhoneNo;
            addresstext.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            districttext.Text = item.District;
            statetext.Text = item.State;
            if (item.Gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else if (item.Gender == "Female")
            {
                radioButton2.Checked = true;
            }
            else if (item.Gender == "Other")
            {
                radioButton3.Checked = true;
            }
            if (item.Martial_status == "Married")
            {
                radioButton4.Checked = true;
            }
            else if (item.Martial_status == "Unmarried")
            {
                radioButton5.Checked = true;
            }
        }

        private void btn_reup_Click(object sender, EventArgs e)
        {
            OpenFileDialog opndblg = new OpenFileDialog();
            if (opndblg.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(opndblg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms,img.RawFormat);
            }
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            ba.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dba = new Banking_dbEntities();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dba.userAccounts.First(s => s.Account_no.Equals(a));
            dba.userAccounts.Remove(acc);
            dba.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.Show();
        }
    }
}
