﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{           
    //allows for inheritence  child = Monkey : parent = Mammals

    public abstract class Monkey : Mammals
    {
        //changes the value of Legs

        public override int Legs { get; set; } = 2;

        public override void Sleep()
        {

        }
        public override void Eat()
        {
           
        }

    }
}
