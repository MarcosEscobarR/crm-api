using Core.Helpers.Result;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Helpers;

public static class ToActionResultExtension
{
    public static IActionResult ToActionResult(this Result result)
        => result.IsSuccessful
            ? result.Data is null ? new OkResult() : new ObjectResult(result.Data)
            : new NotFoundResult();

    public static IActionResult ToCreatedResult(this Result result)
        => new StatusCodeResult(201);
}