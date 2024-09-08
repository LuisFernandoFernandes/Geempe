using Geempe.Domain.Entities;
using Geempe.Infra.Context;
using Geempe.Infra.Interfaces;

namespace Geempe.Infra.Repository;

public class PaymentRepository(AppDBContext context) : RepositoryBase<Payment>(context), IPaymentRepository
{
}
