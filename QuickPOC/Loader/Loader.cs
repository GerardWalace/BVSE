using QuickPOC.ILoader;
using QuickPOC.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.Loader
{
    class Loader<T> : ILoader<T>
    {
        public EnumLoadingStatus LoadingStatus
        {
            get;
            set;
        }

        public T Item
        {
            get;
            set;
        }
    }
}
