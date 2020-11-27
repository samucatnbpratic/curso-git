using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleContrato.Services
{
    interface IPagamento
    {
        double TaxaPagamento(double valor);
        double CalculoParcela(double valorBase, int mes);
    }
}
