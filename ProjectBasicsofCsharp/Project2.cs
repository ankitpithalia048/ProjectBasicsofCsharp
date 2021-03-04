using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectBasicsofCsharp
{
    class Project2
    {
        public static void Do()
        {

            string input;
            do
            {
                Console.WriteLine("1.Show Sorted Data\n2.Search");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    readTextAndSort();
                }
                else
                {
                    
                    SearchData();
                }
                Console.WriteLine("\n\nWant to continue?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));
        }

        private static void readTextAndSort()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            if (File.Exists(filename))
            {
                
                string[] names = File.ReadAllLines(filename);
                string temp;
                
                
                for (int i = 1; i < names.Length - 1; i++)
                {
                    
                    for (int j = 0; j < names.Length - 1; j++)
                    {
                        if (names[j + 1].CompareTo(names[j]) < 0)
                        {
                            temp = names[j];
                            names[j] = names[j + 1];
                            names[j + 1] = temp;
                            
                        }
                    }
                }
                Console.WriteLine("\n\nSorted Lists of Student are-\n");
                foreach (var content in names)
                {
                    
                    Console.WriteLine(content);
                }
                
            }
            
        }
        private static void SearchData()
        {

            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            if (File.Exists(filename))
            {
                
                string[] names = File.ReadAllLines(filename);
                Console.WriteLine("\n\nEnter a name to search!");
                string input = Console.ReadLine();
                bool flag = true;
                foreach (string line in names)
                {
                    if (line.Contains(input))
                    {
                        Console.WriteLine(line);
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Record Not Found");
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

        }


    }
}
