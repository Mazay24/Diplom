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

namespace NEW
{
    public partial class Abonent : Form
    {
        public Abonent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            string sqlFormattedDate = date.ToString("yyyy-MM-dd");
            SqlConnection conn = new SqlConnection("Data Source=MAZAY24\\MSSQLSERVER01;Initial Catalog=Lab;Integrated Security=True;Encrypt=False");
            if (textBox1.Text != "" && comboBox1.Text != "")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO INFO(Дата, Статус, Проблема) VALUES ('" + sqlFormattedDate + "','" + comboBox1.Text + "', '" + textBox1.Text + "')", conn);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Запись создана!");
                    textBox1.Text = String.Empty;
                    comboBox1.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void Abonent_Load(object sender, EventArgs e)
        {

        }
    }
}
