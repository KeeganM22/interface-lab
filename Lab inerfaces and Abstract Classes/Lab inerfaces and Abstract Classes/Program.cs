using Lab_inerfaces_and_Abstract_Classes;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;

namespace absLab
{
    internal class Program
    {

        
        
        
        static void Main(string[] args)
        {
            List<Animal> animals= new List<Animal>();
            Dog Ian = new Dog("Ian", "Gold", 3, 2, "Corgi");
            animals.Add(Ian);
            Dog Chunky = new Dog("Chunky", "white", 7, 2, "cottonpompoo");
            animals.Add(Chunky);
            Dog Ollie = new Dog("Ollie", "black", 4, 2, "cottonpompoo");
            animals.Add(Ollie);
            Dog Magnus = new Dog("Magnus", "black", 2, 12, "mix");
            animals.Add(Magnus);
            Cat Gizmo = new Cat("Gizmo", "grey", 13, 1, "Short");
            animals.Add(Gizmo);
            Cat Sequoia = new Cat("Sequoia", "multi", 13, 1, "Short");
            animals.Add(Sequoia);
            Cat Anesh = new Cat("Anesh", "grey", 1, 1, "Short");
            animals.Add(Anesh);


            Console.WriteLine("Enter Dog Name");
            string dname = Console.ReadLine();
            Console.WriteLine("Enter Dog height");
            int dheaight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Dog color");
            string dcolor = Console.ReadLine();
            Console.WriteLine("Enter Dog age");
            int dage = int.Parse(Console.ReadLine());
            IAnimal dog = new Dog(dname, dcolor, dage, dheaight, "Corgi");

            dog.Eats();
            dog.Cry();

            Console.WriteLine("Enter cat Name");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter cat height");
            int cheaight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cat color");
            string ccolor = Console.ReadLine();
            Console.WriteLine("Enter cat age");
            int cage = int.Parse(Console.ReadLine());
            IAnimal cat = new Cat(cname, ccolor, cage, cheaight, "Short");

            cat.Eats();
            cat.Cry();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}