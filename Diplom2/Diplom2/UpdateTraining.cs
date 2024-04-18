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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom2
{
    public partial class UpdateTraining : Form
    {
        DataBase dataBase = new DataBase();
        private int idTraining;
        private int idClub;
        private string name;
        private DateTime date;
        private TimeSpan start;
        private TimeSpan end;
        private int idCoach;
        private int place;
        private int busy;
        string coachName;

        public UpdateTraining(int idTraining, int idClub, string name, DateTime date, TimeSpan start, TimeSpan end, int idCoach, int place, int busy)
        {
            InitializeComponent();
            this.idTraining = idTraining;
            this.idClub = idClub;
            this.name = name;
            this.date = date;
            this.start = start;
            this.end = end;
            this.idCoach = idCoach;
            this.place = place;
            this.busy = busy;
            addInfo();
        }
        public void addInfo()
        {
            textBox1.Text = name;
            LoadCoaches();
            dateTimePicker1.Value = date;
            dateTimePicker2.Value = DateTime.Today.Add(start);
            dateTimePicker3.Value = DateTime.Today.Add(end);
            numericUpDown1.Value = place;
        }
        private void LoadCoaches()
        {
            dataBase.openConnectoin();
            string query = "SELECT [Id_coach], [Фамилия] + ' ' + [Имя] AS [FullName] FROM [Diplom].[dbo].[Coach] WHERE [Id_coach] = @Id_coach OR [Id_club] = @Id_club";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@Id_coach", idCoach);
            command.Parameters.AddWithValue("@Id_club", idClub);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Добавляем имена и фамилии тренеров в comboBox1
                    coachName = reader["FullName"].ToString();
                    comboBox1.Items.Add(coachName);
                }
                dataBase.closeConnectoin();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            TimeSpan start = dateTimePicker2.Value.TimeOfDay;
            TimeSpan end = dateTimePicker3.Value.TimeOfDay;

            // Создание подключения и команды SQL для обновления тренировки

            string query = "UPDATE [Diplom].[dbo].[Training] " +
                           "SET[Название] = @Название, [День_тренировки] = @День_тренировки, " +
                           "[Начало] = @Начало, [Конец] = @Конец, [Id_coach] = @Тренер, [Места] = @Места " +
                           "WHERE [Id_training] = @TrainingId";

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                comboBox1.SelectedItem == null ||
                dateTimePicker1.Value == null ||
                dateTimePicker2.Value == null ||
                dateTimePicker3.Value == null ||
                Convert.ToInt32(numericUpDown1.Value) == 0)
            {
                MessageBox.Show("Вы заполнили не все поля");
            }
            else
            {
                var yesNo = MessageBox.Show("Вы уверены, что хотите обновить тренировку?", "Система!", MessageBoxButtons.YesNo);
                if (yesNo == DialogResult.Yes)
                {
                    using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                    {
                        // Передача параметров в запрос
                        command.Parameters.AddWithValue("@Название", textBox1.Text);
                        command.Parameters.AddWithValue("@День_тренировки", date);
                        command.Parameters.AddWithValue("@Начало", start);
                        command.Parameters.AddWithValue("@Конец", end);
                        command.Parameters.AddWithValue("@Тренер", idCoach);
                        command.Parameters.AddWithValue("@Места", Convert.ToInt32(numericUpDown1.Value));
                        command.Parameters.AddWithValue("@TrainingId", idTraining);

                        try
                        {
                            // Открытие подключения и выполнение запроса
                            dataBase.openConnectoin();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Тренировка обновлена");
                            this.Close();
                            Training training = new Training(idClub);
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
                command.Parameters.AddWithValue("@Id_club", idClub);

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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработчик события выбора элемента в ComboBox
            string selectedFullName = comboBox1.SelectedItem.ToString();

            // Разделение строки на имя и фамилию
            string[] nameParts = selectedFullName.Split(' ');
            string firstName = nameParts[1];
            string lastName = nameParts[0];

            // Запрос SQL для получения ID по имени и фамилии
            string query = "SELECT Id_coach FROM Coach WHERE Имя = @FirstName AND Фамилия = @LastName";

            try
            {
                // Создание подключения к базе данных

                // Открытие подключения
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

                    idCoach = Convert.ToInt32(result);


                }
                dataBase.closeConnectoin();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM [Diplom].[dbo].[Training] WHERE [Id_training] = @Id_training";

            try
            {

                using (SqlCommand command = new SqlCommand(deleteQuery, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@Id_training", idTraining);

                    dataBase.openConnectoin();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно удалены.");
                    }
                    else
                    {
                        MessageBox.Show("Данные не найдены или не удалось удалить запись.");
                    }
                    this.Close();
                    Training training = new Training(idClub);
                    training.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении данных: {ex.Message}");
            }
        }
    }
}
