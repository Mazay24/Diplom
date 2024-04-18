using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom2
{
    public partial class UpdateCoach : Form
    {

        DataBase dataBase = new DataBase();
        private string coachName;
        private string coachSurname;
        private string position;
        private string specialization;
        private int id;
        private int id_club;


        public UpdateCoach(string coachName, string coachSurname, string position, string specialization, int id, int id_club)
        {
            InitializeComponent();
            this.coachName = coachName;
            this.coachSurname = coachSurname;
            this.position = position;
            this.specialization = specialization;
            this.id = id;
            this.id_club = id_club;
            textBox1.Text = coachName.ToString(); ;
            textBox2.Text = coachSurname.ToString();
            textBox3.Text = position.ToString();
            textBox4.Text = specialization.ToString();
            Retrieve(pictureBox1, id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM [Diplom].[dbo].[Coach] WHERE [Id_coach] = @ID";



            using (SqlCommand command = new SqlCommand(deleteQuery, dataBase.getConnection()))
            {
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    dataBase.openConnectoin();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("Удалено записей: " + rowsAffected);
                    this.Close();
                    Coachs coach = new Coachs(id_club);
                    coach.ShowDialog();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            var yesNo = MessageBox.Show("Вы уверены, что хотите изменить данные?", "Система!", MessageBoxButtons.YesNo);
            if (yesNo == DialogResult.Yes)
            {

                dataBase.openConnectoin();
                string sqlQuery = "UPDATE Coach SET [Имя] = @Имя, [Фамилия] = @Фамилия, [Должность] = @Должность, [Специализация] = @Специализация WHERE [Id_coach] = @id";

                SqlCommand command = new SqlCommand(sqlQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@Имя", textBox1.Text);
                command.Parameters.AddWithValue("@Фамилия", textBox2.Text);
                command.Parameters.AddWithValue("@Должность", textBox3.Text);
                command.Parameters.AddWithValue("@Специализация", textBox4.Text);
                command.Parameters.AddWithValue("@id", id);
                try
                {

                    command.ExecuteNonQuery();
                    textBox1.Text = new SqlCommand("SELECT Имя FROM Coach", dataBase.getConnection()).ExecuteScalar().ToString();
                    textBox2.Text = new SqlCommand("SELECT Фамилия FROM Coach", dataBase.getConnection()).ExecuteScalar().ToString();
                    textBox3.Text = new SqlCommand("SELECT Должность FROM Coach", dataBase.getConnection()).ExecuteScalar().ToString();
                    textBox4.Text = new SqlCommand("SELECT Специализация FROM Coach", dataBase.getConnection()).ExecuteScalar().ToString();
                    dataBase.closeConnectoin();
                    Upload(pictureBox1, id);
                    Retrieve(pictureBox1, id);

                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то поломалось!");
                    throw;
                }

                MessageBox.Show("Изменения успешно сохранены.");
                this.Close();
                Coachs coach = new Coachs(id_club);
                coach.ShowDialog();

            }
            else
            {

            }


        }


        public void Retrieve(PictureBox pictureBox, int id)
        {
            try
            {
                dataBase.openConnectoin();
                using (var command = dataBase.getConnection().CreateCommand())
                {
                    command.CommandText = "SELECT Фото FROM Coach WHERE Id_coach = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("Фото")))
                            {
                                byte[] imageData = (byte[])reader["Фото"];
                                using (var memoryStream = new MemoryStream(imageData))
                                {
                                    pictureBox.Image?.Dispose(); // Освобождение ресурсов предыдущего изображения, если оно есть
                                    pictureBox.Image = Image.FromStream(memoryStream);
                                }
                            }
                            else
                            {
                                // Обработка случая, когда значение поля "Картинка" равно NULL

                            }
                        }
                        else
                        {
                            // Обработка случая, когда запись с указанным ID не найдена
                            MessageBox.Show("Запись с указанным ID не найдена.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке изображения: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnectoin(); // Гарантированное закрытие соединения с базой данных
            }
        }
        public void Upload(PictureBox pictureBox, int id)
        {
            dataBase.openConnectoin();
            using (var command = dataBase.getConnection().CreateCommand())
            {
                command.CommandText = "UPDATE Coach SET Фото = @image WHERE [Id_coach] = @id";
                command.Parameters.AddWithValue("@id", id);

                var image = new Bitmap(pictureBox.Image);
                using (var memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    memoryStream.Position = 0;

                    var sqlParameter = new SqlParameter("@image", SqlDbType.VarBinary, (int)memoryStream.Length)
                    {
                        Value = memoryStream.ToArray()
                    };
                    command.Parameters.Add(sqlParameter);
                }
                command.ExecuteNonQuery();
            }
            dataBase.closeConnectoin();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
