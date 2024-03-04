using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User> ,IEntityConfiguration

{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Family)
                  .HasMaxLength(30)
                  .IsRequired();
        builder.Property(x => x.Name)
           .HasMaxLength(30)
           .IsRequired();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.UserName).HasMaxLength(30).IsRequired();
    }
}
