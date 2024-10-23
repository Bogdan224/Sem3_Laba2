using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba2.Mammals
{
    public class Owl : Bird
    {
        public override void Move()
        {
            base.Move();
        }
        public override string ToString()
        {
            return base.ToString() + "\nType: Owl";
        }
    }
}
