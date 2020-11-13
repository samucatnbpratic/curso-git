using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCurso.ExercicioAbstract.Entities
{
    //SEALED - uma classe selada não pode ser herdada
    sealed class SavingsAccountPlus : SavingsAccount
    {
        //override Withdraw - NAO é possivel pois o metodo esta selado.
    }

    //ex: aqui ocorre um erro pois a classe acima está selada, vamos comentar a linha abaixo
    //class SavingsAccountPlusMais: SavingsAccountPlus


}
