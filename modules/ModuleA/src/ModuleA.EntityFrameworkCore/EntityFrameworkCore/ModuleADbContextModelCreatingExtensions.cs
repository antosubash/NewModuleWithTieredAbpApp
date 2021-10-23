using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ModuleA.EntityFrameworkCore
{
    public static class ModuleADbContextModelCreatingExtensions
    {
        public static void ConfigureModuleA(
            this ModelBuilder builder,
            Action<ModuleAModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ModuleAModelBuilderConfigurationOptions(
                ModuleADbProperties.DbTablePrefix,
                ModuleADbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<TodoOne>(b =>
            {
                b.ToTable(options.TablePrefix + "TodoOnes", options.Schema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });
        }
    }
}