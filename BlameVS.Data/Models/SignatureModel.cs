using BlameVS.Data.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlameVS.Data.Models
{
    public class SignatureModel : ISignatureModel
    {
        public string Email
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public DateTimeOffset When
        {
            get;
            set;
        }
    }
}
