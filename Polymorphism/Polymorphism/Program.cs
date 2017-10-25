    
using System;

using System.Linq;

namespace Polymorphism
{
    //sealed class Animal
    class Animal
    {
        private string name;
        protected string sound; // can be changed by a sub-class directly 

        public void MakeSound() 
        {
            Console.WriteLine($"{name} says {sound}"); 
        }

        public Animal ()
            :this("No Name", "No Sound") { }

        public Animal(string name)
            :this(name, "No Sound") { }
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if(value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }
    }
    class 

        public string Sound
        {
            get { return sound; }
            set 
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
