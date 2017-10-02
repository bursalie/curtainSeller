using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Amcacik.Authorization.Roles;
using Amcacik.Authorization.Users;
using Amcacik.Customers;
using Amcacik.MultiTenancy;

namespace Amcacik.EntityFramework
{
    public class AmcacikDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AmcacikDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AmcacikDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AmcacikDbContext since ABP automatically handles it.
         */
        public AmcacikDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AmcacikDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AmcacikDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        public IDbSet<Customer> Customers;
        public IDbSet<Inventory.Inventory> Inventories;
    }
}
