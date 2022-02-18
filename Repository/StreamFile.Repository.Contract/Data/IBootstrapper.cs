using System.Threading;
using System.Threading.Tasks;

namespace StreamFile.Repository.Contract.Data
{
    public interface IBootstrapper
    {
        Task InitialAsync(CancellationToken cancellationToken = default);

        Task RebuildAsync(CancellationToken cancellationToken = default);
    }
}
