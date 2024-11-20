using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba2.Mammals
{
    public abstract class Animal
    {   
        public abstract void Move();
        public override string ToString()
        {
            return "Class: Animal";
        }
    }
}
