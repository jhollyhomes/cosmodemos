namespace Vehicles.Responses.Interfaces;

public interface IResponse<out T>
{
    bool IsSuccess { get; }
    bool IsNotFound { get; }
    bool IsExceptionFailure { get; }
    bool IsValidationFailure { get; }
    T? Data { get; }
    string Error { get; }
}

