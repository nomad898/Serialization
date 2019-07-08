using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    [Serializable]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlAttribute("date", DataType = "date")]
        public DateTime Date { get; set; }
        [XmlElement("book")]
        public List<Book> Books = new List<Book>();        
    }
}
