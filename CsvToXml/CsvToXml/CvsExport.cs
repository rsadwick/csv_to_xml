using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace CsvToXml {
    public class CvsExport {
        private readonly XElement cust;

        public CvsExport() {
            const string CvsString = @"1,Match these great fashion finds!,338025,http://example.com,Watch these tests run wild,546546,http://www.something.net";
            File.WriteAllText("cust.csv", CvsString);
            //read into array of strings
            var source = File.ReadAllLines("cust.csv");
            cust = new XElement("ignoreMeContainer",
                from str in source
                let fields = str.Split(',')
                select new XElement("_sLevelName",
                    new XElement("_nLevelTime", fields[0]),
                    new XElement("_sMessage", fields[1]),
                    new XElement("_nPointsPerMatch", fields[2])
                    ));
        }

        public XElement GetXml() {
            return cust;
        }
    }
}
