using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ModuleA.EntityFrameworkCore
{
    public class ModuleAModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ModuleAModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}