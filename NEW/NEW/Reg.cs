using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NEW
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            md5 md5 = new md5();
            var password = md5.hashPassword(textBox5.Text);
            SqlConnection conn = new SqlConnection("Data Source=MAZAY24\\MSSQLSERVER01;Initial Catalog=Lab;Integrated Security=True;Encrypt=False");
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "")
            {
                if (textBox5.Text == textBox6.Text)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO AUTH(Имя, Фамилия, Должность, Роль, Логин, Пароль) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" +password+ "')", conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i!= 0)
                    {
                        MessageBox.Show("Вы зарегестрированы!");
                    }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля!");
            }
            conn.Close();
             
        }
    }
}
