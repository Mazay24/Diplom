using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    internal class ImageUploader
    {
        DataBase dataBase = new DataBase();

        public void Upload(PictureBox pictureBox, int id)
        {
            dataBase.openConnectoin();
            using (var command = dataBase.getConnection().CreateCommand())
            {
                command.CommandText = "UPDATE Zal SET Картинка = @image WHERE [Id_club] = @id";
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
        public void Retrieve(PictureBox pictureBox, int id)
        {
            try
            {
                dataBase.openConnectoin();
                using (var command = dataBase.getConnection().CreateCommand())
                {
                    command.CommandText = "SELECT Картинка FROM Zal WHERE Id_club = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("Картинка")))
                            {
                                byte[] imageData = (byte[])reader["Картинка"];
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
    }
}

