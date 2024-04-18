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
    public partial class Subscription : Form
    {
        DataBase dataBase = new DataBase();

        public Subscription(int id_club)
        {
            InitializeComponent();
            LoadData(id_club);
        }

        public void LoadData(int id_club)
        {
            string query = "SELECT [Название], [Описание], [Заморозка], [Срок], [Цена] FROM [Diplom].[dbo].[Subscription] WHERE [ID_club] = @ID_club";


            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                dataBase.openConnectoin();
                command.Parameters.AddWithValue("@ID_club", id_club);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataBase.closeConnectoin();
            }

        }
    }
}
