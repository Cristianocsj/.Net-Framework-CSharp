using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancariaTryCatch
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string msg) : base(msg) { }
    }
}
