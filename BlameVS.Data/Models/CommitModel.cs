using BlameVS.Data.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlameVS.Data.Models
{
    public class CommitModel : ICommitModel
    {
        public string Sha 
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public ISignatureModel Author
        {
            get;
            set;
        }
    }
}
