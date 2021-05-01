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
    public partial class FDform : Form
    {
        BindingList<FD> be;
        Banking_dbEntities dbe;
        public FDform()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            be = new BindingList<FD>();
            dbe = new Banking_dbEntities();
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            MessageBox.Show(date);
            var item = dbe.FDs.Where(a=>a.Start_Date.Equals(date));
            dataGridView1.DataSource = item.ToList();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.Show();
        }
    }
}
