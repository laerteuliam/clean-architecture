using System;
using System.Collections.Generic;
using System.Text;

namespace Uliam.Core.Contracts.Interactors
{
    public interface IBaseInteractor<in TInput, out TOutput>
        where TInput:IBaseInteractorInput
        where TOutput:IBaseInteractorOutput
    {
        TOutput Execute(TInput t);
    }

    public interface IBaseInteractor<in TInput>
    {
        void Execute(TInput t);
    }
    
}
