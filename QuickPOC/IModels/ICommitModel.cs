﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.IModels
{
    interface ICommitModel
    {
        public string Sha { get; }

        public string Message { get; }

        public ISignatureModel Author { get; }
    }
}
