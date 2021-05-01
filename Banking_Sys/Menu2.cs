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
    public partial class Menu2 : Form
    {
        Banking_dbEntities dbe = new Banking_dbEntities();
        BindingList<userAccount> bi;
        public Menu2()
        {
            InitializeComponent();
            //label2.Text = status;
        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DepositForm c1 = new DepositForm();
            c1.Show();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            this.Close();
            TransferForm b1 = new TransferForm();
            b1.Show();
        }

        private void btn_fd_Click(object sender, EventArgs e)
        {
            this.Close();
            FixedDeposit m1 = new FixedDeposit();
            m1.Show();
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePasswordForm n1 = new ChangePasswordForm();
            n1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            withdrawalFrom w1 = new withdrawalFrom();
            w1.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new Banking_dbEntities();
            var item = dbe.userAccounts.Where(a => a.Name == textBox_show.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrom lg = new LoginFrom();
            lg.Show();
            MessageBox.Show("Successfully Log out");
        }
    }
}
