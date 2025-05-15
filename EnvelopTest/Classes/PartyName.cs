using EnvelopTest.Common;
using System.Xml.Serialization;

public class PartyName : UblBase
{
    [XmlElement(ElementName = "Name", Namespace = CBC_NS)]
    public string Name { get; set; }
}
