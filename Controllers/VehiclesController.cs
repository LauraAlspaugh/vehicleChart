using System.Net.Http;

namespace vehicleChart.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    private readonly VehiclesService _vehiclesService;
    public VehiclesController(VehiclesService vehiclesService)
    {
        _vehiclesService = vehiclesService;
    }
    [HttpGet]
    public ActionResult<List<Vehicle>> GetVehicles()
    {
        try
        {
            List<Vehicle> vehicles = _vehiclesService.GetVehicles();
            return Ok(vehicles);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpGet("{vehicleId}")]
    public ActionResult<Vehicle> GetVehicleById(int vehicleId)
    {
        try
        {
            Vehicle vehicle = _vehiclesService.GetVehicleById(vehicleId);
            return Ok(vehicle);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpPost]
    public ActionResult<Vehicle> CreateVehicle([FromBody] Vehicle vehicleData)
    {
        try
        {
            Vehicle vehicle = _vehiclesService.CreateVehicle(vehicleData);
            return Ok(vehicle);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpDelete("{vehicleId}")]
    public ActionResult<string> DestroyVehicle(int vehicleId)
    {
        try
        {
            string message = _vehiclesService.DestroyVehicle(vehicleId);
            return Ok(message);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
    [HttpPut("{vehicleId}")]
    public ActionResult<Vehicle> EditVehicle(int vehicleId, [FromBody] Vehicle vehicleData)
    {
        try
        {
            Vehicle vehicle = _vehiclesService.EditVehicle(vehicleData, vehicleId);
            return Ok(vehicle);
        }
        catch (Exception error)
        {

            return BadRequest(error.Message);
        }
    }
}