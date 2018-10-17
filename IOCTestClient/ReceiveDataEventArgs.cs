using System;

namespace IOCTestClient
{
    internal class ReceiveDataEventArgs:EventArgs 
    {
        public object Message { get; set; }
    }
}
