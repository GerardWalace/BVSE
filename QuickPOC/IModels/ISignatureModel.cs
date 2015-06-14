using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IModels
{
    interface ISignatureModel
    {
        string Email { get; }

        string Name { get; }

        DateTimeOffset When { get; }
    }
}
