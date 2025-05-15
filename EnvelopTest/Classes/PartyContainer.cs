using EnvelopTest.Common;
using System.Xml.Serialization;

public class PartyContainer : UblBase
{
    [XmlElement(ElementName = "Party", Namespace = CAC_NS)]
    public Party Party { get; set; }
}
