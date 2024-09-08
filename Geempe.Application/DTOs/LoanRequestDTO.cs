namespace Geempe.Application.DTOs;

public class LoanRequestDTO
{
    public int Id { get; set; }
    public int RequesterId { get; set; }
    public decimal Amount { get; set; }
    public string Reason { get; set; }
    public decimal? InterestRate { get; set; }
    public bool IsConfirmed { get; set; }
    public string PixKey { get; set; }
    public DateTime DueDate { get; set; }
    public decimal PenaltyRate { get; set; }
    public List<PaymentDTO> Payments { get; set; }
}
