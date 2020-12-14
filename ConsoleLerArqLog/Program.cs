using System;
using System.Collections.Generic;
using System.IO;
using ConsoleLerArqLog.Entities;

namespace ConsoleLerArqLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet - estamos usando ele e nao o Sortedset porque a ordem não importa e ele neste caso é o mais rapido
            HashSet<RegistroLog> set = new HashSet<RegistroLog>();

            string path = @"d:\temp\log.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        //observação nao entra registros com nome de usuario repetido
                        set.Add(new RegistroLog(line[0], DateTime.Parse(line[1])));
                        
                    }

                    Console.WriteLine("Total de usuarios: " + set.Count);
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
