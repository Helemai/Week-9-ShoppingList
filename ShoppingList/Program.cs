using System;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\OneDrive\Töölaud\TKTK\III aasta\Programmeerimise algkursus\Samples";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine().ToLower();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine().ToLower();



            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exists.");

            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            }

        }
    }
}
