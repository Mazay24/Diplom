namespace Ekz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Âñòàâëåíî");
        }

        private void èíæåíåğíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void êîïèğîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ñêîïèğîâàíî");
        }

        private void îáû÷íûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
        }
        private void allOn(object sender, EventArgs e)
        {
            for (int i = 0; i < 34; i++)
            {

            }
        }

        private void ôóíêóèèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Graf graf = new Graf();
            graf.Show();
        }

        private void îÏğîãğàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Î ïğîãğàììå!");
        }
    }
}
