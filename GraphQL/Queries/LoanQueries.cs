using AndisbankAPI_GraphQL.Controllers;
using AndisbankAPI_GraphQL.GraphQL.Types;
using AndisbankAPI_GraphQL.Models;
using AndisbankAPI_GraphQL.Repositories;

namespace AndisbankAPI_GraphQL.GraphQL.SchemaGraph
{
    public class LoanQueries: Schema
    {
        private readonly LoanRepository _loanRepository;
        public LoanQueries(LoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }
        public IEnumerable<Loan> GetAllLoans(int id)
        {
            var loans = _loanRepository.GetAllLoans(id);
            
            return loans;
        }
    }
}
