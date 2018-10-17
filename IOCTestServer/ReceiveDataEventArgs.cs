using System;

namespace IOCTestServer
{
    public class ReceiveDataEventArgs : EventArgs
    {
        public AsyncUserToken Token { get; set; }

        public byte[] Buff { get; set; }
    }
}
