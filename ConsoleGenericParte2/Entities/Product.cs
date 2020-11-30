using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleGenericParte2.Entities
{
    class Product : IComparable
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Product(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing  error: is not a Product");
            }

            Product other = obj as Product;
            return Valor.CompareTo(other.Valor);
        }
    }
}
