﻿namespace ExtractSongsLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractSongs
    {
        static void Main()
        {
            var doc = XDocument.Load("../../../catalog.xml");
            var albums = doc.Element("catalog").Elements("album");
            var titles = from title in albums.Descendants("title") select title.Value;

            foreach(var title in titles)
            {
                Console.WriteLine(title);
            }
            Console.Read();
        }
    }
}
