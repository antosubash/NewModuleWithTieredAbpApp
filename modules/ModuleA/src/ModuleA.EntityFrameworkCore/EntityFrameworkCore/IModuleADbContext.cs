using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModuleA.EntityFrameworkCore
{
    [ConnectionStringName(ModuleADbProperties.ConnectionStringName)]
    public interface IModuleADbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}