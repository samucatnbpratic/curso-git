using System;
using System.IO;

namespace ConsoleFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos utilizar File e FileInfo
            //diferença:
            //File - classe estatica porém existe uma verificação de segurança o que torna mais demorada que FileInfo
            //FileInfo - deve ser instanciada e não tem a verificação de segurança.

            string sourcePath = @"d:\temp\file1.txt";
            string targetPath = @"d:\temp\file2.txt";
            try
            {

                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] arq = File.ReadAllLines(sourcePath);
                foreach (string line in arq)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);

            }



        }
    }
}
