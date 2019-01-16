using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Animals
    {
        abstract class Animal
        {
            public abstract int Legs { get; set; }
            public abstract int Teeth { get; set; }
            public bool Hair { get; set; }
            public bool Horns { get; set; }

            public abstract void Eat();
            public abstract void Sleep();
        }

    }
}
