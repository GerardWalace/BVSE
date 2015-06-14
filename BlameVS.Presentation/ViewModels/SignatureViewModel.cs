using BlameVS.Data.IModels;
using BlameVS.Presentation.IViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlameVS.Presentation.ViewModels
{
    class SignatureViewModel : ISignatureViewModel
    {
        private ISignatureModel signature;

        public SignatureViewModel(ISignatureModel signature)
        {
            if (signature == null)
                throw new ArgumentNullException("signature", "SignatureViewModel could not be initialized without an ISignatureModel");

            this.signature = signature;
        }

        public string Email
        {
            get
            {
                return this.signature.Email;
            }
        }

        public string Name
        {
            get
            {
                return this.signature.Name;
            }
        }

        public DateTimeOffset? When
        {
            get
            {
                return this.signature.When;
            }
        }
    }
}
