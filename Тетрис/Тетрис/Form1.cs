using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тетрис
{
    public partial class Form1 : Form
    {
        Shape currentShape;
        int size;
        int[,] map = new int[16,8];
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            size = 25;
            currentShape = new Shape(3, 0);
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(update);
            timer1.Start();

            Invalidate();
        }

        private void update(object sender, EventArgs e)
        {
            currentShape.MoveDown();
            Merge();
            Invalidate();
        }
        public void Merge()
        {
            for (int i = currentShape.y; i < currentShape.y + 3; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + 3; j++)
                {
                    map[i, j] = currentShape.matrix[i - currentShape.y, j - currentShape.x];
                }
            }
        }
        public void DrawMap(Graphics e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; i < 8; i++)
                {
                    if (map[i, j] == 1)
                    {
                        e.FillRectangle(Brushes.Red, new Rectangle(50 + j * size, 50 + i * size, size, size));
                    }
                }
            }
        }
                                 
        public void DrawGrid(Graphics g)
        {
            for (int i = 0; i <= 16; i++)
            {                      
                    g.DrawLine(Pens.Black, new Point(50, 50 + i * size), new Point(50 + 8 * size, 50 + i * size));               
            }

            for (int i = 0; i <= 8; i++)
            {
                g.DrawLine(Pens.Black, new Point(50 + i * size, 50), new Point(50 + i * size, 50 + 16 * size));
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
            DrawMap(e.Graphics);
            
        }
    }
}
