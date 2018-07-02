using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Uliam.Core.Contracts.Repositories;
using Uliam.Core.Entities;

namespace Uliam.Core.Repositories
{
    public abstract class BaseRepository : IBaseRepository<BaseEntity>
    {
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual BaseEntity Add(BaseEntity t)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<BaseEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual BaseEntity GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(BaseEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
