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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from [User] where Username ='" + name.Text + "' and Password ='" + password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                // frmMain objFrmMain = new frmMain();
                // this.Hide();
                user.username = name.Text;
                user.password = password.Text;
                // objFrmMain.Show();
                this.Hide();
                start n = new start();
                n.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
               
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 reg = new Form6();
            reg.Show();
        }
    }
}
