using System;
using System.Collections.Generic;
using System.Text;

namespace Uliam.Core.Contracts.Interactors
{
    public interface IBaseInteractorOutput
    {
        string Message { get; set; }
        bool Success { get; set; }
    }
}
