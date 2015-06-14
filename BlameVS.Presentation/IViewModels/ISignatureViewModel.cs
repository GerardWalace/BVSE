using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlameVS.Presentation.IViewModels
{
    public interface ISignatureViewModel
    {
        string Email { get; }

        string Name { get; }

        DateTimeOffset? When { get; }
    }
}
