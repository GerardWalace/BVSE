using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface IDelayableViewModel
    {
        public bool IsLoading { get; }

        public bool IsError { get; }
    }
}
