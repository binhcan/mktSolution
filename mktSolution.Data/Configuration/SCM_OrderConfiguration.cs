using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mktSolution.Data.Entities;
using mktSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Configuration
{
    public class SCM_OrderConfiguration : IEntityTypeConfiguration<SCM_Order>
    {
        public void Configure(EntityTypeBuilder<SCM_Order> builder)
        {
            builder.ToTable("SCM_Orders");
            builder.HasKey(x => x.IdOrder);
            builder.Property(x => x.IdOrder).UseIdentityColumn();
            builder.Property(x => x.ModelName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Qty).IsRequired();
            builder.Property(x => x.Type).HasDefaultValue("Order");
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);

            //builder.HasOne(x => x.AppUser).WithMany(x => x.SCM_Orders).HasForeignKey(x => x.UserId);
        }
    }
}
