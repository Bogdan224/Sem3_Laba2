using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Laba2
{
    public static class MyStringExtentions
    {
        public static bool Contains(this MyString str, char value)
        {
            return str.IndexOf(value) != -1;
        }
        public static bool Contains(this MyString str, MyString value)
        {
            return str.IndexOf(value) != -1;
        }
        public static MyString RemovingPunctionalMarks(this MyString str)
        {
            str = str.ToString().Replace(",", string.Empty);
            str = str.ToString().Replace(".", string.Empty);
            str = str.ToString().Replace("-", string.Empty);
            str = str.ToString().Replace(":", string.Empty);
            str = str.ToString().Replace(";", string.Empty);
            return new MyString(str);
        }
    }
}
