using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Golden_Monkey : parent = Monkey
    class Golden_Monkey : Monkey
    {
        //changes the value of Horns

        public override string Horns { get; set; } = "none";

    }
}
