
using ConsoleCurso.Heranca.Entities;
using System;
using System.Globalization;

namespace ConsoleCurso.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            string acao = "CAST";
            if (acao == "CAST")
                UpCasting_DownCasting();
            else
                Heranca();



        }


        private static void UpCasting_DownCasting()
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            //UPCASTING
            //a herança é uma relação 'É UM', então compilador aceita numa boa essa atribuição
            //SuperClasse: Account   ;    SubClasse: BusinessAccount, SavingsAccount;
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            //como acc2 é do tipo BusinessAccount então essa conversão é possível.
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //ATENÇÃO !!! embora o compilador não de erro, ocorrerá um erro em tempo de execução.
            //acc3 é do tipo SavingsAccount 
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            //vamos então testar antes de fazer a conversão (verificamos se acc3 é uma instancia de BusinessAccount)
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");

            }
            //se acc3 for uma instancia de SavingsAccount entra aqui
            if (acc3 is SavingsAccount)
            {
                //aqui fazemos o DOWNCASTING para SavingsAccount
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("UPDATE!");

                //outra forma de fazer o cast
                SavingsAccount acc6 = acc3 as SavingsAccount;
                acc6.UpdateBalance();
                Console.WriteLine("UPDATE!");

            }

        }

        private static void Heranca()
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine("Saldo $" + account.Balance);

            Console.Write("Digite o Valor do Empréstimo: ");
            double valorEmp = double.Parse(Console.ReadLine());
            bool result = account.Loan(valorEmp);
            if (result)
            {
                Console.WriteLine("Empréstimo feito com sucesso !");
            }
            else
            {
                Console.WriteLine("Valor de Empréstimo não permitido para esta conta !");
                Console.WriteLine("Valor máximo permitido: $" + account.LoanLimit);
            }
            Console.WriteLine("Saldo atual: $" + account.Balance);

        }

    }
}
