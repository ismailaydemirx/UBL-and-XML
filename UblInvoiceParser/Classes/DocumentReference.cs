using EnvelopTest.Common;
using System.Xml.Serialization;

public class DocumentReference : UblBase
{
    [XmlElement(ElementName = "ID", Namespace = CBC_NS)]
    public string ID { get; set; }

    [XmlElement(ElementName = "UUID", Namespace = CBC_NS)]
    public string UUID { get; set; }

    [XmlElement(ElementName = "URI", Namespace = CBC_NS)]
    public string URI { get; set; }

}
