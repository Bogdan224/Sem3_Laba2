using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba2.Mammals
{
    public class Animal : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("Walk");
        }
        public override string ToString()
        {
            return base.ToString() + "\nSubclass: Animal";

        }
    }
}
