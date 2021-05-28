using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem
{
    public partial class leaderboard : Form
    {
        public leaderboard()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void leaderboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand com;
            try

            {

                com = new SqlCommand();

                com.Connection = con;

                com.CommandText = "select * from Ranking ORDER BY mark DESC"; 

                con.Open();

                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)

                {

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    dataGridView1.DataSource = dt;

                }

            }

            finally

            {

                con.Close();

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start n = new start();
            n.Show();
        }
    }
}

