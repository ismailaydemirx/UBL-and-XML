using EnvelopTest.Common;
using System.Xml.Serialization;

public class Party : UblBase
{
    [XmlElement(ElementName = "PartyName", Namespace = CAC_NS)]
    public PartyName PartyName { get; set; }
}
