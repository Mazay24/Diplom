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
    public partial class Info : Form
    {
        DataBase dataBase = new DataBase();
        int id_club;
        public Info(int id_club)
        {
            InitializeComponent();
            this.id_club = id_club;
            LoadClubInfoIntoLabels();
            Retrieve();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void LoadClubInfoIntoLabels()
        {


            string sql = "SELECT Логин, Пароль, Название, Описание, Время_работы, Картинка, Телефон, Сети, Адрес FROM Zal WHERE Id_club = @IdClub";
            SqlCommand command = new SqlCommand(sql, dataBase.getConnection());
            command.Parameters.AddWithValue("@IdClub", id_club);

            try
            {
                dataBase.openConnectoin();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    label1.Text = reader["Название"].ToString();
                    label2.Text = FormatDescription(reader["Описание"].ToString());
                    label3.Text = reader["Время_работы"].ToString();
                    label4.Text = reader["Телефон"].ToString();
                    label5.Text = reader["Сети"].ToString();
                    label6.Text = reader["Адрес"].ToString();
                }
                else
                {
                    MessageBox.Show("Запись не найдена.");
                }
                dataBase.closeConnectoin();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        public void Retrieve()
        {
            try
            {
                dataBase.openConnectoin();
                using (var command = dataBase.getConnection().CreateCommand())
                {
                    command.CommandText = "SELECT Картинка FROM Zal WHERE Id_club = @id";
                    command.Parameters.AddWithValue("@id", id_club);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("Картинка")))
                            {
                                byte[] imageData = (byte[])reader["Картинка"];
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
        private string FormatDescription(string description)
        {
            // Разделение текста на строки для обеспечения отступов и переносов
            string formattedDescription = "";
            int lineLength = 30; // Максимальная длина строки

            while (description.Length > lineLength)
            {
                int lastSpaceIndex = description.Substring(0, lineLength).LastIndexOf(' ');
                if (lastSpaceIndex > 0)
                {
                    formattedDescription += description.Substring(0, lastSpaceIndex) + "\n";
                    description = description.Substring(lastSpaceIndex + 1);
                }
                else
                {
                    formattedDescription += description.Substring(0, lineLength) + "\n";
                    description = description.Substring(lineLength);
                }
            }

            formattedDescription += description; // Добавляем оставшуюся часть описания
            return formattedDescription;
        }

    }
}
