using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;


namespace Zoo.Classes
{
    //allows for inheritence  child = Gecko : parent = Lizard

    class Gecko : Lizard, IGrowTailBack
    {   
        //changes the value of Teeth
        public override int Teeth { get; set; } = 0;

        public string GrowTailBack()
        {
            return "My tail grows back!!";
        }

    }
}
