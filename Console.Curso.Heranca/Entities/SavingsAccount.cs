using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCurso.Heranca.Entities
{
    //conta poupança
    class SavingsAccount: Account
    {

        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            :base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //aqui pra exemplo estamos usando sealed -  para selar o metodo e não permtir que ele seja sobreposto
        // selar é necessario para segurança e performace.
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
