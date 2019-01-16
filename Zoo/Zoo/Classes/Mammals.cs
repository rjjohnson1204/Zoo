using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //allows for inheritence  child = Mammals : parent = Animals

    abstract class Mammals : Animals 
        {  
        // property of mammals
            public override int Teeth { get; set; } = 100;
            
        // method of mammas
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
