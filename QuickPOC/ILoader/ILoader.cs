using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.ILoader
{
    interface ILoader<T>
    {
        EnumLoadingStatus LoadingStatus { get; }

        T Item { get; }
    }
}
