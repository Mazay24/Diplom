using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labba4
{
    public partial class Form2 : Form
    {
        public String FileName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = FileName; }
        }
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            fontDialog1.ShowColor = true;
        }
    }
}
