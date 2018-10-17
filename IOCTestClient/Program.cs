using System;
using System.Threading;

namespace IOCTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var r = new Request();
                r.Connect();
                for (int j = 0; j < 10; j++)
                {
                    Request.Send($"hello word {i}{j}!");
                    Thread.Sleep(100);
                }
            }

            Console.ReadKey();
        }
    }
}
