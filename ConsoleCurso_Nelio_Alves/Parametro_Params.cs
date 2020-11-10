using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCurso_Nelio_Alves
{
    class Parametro_Params
    {
        /// <summary>
        /// aqui estamos utilizando o o recurso bem interessante de sobrecarga
        /// estamos usando um vetor como parametro
        /// estamos usando modificador params (torna a chamada desta função muito mais simples sem ter que instanciar vetor)
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns></returns>
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
    }
}
