using ConsoleVeiculo.Entities;
using System;

namespace ConsoleVeiculo.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //aqui primeiro exemplo ficava muito acoplado
        // private BrazilTaxService brazilTaxService = new BrazilTaxService();

        //vamos atraves da interface criar a inversão de controle por meio de injeção de dependencia
        private ITaxService taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            this.taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
