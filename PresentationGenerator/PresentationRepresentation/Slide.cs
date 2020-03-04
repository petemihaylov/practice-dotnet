using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationRepresentation
{
    class Slide
    {
        public Slide() {
            this.Title = new Text();
            this.Bullets = new List<Text>();
        }
     
        private int _number;
        public int Number
        {
            get => _number;
            set
            {
                if ((value > 0))
                {
                    _number = value;
                }
                else
                {
                    _number = 1;
                }
            }
        }
        public  Text Title { get; set; }
        public List<Text> Bullets { get; set; }

    }
}
