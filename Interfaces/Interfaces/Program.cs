using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            } else 
            {
                Console.WriteLine($"The {buick.Brand} can't be driven");
            }

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();

            Console.ReadLine();
        }
    }
}
