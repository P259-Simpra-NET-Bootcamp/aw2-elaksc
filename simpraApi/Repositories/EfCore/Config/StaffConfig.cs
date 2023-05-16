using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config;
public class StaffConfig : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.ToTable("Staff");

        builder.HasKey(s => s.Id);

        builder.HasIndex(s => s.Email)
            .IsUnique();

        builder.Property(s => s.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(s => s.DateOfBirth)
            .IsRequired();

        builder.Property(s => s.AddressLine1)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.City)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Country)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Province)
            .IsRequired()
            .HasMaxLength(50);

        builder.Ignore(s => s.FullName);
    }
}
