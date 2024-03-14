using AutoManager.Domain.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace AutoManager.Domain
{
    public class Model : IModel, IEntityTypeConfiguration<Model>
    {
        [BsonId]
        [Required]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public string Name { get; set; }

        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasIndex(b => b.Id).IsUnique();
            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.Name).IsRequired();
        }
    }
}
