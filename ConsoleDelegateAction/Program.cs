﻿using System;
using ConsoleDelegateAction.Entities;
using System.Collections.Generic;

namespace ConsoleDelegateAction
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

            list.ForEach(UdpatePrice);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UdpatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
