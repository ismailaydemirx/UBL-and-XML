using EnvelopTest.Common;
using System.Xml.Serialization;

public class EnvelopeExample : UblBase
{
    // Root Element
    [XmlRoot(ElementName = "InvoiceEnvelope", Namespace = UBL_INVOICE_NS)]
    public class InvoiceEnvelope
    {
        public string UUID { get; set; }

        [XmlElement(ElementName = "IssueDate", Namespace = CBC_NS)]
        public DateTime IssueDate { get; set; }

        [XmlElement(ElementName = "SenderParty", Namespace = CAC_NS)]
        public PartyContainer SenderParty { get; set; }

        [XmlElement(ElementName = "ReceiverParty", Namespace = CAC_NS)]
        public PartyContainer ReceiverParty { get; set; }

        [XmlElement(ElementName = "InvoiceDocumentReference", Namespace = CAC_NS)]
        public List<DocumentReference> InvoiceDocumentReference { get; set; }
    }
}
