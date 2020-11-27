using System;
using System.Globalization;
using ConsoleContrato.Entities;
using ConsoleContrato.Services;

namespace ConsoleContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Nummero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Numero de Parcelas: ");
            int nParcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valorContrato, nParcelas);
            ContratoServico contratoServico = new ContratoServico(new ServicoPaypal());
            contratoServico.ProcessarContrato(contrato);

            Console.WriteLine("Parcelas: ");
            foreach (Parcela item in contrato.listaParcelas)
            {
                Console.WriteLine(item);
            }

        }
    }
}
