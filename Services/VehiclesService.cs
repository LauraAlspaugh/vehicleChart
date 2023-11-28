



namespace vehicleChart.Services;
public class VehiclesService
{
    private readonly VehiclesRepository _vehiclesRepository;
    public VehiclesService(VehiclesRepository vehiclesRepository)
    {
        _vehiclesRepository = vehiclesRepository;
    }

    internal Vehicle CreateVehicle(Vehicle vehicleData)
    {
        Vehicle vehicle = _vehiclesRepository.CreateVehicle(vehicleData);
        return vehicle;
    }

    internal string DestroyVehicle(int vehicleId)
    {
        Vehicle vehicle = GetVehicleById(vehicleId);
        _vehiclesRepository.DestroyVehicle(vehicle);
        return "this vehicle has been taken off the lot!";
    }

    internal Vehicle GetVehicleById(int vehicleId)
    {
        Vehicle vehicle = _vehiclesRepository.GetVehicleById(vehicleId);
        return vehicle;
    }

    internal List<Vehicle> GetVehicles()
    {
        List<Vehicle> vehicles = _vehiclesRepository.GetVehicles();
        return vehicles;
    }
}