using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGenericParte1
{
    class PrintService
    {
        //NÃO TEM type safety - não é a solução ideal. (não se deve usar o object)
        //compilador não pega erros ocorrendo somente em tempo de execução
        private object[] values = new object[10];
        private int count = 0;

        public void AddValue(object value)
        {
            if (count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            values[count] = value;
            count++;
        }

        public object First()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Value is null");
            }
            return values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count -1; i++)
            {
                Console.Write(values[i] + ", ");
            }
            if (count > 0)
            {
                Console.Write(values[count - 1]);

            }
            Console.WriteLine("]");
        }
    }
}
