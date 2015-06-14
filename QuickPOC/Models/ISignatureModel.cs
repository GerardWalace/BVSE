using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IModels
{
    class SignatureModel : ISignatureModel
    {
        public string Email
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public DateTimeOffset When
        {
            get;
            set;
        }
    }
}
