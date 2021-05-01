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
    public partial class withdrawalFrom : Form
    {
        public withdrawalFrom()
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
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void btn_dtl_Click(object sender, EventArgs e)
        {
            Banking_dbEntities dbe = new Banking_dbEntities();
            decimal b = Convert.ToDecimal(acctext.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.Balance);

        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            Banking_dbEntities dba = new Banking_dbEntities();
            RegisterForm nacc = new RegisterForm();
            debit dp = new debit();
            dp.Date = datelbl.Text;
            dp.Account_no = Convert.ToDecimal(acctext.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(amounttxt.Text);
            dba.debits.Add(dp);
            dba.SaveChanges();
            decimal b = Convert.ToDecimal(acctext.Text);
            var item = (from u in dba.userAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            item.Balance = item.Balance - Convert.ToDecimal(acctext.Text);
            dba.SaveChanges();
            MessageBox.Show("Thank You For Transaction");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 mn = new Menu2();
            mn.Show();
        }
    }
}
