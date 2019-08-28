using System;
using System.Collections.Generic;
using System.Text;
using LeafSoft.Lib;

namespace LeafSoft.Model
{
    /// <summary>
    /// 命令实体模型
    /// </summary>
    public class CMD
    {
        EnumType.DataEncode _DataEncode = EnumType.DataEncode.Hex;
        string _strCMD = "";
        byte[] _byteCMD = null;
        string _tipCMD = "";

        public CMD(EnumType.DataEncode DataEncode, byte[] data)
        {
            _DataEncode = DataEncode;
            _byteCMD = data;
            switch (_DataEncode)
            {
                case EnumType.DataEncode.Hex:
                    foreach (byte b in _byteCMD)
                    {
                        _strCMD += string.Format("{0:X2} ", b);
                    }
                    _strCMD = _strCMD.TrimEnd();
                    break;
                case EnumType.DataEncode.ASCII:
                    _strCMD = new ASCIIEncoding().GetString(_byteCMD);
                    break;
                case EnumType.DataEncode.UTF8:
                    _strCMD = new UTF8Encoding().GetString(_byteCMD);
                    break;
                case EnumType.DataEncode.GB2312:
                    _strCMD = Encoding.GetEncoding("GB2312").GetString(_byteCMD);
                    break;
            }
        }

        public CMD(EnumType.DataEncode DataEncode, string data)
        {
            _DataEncode = DataEncode;
            _strCMD = data;
            switch (_DataEncode)
            {
                case EnumType.DataEncode.Hex:
                    data = data.Replace(" ", "");
                    byte[] array = new byte[data.Length / 2];
                    for (int i = 0; i < data.Length; i += 2)
                    {
                        array[i / 2] = Convert.ToByte(data.Substring(i, 2), 16);
                    }
                    _byteCMD = array;
                    break;
                case EnumType.DataEncode.ASCII:
                    _byteCMD = new ASCIIEncoding().GetBytes(_strCMD);
                    break;
                case EnumType.DataEncode.UTF8:
                    _byteCMD = new UTF8Encoding().GetBytes(_strCMD);
                    break;
                case EnumType.DataEncode.GB2312:
                    _byteCMD = Encoding.GetEncoding("GB2312").GetBytes(_strCMD);
                    break;
            }
        }


        /// <summary>
        /// 命令类型
        /// </summary>
        public EnumType.DataEncode ContentType
        {
            get
            {
                return _DataEncode;
            }
        }

        /// <summary>
        /// 命令类型
        /// </summary>
        public string ContentTypeName
        {
            get
            {
                return _DataEncode.ToString();
            }
        }

        /// <summary>
        /// 命令字符串
        /// </summary>
        public string Text
        {
            get
            {
                return _strCMD;
            }
        }

        /// <summary>
        /// 命令字节数组
        /// </summary>
        public byte[] Bytes
        {
            get
            {
                return _byteCMD;
            }
        }

        public string Tips
        {
            set
            {
                _tipCMD = value;
            }
            get
            {
                return _tipCMD;
            }
        }
    }
}
