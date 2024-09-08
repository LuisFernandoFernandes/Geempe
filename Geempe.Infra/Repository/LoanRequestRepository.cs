using Geempe.Domain.Entities;
using Geempe.Infra.Context;
using Geempe.Infra.Interfaces;

namespace Geempe.Infra.Repository;

public class LoanRequestRepository(AppDBContext context) : RepositoryBase<LoanRequest>(context), ILoanRequestRepository
{
}