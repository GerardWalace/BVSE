using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface IBlamedFileViewModel
    {
        IList<IBlamedLineViewModel> Lines { get; }

        ICommitViewModel CommitShown { get; }

        IList<ICommitViewModel> CommitsHistory { get; }
    }
}
