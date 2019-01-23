using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Mammals : parent = Animals

    public abstract class Mammals : Animals 
        {
        // property of mammals
        //changes the value of teeth

        public override int Teeth { get; set; } = 100;
            
        // method of mammals
            public virtual bool Climbs(bool canClimb)
            {
                if (canClimb == true)
                {
                    return true;
                }

              return false;
            }   
     }
    
}
