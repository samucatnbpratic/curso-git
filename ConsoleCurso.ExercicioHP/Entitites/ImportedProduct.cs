using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleCurso.ExercicioHP.Entitites
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee)
            :base(name, price)
        {
            CustomFee = customFee;
        }

        public sealed override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + 
                " (Customs fee: $ " + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
