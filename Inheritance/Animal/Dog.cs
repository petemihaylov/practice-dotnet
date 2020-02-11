using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalApp
{
    class Dog : Animal
    {
       public Dog(string name) : base(name) { }
       public Dog(string name, int age) : base(name, age) { }

        public override void CelebrateBirthday()
        {
            if (age <= 20)
            {
                age++;
            }
        }

        public override string ToString()
        {
            return $"Dog: {this.name} {this.age} year";
        }
    }
}
