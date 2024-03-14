using AutoManager.Domain.Abstractions.Enums;
using AutoManager.Domain.Abstractions.Interfaces;

namespace AutoManager.Domain.Abstractions
{
    public class Vehicle : IVehicle
    {
        public long Id { get; set; }
        public IModel Model { get; set; }
        public int Year { get; set; }        
        public string? RegistrationPlate { get; set; }
        public VehicleType VehicleType { get; set; }

        public IVehicle Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public IVehicle Get(string RegistrationPlate)
        {
            throw new NotImplementedException();
        }

        public IVehicle Insert(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public IVehicle Update(long Id, string RegistrationPlate)
        {
            throw new NotImplementedException();
        }
    }
}
