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
    public partial class Form1 : Form
    {
        public static int esy=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 next = new Form2();
            
   
            next.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }
      

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            esy++;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            esy++;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            esy++;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
