using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
    [TestClass]
   public class ArcsinTest
    {
        [TestMethod]
        public void Arcsin()
        {
            Mock.MockPrint print = new Mock.MockPrint();
            Library lib = new Library();

            lib.AddFunction(new SuperBASIC.Functions.Arcsin(), 1, "ARCSIN");
            lib.AddFunction(print, 1, "PRINT");

            Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\ArcsinTest1.txt");
            r.Run();

            Assert.AreEqual((float)print.output[0], 0);
        }
    }
}
