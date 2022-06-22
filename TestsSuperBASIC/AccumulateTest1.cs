using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
    [TestClass]
    public class AccumulateTest1
    {

        [TestMethod]
        public void Accumulate() 
        {
            Mock.MockPrint print = new Mock.MockPrint();
            Library lib = new Library();

            lib.AddFunction(new SuperBASIC.Functions.Accumulate(), 4, "ACCUMULATE");
            lib.AddFunction(print, 1, "PRINT");

            Runtime r = new Runtime(lib);
            r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\AccumulateTest1.txt");
            r.Run();

            Assert.AreEqual((float)print.output[0], 0);
        }
    }
}
