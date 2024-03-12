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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;
           

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            md5 md5 = new md5();    
            string querystring = $"SELECT ID, Логин, Пароль, Роль FROM Auth WHERE Логин = '{login}' AND Пароль = '{md5.hashPassword(password)}'";
            SqlConnection conn = new SqlConnection("Data Source=MAZAY24\\MSSQLSERVER01;Initial Catalog=Lab;Integrated Security=True;Encrypt=False");
            conn.Open();  
            SqlCommand command = new SqlCommand(querystring, conn);


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                SqlCommand rol = new SqlCommand($"SELECT Роль From Auth Where Логин = '{login}'", conn);
                string role = (string)rol.ExecuteScalar();
                if (role == "абонент")
                {
                    Abonent abonent = new Abonent();
                    abonent.Show();
                }
                if (role == "админ")
                {
                    Admin admin = new Admin();
                    admin.Show();

                }
                if (role == "оператор")
                {
                    Operator @operator = new Operator();   
                    @operator.Show();

                }

            }
            else {
                MessageBox.Show("Пользователя не существует");
            }
        }
    }
}
