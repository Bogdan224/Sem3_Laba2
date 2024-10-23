using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba2.Mammals
{
    public class Bird : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("Fly");
        }
        public override string ToString()
        {
            return base.ToString() + "\nSubclass: Bird";
        }
    }
}
