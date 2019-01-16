using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Gecko : parent = Lizard

    class Gecko : Lizard
    {   
        //changes the value of Teeth
        public override int Teeth { get; set; } = 0;

    }
}
