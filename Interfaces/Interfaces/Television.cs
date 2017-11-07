using System;
namespace Interfaces
{
    public class Television : IElectronicDevice
    {
        public int Volume;

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void Off()
        {
            Console.WriteLine("The TV is Off");        
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV Volume is at {Volume}");
        }
         
    }
}
