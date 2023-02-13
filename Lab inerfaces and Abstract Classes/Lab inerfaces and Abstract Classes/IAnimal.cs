using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_inerfaces_and_Abstract_Classes
{
    internal interface IAnimal
    {
        string Name { get; set; }
        string Color { get; set; }
        int height { get; set; }
        int age
        {
            get;
            set;
        }

        public void Eats();
        public void Cry();
    }
}
