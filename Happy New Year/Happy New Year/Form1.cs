
namespace Happy_New_Year
{
    public partial class Form1 : Form
    {
        DateTime date = DateTime.Today;
        public Form1()
        {
            InitializeComponent();
        }
        private void Happy_New_Year(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 2024; i++) {
                Console.WriteLine("От лица группы 20ИТ17, поздравляем вас " +
                    "с наступающим Новым годом!" +
                    "Пусть 2024 год принесет в ваши жизни радость, " +
                    "удачу, новые возможности и приятные сюрпризы." +
                    " Пусть каждый день будет наполнен яркими впечатлениями," +
                    " а ваши стремления и цели сбудутся." +
                    "Счастья вам и процветания в новом году! 🎉");
            }
        }
    }
}


