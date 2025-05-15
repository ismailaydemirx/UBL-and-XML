using System.Xml.Linq;

class Program
{
    static void Main()
    {
        var xml = XDocument.Load("../../../fatura.xml");
        var faturalar = xml.Root.Elements("fatura"); // 1 den fazla olduğu için Elements fonksiyonu kullanıldı

        // Control
        Console.WriteLine($"Kök etiket: {xml.Root.Name}");
        Console.WriteLine($"Fatura sayısı: {faturalar.Count()}");

        foreach (var fatura in faturalar)
        {
            // Id, fatura elementi içerisinde bulunan bir attribute olduğu için burada Attribute fonksiyonu kullanıldı
            var id = fatura.Attribute("id")?.Value;
            var alici = fatura.Element("aliciverici")?.Element("ad")?.Value;
            var vergiNo = fatura.Element("aliciverici")?.Element("vergiNo")?.Value;
            var tutar = fatura.Element("tutar")?.Value;

            Console.WriteLine($"Fatura Id: {id}");
            Console.WriteLine($"Alıcı: {alici}");
            Console.WriteLine($"Vergi No: {vergiNo}");
            Console.WriteLine($"Tutar: {tutar}");
            Console.WriteLine("-----------------------------");
        }

    }
}