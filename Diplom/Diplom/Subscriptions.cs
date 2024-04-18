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

    public partial class Subscriptions : Form
    {
        int id_club;
        DataBase dataBase = new DataBase();
        public Subscriptions(int id)
        {
            InitializeComponent();
            this.id_club = id;
            LoadData(id_club);
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        public Subscriptions()
        {
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
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataBase.closeConnectoin();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubscription addSubscription = new AddSubscription(id_club);

            addSubscription.ShowDialog();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получение данных из выбранной строки
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells["Название"].Value.ToString();
                string description = row.Cells["Описание"].Value.ToString();
                string hold = row.Cells["Заморозка"].Value.ToString();
                string date = row.Cells["Срок"].Value.ToString();
                double price = (double)row.Cells["Цена"].Value;           
                
                    string query = "SELECT[Id_subscription], [ID_club] FROM[Diplom].[dbo].[Subscription] WHERE[Название] = @Название";
                    using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                    {
                        // Передача параметра в запрос
                        command.Parameters.AddWithValue("@Название", name);

                        try
                        {
                            // Открытие подключения и выполнение запроса
                            dataBase.openConnectoin();                      
                        SqlDataReader reader = command.ExecuteReader();

                        // Проверка на наличие результата
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id_subscription"]);
                            int id_club = Convert.ToInt32(reader["ID_club"]);
                            UpdateSubscription update = new UpdateSubscription(name, description, hold, date, id, id_club, price);
                            update.Show();
                        }           
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                        }
                            dataBase.closeConnectoin(); 
                            this.Close();
                    }
               
            }
            
                  }
        }
    }
