using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Turtle : Reptiles
    {
        public override int Teeth { get; set; } = 0;
        public override string Horns { get; set; } = "none";


    }
}
