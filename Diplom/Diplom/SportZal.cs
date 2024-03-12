using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class SportZal : Form
    {
        int id;
        public SportZal(int id)
        {
            InitializeComponent();
            this.id = id;
            this.SendToBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(id);
            profil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coach coach = new Coach(id);
            coach.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subscription subscription = new Subscription(id);
            subscription.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Training training = new Training(id);
            training.ShowDialog();
        }
    }
}
