using Microsoft.Data.SqlClient;
using System.Data;

namespace Diplom2
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            var password = Md5.hashPassword(textBox2.Text); // �������� ��������� ������

            dataBase.openConnectoin();
            string query = "SELECT Id_user, Id_club FROM Users WHERE [�����] = @����� AND [������] = @Password";
            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@�����", login);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(reader.GetOrdinal("Id_user"));
                        int clubId = reader.GetInt32(reader.GetOrdinal("Id_club"));

                        // ������� ���������� �������� � ����������� Entry
                        Entry entry = new Entry(userId, clubId);
                        entry.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("������������ ����� ��� ������!");
                    }
                }
                dataBase.closeConnectoin();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Close();
        }

        private void label3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recovery recovery = new Recovery();
            recovery.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
            this.Close();

        }
    }
}

