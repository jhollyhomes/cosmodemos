namespace Vehicles.Responses;

public interface IResponse<out T>
{
    bool IsSuccess { get; }
    bool IsNotFound { get; }
    bool IsExceptionFailure { get; }
    T? Data { get; }
    string Error { get; }
}

