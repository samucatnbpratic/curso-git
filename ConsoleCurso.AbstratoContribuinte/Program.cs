using ConsoleCurso.AbstratoContribuinte.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleCurso.AbstratoContribuinte
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Entre com o numero de contruibuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Contribuinte #{i} dados: ");
                Console.Write("Pessoa Física ou Jurídica (i/c) ?");
                char p = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());
                if (p == 'i')
                {
                    Console.Write("Gastos Saude: ");
                    double gastoSaude = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(nome, renda, gastoSaude));
                }
                else
                {
                    Console.Write("Número de Funcionários: ");
                    int numFunc = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, renda, numFunc));

                }
            }

            double imposto = 0.0, total = 0.0;
            Console.WriteLine("TAXES PAID: ");
            foreach (Pessoa item in list)
            {
                imposto = item.Imposto();
                total += imposto;
                Console.WriteLine(item.Nome + " $" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


            foreach (Pessoa item in list)
            {

               
            }
            Console.WriteLine("TOTAL IMPOSTO $" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
