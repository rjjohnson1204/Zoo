using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
   abstract class Reptiles : Animals
   {
        public override string Hair { get; set; } 

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
