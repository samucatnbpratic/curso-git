using System;
using ConsoleEquals.Entities;

namespace ConsoleEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Nome = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Nome = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(a == b);//compara referencia de memoria 
        }
    }
}
