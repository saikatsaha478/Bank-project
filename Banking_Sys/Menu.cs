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
    public partial class Menu : Form
    {
        Banking_dbEntities dbe = new Banking_dbEntities();
        BindingList<userAccount> bi;
        public Menu()
        {
            InitializeComponent();
            //status_lbl.Text = status;
            bindgrid();
        }

        /*public Menu()
        {
        }*/

        private void bindgrid()
        {
            //throw new NotImplementedException();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void cus_details_Click(object sender, EventArgs e)
        {
            Banking_dbEntities bs = new Banking_dbEntities();
            var item = bs.userAccounts.ToList();
            dataGridView1.DataSource = item;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new Banking_dbEntities();
            var item = dbe.userAccounts.Where(a => a.Name == textBox1.Text);
            foreach (var item1  in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_Form u1 = new Update_Form();
            u1.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new Banking_dbEntities();
            var item = Convert.ToString(textBox1.Text);
            userAccount acc = dbe.userAccounts.First(s=>s.Name.Equals(item));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
        }

        private void btn_fd_Click(object sender, EventArgs e)
        {
            this.Close();
            FDform fd = new FDform();
            fd.Show();
        }

        private void btn_sheet_Click(object sender, EventArgs e)
        {
            this.Close();
            BalanceSheet bs = new BalanceSheet();
            bs.Show();
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
