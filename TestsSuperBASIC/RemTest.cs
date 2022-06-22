using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
    [TestClass]
    public class RemTest
    {
        [TestMethod]
        public void Rem() 
        {
            Mock.MockPrint print = new Mock.MockPrint();
            Library lib = new Library();

            lib.AddFunction(new SuperBASIC.Functions.Rem(), 2, "REM");
            lib.AddFunction(print, 1, "PRINT");


            Runtime r = new Runtime(lib);
            r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\RemTest1.txt");
            r.Run();

            Assert.AreEqual((float)print.output[0], 0);
        }
    }
}
