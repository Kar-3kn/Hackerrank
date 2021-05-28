using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();

                SqlCommand cmd = new SqlCommand("insert into [User] values('" + uname.Text + "','" + name.Text + "','" + email.Text + "' ,'" +password.Text + "','" + cpass.Text + "')", sql);

                //  cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register successfull");
                sql.Close();

                this.Hide();
                Login next = new Login();
                next.Show();


            }

            catch
            {

                MessageBox.Show("Something went wrong try again");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
