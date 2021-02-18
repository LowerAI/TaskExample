using System;

namespace ValueTaskExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<int> repository = new Repository<int>();
            var result = repository.GetData();
            if (result.IsCompleted)
                Console.WriteLine("Operation complete...");
            else
                Console.WriteLine("Operation incomplete...");

            var ret = repository.GetDataAsync();
            if (ret.IsCompleted)
                Console.WriteLine("Operation complete again...");
            else
                Console.WriteLine("Operation incomplete again...");

            Console.ReadKey();
        }
    }
}
