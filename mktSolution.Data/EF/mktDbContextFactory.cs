using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mktSolution.Data.EF
{
    public class mktDbContextFactory : IDesignTimeDbContextFactory<MktDbContext>
    {
        public MktDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionstring = configuration.GetConnectionString("mktSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<MktDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);

            return new MktDbContext(optionsBuilder.Options);
        }
    }
}
