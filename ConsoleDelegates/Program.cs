using System;
using ConsoleDelegates.Services;

namespace ConsoleDelegates
{
    class Program
    {
        //declaração de um delegate 
        //ele será referencia para uma função que recebe dois numeros double e retorna um double
        delegate double BinaryNumericOperation(double n1, double n2);

        //neste delegate vamos referenciar mais de um metodo
        //obs: neste caso não faz sentido retornar valores, o interessante é usar metodos void
        delegate void MultiFuncs(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op;
            

            double result = 0;
            result = CalculationService.Sum(a, b);
            Console.WriteLine("SUM: " + result);
            //usando o delegate, ele é uma referencia para função
            op = CalculationService.Sum;
            Console.WriteLine("DELEGATE SUM: " + op(a, b));
            //sintaxe alternativa
            Console.WriteLine("DELEGATE (INVOKE) SUM: " + op.Invoke(a, b));

            result = CalculationService.Max(a, b);
            Console.WriteLine("MAX: " + result);
            //usando o delegate, ele é uma referencia para função
            op = CalculationService.Max;
            Console.WriteLine("DELEGATE MAX: " + op(a, b));

            result = CalculationService.Square(a);
            Console.WriteLine("SQUARE: " + result);
            //OBS: aqui não podemos usar o delegate porque numero de parametros da função Square é diferente.

            Console.WriteLine("\n\nDELEGATE MULTI METODOS\nOBSERVE QUE ELE EXECUTA E MOSTRA RESULTADO\n");
            //referenciando nosso delegate a dois metodos
            MultiFuncs mf = CalculationService.ShowSum;
            mf += CalculationService.ShowMax;
            mf(a, b);


        }
    }
}
