using Microsoft.EntityFrameworkCore;
using mktSolution.Data.Configuration;
using mktSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.EF
{
    public class MktDbContext : DbContext
    {
        public MktDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SCM_OrderConfiguration());
            modelBuilder.ApplyConfiguration(new SCM_ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SCM_CalendarConfiguration());

            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<SCM_Product> SCM_Products { set; get; }
        public DbSet<SCM_Order> SCM_Orders { set; get; }
        public DbSet<SCM_Calendar> SCM_Calendars { set; get; }
    }
}
