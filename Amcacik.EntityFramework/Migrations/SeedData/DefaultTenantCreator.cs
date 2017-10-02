using System.Linq;
using Amcacik.EntityFramework;
using Amcacik.MultiTenancy;

namespace Amcacik.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AmcacikDbContext _context;

        public DefaultTenantCreator(AmcacikDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
