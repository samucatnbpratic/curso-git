using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCurso.Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }

        //titular da conta
        public string Holder { get; private set; }

        //saldo da conta protected permite que a subclasse altere está propriedade, mas não outras classes
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
