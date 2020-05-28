using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 100.5;
            FiveOneTwoEigth.Depth = 60;
            FiveOneTwoEigth.Stories = 4;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Bob");

            Building FourOneTwoEigth = new Building("412 8th Avenue");
            FourOneTwoEigth.Width = 200.5;
            FourOneTwoEigth.Depth = 80.5;
            FourOneTwoEigth.Stories = 4;
            FourOneTwoEigth.Construct();
            FourOneTwoEigth.Purchase("Rob");

            Building ThreeOneTwoEigth = new Building("312 8th Avenue");
            ThreeOneTwoEigth.Width = 100.5;
            ThreeOneTwoEigth.Depth = 60;
            ThreeOneTwoEigth.Stories = 4;
            ThreeOneTwoEigth.Construct();
            ThreeOneTwoEigth.Purchase("Cob");

            Console.WriteLine(FiveOneTwoEigth.Address);
            Console.WriteLine("------------------------");
            Console.WriteLine($"designed by {FiveOneTwoEigth.Designer}");
            Console.WriteLine($"Constructed on {FiveOneTwoEigth.DateConstructed}");
            Console.WriteLine($"Owned by {FiveOneTwoEigth.Owner}");
            Console.WriteLine($"{FiveOneTwoEigth.Volume} cubic meters of space");
            Console.WriteLine("");
            Console.WriteLine(FourOneTwoEigth.Address);
            Console.WriteLine("------------------------");
            Console.WriteLine($"designed by {FourOneTwoEigth.Designer}");
            Console.WriteLine($"Constructed on {FourOneTwoEigth.DateConstructed}");
            Console.WriteLine($"Owned by {FourOneTwoEigth.Owner}");
            Console.WriteLine($"{FourOneTwoEigth.Volume} cubic meters of space");
            Console.WriteLine("");
            Console.WriteLine(ThreeOneTwoEigth.Address);
            Console.WriteLine("------------------------");
            Console.WriteLine($"designed by {ThreeOneTwoEigth.Designer}");
            Console.WriteLine($"Constructed on {ThreeOneTwoEigth.DateConstructed}");
            Console.WriteLine($"Owned by {ThreeOneTwoEigth.Owner}");
            Console.WriteLine($"{ThreeOneTwoEigth.Volume} cubic meters of space");
        }
    }
}