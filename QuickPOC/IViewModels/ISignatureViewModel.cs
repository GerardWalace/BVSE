using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface ISignatureViewModel
    {
        public string Email { get; }

        public string Name { get; }

        public DateTimeOffset? When { get; }
    }
}
