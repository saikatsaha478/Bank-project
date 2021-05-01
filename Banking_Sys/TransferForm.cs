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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            Banking_dbEntities dbe = new Banking_dbEntities();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name;
            crtamounttxt.Text = Convert.ToString(item.Balance);
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            Banking_dbEntities dbe = new Banking_dbEntities();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_no == b
                        select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.Balance);
            decimal totalbal = Convert.ToDecimal(amounttxt.Text);
            decimal transferacc = Convert.ToDecimal(desamounttxt.Text);
            if (b1>totalbal)
            {
                userAccount item2 = (from u in dbe.userAccounts
                                     where u.Account_no == transferacc
                                     select u).FirstOrDefault();
                item2.Balance = item2.Balance + totalbal;
                item.Balance = item.Balance - totalbal;
                Transfer transfer = new Transfer();
                transfer.Account_No = Convert.ToDecimal(acctxt.Text);
                transfer.ToTransfer = Convert.ToDecimal(desamounttxt.Text);
                transfer.Date = DateTime.UtcNow.ToString();
                transfer.Name = nametxt.Text;
                transfer.balance = Convert.ToDecimal(amounttxt.Text);
                dbe.Transfers.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("Money Transfered");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 mn = new Menu2();
            mn.Show();
        }
    }
}
