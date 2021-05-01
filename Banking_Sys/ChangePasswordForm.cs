using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Sys
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Banking_dbEntities dbe = new Banking_dbEntities();
            if (oldpasstxt.Text != string.Empty || newpasstxt.Text != string.Empty || repasstxt.Text != string.Empty)
            {
                Db1 db = dbe.Db1.FirstOrDefault(a => a.username.Equals(usertext.Text));
                if (db != null)
                {
                    if (db.password.Equals(oldpasstxt.Text))
                    {
                        db.password = newpasstxt.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("Password Changed Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
            }
                
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 mn = new Menu2();
            mn.Show();
        }
    }
}
