using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    class Animal
    {
        private IAnimal _animal { get; set; }

        public Animal(IAnimal animal)
        {
            _animal = animal;
        }

        public IAnimal GetAnimal()
        {
            return _animal;
        }
    }
}
