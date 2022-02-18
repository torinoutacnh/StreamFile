﻿using Invedia.DI.Attributes;
using Microsoft.Extensions.DependencyInjection;
using StreamFile.Repository.Contract.Data;
using StreamFile.Service.Contract;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StreamFile.Service
{
    [ScopedDependency(ServiceType = typeof(IBootstrapperService))]
    public class BootstrapperService : IBootstrapperService
    {
        private readonly IBootstrapper _bootstrapper;

        public BootstrapperService(IServiceProvider serviceProvider)
        {
            _bootstrapper = serviceProvider.GetRequiredService<IBootstrapper>();
        }

        public async Task InitialAsync(CancellationToken cancellationToken = default)
        {
            await _bootstrapper.InitialAsync(cancellationToken);
        }

        public Task RebuildAsync(CancellationToken cancellationToken = default)
        {
            _bootstrapper.RebuildAsync(cancellationToken).Wait(cancellationToken);

            return Task.CompletedTask;
        }
    }
}
