using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsApp
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius, double centerX, double centerY) : base(centerX, centerY)
        {
            this.radius = radius;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(this.color);
            graphics.DrawEllipse(pen,(float)(this.centerX - this.radius), (float)(this.centerY - this.radius),(float)(2 * this.radius), (float)(2 * this.radius));

        }

        public void Fill(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(this.color), (float)(this.centerX - this.radius), (float)(this.centerY - radius),(float)(radius + radius), (float)(2 * this.radius));
        }

    }
}
