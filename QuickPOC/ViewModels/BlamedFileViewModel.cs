using QuickPOC.IViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.ViewModels
{
    class BlamedFileViewModel : IBlamedFileViewModel
    {
        public BlamedFileViewModel(string filePath)
            : this(filePath, "HEAD") 
        {

        }

        public BlamedFileViewModel(string filePath, string startingCommitSha)
        {
            // TODO : Faire un loader et tout et tout !
        }

        public IList<IBlamedLineViewModel> Lines { get; protected set; }

        public ICommitViewModel CommitShown { get; protected set; }

        public IList<ICommitViewModel> CommitsHistory { get; protected set; }
    }
}
