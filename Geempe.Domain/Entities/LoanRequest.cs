namespace Geempe.Domain.Entities
{
    public class LoanRequest : EntityBase
    {
        public int RequesterId { get; private set; }
        public User Requester { get; private set; }
        public decimal Amount { get; private set; }
        public string Reason { get; private set; }
        public decimal? InterestRate { get; private set; }
        public bool IsConfirmed { get; private set; }

        public LoanRequest(int requesterId, decimal amount, string reason)
        {
            RequesterId = requesterId;
            Amount = amount;
            Reason = reason;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
    }
}