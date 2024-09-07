using Geempe.Domain.Entities;
using Geempe.Infra.Context;
using Geempe.Infra.Interfaces;

namespace Geempe.Infra.Repository;

public class LoanRepository(AppDBContext context) : RepositoryBase<Loan>(context), ILoanRepository
{
}
