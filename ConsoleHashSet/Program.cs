using ConsoleHashSet.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));


            //obs aqui é um novo endereço de memoria uma nova instancia 
            Product prod = new Product("Notebook", 1200.0);

            //como temos dois objetos diferentes e não tem o GETHASHCODE e EQUALS ele retorna falso, pois compara por referencia
            Console.WriteLine(a.Contains(prod));

            //quanto tipo é struct vai comparar por valor e não por referencia, então neste caso não precisamos implementar o 
            //GetHashCode e Equals
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Point p = new Point(5, 10);

            Console.WriteLine(b.Contains(p));


           
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            set.Add("Bike");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string o in set)
            {
                Console.WriteLine(o);
            }
            
        }
    }
}
