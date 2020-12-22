using ConsoleLinqExercResolvido.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Globalization;

namespace ConsoleLinqExercResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\produtos.csv";
            List<Product> products = new List<Product>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] prod = sr.ReadLine().Split(",");
                    string name = prod[0];
                    double price = double.Parse(prod[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            var list = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            foreach (var p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
