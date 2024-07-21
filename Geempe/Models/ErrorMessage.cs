namespace Geempe.Api.Models
{
    public class ErrorMessage
    {
        public ErrorMessage(List<string> errors)
        {
            errorMessage = errors;
        }
        public List<string> errorMessage { get; private set; }
    }
}
