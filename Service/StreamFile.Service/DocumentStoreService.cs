using Invedia.DI.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using StreamFile.Repository.Contract.Data;
using StreamFile.Repository.Contract.Interface;
using StreamFile.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamFile.Service
{
    [ScopedDependency(ServiceType = typeof(IDocumentStoreService))]
    public class DocumentStoreService : Base.Service, IDocumentStoreService
    {
        private readonly ILogger _logger;
        private readonly IDocumentStoreRepository _documentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DocumentStoreService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _logger = Log.Logger;
            _documentRepository = serviceProvider.GetRequiredService<IDocumentStoreRepository>();
            _unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
        }
    }
}
