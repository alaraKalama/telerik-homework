namespace Space3D
{
    using System;
    //using System.Collections.Generic;
    using System.Linq;
    //using System.Text;
   // using System.Threading.Tasks;
    using System.IO;

    public static class PathStorage
    {
        public static void Save(Path3D path)
        {
            Console.WriteLine("Enter name for the file:");
            string name = Console.ReadLine();
            string fullPath = @"..\..\files\paths\" + name.Trim() + ".txt";
            try
            {
                using (StreamWriter write = File.CreateText(fullPath))
                {
                    if (File.Exists(fullPath))
                    {
                        Console.WriteLine("A file with that name already exist");
                        Console.WriteLine("If you want to override it, enter the name again, else = enter new name:");
                        name = Console.ReadLine();
                    }
                    string text = path.ToString();
                    write.Write(text);
                    Console.WriteLine("Success! A new file: {0}, was created at {1}",
                                      Path.GetFileNameWithoutExtension(fullPath),
                                      Path.GetFullPath(fullPath));
                }
            }
            catch (DirectoryNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

        }

        public static Path3D Load ()
        {
            Path3D path = new Path3D();
            Console.WriteLine("What file you want to open?");
            Console.WriteLine("Enter name of the file:");
            string name = Console.ReadLine();
            string fullPath = @"..\..\files\paths\" + name.Trim() + ".txt";

            try 
            {
                var reader = new StreamReader(fullPath);
                string[] pointsText = reader.ReadToEnd().
                                      Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach(var point in pointsText)
                {
                    char[] coor = point.ToCharArray();
                    int i = 0;
                    double[] coo = new double[3];
                    foreach(char c in coor)
                    {
                        if (char.IsDigit(c))
                        {
                            coo[i] = c - '0';
                            i++;
                        }
                    }
                    
                    //double[] coo = point.Trim()
                    //      .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    //      .Select(x => double.Parse(x))
                    //      .ToArray();

                    path.AddPoint(new Point3D(coo[0], coo[1], coo[2]));
                }
            }
            catch(FileLoadException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(FileNotFoundException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }

            return path;
        }

    }
}
