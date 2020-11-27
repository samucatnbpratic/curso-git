using System;
using System.Collections.Generic;
using ConsoleContrato.Services;

namespace ConsoleContrato.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorContrato { get; set; }
        public int QtdeParcela { get; set; }

        public List<Parcela> listaParcelas;

        public Contrato(int numero, DateTime data, double valorContrato, int qtdeParcela)
        {
            Numero = numero;
            Data = data;
            ValorContrato = valorContrato;
            QtdeParcela = qtdeParcela;
            listaParcelas = new List<Parcela>();
        }

        public void AddParcela(Parcela parcela)
        {
            listaParcelas.Add(parcela);
        }

    }
}
