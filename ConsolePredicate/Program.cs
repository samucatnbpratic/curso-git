using System;
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
            list.RemoveAll(ProductTest); //obedece os criterios da função para excluir
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //criamos uma função e estamos passando como parametro do metodo RemoveAll do nosso list 
        public static bool ProductTest(Product P)
        {
            return P.Price >= 100.0;
        }

    }
}
