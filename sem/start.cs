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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.btn1Click = DateTime.Now;
            this.Hide();
            Form1 next = new Form1();
            next.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user.btn1Click = DateTime.Now;
            this.Hide();
            coading next = new coading();
            next.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 n = new Form4();
            n.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            report n = new report();
            n.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user.btn1Click = DateTime.Now;
            this.Hide();
            Form7 n = new Form7();
            n.Show();

        }
    }
}
