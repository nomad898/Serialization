using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    [Serializable]
    [XmlRoot("book")]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("isbn")]
        public string Isbn { get; set; }
        [XmlElement("author")]
        public string Author { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public Genre Genre { get; set; }
        [XmlElement("publisher")]
        public string Publisher { get; set; }        
        [XmlElement("publish_date", DataType = "date")]
        public DateTime PublishDate { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("registration_date", DataType = "date")]
        public DateTime RegistrationDate { get; set; }

        public override string ToString()
        {
            return
                $"ID: {Id}| " +
                $"ISBN: {Isbn}| " +
                $"Author: {Author}| " +
                $"Title: {Title}| " +
                $"Genre: {Genre}| " +
                $"Publisher: {Publisher}|" +
                $"PublisherDate: {PublishDate.Date.ToString("dd/MM/yyyy")}|" +
                $"Description: {Description}|" +
                $"RegistrationDate: {RegistrationDate.Date.ToString("dd/MM/yyyy")}";
        }
    }
}
