using System;
using System.Threading.Tasks;

namespace AsyncAwaitTaskDemo
{
    class Program2
    {
        static async Task Main2(string[] args)
        {
            var tea = await MakeTeaAsync();
            Console.WriteLine(tea);
        }

        public static async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();

            Console.WriteLine("take the cups out");

            var a = 0;
            for (int i = 0; i < 100_000_000; i++)
            {
                a += 1;
            }

            Console.WriteLine("put tea in cops");

            var water = await boilingWater;

            var tea = $"pour {water} in cups";

            return tea;
        }

        public static async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");

            Console.WriteLine("waiting for the kettle");
            await Task.Delay(300);

            Console.WriteLine("kettle finished boiling");

            return "water";
        }
    }
}
