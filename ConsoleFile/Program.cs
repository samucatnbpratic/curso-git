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

            // PrimeiroExemplo();

            SegundoExemplo();

            TerceiroExemplo();

            QuartoExemplo(); //vamos usar o StreamWrite

        }

        private static void QuartoExemplo()
        {
            string sourcePath = @"d:\temp\file1.txt";
            string targetPath = @"d:\temp\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);

            }
        }

        private static void TerceiroExemplo()
        {
            string sourcePath = @"d:\temp\file1.txt";
            try
            {

                using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);

                        }

                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);

            }
        }

        private static void SegundoExemplo()
        {
            string sourcePath = @"d:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(sourcePath, FileMode.Open);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }

        private static void PrimeiroExemplo()
        {
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
