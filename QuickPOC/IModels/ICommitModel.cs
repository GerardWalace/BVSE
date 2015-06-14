using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IModels
{
    interface ICommitModel
    {
        string Sha { get; }

        string Message { get; }

        ISignatureModel Author { get; }
    }
}
