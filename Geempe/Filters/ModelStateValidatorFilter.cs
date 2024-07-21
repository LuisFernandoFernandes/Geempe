using Geempe.Api.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Geempe.Api.Filters;

public class ModelStateValidatorFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {

    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var erros = context.ModelState.ReturnErrorMessages();
            context.Result = new BadRequestObjectResult(erros);
        }
    }
}
