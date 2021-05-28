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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

            sql.Open();

            SqlCommand cmd = new SqlCommand("update [User] set Password='" + password.Text + "' , Email='" + email.Text + "' where Username='" + name.Text + "'", sql);

            //  cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfull");
            sql.Close();

            this.Hide();
            start next = new start();
            next.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            name.Text = user.username;
            password.Text = user.password;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
          
            
        }
    }
    }

