using StreamFile.Core.Utils;
using StreamFile.Repository.Contract.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamFile.Repository.Contract.StreamFile.Models
{
    [Table("TransferLog")]
    public class TransferLogEntity : Entity
    {
        public TransferLogEntity()
        {
            TimeExpired = CoreHelper.SystemTimeNow.AddHours(6);
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DocumentId { get; set; }
        public string OtpToken { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? TimeExpired { get; set; }
        public string RefId { get; set; }
        public int TotalDownload { get; set; }
    }
}
