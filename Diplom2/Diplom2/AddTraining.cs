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
    public partial class AddTraining : Form
    {
        DataBase dataBase = new DataBase();
        int id_club;
        int id_coach;
        public AddTraining(int id_club)
        {
            this.id_club = id_club;
            InitializeComponent();
            FillComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date = dateTimePicker1.Value.Date;
            TimeSpan start = dateTimePicker2.Value.TimeOfDay;
            TimeSpan end = dateTimePicker3.Value.TimeOfDay;

            // Проверка на пересечение временных интервалов с существующими тренировками
            if (CheckForTimeConflict(date, start, end))
            {
                MessageBox.Show("Временной интервал тренировки пересекается с уже существующей тренировкой. " +
                                "Пожалуйста, выберите другое время.", "Ошибка");
                return;
            }

            // Создание подключения и команды SQL для добавления новой тренировки

            string query = "INSERT INTO [Diplom].[dbo].[Training] ([ID_club], [Название], [День_тренировки], [Начало], [Конец], [Id_coach], [Места]) " +
                           "VALUES (@ID_club, @Название, @День_тренировки, @Начало, @Конец, @Тренер, @Места)";
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                comboBox1 == null ||
                dateTimePicker1.Value == null ||
                dateTimePicker2.Value == null ||
                dateTimePicker3.Value == null ||
                Convert.ToInt32(numericUpDown1.Value) == 0)
            {
                MessageBox.Show("Вы заполнили не все поля");

            }
            else
            {
                var yesNo = MessageBox.Show("Вы уверены, что хотите добавить тренировку?", "Система!", MessageBoxButtons.YesNo);
                if (yesNo == DialogResult.Yes)
                {
                    using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                    {

                        // Передача параметров в запрос
                        command.Parameters.AddWithValue("@ID_club", id_club);
                        command.Parameters.AddWithValue("@Название", textBox1.Text);
                        command.Parameters.AddWithValue("@День_тренировки", date);
                        command.Parameters.AddWithValue("@Начало", start);
                        command.Parameters.AddWithValue("@Конец", end);
                        command.Parameters.AddWithValue("@Тренер", id_coach);
                        command.Parameters.AddWithValue("@Места", Convert.ToInt32(numericUpDown1.Value));

                        try
                        {
                            // Открытие подключения и выполнение запроса
                            dataBase.openConnectoin();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Тренировка добавлена");
                            this.Close();
                            Training training = new Training(id_club);
                            training.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                        }
                        dataBase.closeConnectoin();
                    }
                }
            }
        }


        private bool CheckForTimeConflict(DateTime date, TimeSpan start, TimeSpan end)
        {

            // Запрос к базе данных для проверки пересечения временных интервалов
            string query = "SELECT COUNT(*) FROM [Diplom].[dbo].[Training] " +
                           "WHERE [День_тренировки] = @День_тренировки AND " +
                           "((@Начало BETWEEN [Начало] AND [Конец]) OR " +
                           "(@Конец BETWEEN [Начало] AND [Конец]) OR " +
                           "([Начало] BETWEEN @Начало AND @Конец) OR " +
                           "([Конец] BETWEEN @Начало AND @Конец))";


            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@День_тренировки", date);
                command.Parameters.AddWithValue("@Начало", start);
                command.Parameters.AddWithValue("@Конец", end);

                dataBase.openConnectoin();
                int count = (int)command.ExecuteScalar();
                dataBase.closeConnectoin();
                return count > 0;
            }


        }




        private void FillComboBox()
        {
            dataBase.openConnectoin();
            string query = "SELECT Id_coach, Фамилия, Имя FROM Coach WHERE Id_club = @Id_club";


            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@Id_club", id_club);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string fullName = $"{reader["Фамилия"]} {reader["Имя"]}";
                        comboBox1.Items.Add(fullName);
                    }
                    dataBase.closeConnectoin();
                }
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedFullName = comboBox1.SelectedItem.ToString();

            // Разделение строки на имя и фамилию
            string[] nameParts = selectedFullName.Split(' ');
            string firstName = nameParts[1];
            string lastName = nameParts[0];

            // Запрос SQL для получения ID по имени и фамилии
            string query = "SELECT Id_coach FROM Coach WHERE Имя = @FirstName AND Фамилия = @LastName";

            try
            {
                dataBase.openConnectoin();

                // Создание команды SQL с параметрами
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    // Добавление параметров к запросу
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    // Выполнение запроса и получение результата
                    object result = command.ExecuteScalar();

                    // Проверка на наличие результата

                    id_coach = Convert.ToInt32(result);
                }
                dataBase.closeConnectoin();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
