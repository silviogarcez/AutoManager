using AutoManager.Domain.Abstractions.Enums;
using AutoManager.Domain.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace AutoManager.Domain
{
    public class Cnh : ICnh, IEntityTypeConfiguration<Cnh>
    {
        [BsonId]
        [Required]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public string Number { get; set; }
        public List<CnhType> CnhType { get; set; }
        public string Image { get; set; }

        public void Configure(EntityTypeBuilder<Cnh> builder)
        {
            builder.HasIndex(e => e.Number).IsUnique();
        }
    }
}
