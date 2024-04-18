using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Diplom
{
    public partial class Admin : Form
    {
        DataBase dataBase = new DataBase();
        public Admin()
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
            string querystring = $"SELECT Id_club, Логин, Пароль FROM Zal WHERE Логин = '{login}' AND Пароль = '{password}'";
            dataBase.openConnectoin();
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                int id = (int)table.Rows[0]["Id_club"];
                SportZal sportZal = new SportZal(id);
                sportZal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Пользователя не существует!");
            }
            dataBase.closeConnectoin();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
