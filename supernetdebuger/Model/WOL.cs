using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeafSoft.Model
{
    public class WOL
    {
        string _strWOLMac = "";
        string _strWOLName = "";
        string _strWOLIp = "";

        public WOL(string mac,string name,string ip)
        {
            _strWOLMac = mac;
            _strWOLName = name;
            _strWOLIp = ip;
        }

        public string MAC
        {
            get { return _strWOLMac; }
        }
        public string NAME
        {
            get { return _strWOLName; }
        }
        public string IP
        {
            get { return _strWOLIp; }
        }
    }
}
