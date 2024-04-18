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
    public partial class LookCoach : Form
    {
        DataBase dataBase = new DataBase();
        private string coachName;
        private string coachSurname;
        private string position;
        private string specialization;
        private int id;
        private int id_club;


        public LookCoach(string coachName, string coachSurname, string position, string specialization, int id, int id_club)
        {
            this.coachName = coachName;
            this.coachSurname = coachSurname;
            this.position = position;
            this.specialization = specialization;
            this.id = id;
            this.id_club = id_club;
            InitializeComponent();
            Retrieve();
            See();
        }

        private void See()
        {
            label1.Text = coachName.ToString();
            label2.Text = coachSurname.ToString();
            label3.Text = position.ToString();
            label4.Text = FormatDescription(specialization.ToString()); 
        }
        private string FormatDescription(string description)
        {
            // Разделение текста на строки для обеспечения отступов и переносов
            string formattedDescription = "";
            int lineLength = 30; // Максимальная длина строки

            while (description.Length > lineLength)
            {
                int lastSpaceIndex = description.Substring(0, lineLength).LastIndexOf(' ');
                if (lastSpaceIndex > 0)
                {
                    formattedDescription += description.Substring(0, lastSpaceIndex) + "\n";
                    description = description.Substring(lastSpaceIndex + 1);
                }
                else
                {
                    formattedDescription += description.Substring(0, lineLength) + "\n";
                    description = description.Substring(lineLength);
                }
            }

            formattedDescription += description; // Добавляем оставшуюся часть описания
            return formattedDescription;
        }
        public void Retrieve()
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
                                    pictureBox1.Image?.Dispose(); // Освобождение ресурсов предыдущего изображения, если оно есть
                                    pictureBox1.Image = Image.FromStream(memoryStream);
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
    }
}
