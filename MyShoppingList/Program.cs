using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\OneDrive\Töölaud\TKTK\III aasta\Programmeerimise algkursus\Samples\shoppinglist";
            string fileName = @"\\myshoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myshoppinglist = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter something to your shopping list:");
                    string userWish = Console.ReadLine();
                    myshoppinglist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Good shopping!");

                }
                File.WriteAllLines($"{fileLocation}{fileName}", myshoppinglist);
            }
           
        }
    }
}
