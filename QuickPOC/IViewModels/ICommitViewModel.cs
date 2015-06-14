using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface ICommitViewModel
    {
        string Sha { get; }

        string Message { get; }

        ISignatureViewModel Author { get; }
    }
}
