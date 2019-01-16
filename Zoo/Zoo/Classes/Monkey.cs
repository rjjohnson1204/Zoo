using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{           
    //allows for inheritence  child = Monkey : parent = Mammals

    abstract class Monkey : Mammals
    {
        public override int Legs { get; set; } = 2;

        public override void Sleep()
        {

        }
        public override void Eat()
        {
           
        }

    }
}
