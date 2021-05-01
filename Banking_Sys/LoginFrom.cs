using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking_Sys
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=SAIKAT\SQLEXPRESS;Initial Catalog=Banking_db;Integrated Security=True");
        private void lbl_log_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sdf = new SqlDataAdapter("select status from Db1 where username ='" +textBox1.Text +"' and password='"+textBox2.Text+"' ", con);
            DataTable dt = new DataTable();
            sdf.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                if (dt.Rows[0][0].ToString() == "manager")
                {
                    Menu m1 = new Menu();
                    m1.Show();
                }
                else if (dt.Rows[0][0].ToString() == "client")
                {
                    Menu2 m2 = new Menu2();
                    m2.Show();
                }
            }
            else
            {
                MessageBox.Show("Make sure that Username & Password are correct");
            }

        }

        private void lbl_sign_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm a1 = new RegisterForm();
            a1.Show();

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
