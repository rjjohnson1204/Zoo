using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;


namespace Zoo.Classes
{
    //allows for inheritence  child = Golden_Monkey : parent = Monkey
    public class Golden_Monkey : Monkey, ISwing
    {
        //changes the value of Horns

        public override string Horns { get; set; } = "none";

        public string Swing()
        {
            return "I swing from trees!!";
        }

    }
}
