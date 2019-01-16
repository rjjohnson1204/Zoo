using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{  
    //allows for inheritence  child = Reptiles : parent = Animals
    abstract class Reptiles : Animals
   {
        public override string Hair { get; set; } 

        // method of reptiles
        public virtual bool LaysEggs(bool eggs)
        {
            if (eggs == true)
            {
                return true;
            }
            return false;
        }
    }
}
