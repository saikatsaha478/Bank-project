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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            label7.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_depup_Click(object sender, EventArgs e)
        {
            Banking_dbEntities context = new Banking_dbEntities();
            RegisterForm acc = new RegisterForm();
            Deposit dp = new Deposit();
            dp.Date = label7.Text;
            dp.AccountNo = Convert.ToDecimal(textBox1.Text);
            dp.Name = textBox2.Text;
            dp.OldBalance = Convert.ToDecimal(textBox3.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(textBox4.Text);
            context.Deposits.Add(dp);
            context.SaveChanges();
            Decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in context.userAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            item.Balance = item.Balance + Convert.ToDecimal(textBox4.Text);
            context.SaveChanges();
            MessageBox.Show("Sucessfully Deposited");
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            Banking_dbEntities context = new Banking_dbEntities();
            Decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in context.userAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            textBox2.Text = item.Name;
            textBox3.Text = Convert.ToString(item.Balance);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 m1 = new Menu2();
            m1.Show();
        }
    }
}
