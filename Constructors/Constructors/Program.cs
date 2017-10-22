﻿using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();

            cat.SetName("Whiskers");

            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}",
                              cat.GetName(), cat.Sound);

            cat.Owner = "Andrew";

            Console.WriteLine("{0} owner is {1}", 
                              cat.GetName(), cat.Owner);

            Console.WriteLine("{0} shelter id is {1}",
                              cat.GetName(), cat.idNum);
            Console.WriteLine("# of Animals : {0}",
                              Animal.NumOfAnimals);

            Console.ReadLine();
        }
    }
}
