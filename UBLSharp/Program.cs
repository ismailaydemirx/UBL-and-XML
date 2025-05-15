using System;
using System.IO;
using System.Xml.Serialization;
using UblSharp;

class Program
{
    static void Main()
    {
        var xmlPath = "../../../invoice.xml";

        using (var stream = File.OpenRead(xmlPath))
        {
            var serializer = new XmlSerializer(typeof(InvoiceType));
            var invoice = (InvoiceType)serializer.Deserialize(stream);

            var faturaId = invoice.ID.Value;
            var faturaTarihi = invoice.IssueDate.Value;
            var Tedarikci = invoice.AccountingSupplierParty.Party.PartyName[0].Name.Value;
            var toplamTutar = invoice.LegalMonetaryTotal.PayableAmount.Value;
            var paraBirimi = invoice.LegalMonetaryTotal.PayableAmount.currencyID;

            Console.WriteLine($"Fatura ID: {faturaId}");
            Console.WriteLine($"Fatura Tarihi: {faturaTarihi}");
            Console.WriteLine($"Tedarikçi: {Tedarikci}");
            Console.WriteLine($"Toplam Tutar: {toplamTutar} {paraBirimi}");
        }
    }
}
