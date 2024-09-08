namespace Geempe.Domain.Entities;

public class LoanRequest : EntityBase
{
    public int RequesterId { get; private set; }
    public User? Requester { get; private set; }
    public decimal Amount { get; private set; }
    public string Reason { get; private set; }
    public decimal? InterestRate { get; private set; }
    public bool IsConfirmed { get; private set; }
    public string PixKey { get; private set; }
    public DateTime DueDate { get; private set; }
    public decimal PenaltyRate { get; private set; }
    public List<Payment> Payments { get; private set; }

    public LoanRequest(int requesterId, decimal amount, string reason, string pixKey, DateTime dueDate, decimal penaltyRate)
    {
        RequesterId = requesterId;
        Amount = amount;
        Reason = reason;
        PixKey = pixKey;
        DueDate = dueDate;
        PenaltyRate = penaltyRate;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        IsActive = true;
        Payments = new List<Payment>();
    }
}
