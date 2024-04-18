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
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace Diplom2
{
    public partial class Registration : Form
    {
        DataBase dataBase = new DataBase();
        int num;
        public Registration()
        {
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {

            // Открываем подключение
            dataBase.openConnectoin();

            // SQL запрос для выбора всех уникальных названий из столбца [Название]
            string query = "SELECT DISTINCT [Название] FROM [Diplom].[dbo].[Zal]";

            // Создаем команду для выполнения запроса
            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                // Выполняем запрос и получаем результат
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Проверяем, есть ли строки в результате запроса
                    if (reader.HasRows)
                    {
                        // Проходим по всем строкам результата
                        while (reader.Read())
                        {
                            // Получаем значение из столбца [Название]
                            string name = reader.GetString(0);

                            // Добавляем значение в comboBox
                            comboBox1.Items.Add(name);

                        }
                    }
                    dataBase.closeConnectoin();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var password = Md5.hashPassword(textBox4.Text);

            if (
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Вы заполнили не все поля.");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Вы не подтвердили почту");
                }
                else
                {
                    if (textBox2.Text == textBox4.Text)
                    {
                        if (IsEmailExists(textBox3.Text))
                        {
                            MessageBox.Show("Адрес электронной почты уже существует в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (textBox5.Text == num.ToString())
                            {
                                // Добавление новой записи в базу данных
                                string query = "INSERT INTO Users (Пароль, Почта, Id_club) VALUES ( @Пароль, @Email, @Id_club)";
                                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                                command.Parameters.AddWithValue("@Пароль", password);
                                command.Parameters.AddWithValue("@Email", textBox3.Text);
                                command.Parameters.AddWithValue("@Id_club", IsId_club(comboBox1.Text));
                                dataBase.openConnectoin();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Вы зарегестрировались!");
                                dataBase.closeConnectoin();
                                this.Close();
                                Form1 form1 = new Form1();  
                                form1.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Неверный код подтверждения!");
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }
                }
            }
        }

        private bool IsEmailExists(string email)
        {

            string query = "SELECT COUNT(*) FROM Users WHERE Почта = @Email";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@Email", email);
            dataBase.openConnectoin();
            int count = (int)command.ExecuteScalar();
            dataBase.closeConnectoin();
            return count > 0;

        }
        private int IsId_club(string nameClub)
        {
            string query = "SELECT [Id_club] FROM [Diplom].[dbo].[Zal] WHERE [Название] = @ClubName";
            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                // Добавление параметра для названия клуба
                command.Parameters.AddWithValue("@ClubName", nameClub);


                dataBase.openConnectoin();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int clubId = (int)result;
                    dataBase.closeConnectoin();
                    return clubId;

                }
                return 0;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void SendMessage()
        {
            // Настройки SMTP-сервера Mail.ru
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string smtpUsername = "nik.isaev2004@mail.ru";
            string smtpPassword = "hG4APvZNVuTJHBbD1g9P";

            // Создаем объект клиента SMTP
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                // Настройки аутентификации 
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(textBox3.Text);
                    mailMessage.Subject = "Подтверждение аккаунта";
                    Random rnd = new Random();
                    num = rnd.Next();
                    mailMessage.Body = "Ваш код подтверждения: " + num.ToString();

                    try
                    {
                        // Отправляем сообщение
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Код успешно отправлен");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка отправки сообщения: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Вы не ввели почту");
            }
            else {
                SendMessage();
            }
          
        }
    }
}
