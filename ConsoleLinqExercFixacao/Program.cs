using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using ConsoleLinqExercFixacao.Entities;

namespace ConsoleLinqExercFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\funcionarios.csv";
            IList<Funcionario> list = new List<Funcionario>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] func = sr.ReadLine().Split(',');
                    string nome = func[0];
                    string email = func[1];
                    double salario = double.Parse(func[2], CultureInfo.InvariantCulture);
                    list.Add(new Funcionario(nome, email, salario));
                }
            }

            Console.Write("SALARIO BASE: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var listEmail = list.Where(p => p.Salario > valor).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine($"EMAIL DOS FUNCIONARIOS COM VALOR SUPERIOR A: {valor}");
            foreach (var item in listEmail)
            {
                Console.WriteLine(item);
            }

            var somaSalario = list.Where(p => p.Nome[0] == 'M').Sum(p => p.Salario);
            Console.WriteLine("SOMA DOS SALARIOS DOS FUNCIONARIOS QUE O NOME COMEÇA COM 'M': " 
                + somaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
