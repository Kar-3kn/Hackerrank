using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem
{
    public partial class coading : Form
    {
        public coading()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        private TimeSpan ts;

        public void add(string timespan)
            {
                

                sql.Open();

                SqlCommand cmd = new SqlCommand("insert into Learning values('" + user.username + "','" + "forloop" + "','" + user.btn1Click + "','" + user.btn2click + "' ,'" + timespan + "')", sql);

                //  cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.ExecuteNonQuery();

                sql.Close();



            }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\user\\Desktop\\program.txt", textBox1.Text);
            File.WriteAllText("C:\\Users\\user\\Desktop\\midsem.py", textBox1.Text);

            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\python.exe";

            var script = @"C:\Users\user\Desktop\midsem.py";

            psi.Arguments = $"\"{script}\"";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
                

            }

            textBox2.Text = results;
            textBox3.Text = errors;

            if (results.ToString().Replace(Environment.NewLine, "") == "12345")
            {
                label4.ForeColor = Color.Green;
                user.btn2click = DateTime.Now;
                 ts = user.btn2click.Subtract(user.btn1Click);
                string formatted = ts.ToString(@"dd\.hh\:mm\:ss");
                add(formatted);
            }
            else
                label4.ForeColor = Color.Red;

            
              
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void coading_Load(object sender, EventArgs e)
        {
            label1.Text = "Write a python program to display number from 1 to 5";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ifstatement next = new ifstatement();
            next.Show();
        }
    }
}
