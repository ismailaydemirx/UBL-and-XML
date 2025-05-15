using System;
using System.IO;
using System.Xml.Serialization;
using static EnvelopeExample;

class Program
{
    static void Main()
    {
        var path = "../../../invoiceEnvelope.xml";

        // XML'den InvoiceEnvelope tipinde veri okumak için serializer oluşturuluyor
        var serializer = new XmlSerializer(typeof(InvoiceEnvelope));
        using var stream = File.OpenRead(path);

        // XML içeriğini C# nesnesine dönüştürüyoruz
        var envelope = (InvoiceEnvelope)serializer.Deserialize(stream);

        Console.WriteLine($"Zarf UUID: {envelope.UUID}");
        Console.WriteLine($"Tarih: {envelope.IssueDate:yyyy-MM-dd}");
        Console.WriteLine($"Gönderen: {envelope.SenderParty.Party.PartyName.Name}");
        Console.WriteLine($"Alıcı: {envelope.ReceiverParty.Party.PartyName.Name}");
        Console.WriteLine("Fatura Referansları:");

        foreach (var refDoc in envelope.InvoiceDocumentReference)
        {
            Console.WriteLine($"- ID: {refDoc.ID}, UUID: {refDoc.UUID}, Dosya: {refDoc.URI}");
        }
    }
}