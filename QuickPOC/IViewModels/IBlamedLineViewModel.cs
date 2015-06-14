using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface IBlamedLineViewModel
    {
        public string Text { get; }

        public int LineNumber { get; }

        public ICommitViewModel Commit { get; }
    }
}
