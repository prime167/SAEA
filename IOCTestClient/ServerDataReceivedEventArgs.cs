using System;

namespace IOCTestClient
{
    internal class ServerDataReceivedEventArgs : EventArgs 
    {
        public byte[] Buff { get; set; }
    }
}
