using QuickPOC.IViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.ViewModels
{
    class BlamedLineViewModel : IBlamedLineViewModel
    {
        public BlamedLineViewModel(string text, int lineNumber, string commitSha)
        {
            this.Text = text;
            this.LineNumber = lineNumber;
            this.Commit = new CommitViewModel(commitSha);
        }

        public string Text { get; protected set; }

        public int LineNumber { get; protected set; }

        public ICommitViewModel Commit { get; protected set; }
    }
}
