using System;

namespace ConsoleApp8core
{
    enum Colour
    {
        unknown,
        red,
        green,
        blue,
        yellow
    }
    enum BikeType
    {
        unknown,
        MTB,
        Gravel,
        Road,

    }

  
   

    internal class Program
    {
        static void Print(Bycicle bike)
        {
            Console.WriteLine($"bike info:");
            Console.WriteLine($"id {bike.id}");
            Console.WriteLine($"framesize {bike.frameSize}");
            Console.WriteLine($"manufacturer {bike.manufacturer}");
            Console.WriteLine($"colour {bike.colour}");
            Console.WriteLine($"biketype {bike.bikeType}");
            Console.WriteLine($"wheel size {bike.wheelSize}");
        }

        static Bycicle GetBycicle()
        {
            Bycicle bike = new Bycicle();

            bike.manufacturer = "Canyon";
            bike.colour = Colour.red;
            bike.frameSize = 50;
            bike.id = Guid.NewGuid();
            bike.bikeType = BikeType.MTB;
            //bike.wheelSize = 29;

            return bike;
        }


        static void Main(string[] args)
        {
            var firstbike = GetBycicle();
            Print(firstbike);
        

        }
    }
}
