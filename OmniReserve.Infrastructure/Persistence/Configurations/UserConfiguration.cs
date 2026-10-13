using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmniReserve.Domain.Entities;
using OmniReserve.Domain.ValueObjects;

namespace OmniReserve.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.FirstName)
            .IsRequired()
            .HasMaxLength(75);

        builder.Property(u => u.LastName)
            .IsRequired()
            .HasMaxLength(75);
        
                // Value Conversion: El puente entre el Dominio complejo y la BD simple
        builder.Property(user => user.Email)
               .HasConversion(
                   emailObj => emailObj.Value, // Cómo grabar (C# a SQL)
                   emailStr => new EmailAddress(emailStr) // Cómo leer (SQL a C#)
               )
               .HasColumnName("Email") // Fuerza el nombre de la columna en la BD
               .HasMaxLength(255)
               .IsRequired();
    }
}
