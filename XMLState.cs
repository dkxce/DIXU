using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DIXU
{
    [Serializable]
    public class XMLState: XMLSaved<XMLState>
    {
        public byte textEnc = 0;
        public byte baseKey = 0;
        public string lastText;
        public string lastCode;
        public bool onFly = false;
        public List<string> keyHistory = new List<string>();
    }
}
