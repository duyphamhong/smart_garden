using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Embedded.Api.Infrastructure.Exceptions
{
    /// <summary>
    /// Exception type for app exceptions
    /// </summary>
    public class EmbeddedDomainException : Exception
    {
        public EmbeddedDomainException()
        { }

        public EmbeddedDomainException(string message)
            : base(message)
        { }

        public EmbeddedDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
