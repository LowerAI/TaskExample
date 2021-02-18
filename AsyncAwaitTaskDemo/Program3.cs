using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitTaskDemo
{
    class Program3
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine($"1:{Thread.CurrentThread.ManagedThreadId}");
            var client = new HttpClient();
            Console.WriteLine($"2:{Thread.CurrentThread.ManagedThreadId}");
            var task = client.GetStringAsync("http://baidu.com");
            Console.WriteLine($"3:{Thread.CurrentThread.ManagedThreadId}");

            var a = 0;
            for (int i = 0; i < 100_000_000; i++)
            {
                a += 1;
            }

            Console.WriteLine($"4:{Thread.CurrentThread.ManagedThreadId}");
            var page = await task;
            Console.WriteLine($"5:{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
