using AutoManager.Api.Services.Abstractions.Interfaces;
using AutoManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AutoManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController(ILogger<Vehicle> logger, IVehicleService vehicleService) : ControllerBase
    {
        private readonly ILogger<Vehicle> logger = logger;
        private readonly IVehicleService vehicleService = vehicleService;

        [HttpGet(Name = "GetVehicle")]
        public IEnumerable<Vehicle> Get()
        {
            try
            {

            }
            catch (Exception ex)
            {
                logger.LogError("GetVehicle has an error: ", ex);
                throw ex;
            }
        }
    }
}
