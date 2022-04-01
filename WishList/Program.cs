using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyWishList = new List<string>();

            Console.WriteLine(MyWishList.Count);

            MyWishList.Add("coffee machine");
            MyWishList.Add("new pair of socks");
            MyWishList.Add("box of chocolates");
            MyWishList.Add("new pillow");

            Console.WriteLine(MyWishList.Count);
            
            foreach(string wish in MyWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
