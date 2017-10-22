// Structs, Classes, Fields, Methods, Constructors, Static, Static Classes, Nullable Types...
using System;

namespace Classes_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;

            Console.WriteLine("Area of rect1: {0}",
                              rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);

            //// rect2 = rect1;
            //// rect1.length = 33; //ref not bound to rect2 so this will only change rect1

            Console.WriteLine("length of rect2: {0}",
                              rect2.length);

            Console.ReadLine();
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1,
                             double w = 1) // has to be the same name as struct
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
