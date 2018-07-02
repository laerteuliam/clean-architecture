using System;
using System.Collections.Generic;
using System.Text;
using Uliam.Core.Contracts.Repositories;
using Uliam.Core.Entities;

namespace Uliam.Core.Interactors
{
    public abstract class BaseRepositoryInteractor 
    {
        protected readonly IBaseRepository<BaseEntity> repository;

        public BaseRepositoryInteractor(IBaseRepository<BaseEntity> repository)
        {
            this.repository = repository;
        }
    }
}
