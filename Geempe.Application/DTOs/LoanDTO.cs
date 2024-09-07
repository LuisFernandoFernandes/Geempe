namespace Geempe.Application.DTOs
{
    public class LoanDTO
    {
        public int Id { get; set; }
        public int LenderId { get; set; }
        public int BorrowerId { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
