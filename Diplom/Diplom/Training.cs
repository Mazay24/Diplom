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
    public partial class Training : Form
    {
        int id_club;
        public Training(int id)
        {
            this.id_club = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTraining addTraining = new AddTraining(id_club);
            addTraining.Show();
        }
    }
}
