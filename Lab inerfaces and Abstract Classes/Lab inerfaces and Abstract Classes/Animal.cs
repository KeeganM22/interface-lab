using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_inerfaces_and_Abstract_Classes
{
    internal class Animal
    {
        protected string name;
        protected string color;
        protected int age;
        protected int height;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {

            get { return color; }
            set { color = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public Animal(string name, string color, int age, int height)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            this.height = height;

        }
        public Animal()
        {

        }

        
    }
}
