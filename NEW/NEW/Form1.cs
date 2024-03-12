namespace NEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var auth = new Auth();
            auth.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reg = new Reg();
            reg.Show();
        }
    }
}
