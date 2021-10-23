using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using ModuleA.EntityFrameworkCore;
namespace MainApp.EntityFrameworkCore.ModuleA
{
    public class ModuleAHttpApiHostMigrationsDbContext : AbpDbContext<ModuleAHttpApiHostMigrationsDbContext>
    {
        public ModuleAHttpApiHostMigrationsDbContext(DbContextOptions<ModuleAHttpApiHostMigrationsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureModuleA();
        }
    }
}
