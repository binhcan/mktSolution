using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mktSolution.Data.Entities;
using mktSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Configuration
{
    public class SCM_ProductConfiguration : IEntityTypeConfiguration<SCM_Product>
    {
        public void Configure(EntityTypeBuilder<SCM_Product> builder)
        {
            builder.ToTable("SCM_Products");

            //One Order to many Product
            builder.HasKey(x => new { x.IdOrder, x.IdProduct });
            builder.HasOne(x => x.SCM_Order).WithMany(x => x.SCM_Product).HasForeignKey(x => x.IdOrder);

            builder.Property(x => x.ModelName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Qty).IsRequired();
            builder.Property(x => x.Type).HasDefaultValue("Plan");
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);

           
        }
    }
}
