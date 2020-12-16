using System;
using System.Globalization;

namespace ConsoleExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //estou utilizando para mostrar como podemos definir a cultura para depois ser usado em todo sistema.
            SuperClass.CultureInfoSis = CultureInfo.GetCultureInfo("pt-BR");
            DateTime data = new DateTime(2020, 12, 13, 23, 00, 00);

            Console.WriteLine(data.TempoDecorrido());
            string s1 = "1.520,23";
            decimal valor = 23.156M;
            Console.WriteLine(valor.ValorFormatado(0));
            Console.WriteLine(valor.ValorFormatado(2));
            Console.WriteLine(valor.ValorFormatado(3));
            Console.WriteLine(valor.ValorFormatado(4));

            valor = decimal.Parse(s1);
            Console.WriteLine(valor.ValorFormatado(0));
            Console.WriteLine(valor.ValorFormatado(2));
            Console.WriteLine(valor.ValorFormatado(3));
            Console.WriteLine(valor.ValorFormatado(4));
        }
    }
}
