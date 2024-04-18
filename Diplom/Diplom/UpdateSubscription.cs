using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class UpdateSubscription : Form
    {
        DataBase dataBase = new DataBase();
        private string name;
        private string description;
        private string hold;
        private string date;
        private int id;
        private int id_club;
        private double price;


        public UpdateSubscription(string name, string description, string hold, string date, int id, int id_club, double price)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            this.hold = hold;
            this.date = date;
            this.id = id;
            this.id_club = id_club;
            this.price = price;
            addInfo();
        }
        public void addInfo()
        {
            textBox1.Text = name;
            textBox2.Text = description;
            textBox3.Text = hold;
            textBox4.Text = date;
            numericUpDown1.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [Diplom].[dbo].[Subscription] SET [Название] = @Название, [Описание] = @Описание, [Заморозка] = @Заморозка, [Срок] = @Срок, [Цена] = @Цена WHERE [Id_subscription] = @ID";


            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Название", textBox1.Text);
                command.Parameters.AddWithValue("@Описание", textBox2.Text);
                command.Parameters.AddWithValue("@Заморозка", textBox3.Text);
                command.Parameters.AddWithValue("@Срок", textBox4.Text);
                command.Parameters.AddWithValue("@Цена", float.Parse(numericUpDown1.Text, CultureInfo.InvariantCulture.NumberFormat));

                try
                {
                    dataBase.openConnectoin();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно обновлены.");
                    }
                    else
                    {
                        MessageBox.Show("Обновление данных не удалось.");
                    }
                    dataBase.closeConnectoin();
                    this.Close();
                    Subscriptions subscription = new Subscriptions(id_club);
                    subscription.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var yesNo = MessageBox.Show("Вы уверены, что хотите удалить абонемент?", "Система!", MessageBoxButtons.YesNo);
            if (yesNo == DialogResult.Yes)
            {

                string query = "DELETE FROM Subscription WHERE [Id_subscription] = @ID";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    // Передача параметра в запрос
                    command.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        // Открытие подключения и выполнение запроса
                        dataBase.openConnectoin();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Проверка на успешное удаление строки
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Абонемент успешно удален!");
                            Subscriptions subscription = new Subscriptions(id_club);
                            subscription.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Что-то пошло не так");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                    }
                }

            }
            else
            {

            }

        }
    }
}
