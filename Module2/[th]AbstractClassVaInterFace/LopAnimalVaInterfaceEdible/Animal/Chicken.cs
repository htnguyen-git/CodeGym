using LopAnimalVaInterfaceEdible.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LopAnimalVaInterfaceEdible.Animal
{
    class Chicken : AAnimal, Edible
    {
        public string HowToEat()
        {
            return "Nướng lên";
        }

        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
    }
}
