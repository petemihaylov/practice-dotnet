using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalApp
{
    class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name = "")
        {
            this.name = name;
        }

        public Animal(string name = "", int age = 1)
        {
            this.name = name;
            this.age = age;
        }

        public  virtual void CelebrateBirthday()
        {
            if(age <= 100)
            {
                age++;
            }
        }
        public virtual string ToString()
        {
            return $"{this.name} {this.age} year";
        }
    }
}
