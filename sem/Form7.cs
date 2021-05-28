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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int a = 0, b = 0, c = 0; 
        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = "Given an integer n perform the following conditional actions" +
                "1)If is odd print Weird  " +
                "2)if is even and in the inclusive range of 2 to 5 print Not Weird" +
                "3)else print Weird";
        }
        private void check()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\python.exe";

            var script = @"C:\Users\user\Desktop\midsem.py";


            psi.Arguments = $" \"{script}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;


            var results = "";

            /* case1 */

            using (var process = Process.Start(psi))
            {
                StreamWriter myStreamWriter = process.StandardInput;
                String inputText;


                inputText = "1";
                
                if (inputText.Length > 0)
                {

                    myStreamWriter.WriteLine(inputText);
                    
                }

                
                results = process.StandardOutput.ReadToEnd().ToString().Replace(Environment.NewLine, "");

                Console.WriteLine(results);

                if (results == "Weird")
                {
                    label4.ForeColor = Color.Green;
                    a = 1;
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    a = 0;
                }

            }

            textBox2.Text = results;
            


            /* case2 */

            using (var process = Process.Start(psi))
            {
                StreamWriter myStreamWriter = process.StandardInput;
                String inputText;


                Console.WriteLine("Enter a line of text (or press the Enter key to stop):");

                inputText = "2";
                
                if (inputText.Length > 0)
                {

                    myStreamWriter.WriteLine(inputText);
                    

                }
                results = process.StandardOutput.ReadToEnd().ToString().Replace(Environment.NewLine, "");

                if (results == "Not Weird")
                {
                    label5.ForeColor = Color.Green;
                    b = 1;
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    b = 0;
                }



            }

            /* case3 */

            using (var process = Process.Start(psi))
            {
                StreamWriter myStreamWriter = process.StandardInput;
                String inputText;


                Console.WriteLine("Enter a line of text (or press the Enter key to stop):");

                inputText = "10";

                if (inputText.Length > 0)
                {

                    myStreamWriter.WriteLine(inputText);


                }
                results = process.StandardOutput.ReadToEnd().ToString().Replace(Environment.NewLine, "");

                if (results == "Weird")
                {
                    c = 1;
                    label3.ForeColor = Color.Green;
                }
                else
                {
                    c = 0;
                    label3.ForeColor = Color.Red;
                }



            }

        }

            private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\user\\Desktop\\program.txt", textBox1.Text);
            File.WriteAllText("C:\\Users\\user\\Desktop\\midsem.py", textBox1.Text);
           


            check();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");
        private TimeSpan ts;

        public void add(int result,string formatted)
        {


            sql.Open();

            SqlCommand cmd = new SqlCommand("insert into Ranking values('" + user.username + "','" + result + "','" + formatted + "')", sql);

            //  cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.ExecuteNonQuery();

            sql.Close();



        }


        private void button2_Click(object sender, EventArgs e)
        {
            int result = a + b + c;
            
            user.btn2click = DateTime.Now;
            ts = user.btn2click.Subtract(user.btn1Click);
            string formatted = ts.ToString(@"dd\.hh\:mm\:ss");
            add(result,formatted);
            this.Hide();
            leaderboard n = new leaderboard();
            n.Show();

        }
    }
}
