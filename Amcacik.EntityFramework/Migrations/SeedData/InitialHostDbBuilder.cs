using Amcacik.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Amcacik.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AmcacikDbContext _context;

        public InitialHostDbBuilder(AmcacikDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
