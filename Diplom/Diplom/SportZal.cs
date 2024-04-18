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

        private void button1_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(id);
            profil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coachs coach = new Coachs(id);
            coach.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subscriptions subscription = new Subscriptions(id);
            subscription.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Training training = new Training(id);
            training.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Record records = new Record(id);
            records.ShowDialog();
        }
    }
}
