using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGenericParte2
{
    class CalculationService
    {
        //a implementação da interface IComparable é necessária para podermos comparar os valores da lista de forma generica.
        public T Max<T>(List<T> list) where T  : IComparable
        {
            if(list.Count == 0)
            {
                throw new InvalidOperationException("List can not be empty");
            }
            T valor = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if(list[i].CompareTo(valor) > 0)
                {
                    valor = list[i];
                }
            }
            return valor;
        }
    }
}
