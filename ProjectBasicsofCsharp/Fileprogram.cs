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
            Writetext();
            readText();
        }
        private static void Writetext()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

            StreamWriter wrt = File.CreateText(filename);
            wrt.WriteLine("Name: Ankit, Age: 21, Dept: Traniee");
            wrt.WriteLine("Name: Shaswat, Age: 21, Dept: Devops");
            wrt.WriteLine("Name: Yash, Age: 21, Dept: Traniee");
            wrt.WriteLine("Name: John, Age: 21, Dept: CD");
            wrt.WriteLine("Name: Adam, Age: 21, Dept: IT");
            wrt.Close();
            Console.WriteLine("Content lines have been added into file");
        }
        private static void readText()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
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
