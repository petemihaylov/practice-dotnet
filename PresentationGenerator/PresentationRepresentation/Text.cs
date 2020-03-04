using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationRepresentation
{
    class Text
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public  int Size { get; set; }

        public Text() { }
        public Text(string name ,string content, int size)
        {
            this.Name = name;
            this.Content = content;
            this.Size = size;
        }
    }
}
