using System;
using System.Collections;
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
            string query = "INSERT INTO [Diplom].[dbo].[Subscription] ([Название], [Описание], [Заморозка], [Срок], [ID_club]) VALUES (@Название, @Описание, @Заморозка, @Срок, @ID_club)";

            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                
                    command.Parameters.AddWithValue("@Название", textBox1.Text);
                    command.Parameters.AddWithValue("@Описание", textBox2.Text);
                    command.Parameters.AddWithValue("@Заморозка", textBox4.Text);
                    command.Parameters.AddWithValue("@Срок", textBox3.Text);
                    command.Parameters.AddWithValue("@ID_club", id_club);
                    command.Parameters.AddWithValue("Цена", textBox4.Text);
                try
                {
                    dataBase.openConnectoin();
                    command.ExecuteNonQuery();
                    this.Close();
                    MessageBox.Show("Абонемент добавлен");
                    Subscription subscription = new Subscription(id_club);
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
    }
}
        
    

