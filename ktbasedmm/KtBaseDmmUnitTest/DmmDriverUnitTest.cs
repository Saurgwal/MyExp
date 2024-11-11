using Keysight.KtBaseDmm;

namespace KtBaseDmmDriverUnitTest
{ 

public class BaseTest
{
    protected KtBaseDmm? Driver { get; private set; }

    public virtual void _Init()
    {
        var initOptions = "QueryInstrStatus=true, Simulate=false, DriverSetup= Model=, Trace=true, UdpLogEnabled=true";
        bool idQuery = true;
        bool reset = true;

        string MyInstrument = "10.15.97.192";
        this.Driver = new KtBaseDmm(MyInstrument, idQuery, reset, initOptions);
    }


    public virtual void _Close()
    {
      
        this.Driver.Close();
       
        this.Driver = null;
    }
}
}
