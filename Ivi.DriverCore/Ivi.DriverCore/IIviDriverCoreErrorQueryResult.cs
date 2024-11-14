using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivi.DriverCore
{
    /// <summary>
    /// Represents the result of an error query from an IVI driver.
    /// </summary>
    public struct ErrorQueryResult
    {
        /// <summary>
        /// Gets the error code associated with the query.
        /// </summary>
        Int32 Code { get; }

        /// <summary>
        /// Gets the error message associated with the query.
        /// </summary>
        String Message { get; }
    }
}
