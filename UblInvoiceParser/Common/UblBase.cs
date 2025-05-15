using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EnvelopTest.Common
{
    public abstract class UblBase
    {
        public const string UBL_INVOICE_NS = "urn:oasis:names:specification:ubl:schema:xsd:InvoiceEnvelope-2";
        public const string CBC_NS = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string CAC_NS = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces Xmlns;

        protected UblBase()
        {
            Xmlns = new XmlSerializerNamespaces();
            Xmlns.Add("cbc", CBC_NS);
            Xmlns.Add("cac", CAC_NS);
            Xmlns.Add("", UBL_INVOICE_NS);
        }
    }
}
