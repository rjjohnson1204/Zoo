using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Sea_turtle : parent = Turtle

     public class Sea_turtle : Turtle
    {
        //changes the value of Legs

        public override int Legs { get; set; } = 0;

    }
}
