using System;
using System.IO;

namespace ConsolePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\temp\file1.txt";
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

        }
    }
}
