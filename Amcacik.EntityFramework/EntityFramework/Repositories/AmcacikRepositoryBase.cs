using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Amcacik.EntityFramework.Repositories
{
    public abstract class AmcacikRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AmcacikDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AmcacikRepositoryBase(IDbContextProvider<AmcacikDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AmcacikRepositoryBase<TEntity> : AmcacikRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AmcacikRepositoryBase(IDbContextProvider<AmcacikDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
