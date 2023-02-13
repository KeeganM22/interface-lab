using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_inerfaces_and_Abstract_Classes
{
    internal class Dog : Animal, IAnimal
    {
        protected string breed;

        

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        string IAnimal.Name { get; set; }
        string IAnimal.Color { get; set; }
        int IAnimal.height { get; set; }
        int IAnimal.age { get; set; }

        public Dog(string name, string color, int age, int height, string breed)
        {
            this.Name = name;
            this.Color = color;
            this.Height = height;
            this.Age = age;
            this.Breed = breed;
        }

        void IAnimal.Eats()
        {
            Console.WriteLine("dogs eat meat");
            
        }

        void IAnimal.Cry()
        {
            Console.WriteLine("woof!");
            
        }
    }
}
