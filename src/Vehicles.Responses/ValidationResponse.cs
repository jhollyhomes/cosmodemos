using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Responses.Interfaces;

namespace Vehicles.Responses;

public class ValidationResponse<T> : IResponse<T>
{
    public ValidationResponse(string message)
    { 
        Error = message;
        IsValidationFailure = true;
    }

    public bool IsSuccess { get; } = false;
    public bool IsNotFound { get; } = false;
    public bool IsExceptionFailure { get; } = false;
    public bool IsValidationFailure { get; }
    public T? Data { get; } = default!;
    public string Error { get; }
}
