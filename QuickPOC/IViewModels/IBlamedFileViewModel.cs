using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface IBlamedFileViewModel : IDelayableViewModel
    {
        public IList<IBlamedLineViewModel> Lines { get; }

        public ICommitViewModel CommitShown { get; }

        public IList<ICommitViewModel> CommitsHistory { get; }
    }
}
