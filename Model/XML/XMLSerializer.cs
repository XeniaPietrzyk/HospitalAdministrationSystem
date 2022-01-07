using Model.Model;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Model.XML
{
    class XMLSerializer
    {
        public string Object2Xml<T>(List<T> data, string fileName)
        {
            var filePath = makeFilePath(fileName);
            var xmlSerializer = new XmlSerializer(typeof(List<T>));

            if (File.Exists(filePath)) File.Delete(filePath);

            #region Xml Writer Settings

            var xmlWriterSettings = new XmlWriterSettings
            {
                Encoding = new UnicodeEncoding(false, false),
                Indent = true,
                IndentChars = "\t",
                OmitXmlDeclaration = false
            };

            #endregion

            using (var streamWriter = new StreamWriter(filePath))
            {
                using (var xmlWriter = XmlWriter.Create(streamWriter, xmlWriterSettings))
                {
                    xmlSerializer.Serialize(xmlWriter, data);
                }
                return streamWriter.ToString();
            }
        }

        public List<T> Xml2Object<T>(List<T> data, string fileName)
        {
            var filePath = makeFilePath(fileName);
            var xmlSerializer = new XmlSerializer(typeof(List<T>));
            var xmlReaderSettings = new XmlReaderSettings();      
            
            if (!File.Exists(filePath))
            {
                Object2Xml<T>(data, fileName);
                return data;
            }
            else
            {
                using (var streamReader = new StreamReader(filePath))
                {
                    using (var xmlReader = XmlReader.Create(streamReader, xmlReaderSettings))
                    {
                        return (List<T>)xmlSerializer.Deserialize(xmlReader);
                    }
                }
            }            
        }

        private string makeFilePath(string fileName)
        {
            var xmlDirectory = Directory.GetCurrentDirectory() + @"\xml";
            Directory.CreateDirectory(xmlDirectory);

            var newPath = xmlDirectory + @"\" + fileName;
            return newPath;
        }
    }
}
