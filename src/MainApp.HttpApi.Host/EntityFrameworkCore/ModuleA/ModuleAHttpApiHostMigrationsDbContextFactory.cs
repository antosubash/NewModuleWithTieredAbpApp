using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MainApp.EntityFrameworkCore.ModuleA
{
    public class ModuleAHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ModuleAHttpApiHostMigrationsDbContext>
    {
        public ModuleAHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ModuleAHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("ModuleA"));
            return new ModuleAHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
