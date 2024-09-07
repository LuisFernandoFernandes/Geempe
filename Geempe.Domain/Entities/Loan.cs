namespace Geempe.Domain.Entities;

public class Loan : EntityBase
{
    public int LenderId { get; private set; }
    public User? Lender { get; private set; }
    public int BorrowerId { get; private set; }
    public User? Borrower { get; private set; }
    public decimal Amount { get; private set; }
    public decimal InterestRate { get; private set; }
    public DateTime DueDate { get; private set; }
    public decimal OutstandingAmount { get; private set; }

    public Loan(int lenderId, int borrowerId, decimal amount, decimal interestRate, DateTime dueDate)
    {
        LenderId = lenderId;
        BorrowerId = borrowerId;
        Amount = amount;
        InterestRate = interestRate;
        DueDate = dueDate;
        OutstandingAmount = amount;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        IsActive = true;
    }
}


