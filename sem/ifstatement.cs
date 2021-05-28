using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem
{
    public partial class ifstatement : Form
    {
        public ifstatement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ifstatement_Load(object sender, EventArgs e)
        {
            label1.Text = "Write a python program to compare two number and return it is greatest or equal";
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
            psi.RedirectStandardError = true;
            

            var errors = "";
            var results = "";

            /* case1 */

            using (var process = Process.Start(psi))
            {
                StreamWriter myStreamWriter = process.StandardInput;
                String inputText;
               
                
                    Console.WriteLine("Enter a line of text (or press the Enter key to stop):");

                    inputText = "6";
                    string second = "10";
                    if (inputText.Length > 0)
                    {
                       
                        myStreamWriter.WriteLine(inputText);
                        myStreamWriter.WriteLine(second);
                    }
               
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd().ToString().Replace(Environment.NewLine, "");
                
                Console.WriteLine(results);

                if (results == "greatest")       
                {
                    label4.ForeColor = Color.Green;
                }
                else
                    label4.ForeColor = Color.Red;


            }
            
            textBox2.Text = results;
            textBox3.Text = errors;


            /* case2 */

            using (var process = Process.Start(psi))
            {
                StreamWriter myStreamWriter = process.StandardInput;
                String inputText;


                Console.WriteLine("Enter a line of text (or press the Enter key to stop):");

                inputText = "10";
                string second = "10";
                if (inputText.Length > 0)
                {

                    myStreamWriter.WriteLine(inputText);
                    myStreamWriter.WriteLine(second);
                    
                }
                results = process.StandardOutput.ReadToEnd().ToString().Replace(Environment.NewLine, "");

                if (results == "equal")
                {
                    label5.ForeColor = Color.Green;
                }
                else
                    label5.ForeColor = Color.Red;




            }




        
            
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\user\\Desktop\\program.txt", textBox1.Text);
            File.WriteAllText("C:\\Users\\user\\Desktop\\midsem.py", textBox1.Text);

            check();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            start n = new start();
            n.Show();
        }
    }
}
