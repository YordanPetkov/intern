using System;
using System.Text;
using System.Xml;

namespace _10.ExtractTextFromXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader xmlReader = XmlReader.Create("../../../file.xml");
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                        Console.WriteLine(xmlReader.Name);
                }
                if (xmlReader.NodeType == XmlNodeType.Text)
                {
                        Console.WriteLine(xmlReader.Value);
                }
                if (xmlReader.NodeType == XmlNodeType.EndElement)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
