using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
        // parent class
        abstract class Animals
        {   // properties of animals
            public abstract int Legs { get; set; }
            public abstract int Teeth { get; set; }
            public virtual bool Hair { get; set; }
            public virtual bool Horns { get; set; }
            
        //methods of animals
            public abstract void Eat();
            public abstract void Sleep();
        }
}
