using Geempe.Api.Models;

namespace Geempe.Api.Extensions;

public static class ErrorExtension
{
    public static ErrorMessage ConvertToError(this string message)
    {
        return new ErrorMessage(new List<string>(new string[] { message }));
    }
}
