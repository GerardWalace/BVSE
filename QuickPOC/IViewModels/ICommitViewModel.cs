using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface ICommitViewModel : IDelayableViewModel
    {
        public string Sha { get; }

        public string Message { get; }

        public ISignatureViewModel Author { get; }
    }
}
