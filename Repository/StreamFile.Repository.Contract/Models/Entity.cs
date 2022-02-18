using Invedia.Data.EF.Models;
using StreamFile.Core.Utils;
using System;

namespace StreamFile.Repository.Contract.Models
{
    public abstract class Entity : StringEntity
    {
        protected Entity()
        {
            Id = Guid.NewGuid().ToString("N");

            CreatedTime = LastUpdatedTime = CoreHelper.SystemTimeNow;
        }
    }
}
