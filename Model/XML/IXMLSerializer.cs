using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.XML
{
    public interface IXMLSerializer
    {
        string Object2Xml<T>(T data);

        T Xml2Object<T>(string xml);
    }
}
