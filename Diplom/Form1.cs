using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Diplom
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
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
            string querystring = $"SELECT Id_club, �����, ������ FROM Zal WHERE ����� = '{login}' AND ������ = '{password}'";
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
                MessageBox.Show("������������ �� ����������!");
            }
            dataBase.closeConnectoin();
            
            
        }
    }
}
