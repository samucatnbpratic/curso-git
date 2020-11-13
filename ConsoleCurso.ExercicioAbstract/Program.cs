using ConsoleCurso.ExercicioAbstract.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleCurso.ExercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //utilizando um exemplo com a classe abstract
            List<Account> list = new List<Account>();

            list.Add(new BusinessAccount(1001, "João", 500, 100));
            list.Add(new SavingsAccount(1001, "Maria", 500, 0.10));
            list.Add(new BusinessAccount(1001, "Ricardo", 500, 500));
            list.Add(new SavingsAccount(1001, "Terebentina", 500, 0.10));

            foreach (Account item in list)
            {
                item.Withdraw(100.0);
                if (item is SavingsAccount)
                {
                    SavingsAccount s = (SavingsAccount)item;
                    s.UpdateBalance();
                }
                
            }

            foreach (Account item in list)
            {

                Console.WriteLine(item.Balance);
            }

        }
    }
}
