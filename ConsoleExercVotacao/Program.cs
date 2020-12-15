using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleExercVotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> vot = new Dictionary<string, int>();

            string path = @"d:\temp\votacao.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    int soma = 0;
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        if (vot.ContainsKey(line[0]))
                        {
                            vot.TryGetValue(line[0], out soma); //aqui recuperamos o valor da chave  que já existe
                        }
                        else
                        {
                            soma = 0;
                        }
                        soma += int.Parse(line[1]);
                        vot[line[0]] = soma;

                    }
                    foreach (var item in vot)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
