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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom
{
    public partial class AddCoach : Form
    {
        DataBase dataBase = new DataBase();
        int id;

        public AddCoach(int id)
        {
            InitializeComponent();

            this.id = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Вы заполнили не все поля!");
            }
            else
            {
                
                string defaultImagePath = "C:\\Users\\nikis\\Documents\\def.png";
                Image image = pictureBox1.Image ?? Image.FromFile(defaultImagePath);
                dataBase.openConnectoin();

                var yesNo = MessageBox.Show("Вы уверены, что хотите добавить тренера?", "Система!", MessageBoxButtons.YesNo);
                if (yesNo == DialogResult.Yes)
                {


                    string sqlQuery = @"INSERT INTO [Diplom].[dbo].[Coach] ([Id_club], [Фамилия], [Имя], [Фото], [Должность], [Специализация])
                                 VALUES (@Id_club, @Фамилия, @Имя, @Фото, @Должность, @Специализация)";

                    SqlCommand command = new SqlCommand(sqlQuery, dataBase.getConnection());
                    command.Parameters.AddWithValue("@Id_club", id);
                    command.Parameters.AddWithValue("@Фамилия", textBox2.Text);
                    command.Parameters.AddWithValue("@Имя", textBox1.Text);
                    command.Parameters.AddWithValue("@Должность", textBox3.Text);
                    command.Parameters.AddWithValue("@Специализация", textBox4.Text);
                    command.Parameters.AddWithValue("@Фото", ImageToByteArray(image));



                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        this.Close();
                        MessageBox.Show("Тренер добавлен");
                        Coachs coach = new Coachs(id);
                        coach.LoadDataFromDatabase(id);

                    }
                    catch (Exception ex)
                    {

                    }
                    dataBase.closeConnectoin();

                }
            }


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
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void AddCoach_Load(object sender, EventArgs e)
        {

        }
    }
}

