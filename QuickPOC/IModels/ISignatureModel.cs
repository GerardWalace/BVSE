using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IModels
{
    interface ISignatureModel
    {
        public string Email { get; }

        public string Name { get; }

        public DateTimeOffset When { get; }
    }
}
