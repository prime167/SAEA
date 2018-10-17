using System;

namespace IOCTestServer
{
    public class ClientNumChangeEventArgs:EventArgs
    {
        public AsyncUserToken Token { get; set; }

        /// <summary>
        /// 当前增加客户的个数(用户退出时为负数,增加时为正数,一般为1
        /// </summary>
        public int Num { get; set; }
    }
}
