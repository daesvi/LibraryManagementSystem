using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;

        public LoanService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public void AddLoan(Loan loan)
        {
            _loanRepository.Add(loan);
        }
    }
}
