using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleIComparable.Entities
{
    class Funcionario: IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vect = csvFuncionario.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new ArgumentException("Erro comparando: objeto não é do tipo funcionario");
            }
            Funcionario f = obj as Funcionario;
            return Salario.CompareTo(f.Salario);


        }
    }
}
