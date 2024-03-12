using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{

    public partial class Profil : Form
    {
        int id;
        DataBase dataBase = new DataBase();
        ImageUploader uploader = new ImageUploader();
        public Profil(int id)
        {
            this.id = id;
            InitializeComponent();
            See();
            uploader.Retrieve(pictureBox1, id);          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBase.openConnectoin();

            var yesNo = MessageBox.Show("Вы уверены, что хотите изменить данные?","Система!", MessageBoxButtons.YesNo);
            if (yesNo == DialogResult.Yes)
            {


                string sqlQuery = "UPDATE Zal SET [Название] = @Название, [Описание] = @Описание, [Время_работы] = @Время_работы, [Телефон] = @Телефон, [Сети] = @Сети, [Адрес] = @Адрес WHERE [Id_club] = @id";

                SqlCommand command = new SqlCommand(sqlQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@Название", textBox1.Text);
                command.Parameters.AddWithValue("@Описание", textBox2.Text);
                command.Parameters.AddWithValue("@Время_работы", textBox3.Text);
                command.Parameters.AddWithValue("@Телефон", textBox4.Text);
                command.Parameters.AddWithValue("@Сети", textBox5.Text);
                command.Parameters.AddWithValue("@Адрес", textBox6.Text);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    command.ExecuteNonQuery();
                    dataBase.closeConnectoin();
                    See(); 
                    uploader.Upload(pictureBox1, id);
                    uploader.Retrieve(pictureBox1, id);
                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то поломалось!");
                    throw;
                }
                
                MessageBox.Show("Изменения успешно сохранены.");

               
            }
            else
            {

            }
                        
        }
        private void See()
        {
            dataBase.openConnectoin();

            SqlCommand command = new SqlCommand("SELECT Название, Описание, Время_работы, Телефон, Сети, Адрес FROM Zal WHERE [Id_club] = @id", dataBase.getConnection());
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader["Название"].ToString();
                textBox2.Text = reader["Описание"].ToString();
                textBox3.Text = reader["Время_работы"].ToString();
                textBox4.Text = reader["Телефон"].ToString();
                textBox5.Text = reader["Сети"].ToString();
                textBox6.Text = reader["Адрес"].ToString();
            }

            reader.Close();
            dataBase.closeConnectoin();
        }
    }
}

    

