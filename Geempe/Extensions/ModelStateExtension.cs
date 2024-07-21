using Geempe.Api.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Geempe.Api.Extensions;

public static class ModelStateExtension
{
    public static ErrorMessage ReturnErrorMessages(this ModelStateDictionary modelstate)
    {
        return new ErrorMessage(modelstate
            .SelectMany(ms => ms.Value!.Errors)
            .Select(e => e.ErrorMessage)
            .ToList());
    }
}
