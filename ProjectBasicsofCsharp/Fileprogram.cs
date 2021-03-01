using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjectBasicsofCsharp
{
    class Fileprogram
    {
        public static void Do()
        {
            
            readText();
        }
        
        private static void readText()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("Students Record Present in the Database are:");
                string[] contents = File.ReadAllLines(filename);
                foreach (var content in contents)
                {
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
    }
}
