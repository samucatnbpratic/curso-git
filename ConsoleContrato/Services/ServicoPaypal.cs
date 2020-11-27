using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleContrato.Services
{
    class ServicoPaypal : IPagamento
    {
        private const double TaxaPercentual = 0.02;
        private const double JurosSimples = 0.01;

        public double CalculoParcela(double valorBase, int mes)
        {
            return valorBase * JurosSimples * mes;
        }

        public double TaxaPagamento(double valor)
        {
            return valor * TaxaPercentual;
        }
    }
}
