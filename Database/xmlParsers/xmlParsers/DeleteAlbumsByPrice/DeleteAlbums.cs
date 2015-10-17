namespace DeleteAlbumsByPrice
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class DeleteAlbums
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            var catalog = doc.DocumentElement;

            DeleteAlbumByPrice(catalog, 20.0);
            doc.Save("../../../catalogOfCheapAlbums.xml");
            Console.WriteLine("Success!");
            Console.Read();
        }

        private static void DeleteAlbumByPrice(XmlElement catalog, double maxPrice)
        {
            var albums = catalog.ChildNodes;
            for(int i = albums.Count - 1; i >= 0; i--)
            {
                var album = albums[i];
                var stringPrice = album["price"].InnerText;
                var price = Double.Parse(stringPrice);
                if (price > maxPrice)
                {
                    catalog.RemoveChild(album);
                }
            }

        }
    }
}
