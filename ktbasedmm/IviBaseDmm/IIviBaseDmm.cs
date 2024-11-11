using IviBaseDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IviBaseDmm
{
    /// <summary>
    /// The IIviBaseDmm Interface derived from IIviBaseDriver
    /// </summary>
    public interface IIviBaseDmm : IIviBaseDriver
    {
        new string Version { get; }
        /// <summary>
        /// Get the voltage of DUT.
        /// </summary>
        double GetVoltage();

    }
}
