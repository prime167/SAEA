using System;
using System.Net;
using System.Text;
using Common;

namespace IOCTestServer
{
    class Program
    {
        private static SocketManager _socket;

        static void Main(string[] args)
        {
            _socket = new SocketManager(200, 1024);
            _socket.Init();
            _socket.ReceiveClientData += Socket_ReceiveClientData;
            _socket.ClientNumberChange += Socket_ClientNumberChange;
            _socket.Start(new IPEndPoint(IPAddress.Any, 13909));

            //按任意键终止服务器进程....
            Console.WriteLine("Server Started : Press any key to terminate the server process....");
            Console.ReadKey();
        }

        private static void Socket_ClientNumberChange(object sender, EventArgs<AsyncUserToken, int> e)
        {
            var count =_socket.ClientList.Count;
            Console.WriteLine($"connected client count {count}");
        }

        private static void Socket_ReceiveClientData(object sender, EventArgs<AsyncUserToken, byte[]> e)
        {
            var str = Encoding.UTF8.GetString(e.Value2);
            Console.WriteLine($"receive data {str}");
            var buff1 = Encoding.UTF8.GetBytes($"{str} ok");
            _socket.SendMessage(e.Value, buff1);
        }
    }
}
