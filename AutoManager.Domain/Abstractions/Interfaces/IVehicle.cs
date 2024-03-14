using AutoManager.Domain.Abstractions.Enums;

namespace AutoManager.Domain.Abstractions.Interfaces
{
    public interface IVehicle
    {
        public long Id { get; set; }
        
        public IModel Model { get; set; }

        public int Year { get; set; }

        public string? RegistrationPlate { get; set; }

        public VehicleType VehicleType { get; set; }

        public bool Disponible { get; set; }

        public IVehicle Insert(IVehicle vehicle);

        public IVehicle Get(string RegistrationPlate);

        public IVehicle Update(long Id, string RegistrationPlate);

        public IVehicle Delete(long Id);
    }
}
