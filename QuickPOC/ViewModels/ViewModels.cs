using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.ViewModels
{

    class SignatureViewModel
    {
        public string Email { get; protected set; }
        public string Name { get; protected set; }
        public DateTimeOffset When { get; protected set; }
    }

    class CommitViewModel
    {
        public string Sha { get; protected set; }

        public string FilePath { get; protected set; }

        public string Message { get; protected set; }

        public SignatureViewModel Signature { get; protected set; }
    }

    class BlamedLineViewModel
    {
        public string Text { get; protected set; }

        public int LineNumber { get; protected set; }

        public CommitViewModel Commit { get; protected set; }
    }

    class BlamedFileViewModel
    {
        public IList<BlamedLineViewModel> Lines { get; protected set; }

        public CommitViewModel CommitShown { get; protected set; }

        public IList<CommitViewModel> CommitsHistory { get; protected set; }
    }
}
