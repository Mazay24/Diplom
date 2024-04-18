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
    public partial class Records : Form
    {
        int id_club;
        int id_user;
        DataBase dataBase = new DataBase();
        public Records(int id_club, int id_user)
        {
            InitializeComponent();
            this.id_club = id_club;
            this.id_user = id_user;
            See();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, была ли выбрана строка в dataGridView1
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите тренировку для записи.");
                return;
            }

            // Получаем выбранную строку из dataGridView1
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Получаем Id_training из выбранной строки
            int idTraining = Convert.ToInt32(selectedRow.Cells["Id_training"].Value);

            // Открываем соединение
            dataBase.openConnectoin();

            // Проверяем наличие свободных мест на тренировку
            string checkQuery = "SELECT Места, Занято FROM [Diplom].[dbo].[Training] WHERE [Id_training] = @IdTraining";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, dataBase.getConnection()))
            {
                checkCommand.Parameters.AddWithValue("@IdTraining", idTraining);
                using (SqlDataReader reader = checkCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int availableSeats = (int)reader["Места"];
                        int occupiedSeats = (int)reader["Занято"];
                        if (occupiedSeats >= availableSeats)
                        {
                            MessageBox.Show("К сожалению, на эту тренировку мест нет.");
                            dataBase.closeConnectoin();
                            return;
                        }
                    }
                }
            }

            // Проверяем, записан ли пользователь уже на эту тренировку
            bool isUserAlreadyRegistered = CheckUserRegistration(id_user, idTraining);
            if (isUserAlreadyRegistered)
            {
                MessageBox.Show("Вы уже записаны на эту тренировку!");
                return;
            }

            // Начинаем транзакцию
            SqlTransaction transaction = dataBase.getConnection().BeginTransaction();

            try
            {
                // Выполняем вставку записи в таблицу Records
                string insertQuery = "INSERT INTO [Diplom].[dbo].[Records] ([Id_user], [Id_training]) VALUES (@IdUser, @IdTraining)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, dataBase.getConnection(), transaction))
                {
                    insertCommand.Parameters.AddWithValue("@IdUser", id_user);
                    insertCommand.Parameters.AddWithValue("@IdTraining", idTraining);
                    insertCommand.ExecuteNonQuery();
                }

                // SQL-запрос для обновления столбца "Занято" в таблице Training
                string updateQuery = "UPDATE [Diplom].[dbo].[Training] SET [Занято] = [Занято] + 1 WHERE [Id_training] = @IdTraining";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dataBase.getConnection(), transaction))
                {
                    updateCommand.Parameters.AddWithValue("@IdTraining", idTraining);
                    updateCommand.ExecuteNonQuery();
                }

                // Фиксируем транзакцию
                transaction.Commit();

                MessageBox.Show("Вы успешно записались на тренировку!");
            }
            catch (Exception ex)
            {
                // Если возникает ошибка, откатываем транзакцию
                transaction.Rollback();
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                // В любом случае закрываем соединение
                dataBase.closeConnectoin();
            }
        }

        private bool CheckUserRegistration(int userId, int trainingId)
        {
            bool isRegistered = false;

            string query = "SELECT COUNT(*) FROM [Diplom].[dbo].[Records] WHERE [Id_user] = @UserId AND [Id_training] = @TrainingId";

            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@TrainingId", trainingId);

                try
                {
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isRegistered = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при проверке записи пользователя: " + ex.Message);
                }
                finally
                {
                }
            }

            return isRegistered;
        }
        private void See()
        {
            // Открываем соединение
            dataBase.openConnectoin();

            // Создаем команду для запроса (тренировки)
            SqlCommand trainingCommand = new SqlCommand("SELECT TOP (1000) [Id_training], " +
    "[Название], " +
    "[День_тренировки], " +
    "CONVERT(varchar(5), [Начало], 108) as [Начало], " + // Изменение здесь
    "CONVERT(varchar(5), [Конец], 108) as [Конец], " +   // И и зменение здесь
    "[Места], " +
    "[Занято], " +
    "[Id_coach] " +
    "FROM [Diplom].[dbo].[Training] " +
    "WHERE [Id_club] = @ClubId AND [День_тренировки] >= DATEADD(day, -1, GETDATE())", dataBase.getConnection());

            trainingCommand.Parameters.AddWithValue("@ClubId", id_club);

            // Создаем адаптер данных и заполняем DataTable с результатами запроса
            SqlDataAdapter trainingAdapter = new SqlDataAdapter(trainingCommand);
            DataTable trainingTable = new DataTable();
            trainingAdapter.Fill(trainingTable);

            // Создаем команду для запроса (тренеры)
            SqlCommand coachCommand = new SqlCommand("SELECT [Id_coach], [Фамилия], [Имя] FROM [Diplom].[dbo].[Coach]", dataBase.getConnection());

            // Создаем адаптер данных и заполняем DataTable с результатами запроса
            SqlDataAdapter coachAdapter = new SqlDataAdapter(coachCommand);
            DataTable coachTable = new DataTable();
            coachAdapter.Fill(coachTable);

            // Закрываем соединение
            dataBase.closeConnectoin();

            // Объединяем данные из двух таблиц по Id_coach
            trainingTable.Columns.Add("CoachName", typeof(string));
            foreach (DataRow row in trainingTable.Rows)
            {
                int coachId = Convert.ToInt32(row["Id_coach"]);
                DataRow[] coachRows = coachTable.Select($"Id_coach = {coachId}");
                if (coachRows.Length > 0)
                {
                    string coachName = $"{coachRows[0]["Фамилия"]} {coachRows[0]["Имя"]}";
                    row["CoachName"] = coachName;
                }
            }

            // Отображаем результаты в dataGridView1
            dataGridView1.DataSource = trainingTable;
            // Убираем Id_coach из отображения
            dataGridView1.Columns["Id_coach"].Visible = false;
            dataGridView1.Columns["Id_training"].Visible = false;
            // Устанавливаем новое имя столбца для имени тренера
            dataGridView1.Columns["CoachName"].HeaderText = "Тренер";
        }

    }
}
