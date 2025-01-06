namespace Vehicles.Contracts;

public class CreateVehicleRequest(string colour, string model, string make, string vrm)
{
    public string Vrm { get; set; } = vrm;
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public string Colour { get; set; } = colour;
}

