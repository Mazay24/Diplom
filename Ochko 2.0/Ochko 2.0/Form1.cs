using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ochko_2._0
{
    public partial class Form1 : Form
    {
        int value1 = 0;
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Random rand = new Random();
            int value1 = rand.Next(1, 11);
            textBox1.Text = Convert.ToString(value1);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Random rand2 = new Random();
            int value2 = rand2.Next(1, 11);
            textBox2.Text = Convert.ToString(value2);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int value3 = rand.Next(1, 11) + value1;
            textBox1.Text = Convert.ToString(value3);

        }
    }
}
