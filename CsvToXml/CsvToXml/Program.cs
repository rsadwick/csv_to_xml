using System;

namespace CsvToXml {
    internal class Program {
        private static void Main(string[] args) {
            var csv2Xml = new CvsExport();
            Console.WriteLine(csv2Xml.GetXml());
        }
    }
}
