
using ConsoleExtensionMethods;

namespace System
{
    static class StringExtension
    {
        /// <summary>
        /// Metodo Extensão para retornar valor formatado, com a quantidade de casas decimais desejada
        /// </summary>
        /// <param name="thisObj"></param>
        /// <param name="casaDecimal">quantidade de casas decimais que deseja formatar</param>
        /// <returns></returns>
        public static string ValorFormatado(this decimal thisObj, int casaDecimal)
        {
            return thisObj.ToString($"F{casaDecimal}", SuperClass.CultureInfoSis);
        }


    }
}
