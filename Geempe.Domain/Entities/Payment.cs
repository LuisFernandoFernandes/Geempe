namespace Geempe.Domain.Entities;

public class Payment : EntityBase
{
    public decimal Amount { get; private set; }
    public DateTime PaymentDate { get; private set; }

    public Payment(decimal amount, DateTime? paymentDate)
    {
        Amount = amount;
        PaymentDate = paymentDate ?? DateTime.Now;
    }
}
