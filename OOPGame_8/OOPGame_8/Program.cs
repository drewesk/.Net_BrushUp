using System;

namespace OOPGame_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);

            Warrior bob = new Warrior("Bob", 1000, 120, 40);

            Battle.StartFight(maximus, bob);

            Console.ReadLine();
        }

    }
}

/*
Byte-Sized Notes

Bob Attacks Maximus and Deals 74 Damage Maximus has 69 Health
Maximus Attacks Bob and Deals 6 Damage Bob has 6 Health
Bob Attacks Maximus and Deals 48 Damage Maximus has 21 Health
Maximus Attacks Bob and Deals 48 Damage Bob has -42 Health
Bob has Died and Maximus is Victorious
Game Over
*/
