namespace Vehicles.Contracts;

public class CreateVehicleResponse(string uid, string vrm, string make, string model, string colour)
{
    public string Uid { get; set; } = uid;
    public string Vrm { get; set; } = vrm;
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;
    public string Colour { get; set; } = colour;
}

