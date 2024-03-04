using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class OrderDetailConfiguration : IEntityConfiguration, IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.Order).WithMany(c => c.OrderDetail).HasForeignKey(p => p.OrderId);
            builder.HasOne(p => p.Product).WithMany(c => c.OrderDetail).HasForeignKey(p => p.ProductId);

        }
    }
}
