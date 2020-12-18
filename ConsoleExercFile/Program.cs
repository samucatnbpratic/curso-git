using System;
using System.Globalization;
using System.IO;

namespace ConsoleExercFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Informe o caminho do arquivo: ");
            string path = @"d:\temp\itens.csv";//Console.ReadLine();
            string summary = Path.GetDirectoryName(path) + @"\out\summary.csv";
            try
            {
                if(!Directory.Exists(summary))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(summary));
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    using (StreamWriter sw = File.CreateText(summary))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] dados = sr.ReadLine().Split(',');
                            string nome = dados[0];
                            decimal valorTotal = decimal.Parse(dados[1]) * int.Parse(dados[2]);
                            sw.WriteLine(nome + "," + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }

                }
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
