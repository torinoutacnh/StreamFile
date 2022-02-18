using Microsoft.EntityFrameworkCore;
using StreamFile.Repository.Contract.StreamFile.Models;

namespace StreamFile.Repository.Data
{
    public sealed partial class AppDbContext
    {
        public DbSet<DocumentStoreEntity> User { get; set; }
        public DbSet<TransferLogEntity> Transaction { get; set; }
    }
}
