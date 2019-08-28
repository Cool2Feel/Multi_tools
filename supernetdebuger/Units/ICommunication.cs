using System;
using System.Collections.Generic;
using System.Text;
using LeafSoft.Lib;
namespace LeafSoft.Units
{
    /// <summary>
    /// 通讯调试接口
    /// </summary>
    public interface ICommunication
    {
        /// <summary>
        /// 事件：接收数据
        /// </summary>
        event LeafEvent.DataReceivedHandler DataReceived;

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="data"></param>
        bool SendData(byte[] data);

        /// <summary>
        /// 清理通讯资源
        /// </summary>
        void ClearSelf();
    }
}
