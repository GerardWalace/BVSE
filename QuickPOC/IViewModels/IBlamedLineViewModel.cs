﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IViewModels
{
    interface IBlamedLineViewModel
    {
        string Text { get; }

        int LineNumber { get; }

        ICommitViewModel Commit { get; }
    }
}
