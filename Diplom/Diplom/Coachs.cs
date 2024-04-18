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
    public partial class Coachs : Form
    {
        DataBase dataBase = new DataBase();
        int id;
        public Coachs(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadDataFromDatabase(id);

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            AddCoach addCoach = new AddCoach(id);
            addCoach.ShowDialog();
            LoadDataFromDatabase(id);

        }
        public void AddPictureBox(PictureBox pictureBox, Label label)
        {
            
            // Создаем новый контейнер для PictureBox и Label
            FlowLayoutPanel container;            



            // Если количество элементов в текущем контейнере больше или равно 2,
            // создаем новый контейнер для следующей строки
            if (flowLayoutPanel1.Controls.Count == 0 ||
                ((FlowLayoutPanel)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]).Controls.Count >= 2)
            {
                FlowLayoutPanel newContainer = new FlowLayoutPanel();
                newContainer.FlowDirection = FlowDirection.LeftToRight;
                newContainer.AutoSize = true;
                newContainer.WrapContents = false;
                newContainer.Margin = new Padding(0, 50, 70, 0); // Отступы между строками
                flowLayoutPanel1.Controls.Add(newContainer);
                container = newContainer;
            }
            else
            {
                // Получаем текущий контейнер
                container = (FlowLayoutPanel)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];
            }

            // Добавляем PictureBox и Label в текущий контейнер
            container.Controls.Add(pictureBox);
            container.Controls.Add(label);          
            
        }
        public void LoadDataFromDatabase(int idClub)
        {
            flowLayoutPanel1.Controls.Clear();
            dataBase.openConnectoin();
            string query = $"SELECT [Id_club], [Id_club], [Фамилия], [Имя], [Фото], [Должность], [Специализация] FROM Coach WHERE [Id_club] = @IdClub";       
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@IdClub", idClub);           
            SqlDataReader reader = command.ExecuteReader();        

            while (reader.Read())
            {
                // Создаем новый PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(200, 200);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += PictureBox_Click;

                // Загружаем изображение из базы данных
                byte[] imageBytes = (byte[])reader["Фото"];
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }

                // Создаем новый Label
                Label label = new Label();
                label.Text = reader["Фамилия"].ToString() + " " +  reader["Имя"].ToString();
                label.AutoSize = false;
                label.Size = new Size(100, 50);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Click += Label_Click;

                pictureBox.Tag = new Tuple<string, string>(reader["Имя"].ToString(), reader["Фамилия"].ToString());
                label.Tag = new Tuple<string, string>(reader["Имя"].ToString(), reader["Фамилия"].ToString());

                // Добавляем PictureBox и Label в текущий контейнер            
                AddPictureBox(pictureBox, label);
               
            }

            reader.Close();
            dataBase.closeConnectoin();
            
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            dataBase.openConnectoin();
            // Получаем PictureBox, на котором произошел щелчок           
            PictureBox clickedPictureBox = (PictureBox)sender;
            var tag = (Tuple<string, string>)clickedPictureBox.Tag;
            string name = tag.Item1;
            string surname = tag.Item2;

            // Выполняем запрос к базе данных для получения данных о тренере по имени и фамилии

            string query = "SELECT * FROM [Diplom].[dbo].[Coach] WHERE [Имя] = @Name AND [Фамилия] = @Surname";
            
            
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);              

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Получаем данные тренера из базы данных и сохраняем их в переменные
                    string coachName = reader["Имя"].ToString();
                    string coachSurname = reader["Фамилия"].ToString();
                    string position = reader["Должность"].ToString();
                    string specialization = reader["Специализация"].ToString();    
                    int id = (int)reader["Id_coach"];
                    int id_club = (int)reader["Id_club"];
                    UpdateCoach updateCoach = new UpdateCoach(coachName, coachSurname, position, specialization, id, id_club);
                    updateCoach.Show();
                    this.Close();                   
                }

                reader.Close();
            dataBase.closeConnectoin();
            
            
        }

        // Обработчик события клика на Label
        private void Label_Click(object sender, EventArgs e)
        {
            dataBase.openConnectoin();
            // Получаем Label, на котором произошел щелчок
            Label clickedLabel = (Label)sender;
            var tag = (Tuple<string, string>)clickedLabel.Tag;
            string name = tag.Item1;
            string surname = tag.Item2;             

            // Выполняем запрос к базе данных для получения данных о тренере по имени и фамилии
            string query = "SELECT * FROM [Diplom].[dbo].[Coach] WHERE [Имя] = @Name AND [Фамилия] = @Surname";
            
            
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                // Получаем данные тренера из базы данных и сохраняем их в переменные
                string coachName = reader["Имя"].ToString();
                string coachSurname = reader["Фамилия"].ToString();
                string position = reader["Должность"].ToString();
                string specialization = reader["Специализация"].ToString();
                int id = (int)reader["Id_coach"];
                int id_club = (int)reader["Id_club"];
                UpdateCoach updateCoach = new UpdateCoach(coachName, coachSurname, position, specialization, id, id_club);
                updateCoach.Show();
            }

                reader.Close();
                    
        }
        }
}

