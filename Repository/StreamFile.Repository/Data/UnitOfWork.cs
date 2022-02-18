using Invedia.DI.Attributes;
using StreamFile.Repository.Contract.Data;
using System.Threading;
using System.Threading.Tasks;

namespace StreamFile.Repository.Data
{
    [ScopedDependency(ServiceType = typeof(IUnitOfWork))]
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
