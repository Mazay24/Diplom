using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace six
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new
    System.Drawing.Drawing2D.GraphicsPath();

            // 2. Create an array of points corresponding
            //   to the coordinates of the pentagon forming the form.
            // 2.1. Declare an instance of type "array of points Point[]".
            //      Point is a class that describes a point on the screen.
            Point[] mp = new Point[5];

            // 2.2. Allocate memory for each point and fill it values
            mp[0] = new Point(100, 5);
            mp[1] = new Point(50, 55);
            mp[2] = new Point(75, 105);
            mp[3] = new Point(200, 105);
            mp[4] = new Point(215, 55);

            // 3. Add array of point Point[] to the instance gp
            gp.AddPolygon(mp);

            // 4. Create a Region based on a sequence of points gp
            Region rg = new Region(gp);

            // 5. Set this.Region form region to a new value rg
            this.Region = rg;
        }
    }
}
