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
    public partial class Record : Form
    {
        DataBase dataBase = new DataBase();
        int id_club;


        public Record(int id_club)
        {
            InitializeComponent();
            this.id_club = id_club;
            LoadTrainingData();
        }
        private void LoadTrainingData()
        {

            string query = @"
SELECT 
    u.Id_user,  -- Добавлено для получения, но не будет отображаться напрямую
    t.Название, t.День_тренировки, t.Начало, t.Конец,
    u.Имя, u.Фамилия, u.Телефон
FROM 
    [Diplom].[dbo].[Training] t
JOIN 
    [Diplom].[dbo].[Records] r ON t.Id_training = r.Id_training
JOIN 
    [Diplom].[dbo].[Users] u ON r.Id_user = u.Id_user
WHERE 
    t.Id_club = @IdClub";

            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                dataBase.openConnectoin();
                command.Parameters.AddWithValue("@IdClub", id_club);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.DataSource = table;
                dataGridView1.Columns["Id_user"].Visible = false;
                dataBase.closeConnectoin();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int selectedUserId = Convert.ToInt32(row.Cells["Id_user"].Value);
                User user = new User(selectedUserId);
                user.ShowDialog();
            }
        }
    }
}
