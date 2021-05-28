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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
      
            easy = Form1.esy;
        }
        int easy;
            public static int med = 0;
        private void label2_Click(object sender, EventArgs e)
        {
    
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            med++;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            med++;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            med++;
        }
       
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");

        public void add(string timespan)
        {
            var final = easy + med;

            sql.Open();

                SqlCommand cmd = new SqlCommand("insert into TestTracking values('" + user.username + "','" + user.btn1Click + "','" + user.btn2click+ "' ,'" + timespan + "','" + final.ToString() + "')", sql);

                //  cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.ExecuteNonQuery();
               
                sql.Close();

               


            
        }








        private void button1_Click(object sender, EventArgs e)
        {
            user.btn2click= DateTime.Now;
            TimeSpan timespan;
            timespan = user.btn2click.Subtract(user.btn1Click);
            string time = timespan.ToString(@"dd\.hh\:mm\:ss");
            user.generate = timespan.ToString(@"dd\.hh\:mm\:ss");
            add(time);

            this.Hide();
            Form3 result = new Form3();
            result.Show();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
