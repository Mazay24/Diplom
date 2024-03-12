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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MAZAY24\\MSSQLSERVER01;Initial Catalog=Lab;Integrated Security=True;Encrypt=False");
            conn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM INFO", conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "INFO");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "INFO";
            conn.Close();
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
                    

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM INFO", conn);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds, "INFO");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "INFO";
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }
    }
}