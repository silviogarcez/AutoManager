using AutoManager.Domain.Abstractions.Enums;

namespace AutoManager.Domain.Abstractions.Interfaces
{
    public interface IRented
    {
        public long Id { get; set; }
        public IUser User { get; set; }
        public IVehicle Vehicle { get; set; }
        public DateTime CreationDate { get; set; }
        public int Fee { get; set; }        

        public bool IsRented(long VehicleId);

        public bool Rent(IUser user, IVehicle vehicle, RentPlanType rentPlanType);

        public bool Rent(IUser user, IVehicle vehicle, DateTime startDate, DateTime endDate);

        public bool AdminRent(IVehicle vehicle, DateTime startDate, DateTime endDate);

        public List<IUser> GetNotificationUsers();

        public bool GetOrder(long UserId);

        public bool AcceptOrder(long UserId);

        public int Delivery(long VehicleId);
    }
}
