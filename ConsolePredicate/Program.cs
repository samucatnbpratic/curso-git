
using System.Collections.Generic;
using ConsolePredicate.Entities;

namespace ConsolePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //RemoveAll recebe um Predicate - que é um delegate que recebe um objeto e devolve um booleano
            list.RemoveAll(p => p.Price >= 100.0);
            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }
        }
    }
}
