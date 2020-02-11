using System.Drawing;

namespace GraphicsApp
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height, double centerX, double centerY) : base(centerX, centerY)
        {
            this.width = width;
            this.height = height;
        }
        public override void Draw(Graphics graphics)
        {
            Pen  pen = new Pen(this.color);
            Point[] points =
            {
                new Point((int)(this.centerX + (width/2)), (int)this.centerY),
                new Point((int)(this.centerX + (width/2)),(int)(this.centerY + (height/2))),
                new Point((int)(this.centerX - (width/2)),(int)(this.centerY + (height/2))),
                new Point((int)(this.centerX - (width/2)), (int)(this.centerY - (height/2))),
                new Point((int)(this.centerX + (width/2)), (int)(this.centerY - (height/2))),
                new Point((int)(this.centerX + (width/2)), (int)(this.centerY))
            };
            graphics.DrawLines(pen, points);
        }
    }
}
