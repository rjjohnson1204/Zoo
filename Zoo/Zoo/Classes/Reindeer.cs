using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Reindeer : parent = Deer
    class Reindeer : Deer
    {
        public override string Horns { get; set; } = "has horns";

    }
}
