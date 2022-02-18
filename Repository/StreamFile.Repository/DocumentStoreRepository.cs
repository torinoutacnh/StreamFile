using Invedia.DI.Attributes;
using Serilog;
using StreamFile.Repository.Contract.Interface;
using StreamFile.Repository.Contract.StreamFile.Models;
using StreamFile.Repository.Data;

namespace StreamFile.Repository
{
    [ScopedDependency(ServiceType = typeof(IDocumentStoreRepository))]
    public class DocumentStoreRepository : Repository<DocumentStoreEntity>, IDocumentStoreRepository
    {
        private readonly ILogger _logger;
        public DocumentStoreRepository(AppDbContext dbContext) : base(dbContext)
        {
            _logger = Log.Logger;
        }
    }
}
