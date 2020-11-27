using System;
using System.Collections.Generic;
using System.Text;
using ConsoleContrato.Entities;

namespace ConsoleContrato.Services
{
    class ContratoServico
    {
        private IPagamento pagamentoServico;

        public ContratoServico(IPagamento pagamentoServico)
        {
            this.pagamentoServico = pagamentoServico;
        }

        public void ProcessarContrato(Contrato contrato)
        {
            double valorBase = contrato.ValorContrato / contrato.QtdeParcela;
            for (int i = 1; i <= contrato.QtdeParcela; i++)
            {
                DateTime dataVenc = contrato.Data.AddMonths(i);
                double taxaParcela = valorBase + pagamentoServico.CalculoParcela(valorBase, i);
                double valorParcela = taxaParcela + pagamentoServico.TaxaPagamento(taxaParcela);
                contrato.AddParcela(new Parcela(dataVenc, valorParcela));
            }
        }
    }
}
