using System;
using System.Collections.Generic;
using Uliam.Core.Entities;

namespace Uliam.Core.Contracts.Repositories
{
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        TEntity Add(TEntity t);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity t);
        TEntity GetById(Guid Id);
    }
}
