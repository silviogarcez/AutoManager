using AutoManager.Domain.Abstractions.Interfaces;

namespace AutoManager.Api.Services.Abstractions.Interfaces
{
    public interface IVehicleService
    {
        public IEnumerable<IVehicle> Get();
        public IVehicle Get(string RegistrationPlate);
    }
}
