using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab_inerfaces_and_Abstract_Classes
{
    internal class Cat : Animal, IAnimal
    {
        protected string hairType;

        public string HairType
        {
            get { return hairType; }
            set { hairType = value; }
        }
        string IAnimal.Name { get; set; }
        string IAnimal.Color { get; set; }
        int IAnimal.height { get; set; }
        int IAnimal.age { get; set; }
        public Cat(string name,  string color, int age, int height, string hairType)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
            this.Height = height;
            this.HairType = hairType;
        }
        void IAnimal.Eats()
        {
            Console.WriteLine("cats eat mice");
        }
        void IAnimal.Cry()
        {
            Console.WriteLine("Meow");
        }
    }
}
