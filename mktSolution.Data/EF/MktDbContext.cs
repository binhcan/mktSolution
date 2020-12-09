using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mktSolution.Data.Configuration;
using mktSolution.Data.Entities;
using mktSolution.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.EF
{
    public class MktDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public MktDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure using Fluent API
            modelBuilder.ApplyConfiguration(new SCM_OrderConfiguration());
            modelBuilder.ApplyConfiguration(new SCM_ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SCM_CalendarConfiguration());

            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();

            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<SCM_Product> SCM_Products { set; get; }
        public DbSet<SCM_Order> SCM_Orders { set; get; }
        public DbSet<SCM_Calendar> SCM_Calendars { set; get; }
    }
}
