
namespace ConsoleCurso.Heranca.Entities
{
    class BusinessAccount : Account
    {
        //limite para emprestimo
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanlimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        public bool Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
                Balance += amount;
                return true;
            }
            else
                return false;
        }
    }
}
