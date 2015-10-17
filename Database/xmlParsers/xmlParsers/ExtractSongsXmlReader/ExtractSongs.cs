namespace ExtractSongsXmlReader
{
    using System;
    using System.Xml;

    class ExtractSongs
    {
        static void Main()
        {
            using (XmlReader reader = new XmlTextReader("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
            Console.Read();
        }
    }
}
