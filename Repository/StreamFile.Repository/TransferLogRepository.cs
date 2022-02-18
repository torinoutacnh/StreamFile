using Invedia.DI.Attributes;
using StreamFile.Repository.Contract.Interface;
using StreamFile.Repository.Contract.StreamFile.Models;
using StreamFile.Repository.Data;
using Serilog;

namespace StreamFile.Repository
{
    [ScopedDependency(ServiceType = typeof(ITransferLogRepository))]
    public class TransferLogRepository : Repository<TransferLogEntity>, ITransferLogRepository
    {
        private readonly ILogger _logger;
        public TransferLogRepository(AppDbContext dbContext) : base(dbContext)
        {
            _logger = Log.Logger;
        }
    }
}
