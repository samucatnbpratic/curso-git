using System;
using System.Collections.Generic;

namespace ConsoleSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union - aqui estou instanciando o conjunto 'c' e já inserindo tudo o que existe na coleção 'a'
            SortedSet<int> c = new SortedSet<int>(a);
            //aqui inserimos a coleção 'b' todos os objetos que não existem em 'c' pois não aceita repetição.
            c.UnionWith(b);

            //observação o SortedSet sempre trará os numeros ordernados do menor ao maior.
            PrintCollection(c);

            //aqui ele pega os elementos que estão nas duas listas 'd' e 'b'
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //aqui tras os registros diferentes nas duas listas
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>( IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
