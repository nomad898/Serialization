using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    public enum Genre
    {
        [XmlEnum]
        Computer,
        [XmlEnum]
        Fantasy,
        [XmlEnum]
        Romance,
        [XmlEnum]
        Horror,
        [XmlEnum("Science Fiction")]
        ScienceFiction
    }
}
