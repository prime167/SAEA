using System.Net.Sockets;

namespace IOCTestClient
{
    class MySocketEventArgs : SocketAsyncEventArgs
    {
        /// <summary>
        /// 标识，只是一个编号而已
        /// </summary>
        public int ArgsTag { get; set; }

        /// <summary>
        /// 设置/获取使用状态
        /// </summary>
        public bool IsUsing { get; set; }
    }
}