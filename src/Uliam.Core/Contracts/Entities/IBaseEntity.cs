using System;
using System.Collections.Generic;
using System.Text;

namespace Uliam.Core.Contracts.Entities
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime CreateDate { get; set; }
    }
}
