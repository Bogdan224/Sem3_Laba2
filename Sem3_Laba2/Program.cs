﻿using Sem3_Laba2.Mammals;

namespace Sem3_Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            Part2();
        }

        static void Part1()
        {
            MyString str1 = "qeqoqeq";
            //Console.WriteLine(str1);
            MyString str2 = "qe";
            string str3 = "qeqoqeq";
            
            
            
            MyString str4 = str1 + str2;
            MyString str5 = "Hel,l.o; W-orld";
            Console.WriteLine(str5.RemovingPunctionalMarks());

            //Console.WriteLine(str1 - 5);
            //Console.WriteLine(str1 + 214);
            //Console.WriteLine(str1 * 'a');
            
            //Console.WriteLine(str4.Substring(3));

            //Console.WriteLine(str1.IndexOf("1"));
            //Console.WriteLine(str1.Contains(str2));
            //Console.WriteLine(str1.Substring(8));
        }

        static void Part2()
        {
            //List<Mammal> list = new List<Mammal>
            //{
            //    new Mammal(),
            //    new Bird(),
            //    new Fish(),
            //    new Lion(),
            //    new Tiger(),
            //    new Owl(),
            //    new Parrot(),
            //    new Shark(),
            //    new Crocodile()
            //};
            //foreach (Mammal m in list)
            //{
            //    Console.WriteLine(m.ToString());
            //    m.Move();
            //    Console.WriteLine();
            //}
            Parrot parrot = new Parrot();
            parrot.Fly();

        }
    }
}
