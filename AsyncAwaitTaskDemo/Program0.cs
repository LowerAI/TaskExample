using System;
using System.Threading.Tasks;

namespace AsyncAwaitTaskDemo
{
    class Program0
    {
        static void Main0(string[] args)
        {
            var tea = MakeTea();
            Console.WriteLine(tea);
        }

        public static string MakeTea()
        {
            var water = BoilWater();

            Console.WriteLine("take the cups out");

            Console.WriteLine("put tea in cops");

            var tea = $"pour {water} in cups";

            return tea;
        }

        public static string BoilWater()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("waiting for the kettle");
            Task.Delay(2000).GetAwaiter().GetResult();

            Console.WriteLine("kettle finished boiling");

            return "water";
        }
    }
}
