using System;
using System.Collections.Generic;

namespace work
{
    internal class Program
    {
        public static List<Shape> l = new List<Shape>();
        public static void Main(string[] args)
        {

         l.Add(new circle(5));
         l.Add(new triangle(5,4,3));
         l.Add(new triangle(115,0.00001f,9));
         foreach (Shape s in l)
         {
             Console.WriteLine(s.type);
             Console.WriteLine(s.calcS());
             if (s is triangle t)
             {
                 Console.WriteLine(t.check90()?"прямоугольный":"не прямоугольный");
             }
             Console.Write("\n");
         }
    }
    }
}