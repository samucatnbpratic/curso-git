using System;

namespace ConsoleParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TimeSpan t1 = new TimeSpan(1, 30, 10);

            //aqui fizemos a multiplicação por 2.0 como utilizamos um double, fizemos o cast para poder dar certo.
            TimeSpan mult = TimeSpan.FromTicks( ((long)((double)t1.Ticks * 2.0)));
            Console.WriteLine(t1);
            Console.WriteLine(mult);
            Console.ReadLine();
        }
    }
}
