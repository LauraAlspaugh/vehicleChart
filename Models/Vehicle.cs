namespace vehicleChart.Models;
public class Vehicle
{
    public int Id { get; set; }
    public string Make { get; set; }
    public bool DoesRun { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public Vehicle(int id, string make, bool doesRun, string color, string model)
    {
        Id = id;
        Make = make;
        DoesRun = doesRun;
        Color = color;
        Model = model;
    }
}