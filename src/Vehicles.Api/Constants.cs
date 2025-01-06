namespace Vehicles.Api;
internal static class Constants
{
    internal static class ApiResources
    {
        private const string BasePath = "/api";
        public const string Health = "/health";
        public const string Vehicles = BasePath + "/vehicle";
    }

    internal static class Environment
    {
        public const string TestingEnvironment = "Testing";
    }
}

