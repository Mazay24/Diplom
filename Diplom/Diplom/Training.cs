using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Training : Form
    {
        int id_club;
        DataBase dataBase = new DataBase();
        public Training(int id)
        {
            this.id_club = id;
            InitializeComponent();
            See();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddTraining addTraining = new AddTraining(id_club);
            addTraining.Show();
        }
        private void See()
        {


            // Открываем соединение
            dataBase.openConnectoin();

            SqlCommand trainingCommand = new SqlCommand("SELECT TOP (1000) [Id_training], [Название], [День_тренировки], [Начало], [Конец], [Места], [Занято], [Id_coach] FROM [Diplom].[dbo].[Training] WHERE [Id_club] = @ClubId", dataBase.getConnection());
            trainingCommand.Parameters.AddWithValue("@ClubId", id_club);

            // Создаем адаптер данных и заполняем DataTable
            SqlDataAdapter trainingAdapter = new SqlDataAdapter(trainingCommand);
            DataTable trainingTable = new DataTable();
            trainingAdapter.Fill(trainingTable);

            // Создаем команду для второго запроса (тренеры)
            SqlCommand coachCommand = new SqlCommand("SELECT [Id_coach], [Фамилия], [Имя] FROM [Diplom].[dbo].[Coach]", dataBase.getConnection());

            // Создаем адаптер данных и заполняем DataTable с результатами второго запроса
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                int idTraining = Convert.ToInt32(selectedRow.Cells["Id_training"].Value);
                string name = Convert.ToString(selectedRow.Cells["Название"].Value);
                DateTime date = Convert.ToDateTime(selectedRow.Cells["День_тренировки"].Value);
                TimeSpan start = TimeSpan.Parse(selectedRow.Cells["Начало"].Value.ToString());
                TimeSpan end = TimeSpan.Parse(selectedRow.Cells["Конец"].Value.ToString());
                int idCoach = Convert.ToInt32(selectedRow.Cells["Id_coach"].Value);
                int place = Convert.ToInt32(selectedRow.Cells["Места"].Value);
                int busy = Convert.ToInt32(selectedRow.Cells["Занято"].Value);

                this.Close();
                UpdateTraining update = new UpdateTraining(idTraining, id_club, name, date, start, end, idCoach, place, busy);
                update.Show();

            }
        }
    }
}
