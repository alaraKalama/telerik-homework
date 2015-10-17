namespace ExtractPricesByDateLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractPricesByDate
    {
        static void Main()
        {
            Console.WriteLine("Enter the year you want to filter all albums by!");
            Console.WriteLine("Albums after:");
            var year = int.Parse(Console.ReadLine());

            var doc = XDocument.Load("../../../catalog.xml");

            var albumNames = from album in doc.Descendants("album")
                             where int.Parse(album.Element("year").Value) > year
                             select album.Element("name").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumNames));
        }
    }
}
