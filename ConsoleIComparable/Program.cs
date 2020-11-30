using System;
using System.Collections.Generic;
using System.IO;
using ConsoleIComparable.Entities;

namespace ConsoleIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListaNomes();
            ListaNomeSalario();
        }

        static void ListaNomeSalario()
        {
            string path = @"d:\temp\listanomesalario.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort(); //ordenamos a lista
                    foreach (Funcionario item in list)
                    {
                        Console.WriteLine(item);
                    }
                }

            }
            catch (IOException e)
            {

                Console.WriteLine("Ocorreu um erro! ");
                Console.WriteLine(e.Message);
            }

        }

        static void ListaNomes()
        {
            string path = @"d:\temp\listanomes.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort(); //ordenamos a lista
                    foreach (string item in list)
                    {
                        Console.WriteLine(item);
                    }
                }

            }
            catch (IOException e)
            {

                Console.WriteLine("Ocorreu um erro! ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
