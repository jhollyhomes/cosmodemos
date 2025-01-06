using Microsoft.AspNetCore.Http.HttpResults;
using Vehicles.Responses.Interfaces;

namespace Vehicles.Api.Extensions;

public static class ResponseExtensions
{
    public static IResult ProcessResponse<T>(this IResponse<T> response)
    {
        if (response.IsSuccess)
        {
            return Results.Ok(response.Data);
        }

        if (response.IsNotFound)
        {
            return Results.NotFound(response.Error);
        }

        if (response.IsValidationFailure)
        {
            return Results.BadRequest(response.Error);
        }

        return Results.InternalServerError(response.Error);
    }
}


