using AutoManager.Api.Repository.Abstraction.Interfaces;
using AutoManager.Api.Services.Abstractions.Interfaces;
using AutoManager.Domain.Abstractions.Interfaces;

namespace AutoManager.Api.Services
{
    public class VehicleService(IVehicleRepository vehicleRepository) : IVehicleService
    {
        private readonly IVehicleRepository vehicleRepository = vehicleRepository;

        public IEnumerable<IVehicle> Get()
        {
            throw new NotImplementedException();
        }

        public IVehicle Get(string RegistrationPlate)
        {
            throw new NotImplementedException();
        }
    }
}
