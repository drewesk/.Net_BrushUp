using System;
using System.Linq;

namespace VideoSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrrr"
            };

            grover.Sound = "Wooooooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Smith Jenkins");

            grover.SetAnimalIDInfo(12346, "Paul Brown Jenkins");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy: {0}",
                              getHealth.HealthyWeight(11, 146));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woooofff",
                Sound2 = "Geeerr"
            };

            monkey.MakeSound();
            spot.MakeSound();

            Console.ReadLine();
        }
    }
}
