using System;
using System.Collections.Generic;
using System.Text;
using Uliam.Core.Contracts.Interactors;
using Uliam.Core.Contracts.Repositories;
using Uliam.Core.Entities;

namespace Uliam.Core.Interactors
{
    public class TodoItemAddInteractor : BaseRepositoryInteractor, IBaseInteractor<TodoItemAddInput,TodoItemAddOutput>
    {
        public TodoItemAddInteractor(IBaseRepository<BaseEntity> repository) : base(repository)
        {
        }

        public TodoItemAddOutput Execute(TodoItemAddInput t)
        {
            
        }
    }

    public class TodoItemAddOutput : IBaseInteractorOutput
    {
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Success { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class TodoItemAddInput : IBaseInteractorInput
    {
        public string Text { get; set; }
    }
}
