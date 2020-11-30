using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleGenericParte2.Entities;

namespace ConsoleGenericParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //passamos nome e valor, separado por virgula
                string[] vect = Console.ReadLine().Split(',');
                string nome = vect[0];
                double valor = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(nome,valor));
            }

            CalculationService calc = new CalculationService();

            Product max = calc.Max<Product>(list);
            Console.WriteLine("Max: " + max);
        }
    }
}
