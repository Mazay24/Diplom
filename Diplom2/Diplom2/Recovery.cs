using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace Diplom2
{
    public partial class Recovery : Form
    {
        int num;
        DataBase dataBase = new DataBase();
        public Recovery()
        {
            InitializeComponent();
        }
        private bool CheckEmailExists()
        {
            try
            {
                dataBase.openConnectoin();

                string query = @"
                    SELECT COUNT(*)
                    FROM [Diplom].[dbo].[Users]
                    WHERE [Почта] = @Email";

                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@Email", textBox1.Text);
                    int userCount = (int)command.ExecuteScalar();
                    return userCount > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка при проверке электронной почты: " + ex.Message);
                return false; // В случае ошибки возвращаем false
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var password = Md5.hashPassword(textBox4.Text);

            if (
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Вы заполнили не все поля.");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Вы не подтвердили почту");
                }
                else
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        
                            if (textBox2.Text == num.ToString())
                            {

                                try
                                {
                                    dataBase.openConnectoin();

                                    string query = @"
                                        UPDATE [Diplom].[dbo].[Users]
                                        SET [Пароль] = @NewPassword
                                        WHERE [Почта] = @UserId";
                                    using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                                    {
                                        command.Parameters.AddWithValue("@NewPassword", password);
                                        command.Parameters.AddWithValue("@UserId", textBox1.Text);

                                        int rowsAffected = command.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Пароль успешно обновлен.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Пользователь не найден.");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка при обновлении пароля: " + ex.Message);
                                }
                            dataBase.closeConnectoin();
                            }
                            else
                            {
                                MessageBox.Show("Неверный код");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }
                }
            }
        }
        private void SendMessage()
        {
            // Настройки SMTP-сервера Mail.ru
            string smtpServer = "smtp.mail.ru"; //smpt сервер
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
                    mailMessage.To.Add(textBox1.Text);
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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Вы не ввели почту");
            }
            else
            {
                bool exists = CheckEmailExists();
                if (exists)
                {
                    SendMessage();
                }
                else
                {
                    MessageBox.Show("Электронная почта не найдена в базе данных.");
                }
            }
            
        }
    }
}
