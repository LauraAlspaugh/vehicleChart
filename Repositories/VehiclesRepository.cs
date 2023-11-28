



namespace vehicleChart.Repositories;
public class VehiclesRepository
{
    private List<Vehicle> _vehicles;
    public VehiclesRepository()
    {
        _vehicles = [
new Vehicle(1, "Mazda", true, "black", "Miata" ),
new Vehicle(2, "Honda", true, "gray", "Civic"),
new Vehicle(3, "Tesla", true, "white", "XE"),
new Vehicle(4, "Genesis", true, "white", "suv")
        ];
    }

    internal Vehicle CreateVehicle(Vehicle vehicleData)
    {
        Vehicle lastVehicle = _vehicles[_vehicles.Count - 1];
        if (lastVehicle == null)
        { vehicleData.Id = 1; }
        else
        {
            vehicleData.Id = lastVehicle.Id + 1;
        }
        _vehicles.Add(vehicleData);
        return vehicleData;
    }

    internal void DestroyVehicle(Vehicle vehicle)
    {
        _vehicles.Remove(vehicle);
    }

    internal Vehicle GetVehicleById(int vehicleId)
    {
        Vehicle foundVehicle = _vehicles.Find(vehicle => vehicle.Id == vehicleId);
        return foundVehicle;
    }

    internal List<Vehicle> GetVehicles()
    {
        return _vehicles;
    }
}