using AutoManager.Domain.Abstractions.Enums;
using AutoManager.Domain.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace AutoManager.Domain
{
    public class Rented : IRented, IEntityTypeConfiguration<Rented>
    {
        [BsonId]
        [Required]
        [BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; set; }

        [Required]
        public IUser User { get; set; }

        [Required]
        public IVehicle Vehicle { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public int Fee { get; set; }

        public bool AcceptOrder(long UserId)
        {
            throw new NotImplementedException();
        }

        public bool AdminRent(IVehicle vehicle, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<Rented> builder)
        {
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.User).IsRequired();
            builder.Property(b => b.Id).IsRequired();            
            builder.Property(b => b.Vehicle).IsRequired();
            builder.Property(b => b.Fee).IsRequired();
            builder.HasOne(e => e.User);
            builder.HasOne(e => e.Vehicle);
        }

        public int Delivery(long VehicleId)
        {
            throw new NotImplementedException();
        }

        public List<IUser> GetNotificationUsers()
        {
            throw new NotImplementedException();
        }

        public bool GetOrder(long UserId)
        {
            throw new NotImplementedException();
        }

        public bool IsRented(long VehicleId)
        {
            throw new NotImplementedException();
        }

        public bool Rent(IUser user, IVehicle vehicle, RentPlanType rentPlanType)
        {
            throw new NotImplementedException();
        }

        public bool Rent(IUser user, IVehicle vehicle, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
