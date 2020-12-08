using Microsoft.EntityFrameworkCore;
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

        public DbSet<SCM_Product> SCM_Products { set; get; }
        public DbSet<SCM_Order> SCM_Orders { set; get; }
        public DbSet<SCM_Calendar> SCM_Calendars { set; get; }
    }
}
