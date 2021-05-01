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
    public partial class FixedDeposit : Form
    {
        public FixedDeposit()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Banking_dbEntities dbe = new Banking_dbEntities();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            var accounts = dbe.userAccounts.Where(x=>x.Account_no == accno).SingleOrDefault();
            FD fdfrom = new FD();
            fdfrom.Account_No = Convert.ToDecimal(accnotxt.Text);
            fdfrom.Mode = comboBox1.SelectedItem.ToString();
            fdfrom.Taka = Convert.ToDecimal(takatxt.Text);
            fdfrom.Period = Convert.ToInt32(periodtxt.Text);
            fdfrom.Interest_Rate = Convert.ToDecimal(intersttxt.Text);
            fdfrom.Start_Date = DateTime.UtcNow.ToString("dd/MM/yyyy");
            fdfrom.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("dd/MM/yyyy");
            fdfrom.Maturity_Amount = (Convert.ToDecimal(takatxt.Text) * Convert.ToInt32(intersttxt.Text) * Convert.ToInt32(periodtxt.Text) / (100 * 12 * 30)) + (Convert.ToDecimal(takatxt.Text));
            dbe.FDs.Add(fdfrom);
            decimal amount = Convert.ToDecimal(takatxt.Text);
            decimal totalamount = Convert.ToDecimal(accounts.Balance);
            decimal fdamount = totalamount - amount;
            accounts.Balance = fdamount;
            dbe.SaveChanges();
            MessageBox.Show("FD Started Now");

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 mn = new Menu2();
            mn.Show();
        }
    }
}
