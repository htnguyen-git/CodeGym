using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassVaInterface
{
    class Chicken : AAnimal, IEdible
    {
        public string HowtoEat()
        {
            return "Nuong";
        }

        public override string MakeSound()
        {
            return "Chicken : O o o ";
        }
    }
}
