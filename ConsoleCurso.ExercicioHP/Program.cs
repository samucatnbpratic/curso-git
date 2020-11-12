using ConsoleCurso.ExercicioHP.Entitites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleCurso.ExercicioHP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                //produto comum, usado, ou importado
                Console.Write("Common, used or imported (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Price: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == 'i')
                {
                    Console.Write("Customs fee: ");
                    double custoi = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(nome, preco, custoi));
                }
                else if (tipo == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(nome, preco, data));
                }
                else
                {
                    list.Add(new Product(nome, preco));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());  

            }


        }
    }
}
