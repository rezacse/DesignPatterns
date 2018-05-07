using System;

namespace Facade.SubSystem
{
    public class LoanEligibilityChecker
    {
        private readonly Bank _bank;
        private readonly Loan _loan;
        private readonly Credit _credit;


        //TODO add dependency inversion
        public LoanEligibilityChecker()
        {
            _bank = new Bank();
            _loan = new Loan();
            _credit = new Credit();
        }

        public bool IsEligibleForLoan(Student student, double amount)
        {
            Console.WriteLine($"{student.Name} applies for {amount} loan\n");


            if (!_bank.HasSufficientSavings(student, amount))
                return false;

            if (!_loan.HasNoBadLoans(student))
                return false;

            if (!_credit.HasGoodCredits(student))
                return false;

            return true;
        }
    }
}
