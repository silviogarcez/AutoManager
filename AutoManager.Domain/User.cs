using AutoManager.Domain.Abstractions.Enums;
using AutoManager.Domain.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace AutoManager.Domain
{
    public class User : IUser , IEntityTypeConfiguration<User>
    {
        [BsonId]        
        [Required]
        [BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Cnpj { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Required]
        public ICnh Cnh { get; set; }

        [Required]
        public UserType UserType { get; set; }

        public bool CanRent { get; set; } = true;

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(b => b.Id).IsUnique();
            builder.Property(b => b.Id).IsRequired();
            builder.HasIndex(e => e.Cnpj).IsUnique();
            builder.Property(b => b.Cnpj).IsRequired();
            builder.Property(b => b.Name).IsRequired();
            builder.HasOne(e => e.Cnh);
        }

        public IUser Get(string Name)
        {
            throw new NotImplementedException();
        }

        public IUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ICnh cnh)
        {
            throw new NotImplementedException();
        }
    }
}