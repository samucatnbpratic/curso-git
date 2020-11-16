using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCurso.AbstratoContribuinte.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            double imp = 0.0;
            if(RendaAnual < 20000.00)
            {
                imp = (RendaAnual * 0.15) - (GastoSaude * 0.5);
            }
            else
                imp = (RendaAnual * 0.25) - (GastoSaude * 0.5);

            return imp;
        }
    }
}
