using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mktSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Configuration
{
    public class SCM_CalendarConfiguration : IEntityTypeConfiguration<SCM_Calendar>
    {
        public void Configure(EntityTypeBuilder<SCM_Calendar> builder)
        {
            builder.ToTable("SCM_Calendar");
            builder.HasKey(x => x.IdCalendar);
        }
    }
}
