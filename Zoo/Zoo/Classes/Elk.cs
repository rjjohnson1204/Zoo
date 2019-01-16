using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Elk : parent = Deer
    class Elk : Deer
    {

        public override string Horns { get; set; } = "has horns";

    }
}
