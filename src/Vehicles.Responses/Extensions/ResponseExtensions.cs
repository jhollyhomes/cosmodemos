using Vehicles.Responses.Interfaces;

namespace Vehicles.Responses.Extensions;

public static class ResponseExtensions
{
    public static IResponse<TOut> ReturnFailedResponse<T, TOut>(this IResponse<T> response)
    {
        if (response.IsNotFound)
        {
            return new NotFoundResponse<TOut>(response.Error);
        }

        return new ExceptionResponse<TOut>(response.Error);
    }
}