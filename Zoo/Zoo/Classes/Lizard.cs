using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Lizard : parent = Reptiles

    abstract class Lizard : Reptiles 
    {
        public override int Legs { get; set; } = 4;

        public override void Sleep()
        {

        }
        public override void Eat()
        {

        }
    }

}
