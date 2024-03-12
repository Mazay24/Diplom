using System.ComponentModel;
using System.Windows.Forms;

namespace PictureBoxTest
{
    public partial class Form1 : Form
    {
        private int pictureBoxCount = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            AddPictureBox();
        }

        private void AddPictureBox()
        {
            // Создаем новый PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(100, 100);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Image = Image.FromFile(@"C:\Users\nikis\OneDrive\Desktop\photo_2024-01-17_11-00-30.jpg"); // Замените yourImage на своё изображение
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox.Name = "pictureBox1"; // Можете использовать любое уникальное имя или значение тега

            // Обработчик события щелчка на PictureBox
            pictureBox.Click += PictureBox_Click;

            // Создаем новый Label
            Label label = new Label();
            label.Text = "Информация о PictureBox"; // Замените на ваш текст
            label.AutoSize = true; // Автоматически подстроит размер Label под текст
            label.AutoSize = false; // Устанавливаем автоматическое изменение размеров false
            label.Size = pictureBox.Size; // Устанавливаем размеры Label такие же, как у PictureBox
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Click += Label_Click;

            // Если количество элементов в текущем контейнере больше или равно 2,
            // создаем новый контейнер для следующей строки
            if (flowLayoutPanel1.Controls.Count == 0 ||
                ((FlowLayoutPanel)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]).Controls.Count >= 2)
            {
                FlowLayoutPanel newContainer = new FlowLayoutPanel();
                newContainer.FlowDirection = FlowDirection.LeftToRight;
                newContainer.AutoSize = true;
                newContainer.WrapContents = false;
                newContainer.Margin = new Padding(100, 0, 0, 50); // Отступы между строками
                flowLayoutPanel1.Controls.Add(newContainer);
            }

            // Получаем текущий контейнер
            FlowLayoutPanel currentContainer = (FlowLayoutPanel)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];

            // Добавляем PictureBox и Label в текущий контейнер
            currentContainer.Controls.Add(pictureBox);
            currentContainer.Controls.Add(label);
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Получаем PictureBox, на котором произошел щелчок
            PictureBox clickedPictureBox = (PictureBox)sender;

            // Проверяем, на каком PictureBox произошел щелчок
            if (clickedPictureBox.Name == "pictureBox1")
            {
                // Ваш код для обработки щелчка на pictureBox1
                MessageBox.Show("Вы щелкнули на pictureBox1");
            }
            // Добавьте дополнительные условия, если есть несколько PictureBox
        }
        private void Label_Click(object sender, EventArgs e)
        {
            // Получаем Label, на котором произошел щелчок
            Label clickedLabel = (Label)sender;

            // Проверяем, на каком Label произошел щелчок
            // Здесь вы можете добавить необходимую логику для различных Label
            MessageBox.Show("Вы щелкнули на Label");
        }
}
    }


