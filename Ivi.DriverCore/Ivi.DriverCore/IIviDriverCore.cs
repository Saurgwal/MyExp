using System;

namespace Ivi.DriverCore
{

    /// <summary>
    /// Interface for the IVI Driver Core. This interface specifies essential properties and methods that all IVI drivers must implement.
    /// It includes information about the driver version, vendor, and various methods for error handling, status querying, 
    /// simulation, and instrument interaction as described in the IVI Driver Core Specification.
    /// </summary>
    public interface IIviDriverCore
    {
        /// <summary>
        /// Gets the version of the driver.
        /// This property must return a version string that follows the format: 
        /// MajorVersion.MinorVersion.BuildVersion (e.g., "1.0.0").
        /// It represents the current version of the driver that is being used and ensures consistency across different releases.
        /// </summary>
        String DriverVersion { get; }

        /// <summary>
        /// Gets the name of the driver vendor.
        /// This property returns the name of the vendor that supplies the IVI Core driver, such as "Agilent Technologies".
        /// This allows users to identify which company maintains the driver.
        /// </summary>
        String DriverVendor { get; }

        /// <summary>
        /// Provides setup information for the driver.
        /// This property may provide configuration details required to initialize the driver properly.
        /// It could represent an initialization string or parameters needed for the setup of the driver session.
        /// </summary>
        String DriverSetup { get; }

        /// <summary>
        /// Gets the name of the instrument's manufacturer.
        /// This property should return the manufacturer of the instrument controlled by this driver (e.g., "Keysight Technologies").
        /// This is used to ensure that the driver is controlling the correct type of instrument.
        /// </summary>
        String InstrumentManufacturer { get; }

        /// <summary>
        /// Gets the model number or name of the instrument.
        /// This property must return the model of the instrument that the driver supports (e.g., "34410A").
        /// This helps the user identify the exact model of the instrument for which the driver is compatible.
        /// </summary>
        String InstrumentModel { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the instrument's status should be queried after each operation.
        /// If set to true, the driver will check the instrument's status at the end of every method call to ensure that 
        /// no errors occurred during the operation.
        /// </summary>
        Boolean QueryInstrumentStatus { get; set; }

        /// <summary>
        /// Gets a value indicating whether the driver is operating in simulation mode.
        /// In simulation mode, the driver does not perform actual I/O with the instrument, and instead generates simulated data for testing.
        /// This allows for testing of the driver and associated software without requiring access to real hardware.
        /// </summary>
        Boolean Simulate { get; }

        /// <summary>
        /// Queries the instrument for any error information.
        /// This method checks the instrument’s error queue or status registers and returns an object containing the error code 
        /// and message. It is crucial for debugging and handling issues encountered by the instrument.
        /// </summary>
        /// <returns>Returns an <see cref="ErrorQueryResult"/> that includes the error code and message from the instrument.</returns>
        ErrorQueryResult ErrorQuery();

        /// <summary>
        /// Resets the instrument to a known state.
        /// This method is used to restore the instrument to a default state. For example, an IEEE 488.2 instrument driver may 
        /// send the "*RST" command to reset the device. This is typically used to ensure that the instrument is in a known and 
        /// error-free state before performing any operations.
        /// </summary>
        void Reset();

        /// <summary>
        /// Retrieves the list of supported instrument models compatible with this driver.
        /// This method returns an array of strings where each string represents a model number or name of the instruments 
        /// that the driver can control. It allows the user to know which instrument models the driver supports.
        /// </summary>
        /// <returns>Returns an array of strings containing the names or model numbers of supported instruments.</returns>
        String[] GetSupportInstrumentModels();
    }
}
