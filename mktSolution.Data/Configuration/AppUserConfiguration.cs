using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mktSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Configuration
{
    class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.Ecode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Dept).HasMaxLength(20).IsRequired();

        }
    }
}
