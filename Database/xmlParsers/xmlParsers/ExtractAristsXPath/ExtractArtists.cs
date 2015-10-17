
namespace ExtractAristsXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.XPath;

    class ExtractArtists
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            var catalog = doc.DocumentElement;

            var allArtists = createListOfArtistsAndAlbums(catalog);
            int i = 1;
            foreach (var artist in allArtists)
            {
                Console.WriteLine("{0}. {1} - {2} album(s)", i, artist.Key, artist.Value);
                i++;
            }
            Console.Read();

        }

        private static Dictionary<string, int> createListOfArtistsAndAlbums(XmlElement catalog)
        {
            var result = new Dictionary<string, int>();
            var artists = catalog.SelectNodes("/catalog/album/artist");
            foreach (XmlElement artist in artists)
            {
                var name = artist.InnerText;

                if (result.ContainsKey(name))
                {
                    result[name] += 1;
                }
                else
                {
                    result.Add(name, 1);
                }
            }

            return result;
        }
    }
}
