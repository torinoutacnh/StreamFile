using Invedia.DI.Attributes;
using Microsoft.EntityFrameworkCore;
using StreamFile.Repository.Contract.Data;
using System.Threading;
using System.Threading.Tasks;

namespace StreamFile.Repository.Data
{
    [ScopedDependency(ServiceType = typeof(IBootstrapper))]
    public class Bootstrapper : IBootstrapper
    {
        private readonly AppDbContext _dbContext;

        public Bootstrapper(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task InitialAsync(CancellationToken cancellationToken = default)
        {
            return _dbContext.Database.MigrateAsync(cancellationToken);
        }

        public Task RebuildAsync(CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
