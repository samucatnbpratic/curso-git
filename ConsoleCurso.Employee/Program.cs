using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleCurso.SisEmployee.Entities;

namespace ConsoleCurso.SisEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n) ?"); //pergunta se é terceirizado
                char terc = char.Parse(Console.ReadLine());
                Console.Write("Name: "); 
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Value per  hour: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (terc == 'y')
                {
                    Console.Write("Additional charge: ");
                    double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(nome, horas, valorHora, despesaAdicional));
                }
                else
                    list.Add(new Employee(nome, horas, valorHora));


            }

            Console.WriteLine( );
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee item in list)
            {
                Console.WriteLine(item.Name + " - $ " + item.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }


        }
    }
}
