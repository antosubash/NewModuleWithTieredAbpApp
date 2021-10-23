using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModuleA.EntityFrameworkCore
{
    [ConnectionStringName(ModuleADbProperties.ConnectionStringName)]
    public class ModuleADbContext : AbpDbContext<ModuleADbContext>, IModuleADbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<TodoOne> TodoOnes { get; set; }
        public ModuleADbContext(DbContextOptions<ModuleADbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureModuleA();
        }
    }
}