using System;
using System.Collections;
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
    public partial class AddSubscription : Form
    {
        int id_club;
        DataBase dataBase = new DataBase();
        public AddSubscription(int id_club)
        {
            InitializeComponent();
            this.id_club = id_club;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                Convert.ToInt32(numericUpDown1.Value) == 0)
            {
                string query = "INSERT INTO [Diplom].[dbo].[Subscription] ([Название], [Описание], [Заморозка], [Срок], [ID_club]) VALUES (@Название, @Описание, @Заморозка, @Срок, @ID_club)";

                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {

                    command.Parameters.AddWithValue("@Название", textBox1.Text);
                    command.Parameters.AddWithValue("@Описание", textBox2.Text);
                    command.Parameters.AddWithValue("@Заморозка", textBox4.Text);
                    command.Parameters.AddWithValue("@Срок", textBox3.Text);
                    command.Parameters.AddWithValue("@ID_club", id_club);
                    command.Parameters.AddWithValue("Цена", float.Parse(numericUpDown1.Text, CultureInfo.InvariantCulture.NumberFormat));
                    try
                    {
                        dataBase.openConnectoin();
                        command.ExecuteNonQuery();
                        this.Close();
                        MessageBox.Show("Абонемент добавлен");
                        Subscriptions subscription = new Subscriptions(id_club);
                        subscription.ShowDialog();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    dataBase.closeConnectoin();

                }
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные!");
            }
            
        }
    }
}
        
    

