using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.services
{
    public interface ILoanService
    {
        void AddLoan(Loan loan);
    }
}
