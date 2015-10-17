

namespace ExtractPricesByDate
{
    using System;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the year you want to filter all albums by!");
            Console.WriteLine("Albums after:");
            var year = int.Parse(Console.ReadLine());

            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            var priceYearQuery = "/catalog/album[year>" + year + "]";

            var albums = doc.SelectNodes(priceYearQuery);

            foreach (XmlNode album in albums)
            {
                var albumName = album["name"].InnerText;
                var albumPrice = album["price"].InnerText;
                Console.WriteLine(albumName + " - " + albumPrice + "$");
            }
            Console.Read();

        }
    }
}
