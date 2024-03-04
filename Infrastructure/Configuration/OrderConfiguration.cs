using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>, IEntityConfiguration
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        //builder.Property(x => x.Id).HasDefaultValueSql("NEXT VALUE FOR SeqOrder");
        builder.HasKey(x => x.Id);
        builder.HasOne(p => p.Customer).WithMany(c => c.Order).HasForeignKey(p => p.CustomerId);
    }
}
