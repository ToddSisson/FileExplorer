using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1
{
    class FileExplorer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a directory: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            while (input != "end")
            {
                if (Directory.Exists(input))
                {
                    Console.WriteLine("Directory found.");
                    string[] directoryList = Directory.GetFiles(input);
                    for (int x = 0; x < directoryList.Length; x++)
                    {
                        Console.WriteLine(directoryList[x]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Enter a file name in this directory (just the file name and extension):");
                    string fileInput = input + "/" + Console.ReadLine();
                    if (File.Exists(fileInput))
                    {
                        Console.WriteLine();
                        Console.WriteLine("File exists!");
                        Console.WriteLine(File.GetCreationTime(fileInput));
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("File does not exist");
                    }
                }

                else
                    Console.WriteLine("Directory not found. Try Again.");

                Console.WriteLine();
                Console.WriteLine("Enter the name of a directory: ");
                input = Console.ReadLine();
                Console.WriteLine();

            }

            Console.WriteLine("Program ending.");
        }
    }
}
