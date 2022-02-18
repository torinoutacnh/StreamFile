using Invedia.DI.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using StreamFile.Repository.Contract.Data;
using StreamFile.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamFile.Service
{
    [ScopedDependency(ServiceType = typeof(ITransferLogService))]
    public class TransferLogService : Base.Service, ITransferLogService
    {
        private readonly ILogger _logger;
        private readonly ITransferLogService _transferLogRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TransferLogService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _logger = Log.Logger;
            _transferLogRepository = serviceProvider.GetRequiredService<ITransferLogService>();
            _unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
        }
    }
}
