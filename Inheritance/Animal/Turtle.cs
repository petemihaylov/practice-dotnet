using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalApp
{
    class Turtle : Animal
    {
        public Turtle(string name) : base(name) { }
        public Turtle(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return $"Turtle: {this.name} {this.age} year";
        }
    }
}
