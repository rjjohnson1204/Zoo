using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Turtle : parent = Reptiles

    public abstract class Turtle : Reptiles
    {
        //changes the value of Teeth and Horns

        public override int Teeth { get; set; } = 0;
        public override string Horns { get; set; } = "none";

        public override void Sleep()
        {

        }
        public override void Eat()
        {

        }
    }

}
