using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using mktSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "MKV.international@gmail.com",
                NormalizedEmail = "MKV.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456"),
                SecurityStamp = string.Empty,
                Ecode = "110176",
                Dept = "SE"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            //modelBuilder.Entity<SCM_Order>().HasData(
            //    new SCM_Order() { IdOrder = 1, ModelName = "A", Qty = 1000, DueDate = new DateTime(2020, 12, 1, 10, 30, 50) },
            //    new SCM_Order() { IdOrder = 2, ModelName = "B", Qty = 2000, DueDate = new DateTime(2020, 12, 3, 10, 30, 50) },
            //    new SCM_Order() { IdOrder = 3, ModelName = "A", Qty = 1300, DueDate = new DateTime(2020, 12, 5, 10, 30, 50) },
            //    new SCM_Order() { IdOrder = 4, ModelName = "C", Qty = 5000, DueDate = new DateTime(2020, 12, 7, 10, 30, 50) }
            //    );

            //modelBuilder.Entity<SCM_Product>().HasData(
            //    new SCM_Product() { IdProduct = 1, ModelName = "A", Qty = 500, DateProduct = new DateTime(2020, 12, 2, 10, 30, 50), IdOrder = 1, Jobname = "JN0001" },
            //    new SCM_Product() { IdProduct = 2, ModelName = "B", Qty = 800, DateProduct = new DateTime(2020, 12, 3, 10, 30, 50), IdOrder = 2, Jobname = "JN0002" },
            //    new SCM_Product() { IdProduct = 3, ModelName = "A", Qty = 600, DateProduct = new DateTime(2020, 12, 3, 10, 30, 50), IdOrder = 1, Jobname = "JN0003" },
            //    new SCM_Product() { IdProduct = 4, ModelName = "B", Qty = 1000, DateProduct = new DateTime(2020, 12, 4, 10, 30, 50), IdOrder = 2, Jobname = "JN0004" }
            //    );

            //modelBuilder.Entity<SCM_Calendar>().HasData(
            //    new SCM_Calendar() { IdCalendar = 1, Date = new DateTime(2020, 12, 1, 10, 30, 50) },
            //    new SCM_Calendar() { IdCalendar = 2, Date = new DateTime(2020, 12, 2, 10, 30, 50) },
            //    new SCM_Calendar() { IdCalendar = 3, Date = new DateTime(2020, 12, 3, 10, 30, 50) },
            //    new SCM_Calendar() { IdCalendar = 4, Date = new DateTime(2020, 12, 4, 10, 30, 50) },
            //    new SCM_Calendar() { IdCalendar = 5, Date = new DateTime(2020, 12, 5, 10, 30, 50) },
            //    new SCM_Calendar() { IdCalendar = 6, Date = new DateTime(2020, 12, 6, 10, 30, 50) },
            //    new SCM_Calendar() { IdCalendar = 7, Date = new DateTime(2020, 12, 7, 10, 30, 50) }
            //    );
        }
    }
}
