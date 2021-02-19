using System;
using System.Threading;

namespace AsyncAwaitTaskDemo
{
    class Program4
    {
        private static int newTask(int ms)
        {
            Console.WriteLine("任务开始");
            Thread.Sleep(ms);
            Random random = new Random();
            int n = random.Next(10000);
            Console.WriteLine("任务完成");
            return n;
        }

        private delegate int NewTaskDelegate(int ms);

        static void Main4(string[] args)
        {
            #region    段1 start
            //NewTaskDelegate task = newTask;
            //IAsyncResult asyncResult = task.BeginInvoke(2000, null, null);

            //// EndInvoke方法将被阻塞2秒
            //int result = task.EndInvoke(asyncResult);
            //Console.WriteLine(result);
            #endregion 段1 end

            #region    段2 start
            NewTaskDelegate task = newTask;
            IAsyncResult asyncResult = task.BeginInvoke(2000, null, null); // 此行报“Operation is not supported on this platform.”，百度结果都说是.Net Core不支持

            while (!asyncResult.IsCompleted)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            // 由于异步调用已经完成，因此， EndInvoke会立刻返回结果
            int result = task.EndInvoke(asyncResult);
            Console.WriteLine(result);
            #endregion 段2 end
        }
    }
}
