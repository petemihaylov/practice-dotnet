using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsApp
{
    class Shape
    {
        protected double centerX;
        protected double centerY;
        protected Color color;

        public Shape(double centerX = 0, double centerY = 0)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.color = Color.Black;
        }
        public Shape(double centerX, double centerY, Color color)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.color = color;
        }
        public double GetX()
        {
            return this.centerX;
        }
        public double GetY()
        {
            return this.centerY;
        }

        public virtual void Draw(Graphics graphics){}
        public void SetColor(Color color)
        {
            this.color = color;
        }
    }
}
