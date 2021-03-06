﻿using System;
using System.Linq;
using ConsoleLinq.Entities;
using System.Collections.Generic;

namespace ConsoleLinq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Aula226();

            DemoLinqLambda228();

        }

        private static void DemoLinqLambda228()
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(){Id = 1, Name = "Electronics", Tier = 1 }; //apenas para variar a forma de instanciar

            List<Product> produtcts = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product(){Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product(){Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product(){Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product(){Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product(){Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product(){Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product(){Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product(){Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product(){Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product(){Id = 11, Name = "Level", Price = 70.0, Category = c1}

            };

            var r1 = produtcts.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900: ", r1);

            var r2 = produtcts.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

           // var r3 = produtcts.Where(p => p.Name.ToString().Substring(0,1).ToUpper() == "C").Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = produtcts.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = produtcts.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME ", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = produtcts.First();
            Console.WriteLine("FIRST PRODUCT: " + r6);

            var r7 = produtcts.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT TESTE 2: " + r7);

            var r8 = produtcts.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default teste1: " + r8);

            var r9 = produtcts.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default teste2: " + r9);

            //Max() -  para usar sem passar parametros sua classe Product deve implementar o IComparable, caso contrario dará erro
            var r10 = produtcts.Max(p => p.Price); //definimos qual o campo deverá ser comparado
            Console.WriteLine("Max Price: " + r10);

            var r11 = produtcts.Min(p => p.Price); //definimos qual o campo deverá ser comparado
            Console.WriteLine("Min Price: " + r11);

            var r12 = produtcts.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            var r13 = produtcts.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            //tratando uma possível excessão caso nao retorne nada
            //primeiro usamos Select e selecionamos o campo para calcular a media
            //segundo fazemos uma verificação com DefaultIfEmpty(0) onde devolve zero se não encontrar nada
            //terceiro pegamos a média e não precisamos passar nenhuma expressão pq já temos o campo Price.
            var r14 = produtcts.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            //faremos nossa propria operação personalizada (0.0 defini um valor inicial para conta)
            var r15 = produtcts.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 Agregate(Sum prices): " + r15);

            var r16 = produtcts.GroupBy(p => p.Category);
            foreach (var cat in r16)
            {
                Console.WriteLine("\nCategory " + cat.Key.Name + ":\n");
                foreach (var item in cat)
                {
                    Console.WriteLine(item);
                }
            }
            //outra forma de fazer o foreach
            foreach (IGrouping<Category,Product> cat in r16)
            {
                Console.WriteLine("\nCategory " + cat.Key.Name + ":\n");
                foreach (Product item in cat)
                {
                    Console.WriteLine(item);
                }
            }

        }

        static void Aula226()
        {
            //especifica nossa fonte de dados (de onde pegaremos as informações)
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //defini a expressão query (neste exmplo selecionamos os numeros pares e multiplicamos por 10) 
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //executando a query (o Linq usa a execução Lazy (tardia) então a query acima só é executada no momento em que precisamos dela)
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
