using System;
namespace VideoSeven
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "GRRRRRrr";

        public override void MakeSound() // can be called overriding the SuperClass MakeSound() method
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name",
            string sound = "No Sound",
                   string sound2 = "No Sound 2")
            :base(name, sound) 
        {
            Sound2 = sound2;
        }
    }
}
