
namespace Ivi.DriverCore
{

    public interface IIviDriverCore
    {
        String DriverVersion { get; }
        String DriverVendor { get; }
        String DriverSetup { get; }
        String InstrumentManufacturer { get; }
        String InstrumentModel { get; }
        Boolean QueryInstrumentStatus { get; set; }
        Boolean Simulate { get; }
        ErrorQueryResult ErrorQuery();
        void Reset();
        String[] GetSupportInstrumentModels();
    }
}
