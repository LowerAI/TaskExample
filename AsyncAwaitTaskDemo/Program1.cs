using System;
using System.Threading.Tasks;

namespace AsyncAwaitTaskDemo
{
    class Program1
    {
        static async Task Main1(string[] args)
        {
            var tea = await MakeTeaAsync();
            Console.WriteLine(tea);
        }

        public static async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();

            Console.WriteLine("take the cups out");

            Console.WriteLine("put tea in cops");

            var water = await boilingWater;

            var tea = $"pour {water} in cups";

            return tea;
        }

        public static async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("waiting for the kettle");
            await Task.Delay(2000);

            Console.WriteLine("kettle finished boiling");

            return "water";
        }
    }
}
