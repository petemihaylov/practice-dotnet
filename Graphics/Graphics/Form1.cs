using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsApp
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int centerX, centerY;

        public Form1()
        {
            InitializeComponent();
            this.graphics = this.Canvas.CreateGraphics();
            this.centerX = this.Canvas.Width / 2;
            this.centerY = this.Canvas.Height / 2;

        }

        private void btnCIRC_Click(object sender, EventArgs e)
        {
            this.Canvas.Refresh();
            int length = int.Parse(txtLength.Text);

            //Circle
            for (int i = 0, radius = length; i < int.Parse(txtCount.Text); i++, radius += 10)
            {
                Circle circle = new Circle((radius / 3), this.centerX, this.centerY);
                circle.SetColor(Color.Black);
                circle.Draw(graphics);
            }

        }

        private void btnRECT_Click(object sender, EventArgs e)
        {
            this.Canvas.Refresh();
            int length = int.Parse(txtLength.Text);
            
            // Rectangle
            for (int i = 0, width = length; i < int.Parse(txtCount.Text); i++, width += 10)
            {
                Rectangle rectangle = new Rectangle(width, width, this.centerX, this.centerY);
                rectangle.SetColor(Color.Red);
                rectangle.Draw(graphics);
            }

        }

        private void btnGO_Click(object sender, EventArgs e)
        {

            this.Canvas.Refresh();
            int length = int.Parse(txtLength.Text);
            
            
            // Line
            Point p = new Point(this.centerX, this.centerY + 200);
            Line line = new Line(p, int.Parse(txtLength.Text));
            for (int i = 0; i < int.Parse(txtCount.Text); i++)
            {
                if(i >= 700)
                {
                    p.X = this.centerX + 200;
                    p.Y = this.centerY + 250;
                    line.SetStartPoint(p);
                    line.SetColor(Color.Red);
                    line.Draw(graphics, -60 * i - i);
                }else  line.Draw(graphics, -55 * i + i);

            }


        }
    }
}
