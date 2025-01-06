namespace Vehicles.Api.Extensions;

public static class EnvironmentExtensions
{
    public static bool IsTesting(this IHostEnvironment hostingEnvironment)
    {
        if (hostingEnvironment.IsEnvironment(Constants.Environment.TestingEnvironment))
        {
            return true;
        }

        return false;
    }
}