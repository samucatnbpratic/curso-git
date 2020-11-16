using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCurso.AbstratoContribuinte.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int Funcionario { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int funcionario) : base(nome, rendaAnual)
        {
            Funcionario = funcionario;
        }

        public override double Imposto()
        {
            double imp = 0.0;
            if (Funcionario > 10)
            {
                imp = (RendaAnual * 0.14);
            }
            else
                imp = (RendaAnual * 0.16);

            return imp;

        }
    }
}
