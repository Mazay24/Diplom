using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Entry : Form
    {
        DataBase dataBase =new DataBase();
        int id_user;
        int id_club;
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public Entry(int id_user, int id_club)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.id_club = id_club;
            LoadUserTrainings();
            myTimer.Interval = 5000; // Задаем интервал в 5000 мс (5 секунд)
            myTimer.Tick += new EventHandler(MyMethodWrapper); // Подписываемся на событие Tick
            myTimer.Start();
        }
        private void MyMethodWrapper(object sender, EventArgs e)
        {
            LoadUserTrainings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id_user);
            profile.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info info = new Info(id_club);
            info.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Coachcs coachcs = new Coachcs(id_club);
            coachcs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Subscription subscription = new Subscription(id_club);
            subscription.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Records records = new Records(id_club, id_user);
            records.ShowDialog();
        }
        public void LoadUserTrainings()
        {
            dataBase.openConnectoin();
                string query = @"
                  SELECT 
        T.[Название],
        T.[День_тренировки],
        CONVERT(varchar(5), T.[Начало], 108) as [Начало], 
        CONVERT(varchar(5), T.[Конец], 108) as [Конец],
        C.[Имя] + ' ' + C.[Фамилия] AS 'Тренер'
    FROM 
        [Diplom].[dbo].[Records] AS R
    INNER JOIN 
        [Diplom].[dbo].[Training] AS T ON R.[Id_training] = T.[Id_training]
    INNER JOIN 
        [Diplom].[dbo].[Coach] AS C ON T.[Id_coach] = C.[Id_coach]
    WHERE 
        R.[Id_user] = @UserId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, dataBase.getConnection());
                adapter.SelectCommand.Parameters.AddWithValue("@UserId", id_user);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            dataBase.closeConnectoin();
        }
    }
}
