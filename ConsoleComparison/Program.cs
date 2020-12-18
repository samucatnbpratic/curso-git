using System;
using ConsoleComparison.Entities;
using System.Collections.Generic;

namespace ConsoleComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00m));
            list.Add(new Product("Notebook", 1200.00m));
            list.Add(new Product("Tablet", 450.00m));

            //declaramos uma variavel e ela recebe uma expressão lambda (declaração de função anonima)
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //Comparison - é um delegate que é uma referencia para função type safety
            //observe que não precisamos informar nossos dois parametros da função.
            list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        
    }
}
