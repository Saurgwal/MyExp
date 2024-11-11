using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keysight.KtBaseDmm;
using KtBaseDmmDriverUnitTest;

namespace KtBaseDmmUnitTest
{
    [TestClass]
    public class DmmUnitTest : BaseTest
    {
        protected IKtBaseDmm Interface { get; private set; }

        [TestInitialize]
        public override void _Init()
        {
            base._Init();

            this.Interface = (this.Driver as IKtBaseDmm);
        }

        [TestCleanup]
        public override void _Close()
        {
            base._Close();
        }

        [TestMethod]
        public void GetInstrumentModel()
        {
            //var model =this.Driver.InstrumentModel;
            Console.WriteLine("The Instrument model is {0}" ,  this.Driver.InstrumentModel);

        }
        [TestMethod]
        public void GetInstrumentManufacturer()
        {
            //var model =this.Driver.InstrumentModel;
            Console.WriteLine("The Instrument manufacturer is {0}", this.Driver.InstrumentManufacturer);

        }
        [TestMethod]
        public void GetGeneration()
        {
            //var model =this.Driver.InstrumentModel;
            Console.WriteLine("The driver generation is {0}", this.Driver.Generation);

        }

    }
}
