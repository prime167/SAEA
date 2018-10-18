using System;
using System.Threading;

namespace IOCTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                var r = new Request();
                var user = new UserInfoModel
                {
                    UserId = i,
                    Nickname = "user-" + i
                };

                r.UserInfo = user;
                r.Connect();
                for (int j = 0; j < 2; j++)
                {
                    Request.Send($"hello word {i}{j}!");
                    Thread.Sleep(200);
                }
            }

            Console.ReadKey();
        }
    }
}
