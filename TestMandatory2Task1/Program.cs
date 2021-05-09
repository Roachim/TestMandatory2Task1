using System;
using System.IO;
using System.Xml;

namespace TestMandatory2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(new StreamReader(@"C:\Users\joach\source\repos\KEA\Software Testing\TestMandatory2Task1\TestMandatory2Task1\StorageDepot_Tests.xml"));
            //XmlReader rdr = XmlReader.Create(@"C:\Users\joach\source\repos\KEA\Software Testing\TestMandatory2Task1\TestMandatory2Task1\StorageDepot_Tests.xml");

            Console.WriteLine("Doc info below");

            //while (rdr.Read())
            //{
                
            //}

            Console.WriteLine(XMLParser.DepotStorageParser(doc));

            Console.WriteLine("Doc info above");

            Console.ReadKey();


        }
    }
}
