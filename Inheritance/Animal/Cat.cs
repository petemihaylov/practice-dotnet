using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalApp
{
    class Cat : Animal
    {
        public Cat(string name) : base(name) {}
        public Cat(string name, int age) : base(name, age) { }
        public override void CelebrateBirthday()
        {
            if (age <= 25)
            { 
                age++;
            }
        }
        public override string ToString()
        {
            return $"Cat: {this.name} {this.age} year";
        }
    }
}
