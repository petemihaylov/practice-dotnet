using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsApp
{
    class Line
    {
        private int length;
        private int angle;

        private Point startPoint;
        private Point endPoint;

        private Color color;

        public Line(Point startPoint, int length)
        {
            this.startPoint = startPoint;
            this.endPoint = this.GetEndPoint();
            this.color = Color.Black;
            this.angle = 0;
            this.length = length;
        }
        public Point GetEndPoint()
        {
            var endPoint = new Point(); 
            endPoint.X = (int)(startPoint.X + (Math.Cos(Radian(this.angle)) * this.length));
            endPoint.Y = (int)(startPoint.Y + (Math.Sin(Radian(this.angle)) * this.length));

            return endPoint;
        }
        private double Radian(int angle) { return (Math.PI / 180.0) * angle; }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void SetStartPoint(Point point)
        {
            this.startPoint = point;
        }
        public void Draw(Graphics graphics, int angle)
        {
            this.angle = angle;
            Pen pen = new Pen(this.color);
            endPoint = GetEndPoint();
            graphics.DrawLine(pen, startPoint, endPoint);
            startPoint = endPoint;
        }
    }
}
