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
            // ������� ����� PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(100, 100);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Image = Image.FromFile(@"C:\Users\nikis\OneDrive\Desktop\photo_2024-01-17_11-00-30.jpg"); // �������� yourImage �� ��� �����������
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox.Name = "pictureBox1"; // ������ ������������ ����� ���������� ��� ��� �������� ����

            // ���������� ������� ������ �� PictureBox
            pictureBox.Click += PictureBox_Click;

            // ������� ����� Label
            Label label = new Label();
            label.Text = "���������� � PictureBox"; // �������� �� ��� �����
            label.AutoSize = true; // ������������� ��������� ������ Label ��� �����
            label.AutoSize = false; // ������������� �������������� ��������� �������� false
            label.Size = pictureBox.Size; // ������������� ������� Label ����� ��, ��� � PictureBox
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Click += Label_Click;

            // ���� ���������� ��������� � ������� ���������� ������ ��� ����� 2,
            // ������� ����� ��������� ��� ��������� ������
            if (flowLayoutPanel1.Controls.Count == 0 ||
                ((FlowLayoutPanel)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]).Controls.Count >= 2)
            {
                FlowLayoutPanel newContainer = new FlowLayoutPanel();
                newContainer.FlowDirection = FlowDirection.LeftToRight;
                newContainer.AutoSize = true;
                newContainer.WrapContents = false;
                newContainer.Margin = new Padding(100, 0, 0, 50); // ������� ����� ��������
                flowLayoutPanel1.Controls.Add(newContainer);
            }

            // �������� ������� ���������
            FlowLayoutPanel currentContainer = (FlowLayoutPanel)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];

            // ��������� PictureBox � Label � ������� ���������
            currentContainer.Controls.Add(pictureBox);
            currentContainer.Controls.Add(label);
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            // �������� PictureBox, �� ������� ��������� ������
            PictureBox clickedPictureBox = (PictureBox)sender;

            // ���������, �� ����� PictureBox ��������� ������
            if (clickedPictureBox.Name == "pictureBox1")
            {
                // ��� ��� ��� ��������� ������ �� pictureBox1
                MessageBox.Show("�� �������� �� pictureBox1");
            }
            // �������� �������������� �������, ���� ���� ��������� PictureBox
        }
        private void Label_Click(object sender, EventArgs e)
        {
            // �������� Label, �� ������� ��������� ������
            Label clickedLabel = (Label)sender;

            // ���������, �� ����� Label ��������� ������
            // ����� �� ������ �������� ����������� ������ ��� ��������� Label
            MessageBox.Show("�� �������� �� Label");
        }
}
    }


