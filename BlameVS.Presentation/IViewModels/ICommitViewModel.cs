using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlameVS.Presentation.IViewModels
{
    public interface ICommitViewModel
    {
        string Sha { get; }

        string Message { get; }

        ISignatureViewModel Author { get; }
    }
}
