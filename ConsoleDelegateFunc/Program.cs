using System;
using ConsoleDelegateFunc.Entities;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //objetivo deste projeto é utilizarmos o Delegate Func
            //pra isso estamos usando a função Select do List

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(NameUpper).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
