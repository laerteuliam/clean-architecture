using System;
using Uliam.Core.Contracts.Entities;

namespace Uliam.Core.Entities
{
    public abstract class BaseEntity : IBaseEntity<Guid>
    {
        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
            this.CreateDate = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
