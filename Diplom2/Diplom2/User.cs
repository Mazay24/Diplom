using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2
{
    public partial class User : Form
    {
        DataBase dataBase = new DataBase();
        int id_user;
        public User(int id_user)
        {
            this.id_user = id_user;
            InitializeComponent();
            Retrieve();
            LoadUserData();
        }
        public void Retrieve()
        {
            try
            {
                dataBase.openConnectoin();
                using (var command = dataBase.getConnection().CreateCommand())
                {
                    command.CommandText = "SELECT Фото FROM Users WHERE Id_user = @id";
                    command.Parameters.AddWithValue("@id", id_user);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("Фото")))
                            {
                                byte[] imageData = (byte[])reader["Фото"];
                                using (var memoryStream = new MemoryStream(imageData))
                                {
                                    pictureBox1.Image?.Dispose(); // Освобождение ресурсов предыдущего изображения, если оно есть
                                    pictureBox1.Image = Image.FromStream(memoryStream);
                                }
                            }
                            else
                            {
                                // Обработка случая, когда значение поля "Картинка" равно NULL

                            }
                        }
                        else
                        {
                            // Обработка случая, когда запись с указанным ID не найдена
                            MessageBox.Show("Запись с указанным ID не найдена.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке изображения: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnectoin(); // Гарантированное закрытие соединения с базой данных
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadUserData()
        {
            try
            {
                dataBase.openConnectoin();

                string query = @"
SELECT [Имя], [Фамилия], [Телефон], [Сеть]
FROM [Diplom].[dbo].[Users]
WHERE [Id_user] = @UserId";

                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@UserId", id_user);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Если нашли пользователя
                        {
                            label1.Text = reader["Имя"].ToString();
                            label2.Text = reader["Фамилия"].ToString();
                            label3.Text = reader["Телефон"].ToString();
                            label4.Text = reader["Сеть"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных пользователя: " + ex.Message);
            }
            dataBase.closeConnectoin();
        }
    }
}
