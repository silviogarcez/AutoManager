using AutoManager.Domain.Abstractions.Enums;
using AutoManager.Domain.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace AutoManager.Domain
{
    public class Vehicle : IVehicle, IEntityTypeConfiguration<Vehicle>
    {
        [BsonId]
        [Required]
        [BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; set; }
        
        public int Year { get; set; }
        
        public string? RegistrationPlate { get; set; }

        public VehicleType VehicleType { get; set; }
        
        public IModel Model { get; set; }

        public bool Disponible { get; set; }

        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasIndex(e => e.RegistrationPlate).IsUnique();
            builder.Property(e => e.RegistrationPlate).IsRequired();
            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.Model).IsRequired();
            builder.Property(b => b.Year).IsRequired();
            builder.HasOne(e => e.Model);            
        }

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

