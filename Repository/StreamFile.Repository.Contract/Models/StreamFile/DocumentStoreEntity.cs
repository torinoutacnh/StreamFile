using StreamFile.Repository.Contract.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamFile.Repository.Contract.StreamFile.Models
{
    [Table("DocumentStore")]
    public class DocumentStoreEntity : Entity
    {
        public DocumentStoreEntity()
        {
            ContentType = "application/octet-stream";
        }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long? FileSize { get; set; }
        public string FilePath { get; set; }
        public string DocumentId { get; set; }
    }
}
