using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IviBaseDriver
{
    public interface IIviBaseDriver
    {
        String Version { get; }
        String Vendor { get; }
        String DriverSetup { get; }
        String InstrumentManufacturer { get; }
        String InstrumentModel { get; }
        Boolean QueryInstrumentStatus { get; set; }
        Boolean Simulate { get; }

        void Reset();
        void Close();


    }
}
