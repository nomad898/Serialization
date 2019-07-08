using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BasicSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = $@"{Environment.CurrentDirectory}\books.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            Catalog catalog;
            using (var xmlReader = XmlReader.Create(path))
            {
                catalog = serializer.Deserialize(xmlReader) as Catalog;
            }
            Console.WriteLine($"Date: {catalog.Date}");
            foreach (var item in catalog.Books)
            {
                Console.WriteLine($"{item.ToString()}");
            }


            using (var xmlWriter = XmlWriter.Create("serializedBooks.xml"))
            {
                serializer.Serialize(xmlWriter, catalog);
            }

            Console.ReadKey(true);
        }
    }
}
