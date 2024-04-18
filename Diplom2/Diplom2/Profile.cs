using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom2
{
    public partial class Profile : Form
    {
        DataBase dataBase = new DataBase();
        private int id_user;

        public Profile(int id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
            See();
            Retrieve();
            FillComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }


            }
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
        public void Upload()
        {
            dataBase.openConnectoin();
            using (var command = dataBase.getConnection().CreateCommand())
            {
                command.CommandText = "UPDATE Users SET Фото = @image WHERE [Id_user] = @id";
                command.Parameters.AddWithValue("@id", id_user);

                var image = new Bitmap(pictureBox1.Image);
                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    memoryStream.Position = 0;

                    var sqlParameter = new SqlParameter("@image", SqlDbType.VarBinary, (int)memoryStream.Length)
                    {
                        Value = memoryStream.ToArray()
                    };
                    command.Parameters.Add(sqlParameter);
                }
                command.ExecuteNonQuery();
            }
            dataBase.closeConnectoin();
        }
        private void See()
        {
            dataBase.openConnectoin();

            SqlCommand command = new SqlCommand("SELECT Имя, Фамилия, Телефон, Сеть FROM Users WHERE [Id_user] = @id", dataBase.getConnection());
            command.Parameters.AddWithValue("@id", id_user);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader["Имя"].ToString();
                textBox2.Text = reader["Фамилия"].ToString();
                textBox3.Text = reader["Телефон"].ToString();
                textBox4.Text = reader["Сеть"].ToString();
            }

            reader.Close();
            dataBase.closeConnectoin();
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

        private void button1_Click(object sender, EventArgs e)
        {

            // Получаем Id_club на основе введенного названия клуба
            string getIdClubQuery = @"SELECT TOP (1) [Id_club] FROM [Diplom].[dbo].[Zal] WHERE [Название] = @Название";

            int id_club = 0; // Переменная для хранения Id_club

                dataBase.openConnectoin();

                // Получаем Id_club
                using (SqlCommand commandGetId = new SqlCommand(getIdClubQuery, dataBase.getConnection()))
                {
                    commandGetId.Parameters.AddWithValue("@Название", comboBox1.Text);

                    using (SqlDataReader reader = commandGetId.ExecuteReader())
                    {
                        if (reader.Read()) // Если нашли соответствующий клуб
                        {
                            id_club = (int)reader["Id_club"];
                        }
                        else
                        {
                            MessageBox.Show("Клуб с таким названием не найден.");
                            return;
                        }
                    }
                }

                // Если Id_club найден, обновляем данные пользователя
                if (id_club > 0)
                {
                    // SQL команда на обновление
                    string updateUserQuery = @"UPDATE [Diplom].[dbo].[Users]
                                       SET 
                                           [Имя] = @Имя,
                                           [Фамилия] = @Фамилия,
                                           [Сеть] = @Сеть,
                                           [Телефон] = @Телефон
                                       WHERE [Id_user] = @Id_user;";

                    using (SqlCommand commandUpdateUser = new SqlCommand(updateUserQuery, dataBase.getConnection()))
                    {
                        commandUpdateUser.Parameters.AddWithValue("@Id_club", id_club);
                        commandUpdateUser.Parameters.AddWithValue("@Имя", textBox1.Text);
                        commandUpdateUser.Parameters.AddWithValue("@Фамилия", textBox2.Text);
                        commandUpdateUser.Parameters.AddWithValue("@Сеть", textBox3.Text);
                        commandUpdateUser.Parameters.AddWithValue("@Телефон", textBox4.Text);
                        commandUpdateUser.Parameters.AddWithValue("@Id_user", id_user);
                    dataBase.closeConnectoin();
                        Upload();
                        Retrieve();
                    dataBase.openConnectoin();
                        int rows = commandUpdateUser.ExecuteNonQuery();
                    dataBase.closeConnectoin();

                        if (rows > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены.");
                        }
                        else
                        {
                            MessageBox.Show("Данные не обновлены. Проверьте Id пользователя.");
                        }
                    dataBase.closeConnectoin();
                    }
                }
        }
    }
}
