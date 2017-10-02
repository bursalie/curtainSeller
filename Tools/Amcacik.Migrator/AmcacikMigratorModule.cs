using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Amcacik.EntityFramework;

namespace Amcacik.Migrator
{
    [DependsOn(typeof(AmcacikDataModule))]
    public class AmcacikMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AmcacikDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}