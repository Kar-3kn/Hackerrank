using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            easy=Form1.esy;
            medium = Form2.med;
            InitializeComponent();
            
        }
        int easy,medium;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start s = new start();
            s.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label11.Text = user.generate;
            int final = easy + medium;
            label5.Text = final.ToString();
            label6.Text = easy.ToString();
            label7.Text = medium.ToString();
            label10.Text = user.username;
            if(easy >=3 && medium >=3)
            {
                label4.Text = "You have good knowledge in basics and intermediate\n" +
                    "                        Continue learning more";
            }

            if(easy <= 2 )
            {
                label4.Text = "Please learn basic concepts of python more\n " +
                   "                      Continue learning more";

            }

            if(easy >=3 && medium>=0)
            {
                label4.Text = "You have good knowledge in basics please learn more advance concepts in python \n " +
                    "                            Continue learning more ";
                  

            }


            
        }
    }
}
