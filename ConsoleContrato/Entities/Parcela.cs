using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleContrato.Entities
{
    class Parcela
    {
        public DateTime DataVencimento { get; set; }
        public double ValorParcela { get; set; }

        public Parcela(DateTime dataVencimento, double valorParcela)
        {
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + ValorParcela.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
