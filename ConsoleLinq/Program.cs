using System;
using System.Linq;

namespace ConsoleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //especifica nossa fonte de dados (de onde pegaremos as informações)
            int[] numbers = new int[] { 2,3,4,5 };

            //defini a expressão query (neste exmplo selecionamos os numeros pares e multiplicamos por 10) 
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //executando a query (o Linq usa a execução Lazy (tardia) então a query acima só é executada no momento em que precisamos dela)
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}
